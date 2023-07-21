using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; 

namespace WebApiRESTful_Demo_5.Models
{
    public class MySQLAuthorRepository : IAuthorInterface
    {
        // dependency injection- AppDbContext 

        // create- add
        // read- GetAll
        //      - Get by id
        // update- update
        // delete- delete

        // custom- Get all books by author name

        private readonly AppDbContext context;
        public MySQLAuthorRepository(AppDbContext context)
        {
            this.context = context; 
        }



        // CREATE- add  
        public ActionResult<Author> AddAuthor(Author author)
        {
            context.AuthorTable.Add(author);
            context.SaveChanges();
            return author; 
        }

        // DELETE 
        public Author DeleteAuthor(int id)
        {
            var tempAuthor = context.AuthorTable.Find(id);

            if(tempAuthor == null)
            {
                return null; 
            }

            context.AuthorTable.Remove(tempAuthor);
            context.SaveChanges();
            return tempAuthor; 

        }


        // READ - Gel all author 
        public ActionResult<IEnumerable<Author>> GetAllAuthor()
        {
            var allAuthors = context.AuthorTable.ToList();
            return allAuthors; 
        }

        // READ- get all books by author name 
        public ActionResult<IEnumerable<dynamic>> GetAllBooksByAuthorName(string authorName)
        {
            // Give the AuthorName and it will return all the books writtn by the author

            // 1. find out that the author is present or not
            // 1.1 and Get the AuthorId 
            // 2. find all the books in the books table where AuthorId is == the above AuthorId

            var tempAuthor = context.AuthorTable.Where((author) => author.FirstName == authorName); // #NeedImprovements: must match both firstname and lastname
            if(tempAuthor == null)
            {
                return null; 
            }

            var tempList = tempAuthor.ToList();
            int authorId = 0; 

            foreach(Author author in tempList)
            {
                authorId = author.AuthorId;
                break; 
            } // Now got the author id 

            var listOfBooks = context.BooksTable.Where((book) => book.AuthorId == authorId).ToList();
            return listOfBooks; 

        }

        // READ- get author by id 
        public ActionResult<Author> GetAuthorById(int id)
        {
            // check any entries present in the table or not
            if(context.AuthorTable == null)
            {
                return null; 
            }

            
            var tempAuthor = context.AuthorTable.Find(id); // 
            return tempAuthor; 
        }


        // UPDATE- update author 
        public Author UpdateAuthor(int id, Author author)
        {
            //var temp = context.AuthorTable.Find(id); 
            //if (temp == null) 
            //{
            //    return null; 
            //}

            //context.AuthorTable.Update(author); 
            //context.SaveChanges(); 
            //return author;



            // Mam's code
            if(id != author.AuthorId)
            {
                return null; 
            }

            context.Entry(author).State = EntityState.Modified; 

            //context.Update(author); // entity will be updated even without this line. When SaveChanges() method is called it will EF Core will update the corresponding row in the database table. 
            context.SaveChanges(); 

            return author; 

        }
    }
}



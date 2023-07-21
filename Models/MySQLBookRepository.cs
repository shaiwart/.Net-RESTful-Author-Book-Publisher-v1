using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApiRESTful_Demo_5.Models
{
	public class MySQLBookRepository : IBookInterface
	{

        // Dependency Injection 
        private readonly AppDbContext context; 
		public MySQLBookRepository(AppDbContext context)
		{
            this.context = context; 
		}




        // ADD
        public async Task<ActionResult<Book>> Add(Book book)
        {
            context.BooksTable.AddAsync(book);
            await context.SaveChangesAsync();
            return book; 
        }


        // DELETE  
        public async Task<Book> Delete(int id)
        {
            Book bookToBeDeleted = context.BooksTable.Find(id);
            if(bookToBeDeleted != null)
            {
                context.BooksTable.Remove(bookToBeDeleted);
                await context.SaveChangesAsync(); 
            }
            return bookToBeDeleted; 
        }


        // GET ALL 
        public async Task<ActionResult<IEnumerable<Book>>> GetAllBook()
        {
            if(context.BooksTable == null)
            {
                return null; 
            }
            return await context.BooksTable.ToListAsync(); 
        }


        // GET BY ID 
        public ActionResult<Book>? GetBook(int id)
        {
            // if no element present in the table then return null 
            if(context.BooksTable == null)
            {
                return null; 
            }

            // 
            var tempBook = context.BooksTable.Find(id);
            //if (tempBook == null)
            //{
            //    return null;
            //}

            return tempBook; 

        }



        // GET NAME 
        public ActionResult<IEnumerable<dynamic>> GetName(string name)
        {
            throw new NotImplementedException();
        }



        // UPDATE 
        public Task<Book> Update(int id, Book book)
        {
            throw new NotImplementedException();
        }
    }
}


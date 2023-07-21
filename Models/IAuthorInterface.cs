using System;
using Microsoft.AspNetCore.Mvc;

namespace WebApiRESTful_Demo_5.Models
{
	public interface IAuthorInterface
	{
        // create- add
        // read- GetAll
        //      - Get by id
        // update- update
        // delete- delete

        // custom- Get all books by author name 

        ActionResult<Author> AddAuthor(Author author);

        ActionResult<IEnumerable<Author>> GetAllAuthor();

        ActionResult<Author> GetAuthorById(int id);

        Author UpdateAuthor(int id, Author author);

        Author DeleteAuthor(int id);

        ActionResult<IEnumerable<dynamic>> GetAllBooksByAuthorName(string authorName); 

    }
}


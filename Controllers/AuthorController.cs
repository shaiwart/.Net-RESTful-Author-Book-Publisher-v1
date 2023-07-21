using System;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using WebApiRESTful_Demo_5.Models;

namespace WebApiRESTful_Demo_5.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthorController
	{
        private readonly IAuthorInterface authorRepo; 
        public AuthorController(IAuthorInterface authorRepo)
		{
            this.authorRepo = authorRepo; 
		}

        // CREATE- add 
        // READ- 1) All 2) books By Name 
        // UPDATE
        // DELETE


        // CREATE - add 
        [HttpPost]
        public ActionResult<Author> AddAuthor(Author author)
        {
            return authorRepo.AddAuthor(author);
        
        }

        // READ- 1. All
        [HttpGet]
        public ActionResult<IEnumerable<Author>> GetAllAuthor()
        {
            return authorRepo.GetAllAuthor(); 
        }


        // READ- 2. Get books by Name
        [HttpGet] 
        public ActionResult<IEnumerable<dynamic>> GetAllBooksByAuthorName(string authorName)
        {
            return authorRepo.GetAllBooksByAuthorName(authorName); 
        }


        // UPDATE 
        [HttpPut("{id}")]
        public Author UpdateAuthor(int id, Author author)
        {
            return authorRepo.UpdateAuthor(id, author); 
        }

    }
}


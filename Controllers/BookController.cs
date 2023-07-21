using System;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using WebApiRESTful_Demo_5.Models;

namespace WebApiRESTful_Demo_5.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BookController: ControllerBase
	{
		private readonly IBookInterface bookRepo;

		public BookController(IBookInterface bookRepo)
		{
			this.bookRepo = bookRepo; 
		}

        // ADD
        //[HttpPost]
        //public ActionResult<Book> Add(Book book)
        //{
        //    bookRepo.Add(book);
        //    return book; 
        //}

        // POST: api/Books
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Book>> PostBook(Book book)
        {
            await bookRepo.Add(book);
            return CreatedAtAction("PostBook", new { id = book.BookId }, book);
        }

        // GET ALL
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetAllBook()
        {
            return await bookRepo.GetAllBook(); 
        }


        // DELETE
        // DELETE: api/Books/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            if (bookRepo.GetAllBook() == null)
            {
                return NotFound();
            }

            await bookRepo.Delete(id);
            return NoContent();
        }

        // UPDATE


        // GET BOOK BY ID
        [HttpGet("{id:int}")]
        public ActionResult<Book> GetById(int id)
        {
            var book = bookRepo.GetBook(id); 
            return book == null ? NotFound() : book;
        }



        // GET NAME 
    }
}


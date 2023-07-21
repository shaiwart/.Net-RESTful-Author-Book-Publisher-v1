using System;
using Microsoft.AspNetCore.Mvc;

namespace WebApiRESTful_Demo_5.Models
{
	public interface IBookInterface
	{
		Task<ActionResult<Book>> Add(Book book);

		Task<Book> Update(int id, Book book);

		Task<Book> Delete(int id);

        Task<ActionResult<IEnumerable<Book>>> GetAllBook();

        ActionResult<Book>? GetBook(int id);

        ActionResult<IEnumerable<dynamic>> GetName(string name); 
	}
}


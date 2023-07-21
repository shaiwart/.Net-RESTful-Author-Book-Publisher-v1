using System;
using System.ComponentModel.DataAnnotations;

namespace WebApiRESTful_Demo_5.Models
{
	public class Author
	{
		[Key]
		public int AuthorId { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public ICollection<Book>? Books { get; set; } 
	}
}


using System;
using System.ComponentModel.DataAnnotations;

namespace WebApiRESTful_Demo_5.Models
{
	public class Book
	{
		[Key] 
		public int BookId { get; set; }

		[MaxLength(25)]
		[MinLength(6, ErrorMessage ="Title must be at least 6 characters long")] 
		public string? Title { get; set; }


		public int AuthorId { get; set; }


		[Required(ErrorMessage ="ISBN Required")] 
		public string? Isbn { get; set; } 
	}
}


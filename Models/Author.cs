using System;
using System.ComponentModel.DataAnnotations;

namespace WebApiRESTful_Demo_5.Models
{
	public class Author
	{
		[Key]
		public int AuthorId { get; set; }

		[Required(ErrorMessage ="FirstName required")] 
		public string? FirstName { get; set; }


		public string? LastName { get; set; }




		// This is not property of the Author entity. This just shows the relation btwn Author & Book
		// ** one to many relation: one author can have multiple books. 
		// one to one relation: one book can have only one author.

		// Author you will be appear in multiple books,
		// in the Books table there is one column for you i.e. AuthorId
		public ICollection<Book>? Books { get; set; }
	}
}


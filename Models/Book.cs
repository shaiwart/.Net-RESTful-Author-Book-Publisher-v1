using System;
using System.ComponentModel.DataAnnotations;

namespace WebApiRESTful_Demo_5.Models
{
	public class Book
	{
		[Key] 
		public int BookId { get; set; }

		[MaxLength(100)]
		[MinLength(6, ErrorMessage ="Title must be at least 6 characters long")] 
		public string? Title { get; set; }

        // This will become the foreign key
        // how it will be decided? --> In Author entity we specified this.
        //Author Class ==> public ICollection<Book>? Books { get; set; }
		// we went to Author and tell it that you will appear in multiple Books
		// and one column will be there for you as AuthorId 
        public int AuthorId { get; set; }


		public int PublisherId { get; set; } 


		[Required(ErrorMessage ="ISBN Required")] 
		public string? Isbn { get; set; } 
	}
}



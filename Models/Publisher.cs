using System;
using System.ComponentModel.DataAnnotations;

namespace WebApiRESTful_Demo_5.Models
{
	public class Publisher
	{

		
		public int PublisherId { get; set; }

		[Required(ErrorMessage ="Publisher Name can't be left empty")]
		public string? Name { get; set; }


		public string? Mobile { get; set; }

        public ICollection<Book>? Books { get; set; } 
	}
}


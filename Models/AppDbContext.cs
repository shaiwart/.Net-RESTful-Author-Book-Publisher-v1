using System;
using Microsoft.EntityFrameworkCore;

namespace WebApiRESTful_Demo_5.Models
{
	public class AppDbContext : DbContext 
	{

		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {

		} 

		public DbSet<Book> BooksTable { get; set; }
		public DbSet<Author> AuthorTable { get; set; }
        //public DbSet<Publisher> PublisherTable { get; set; }

	}
}


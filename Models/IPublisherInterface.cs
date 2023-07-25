using System;
using Microsoft.AspNetCore.Mvc;

namespace WebApiRESTful_Demo_5.Models
{
	public interface IPublisherInterface
	{
        // create- add
        // read- GetAll
        //      - Get by id
        // update- update
        // delete- delete

        ActionResult<Publisher> AddAuthor(Author publisher);

        ActionResult<IEnumerable<Publisher>> GetAllAuthor();

        ActionResult<Publisher> GetAuthorById(int id);

        Publisher UpdateAuthor(int id, Publisher publisher);

        Publisher DeleteAuthor(int id);

        ActionResult<IEnumerable<dynamic>> GetAllBooksByPublisherName(string publisherName);

    }
}


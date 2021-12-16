using BookStoreAPI1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreAPI1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public List<Book> books = new List<Book>()
        {
            new Book { Id = 1, Title = "The Girl on the train", Author = "Hawkins, Paula", PublicationYear = 2017, CallNumber = "7904932295"},
            new Book { Id = 2, Title = "The Girl on the train", Author = "Hawkins, Paula",PublicationYear = 2017, CallNumber = "7904932295"},
            new Book { Id = 3, Title = "The Girl on the train", Author = "Hawkins, Paula",PublicationYear = 2017, CallNumber = "7904932295"},
            new Book { Id = 4, Title = "The Girl on the train", Author = "Hawkins, Paula",PublicationYear = 2017, CallNumber = "7904932295"},
            new Book { Id = 5, Title = "The Girl on the train", Author = "Hawkins, Paula",PublicationYear = 2017, CallNumber = "7904932295"},
            new Book { Id = 6, Title = "The Girl on the train", Author = "Hawkins, Paula",PublicationYear = 2017, CallNumber = "7904932295"},
            new Book { Id = 7, Title = "The Girl on the train", Author = "Hawkins, Paula",PublicationYear = 2017, CallNumber = "7904932295"},
            new Book { Id = 8, Title = "The Girl on the train", Author = "Hawkins, Paula",PublicationYear = 2017, CallNumber = "7904932295"},
            new Book { Id = 9, Title = "The Girl on the train", Author = "Hawkins, Paula",PublicationYear = 2017, CallNumber = "7904932295"},
            new Book { Id = 10, Title = "The Girl on the train", Author = "Hawkins, Paula",PublicationYear = 2017, CallNumber = "7904932295"}
        };

        [HttpGet]

        public ActionResult<IEnumerable<Book>> GetAllBooks()
        {
            return books;
        }

        [HttpGet("{id}")]

        public ActionResult<Book> GetBook(int id)
        {
            var book = books.FirstOrDefault(x => x.Id == id);
            if(book == null)
            {
                return NotFound();
            }
            return book;
        }



    }
}

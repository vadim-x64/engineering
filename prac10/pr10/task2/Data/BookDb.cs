using pr10.task2.Interfaces;
using pr10.task2.Models;

namespace pr10.task2.Data
{
	public class BookDb : IBookRepository
	{
		private readonly List<Book> _books = new List<Book>();

		public void AddBook(Book book)
		{
			_books.Add(book);
		}

		public List<Book> GetAll()
		{
			return new List<Book>(_books);
		}
	}
}
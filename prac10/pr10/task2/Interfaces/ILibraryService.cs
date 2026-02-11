using pr10.task2.Models;

namespace pr10.task2.Interfaces
{
	public interface ILibraryService
	{
		void AddBook(string title, string author);
		List<Book> GetLibraryContent();
	}
}
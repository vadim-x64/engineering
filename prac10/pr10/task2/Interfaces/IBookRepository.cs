using pr10.task2.Models;

namespace pr10.task2.Interfaces
{
    public interface IBookRepository
    {
        void AddBook(Book book);
        List<Book> GetAll();
    }
}
namespace pr10.task2.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} \"{Title}\" - {Author}";
        }
    }
}
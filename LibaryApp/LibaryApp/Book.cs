namespace LibraryApp
{
    // Book class
    public class Book
    {
        private static int _idCounter = 0;
        public int Id { get; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set; }

        public Book(string name, string authorName, double price)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(authorName) || price <= 0)
                throw new ArgumentException("Book information is invalid");

            Id = ++_idCounter;
            Name = name;
            AuthorName = authorName;
            Price = price;
        }

        public string ShowInfo()
        {
            return $"ID: {Id}\nName: {Name}\nAuthor: {AuthorName}\nPrice: {Price} AZN";
        }

        public override string ToString()
        {
            return ShowInfo();
        }
    }
}

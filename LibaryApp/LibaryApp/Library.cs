namespace LibraryApp
{
    // Library class
    public class Library
    {
        public string Name { get; set; }
        private Book[] books = new Book[0];

        public Library(string name)
        {
            Name = name;
        }

        public void AddBook(Book book)
        {
            Array.Resize(ref books, books.Length + 1);
            books[^1] = book;
        }

        public Book GetBookById(int id)
        {
            foreach (var book in books)
            {
                if (book.Id == id)
                    return book;
            }
            return null;
        }

        public void RemoveBook(int id)
        {
            int index = Array.FindIndex(books, b => b.Id == id);
            if (index == -1)
            {
                Console.WriteLine("Book not found.");
                return;
            }

            for (int i = index; i < books.Length - 1; i++)
            {
                books[i] = books[i + 1];
            }

            Array.Resize(ref books, books.Length - 1);
            Console.WriteLine("Book removed.");
        }

        public Book[] GetBook(string name)
        {
            Book[] result = Array.FindAll(books, b => b.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            return result;
        }

        public void GetAllBooks()
        {
            if (books.Length == 0)
            {
                Console.WriteLine("Library is empty.");
                return;
            }

            foreach (var book in books)
            {
                Console.WriteLine(book);
                Console.WriteLine("-------------------");
            }
        }

        public void Update(int id, Book newBook)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Id == id)
                {
                    books[i].Name = newBook.Name;
                    books[i].AuthorName = newBook.AuthorName;
                    books[i].Price = newBook.Price;
                    Console.WriteLine("Book updated.");
                    return;
                }
            }

            Console.WriteLine("Book not found.");
        }
    }
}

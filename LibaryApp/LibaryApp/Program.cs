using System;

namespace LibraryApp
{

    // Program class (Menu)
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library("My Library");

            while (true)
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1. Add book");
                Console.WriteLine("2. Get book by id");
                Console.WriteLine("3. Remove book");
                Console.WriteLine("4. Update book");
                Console.WriteLine("5. Get all books");
                Console.WriteLine("0. Quit");
                Console.Write("Choose: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        try
                        {
                            Console.Write("Enter name: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter author name: ");
                            string author = Console.ReadLine();
                            Console.Write("Enter price: ");
                            double price = Convert.ToDouble(Console.ReadLine());

                            Book book = new Book(name, author, price);
                            library.AddBook(book);
                            Console.WriteLine("Book added.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                        break;

                    case "2":
                        Console.Write("Enter book id: ");
                        if (int.TryParse(Console.ReadLine(), out int getId))
                        {
                            Book found = library.GetBookById(getId);
                            Console.WriteLine(found != null ? found.ToString() : "Book not found.");
                        }
                        break;

                    case "3":
                        Console.Write("Enter book id to remove: ");
                        if (int.TryParse(Console.ReadLine(), out int removeId))
                        {
                            library.RemoveBook(removeId);
                        }
                        break;

                    case "4":
                        Console.Write("Enter id to update: ");
                        if (int.TryParse(Console.ReadLine(), out int updateId))
                        {
                            Console.Write("New name: ");
                            string newName = Console.ReadLine();
                            Console.Write("New author: ");
                            string newAuthor = Console.ReadLine();
                            Console.Write("New price: ");
                            if (double.TryParse(Console.ReadLine(), out double newPrice))
                            {
                                Book updatedBook = new Book(newName, newAuthor, newPrice);
                                library.Update(updateId, updatedBook);
                            }
                            else
                            {
                                Console.WriteLine("Invalid price.");
                            }
                        }
                        break;

                    case "5":
                        library.GetAllBooks();
                        break;

                    case "0":
                        Console.WriteLine("Bye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}

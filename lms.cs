// using System;
// using System.Collections.Generic;

// // Interface for items that can be borrowed
// public interface IBorrowable
// {
//     void Borrow();
//     void Return();
// }

// // Interface for items that can be displayed
// public interface IDisplayable
// {
//     void DisplayDetails();
// }

// // Base class for common properties/methods shared between Book, Author, and LibraryMember classes
// public class LibraryItem : IDisplayable
// {
//     public string Title { get; set; }

//     public virtual void DisplayDetails()
//     {
//         Console.WriteLine($"Title: {Title}");
//     }
// }

// // Book class
// public class Book : LibraryItem, IBorrowable
// {
//     public string Author { get; set; }
//     public string ISBN { get; set; }
//     public bool Availability { get; set; } = true;

//     public void Borrow()
//     {
//         if (Availability)
//         {
//             Availability = false;
//             Console.WriteLine($"{Title} has been borrowed.");
//         }
//         else
//         {
//             Console.WriteLine($"{Title} is not available for borrowing.");
//         }
//     }

//     public void Return()
//     {
//         Availability = true;
//         Console.WriteLine($"{Title} has been returned.");
//     }

//     // Override DisplayDetails for better representation
//     public override void DisplayDetails()
//     {
//         base.DisplayDetails();
//         Console.WriteLine($"Author: {Author}, ISBN: {ISBN}, Availability: {(Availability ? "Available" : "Not Available")}");
//     }
// }

// // Author class
// public class Author : LibraryItem
// {
//     public DateTime BirthDate { get; set; }
//     public List<Book> BooksWritten { get; } = new List<Book>();

//     public void AddBook(Book book)
//     {
//         BooksWritten.Add(book);
//     }

//     // Override DisplayDetails for better representation
//     public override void DisplayDetails()
//     {
//         base.DisplayDetails();
//         Console.WriteLine($"Birth Date: {BirthDate.ToShortDateString()}");
//     }
// }

// // LibraryMember class
// public class LibraryMember : IDisplayable
// {
//     public int MemberID { get; set; }
//     public string Name { get; set; }
//     public List<Book> BorrowedBooks { get; } = new List<Book>();

//     public void BorrowBook(Book book)
//     {
//         if (!BorrowedBooks.Contains(book) && !book.Availability)
//         {
//             BorrowedBooks.Add(book);
//             Console.WriteLine($"{Name} has borrowed {book.Title}.");
//         }
//         else
//         {
//             Console.WriteLine($"{Name} cannot borrow {book.Title}.");
//         }
//     }

//     public void ReturnBook(Book book)
//     {
//         if (BorrowedBooks.Contains(book))
//         {
//             BorrowedBooks.Remove(book);
//             Console.WriteLine($"{Name} has returned {book.Title}.");
//         }
//         else
//         {
//             Console.WriteLine($"{Name} did not borrow {book.Title}.");
//         }
//     }

//     // Override DisplayDetails for better representation
//     public void DisplayDetails()
//     {
//         Console.WriteLine($"MemberID: {MemberID}, Name: {Name}, Borrowed Books: {BorrowedBooks.Count}");
//     }
// }

// // Library class
// public class Library
// {
//     public List<Book> Books { get; } = new List<Book>();
//     public List<Author> Authors { get; } = new List<Author>();
//     public List<LibraryMember> Members { get; } = new List<LibraryMember>();

//     // Indexer to access books by their titles
//     public Book GetBookByTitle(string bookTitle) => Books.Find(book => book.Title == bookTitle);

//     // Indexer to access members by their IDs
//     public LibraryMember GetMemberByID(int memberID) => Members.Find(member => member.MemberID == memberID);

//     public void AddBook(Book book)
//     {
//         Books.Add(book);
//     }

//     public void RemoveBook(Book book)
//     {
//         Books.Remove(book);
//     }

//     public void AddAuthor(Author author)
//     {
//         Authors.Add(author);
//     }

//     public void RemoveAuthor(Author author)
//     {
//         Authors.Remove(author);
//     }

//     public void AddMember(LibraryMember member)
//     {
//         Members.Add(member);
//     }

//     public void RemoveMember(LibraryMember member)
//     {
//         Members.Remove(member);
//     }

//     // Display library status
//     public void DisplayLibraryStatus()
//     {
//         Console.WriteLine("Library Status:");
//         Console.WriteLine("Books:");
//         foreach (var book in Books)
//         {
//             book.DisplayDetails();
//         }

//         Console.WriteLine("\nAuthors:");
//         foreach (var author in Authors)
//         {
//             author.DisplayDetails();
//         }

//         Console.WriteLine("\nMembers:");
//         foreach (var member in Members)
//         {
//             member.DisplayDetails();
//         }
//     }
// }

// namespace LibraryManagementSystem
// {
//     class Program
//     {
//         static void Main()
//         {
//             // Sample usage
//             var library = new Library();

//             var author1 = new Author { Title = "Author1", BirthDate = new DateTime(1980, 1, 1) };
//             var book1 = new Book { Title = "Book1", Author = author1.Title, ISBN = "123456789" };
//             var member1 = new LibraryMember { MemberID = 1, Name = "Member1" };

//             author1.AddBook(book1);
//             library.AddAuthor(author1);
//             library.AddBook(book1);
//             library.AddMember(member1);

//             // Borrow and return book
//             member1.BorrowBook(book1);
//             book1.DisplayDetails();

//             member1.ReturnBook(book1);
//             book1.DisplayDetails();

//             // Display library status
//             library.DisplayLibraryStatus();
//         }
//     }
// }

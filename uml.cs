namespace LibraryManagementSystem
{
    public class LibraryManagementSystem
    {
        public string UserType { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class User
    {
        public string Name { get; set; }
        public string ID { get; set; }
    }

    public class Staff : User
    {
        public string Dept { get; set; }
    }

    public class Student : User
    {
        public string Class { get; set; }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime Publication { get; set; }
    }

    public class Account
    {
        public int NoBorrowedBooks { get; set; }
        public int NoReservedBooks { get; set; }
        public int NoReturnedBooks { get; set; }
        public int NoLostBooks { get; set; }
        public float FineAmount { get; set; }
    }

    public class Librarian
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string Password { get; set; }
    }

    public class LibraryDatabase
    {
        public List<Book> ListOfBooks { get; set; } = new List<Book>();
    }
}
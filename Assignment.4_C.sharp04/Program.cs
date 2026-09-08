using System;
#nullable disable
namespace Assignment._4_C.sharp04
{
    public class Program
    {
        #region Q6
        public class Book { 
            public Genre genre ; 
        }
        public static void Main(string[] args)
        {
            Book book = new Book();
            int genreNumber = 1;
            Console.WriteLine($"The genre of the book is: {(Genre)genreNumber}");

        }
        #endregion
    }
}

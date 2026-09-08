using System;
#nullable disable
namespace Assignment._4_C.sharp04
{
    public class Program
    {
        #region Q4
        public class Book { 
            public Genre genre ; 
        }
        public static void Main(string[] args)
        {
            Book book = new Book();
           book.genre = Genre.Science;
            Console.WriteLine(book.genre); // Science
        }
        #endregion
    }
}

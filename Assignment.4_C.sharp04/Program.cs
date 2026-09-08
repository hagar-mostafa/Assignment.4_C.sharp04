using System;
#nullable disable
namespace Assignment._4_C.sharp04
{
    public class Program
    {
        #region Q7
        public class Book { 
            public Genre genre ; 
        }
        public static void Main(string[] args)
        {
            Book book = new Book();
            Genre genre = Genre.Fiction;
            Console.WriteLine("gener after to string is : " + genre.ToString());

        }
        #endregion
    }
}

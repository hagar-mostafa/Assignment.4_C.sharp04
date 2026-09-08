using System;
#nullable disable
namespace Assignment._4_C.sharp04
{
    public class Program
    {
        #region Q8
        public class Book { 
            public Genre genre ; 
        }
        public static void Main(string[] args)
        {
            Book book = new Book();
            string genreText = "Science";
            Enum.Parse(typeof(Genre), genreText);
            Console.WriteLine(" After Using Parse() : " + genreText );

        }
        #endregion
    }
}

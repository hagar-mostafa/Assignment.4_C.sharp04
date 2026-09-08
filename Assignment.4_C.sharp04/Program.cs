using System;
#nullable disable
namespace Assignment._4_C.sharp04
{
    public class Program
    {
        #region Q9
        public class Book { 
            public Genre genre ; 
        }
        public static void Main(string[] args)
        {
           string genreText = "Mystery";
           bool flag =  Enum.TryParse(genreText, out Genre genre);

            Console.WriteLine(flag ? genreText : "Unknown genre");

        }
        #endregion
    }
}

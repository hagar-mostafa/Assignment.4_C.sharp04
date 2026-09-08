using System;
#nullable disable
namespace Assignment._4_C.sharp04
{
    public class Program
    {
        #region Q5
        public class Book { 
            public Genre genre ; 
        }
        public static void Main(string[] args)
        {
            Book book = new Book();
         
            Console.WriteLine($"The value of Fiction is: {(int)Genre.Fiction}"); // 0
            Console.WriteLine($"The value of NonFiction is: {(int)Genre.NonFiction}"); // 1
            Console.WriteLine($"The value of Science is: {(int)Genre.Science}"); // 2
        }
        #endregion
    }
}

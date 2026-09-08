using System;
#nullable disable
namespace Assignment._4_C.sharp04
{
    public class Program
    {
        #region Q3
        public class Book { 
            public string title ; 
        }
        public static void Main(string[] args)
        {
            Book book = new Book();
           book.title = "Clean Code"; // This will work because the property is public
                                    // public can be accessed within the same Project or out side project
        Console.WriteLine(book.title);
        }
        #endregion
    }
}

using System;
#nullable disable
namespace Assignment._4_C.sharp04
{
    public class Program
    {
        #region Q2
        public class Book { 
            internal int copiesInStock ; 
        }
        public static void Main(string[] args)
        {
            Book book = new Book();
           book.copiesInStock = 10; // This will work because the property is internal
                                    // internal can be accessed within the same Project
        Console.WriteLine(book.copiesInStock);
        }
        #endregion
    }
}

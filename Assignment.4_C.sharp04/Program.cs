using System;
#nullable disable
namespace Assignment._4_C.sharp04
{
    public class Program
    {
        #region Q1
        class Book { private string password = "secret";  }
        public static void Main(string[] args)
        {
            Book book = new Book();
           //Book.password // syntax error
           // password property is private and cannot be accessed from outside the class
            // The solution is to change the access modifier to public or internal, or to make a public method to access the property.
        }
        #endregion
    }
}

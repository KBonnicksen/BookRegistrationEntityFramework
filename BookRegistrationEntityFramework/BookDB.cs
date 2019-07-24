using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRegistrationEntityFramework
{
    /// <summary>
    /// Contains helper methods linking to the book database
    /// </summary>
    static class BookDB
    {
        /// <summary>
        /// Retrieves all books sorted in alphabetical order by title
        /// </summary>
        /// <returns></returns>
        public static List<Book> GetBooks()
        {
            //The using statement will forve the compiler to create a try/finally
            //Disposes of it when finished
            using(var context = new BookRegistrationEntities())
            {
                return context.Book.OrderBy(b => b.Title).ToList();
            }
        }
    }
}

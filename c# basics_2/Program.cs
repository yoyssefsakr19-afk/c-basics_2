using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__basics_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region quesion1
            //Q1
            //string title = "clean code";
            //string upperTitle = title.ToUpper();
            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle);
            #endregion
            #region quesion 2
            //Q2
            //string first = "clean code";
            //string second = "clean code";

            //Console.WriteLine(ReferenceEquals(first, second));
            #endregion
            #region quesion 3
            //Q3
            StringBuilder builder = new StringBuilder();
            //builder.Append("Book list");
            //builder.Append(" - Updated");
            //builder.Append(" - Updated");
            //builder.Append(" - Updated");
            //builder.Append(" - Updated");
            //Console.WriteLine(builder);
            #endregion
            #region quesion 4
            //Q4
            //builder.Replace("Book list", "library");

            //int pages = 464;

            #endregion
            #region quesion 5
            //Q5
            //string title = "clean code";
            //int ages = 464;

            //string sentence = "Book: " + title + ", pages:" + pages;
            //Console.WriteLine(sentence);
            #endregion
            #region quesion 6
            //string sentense = $"Book:{title},pages:{pages}";
            //Console.WriteLine(sentense);
            #endregion
            #region quesion 7
            //Q7
            //string sentence = string.Format("Book:{1}, pages: {0}", titele, pages);
            //Console.WriteLine(sentence);
            #endregion
            #region quesion 8
            //Q8
            //int pages = 464;

            //if(pages> 300)
            //    Console.WriteLine("long book");
            //else
            //    Console.WriteLine("short Book")

            #endregion
            #region quesion 9
            //Q
            //bool isAvailable = true;
            //if (pages > 300 && isAvailable) ;
            //Console.WriteLine("you can borrw this book");

            #endregion
            #region quesion 10
            //Q10
            //string title = "refactoring";
            //switch (title)

            //{
            //    case "clean code":
            //        Console.WriteLine("Great choice!");
            //        break;
            //    default:
            //        Console.WriteLine("never heard of it");
            //        break;
            //}






            #endregion
            #region quesion11
            //Q11
            //int pages = 250;
            //string sizelabel = pages > 300 ? "long Book" : pages > 250 ? "test" : "ENded";
            //Console.WriteLine(sizelabel);
            #endregion
            #region quesion 12 
            //Q12
            //for (int i = 0; i < Book.length; i++)
            //{
            //    Console.WriteLine($"{i}.{books[i]}");
            //}
            #endregion
            #region quesion 13
            //Q13
            //int i = 0;
            //while (i < books.Length)
            //{
            //    Console.WriteLine(books[i]);
            //    i++;
            //}
            #endregion
            #region quesion 14
            //Q14
            //int count = 0;
            //do
            //{
            //    Console.WriteLine("Cheaking Books....");
            //    count++;
            //} while (count > 3);


            #endregion
            #region quesion 15
            foreach (var book in books)
                Console.WriteLine(book);
            #endregion
        }
    }
}

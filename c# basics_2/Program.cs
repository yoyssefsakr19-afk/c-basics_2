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
            string first = "clean code";
            string second = "clean code";

            Console.WriteLine(ReferenceEquals(first, second));
            #endregion
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10.Demo
{

        public class BookFunctions
        {
            public static string GetTitle(Book B)
            {
                return B.Title;
            }
            public static string GetAuthors(Book B)
            {

                //string temp = "";
                //for (int i = 0; i < B.Authors.Length; i++)
                //{
                //    if (i != B.Authors.Length - 1)
                //        temp += B.Authors[i] + " and ";
                //    else
                //    {
                //        temp += B.Authors[i];
                //    }
                //}
                //return temp;

            return String.Join(" ", B.Authors);
            }
            public static string GetPrice(Book B)
            {
                return $"{B.Price}";
            }
        }
}

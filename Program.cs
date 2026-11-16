using System.Dynamic;
using System.Runtime.CompilerServices;

namespace C_Assigment1_withouttoplevel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q.1

            Book b1 = new Book() { Title = "c#", Pages = 500 };
            Console.WriteLine(b1.Title);
            Console.WriteLine(b1.Pages); 
            #endregion


            #region Q.2
            //Book b1 = new Book() { Title = "C++", Pages = 200 };
            //Book b2 = new Book() { Title = "C++", Pages = 200 };
            //Console.WriteLine(b1.ToString());
            //Console.WriteLine(b1.Equals(b2));
            //Console.WriteLine(b1.GetHashCode());
            //Console.WriteLine(b2.GetType()); 
            #endregion

            #region Q.3
            // Compile-time error .
            //int pages = 464;

            #endregion

            #region Q.4
            //try
            //{
            //    int Num1 = 10;
            //    int Num2 = 0;
            //    int res = (Num1 / Num2);
            //    Console.WriteLine(res);

            //}
            //catch(DivideByZeroException ex) 
            //{
            //    Console.WriteLine("cannot divide by zero");
            //    Console.WriteLine($"MES is : {ex.Message}");

            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}



            #endregion

            #region Q.5
            //int pages = 300;
            //double pages2 = pages;
            //Console.WriteLine(pages2);

            #endregion

            #region Q.6
            //double price = 49.99;
            //int p2 =(int)price;
            //Console.WriteLine(p2);
            #endregion

            #region Q.7
            //string pages = "464";
            //int y = Convert.ToInt32(pages);
            //Console.WriteLine(y); 
            #endregion

            #region Q.8
            //string years = "2023";
            //int y = int.Parse(years);
            //Console.WriteLine(y);

            //string badtext = "abc";
            //bool badnumber = int.TryParse(badtext,out int y);
            //if(badnumber==false)
            //{
            //    Console.WriteLine("invalid number");
            //    Console.WriteLine(y);

            //}
            //else
            //{
            //    Console.WriteLine("succeseful number");
            //    Console.WriteLine(y);
            //}



            #endregion

            #region Q.9

            //int pages = 464;
            //string y = pages.ToString();
            //Console.WriteLine(y);
            //Console.WriteLine(y.GetType());
            #endregion

            #region Q.10
            //int copies = 100;
            //object obj1 = copies;
            //int copies2 = (int)obj1;
            //Console.WriteLine(copies2 + " " + copies);
            #endregion

            #region Q.11
            //int? years = null;
            //Console.WriteLine(years.HasValue);
            //years = 2023;
            //Console.WriteLine(years.HasValue);

            #endregion

            #region Q.12
            //string? reviewer = null;
            //Console.WriteLine(reviewer is null);
            #endregion

            #region Q.13
            //Console.WriteLine(book?.Title);             
            //Book? book = null;  


            #endregion

            #region Q.14
            //string? title = null;
            //Console.WriteLine(title?? "untitled");
            //title ??= "untitled";
            //Console.WriteLine(title);

            #endregion

            #region Q.15
            string? name = "Ahmed";
            string confirmedname = name ! ;
            Console.WriteLine(confirmedname);

            #endregion
        }
    }
}

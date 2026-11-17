namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            #region Q1

            //object book = new Book() { Page = 123, Title = "css" };
            #endregion
            #region Q2

            //Console.WriteLine(book.ToString());
            //Console.WriteLine(book.Equals(book));
            //Console.WriteLine(book.GetHashCode());
            //Console.WriteLine(book.GetType());
            #endregion
            #region Q3
            // syntax error can't put string in varabil int
            //int x = "464";
            int x = 464;
            #endregion
            #region Q4
            //try
            //{
            //    int result = 10 / 0; 
            //}
            //catch (DivideByZeroException)
            //{

            //    Console.WriteLine("cannot divide by zero");
            //}
            //finally { Console.WriteLine("Done"); }
            #endregion
            #region Q5
            //int page = 300;
            //double number = page;
            //Console.WriteLine (number);
            #endregion
            #region Q6
            //double pirce = 49.99;
            //int number = (int)pirce;
            //Console.WriteLine(number);
            #endregion
            #region Q7
            //string pagesText = "466";
            //int page=Convert.ToInt32(pagesText);
            //Console.WriteLine(page);
            #endregion
            #region Q8
            //string yearText = "2023";
            //int year=int.Parse(yearText);
            //Console.WriteLine(year);
            //string badText = "abc";
            //int number;
            //if (int.TryParse(badText, out number))
            //{
            //    Console.WriteLine(number);
            //}  
            //else { Console.WriteLine("Invalid number"); }

            #endregion
            #region Q9
            //int pages = 464;
            //string text=pages.ToString();
            //Console.WriteLine(text);
            //Console.WriteLine(text.GetType());
            #endregion
            #region Q10
            //int copies = 100;
            //object num1 = copies;
            //int num2 = (int)num1;
            //Console.WriteLine("boxing : "+num2);
            //Console.WriteLine("unboxing : " + num2);

            #endregion
            #region Q11
            //int? year = null;
            //Console.WriteLine(year.HasValue);
            //year = 2023;
            //Console.WriteLine(year);
            #endregion
            #region Q12
            //string? revewer = null;
            //Console.WriteLine(revewer==null);
            #endregion
            #region Q13
            //Book? book= null;
            //string title = book?.Title;
            //Console.WriteLine(title);
            #endregion
            #region Q14
            //string? title = null;
            //Console.WriteLine(title ?? "untitled");
            //title ??= "untitled";
            //Console.WriteLine(title);
            #endregion
            #region Q15
            //string? name = "Ahmed";
            //string confirmedName = name!;
            //Console.WriteLine(confirmedName);
            #endregion
        }

    }
}

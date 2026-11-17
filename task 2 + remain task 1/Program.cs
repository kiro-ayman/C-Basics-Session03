using System.Net.Http.Headers;

namespace task_2___remain_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1 question 5
            //int pages = 300;
            //double implicit_pages = pages;
            #endregion

            #region task1 question 6
            //double price = 49.99;
            //int explicit_price = (int)price;
            #endregion

            #region task1 question 7
            //string pages = "464";
            //int converted_numbers = Convert.ToInt32(pages);
            #endregion

            #region task1 question 8
            //string yearText = "2023";
            //int yearInt = int.Parse(yearText);
            //string badText = "asd";
            //bool isParsed = int.TryParse(badText, out int x);


            ////wrong  isParsed ? Console.WriteLine("x") : Console.WriteLine("Conversion failed");

            //Console.WriteLine(isParsed ? x : "Conversion failed");

            #endregion

            #region task1 question 9
            //int pages = 456;
            //string pagesText = Convert.ToString(pages);
            //Console.WriteLine(pagesText.GetType());
            #endregion

            #region task1 question 10
            //int copies = 100;
            //object obj = copies; 
            //int unboxedCopies = (int)obj; 
            //Console.WriteLine(obj);
            //Console.WriteLine(unboxedCopies);

            ////draft  Console.WriteLine(unboxedCopies.GetType());
            ////draft  Console.WriteLine(obj.GetType());
            #endregion

            #region task1 question 11
            ////nullable : in normal i cant put null in int but in nullable i can put null in int
            //// varible.hasValue : check if the variable has value or not
            //// benfit : graduatetd year , product discount 
            //int? year = null;
            //Console.WriteLine(year.HasValue);
            //Console.WriteLine(year);

            //year = 2023;
            //Console.WriteLine(year.HasValue);
            //Console.WriteLine(year);

            #endregion

            #region task1 question 12
            //string ? reviewer = null;

            //Console.WriteLine(reviewer==null?"Reviewer is null":reviewer);

            #endregion

            #region task1 question 13
            //// .? : check if the variable is null or not
            //// . :crash if the variable is null
            //// ! : tell the compiler to trust me 
            //Book ? book = null;
            //Console.WriteLine(book ?.Title); // null
            //Book book2 = new Book();
            //Console.WriteLine(book2.Title);
            ////draft
            ////Console.WriteLine(book!.Title); // nullreference exception
            ////Console.WriteLine(book.Title); // nullreference exception

            #endregion

            #region task1 question 14
            ////null coalesing ?? : it chek if value is null return right hand side if not left hand side 
            //Book? b1 = null;
            //Console.WriteLine(b1?.Title ?? "untitled");


            //b1 ??= new Book();
            //b1?.Title ??= "untitled"; // it will put untitle only if title was empty 
            //Console.WriteLine(b1.Title);
            #endregion

            #region task1 question 15
            //string? name = "ahmed";
            //string confirmedName = name!;


            #endregion


            //    // draft
            //    int x = 5;
            //    goto check;
            //    Console.WriteLine("this line will not be executed");
            //check:
            //    Console.WriteLine(x);



            #region task2 question 1
            // Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than
            //300, otherwise prints "Short Book".

            //int pages = 464;
            //if (pages > 300)
            //{
            //    Console.WriteLine("Long Book");
            //}
            //else
            //{
            //    Console.WriteLine("Short Book");
            //}

            #endregion

            #region task2 question 2
            //int pages = 464;
            //bool isAvailable = true;
            //if (pages > 300 && isAvailable)
            //{
            //    Console.WriteLine("You can borrow this book");
            //}
            #endregion

            #region task2 question 3
            //string title = "refactoring";
            //switch(title){
            //    case "clean code":
            //        Console.WriteLine("great choice ");
            //        break;
            //    case "refactoring":
            //        Console.WriteLine("nice pick");
            //        break;
            //    default:
            //        Console.WriteLine("never heard of it");
            //        break;
            //}
            #endregion

            #region task2 question 4
            //int pages = 464;
            //string sizeLabel = (pages > 300) ? "long book" : "short book";
            //Console.WriteLine(sizeLabel);
            #endregion

            #region task2 question 5
            //string[] books = { "clean code", "the Pragmatic Programmer", "refactoring" };
            //for (int i = 0; i < books.Length; i++)
            //{
            //    Console.WriteLine( $"{i + 1}) {books[i]}");
            //}
            #endregion

            #region  task2 question 6
            string[] books = { "clean code", "the Pragmatic Programmer", "refactoring" };
            int i = 0;
            while ( i < books.Length )
            {
                Console.WriteLine($"{i + 1}) {books[i]}");
                i++;
            }
            #endregion


        }
    }
}

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
            int copies = 100;
            object obj = copies; 
            int unboxedCopies = (int)obj; 
            Console.WriteLine(obj);
            Console.WriteLine(unboxedCopies);

            //draft  Console.WriteLine(unboxedCopies.GetType());
            //draft  Console.WriteLine(obj.GetType());
            #endregion

        }
    }
}

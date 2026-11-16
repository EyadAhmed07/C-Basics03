namespace Assignment_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //1_Create a one-dimensional array double[] prices

            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(prices[1]);
            #endregion


            #region Question02
            //int[,] shelfCopie = {

            //    {0,3,5 },
            //    {1,1,4 }

            //};
            //Console.WriteLine(shelfCopie[1,0]);
            #endregion


            #region Question03
            //PrintWelcomeMessage();
            #endregion


            #region Question04
            //string str = "Clean Code";
            //PrintBookTitle(str);
            #endregion


            #region Question05
            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine(pages);
            //value doesn't change  because we pass by value
            #endregion


            #region Question06
            ////20.5
            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);
            ////Arrays are reference types so value will change
            #endregion


            #region Question07
            //int pages = 400;
            //AddBonusPages(ref pages);
            //Console.WriteLine(pages);
            #endregion


            #region Question08
            //double[] prices = { 25.5, 40.0 };
            //ReplaceArray( ref prices);
            //Console.WriteLine($"Array size: {prices.Length}");
            #endregion


            #region Question09
            // string title = "Clean Code";
            // double price;
            //TryGetPrice(title ,out price);
            //Console.WriteLine(price);
            #endregion


            #region Question10
            //string title = "The Knight";
            //int pages = 280;
            //PrintBookInfo(title);
            //PrintBookInfo(title,pages);
            #endregion


            #region Question11
            //PrintBookInfo(pages:200,title:"The knight");
            #endregion


            #region Question12
            string[] titles = { "title 1", "title 2", "title 3" };
            PrintAllTitles(titles);
            #endregion


        }
        


        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }


        static void PrintBookTitle(string title)
        {
            Console.WriteLine($"Book title: {title}");
        }


        static void AddBonusPages(int  pages)
        {
            pages += 50;
        }


        static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }


        static void AddBonusPages(ref int pages)
        {
            pages += 50;
        }


        static void ReplaceArray( ref double[] prices)
        {

            prices = new double[] { 10.0, 12.5, 15.0 };
        }


       static bool TryGetPrice(string title, out double price)
       {
            if(title=="Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }

       }


       static void PrintBookInfo(string title, int pages = 300)
       {

            Console.WriteLine($"Title: {title}\npages: {pages}");
       }


       static void PrintAllTitles(params string[] titles)
       {
            foreach (string s in titles) { Console.WriteLine($"#{s}"); }

       }
    }
}

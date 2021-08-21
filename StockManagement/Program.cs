using System;

namespace StockManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();
            Console.WriteLine("Welcome to Stock Account Management!");
            Console.WriteLine("************************************");
            Console.WriteLine("Enter Number Of Stocks:-");
            int NumberOfStocks = int.Parse(Console.ReadLine());
            for (int i = 1; i <= NumberOfStocks; i++)
            {
                Console.WriteLine("Enter ShareName:-");
                string ShareName = Console.ReadLine();

                Console.WriteLine("Enter Total Number Of Shares:-");
                int NoOfShares = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Price Per Share:-");
                int PricePerEachShare = int.Parse(Console.ReadLine());

                stock.Stockvalue(NoOfShares, PricePerEachShare, ShareName);
            }
        }
    }
}


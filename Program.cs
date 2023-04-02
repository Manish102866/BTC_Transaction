using System;

namespace BTC_Transaction
{
    public class BTC_Transaction
    {
        public int Id { get; set; }
        public int Size { get; set; }
        public double Fee { get; set; }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            BTC_Transaction[] transactions = new BTC_Transaction[]
           {
            new BTC_Transaction() { Id = 1, Size = 57247, Fee = 0.0887 },
            new BTC_Transaction() { Id = 2, Size = 98732, Fee = 0.1856 },
            new BTC_Transaction() { Id = 3, Size = 134928, Fee = 0.2307 },
            new BTC_Transaction() { Id = 4, Size = 77275, Fee = 0.1522 },
            new BTC_Transaction() { Id = 5, Size = 29240, Fee = 0.0532 },
            new BTC_Transaction() { Id = 6, Size = 15440, Fee = 0.0250 },
            new BTC_Transaction() { Id = 7, Size = 70820, Fee = 0.1409 },
            new BTC_Transaction() { Id = 8, Size = 139603, Fee = 0.2541 },
            new BTC_Transaction() { Id = 9, Size = 63718, Fee = 0.1147 },
            new BTC_Transaction() { Id = 10, Size = 143807, Fee = 0.2660 },
            new BTC_Transaction() { Id = 11, Size = 190457, Fee = 0.2933 },
            new BTC_Transaction() { Id = 12, Size = 40572, Fee = 0.0686 }
           };

            Array.Sort(transactions, (x, y) => y.Fee.CompareTo(x.Fee));
            int maxSize = 500000;
            int currentSize = 0;
            double currentReward = 0;

            foreach (BTC_Transaction transaction in transactions)
            {
                if (currentSize + transaction.Size <= maxSize)
                {
                    currentSize += transaction.Size;
                    currentReward += transaction.Fee;
                }
                else
                {
                    break;
                }
            }
            currentReward += 12.5;

            Console.WriteLine("Maximum possible reward for creating a block: {0:F4} BTC", currentReward);
            Console.ReadKey();
        }
    }
}
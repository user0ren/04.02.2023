using System;
using Libr;


namespace brak
{
    internal class Program
    {
        static void Main()
        {
            while(true)
            {
                int productType = 3;
                int materialType = 1;
                int count = 15;
                float width = 20;
                float length = 45;
                int num = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
                Console.WriteLine(num);
                Console.ReadLine();
            }
        }
    }
}

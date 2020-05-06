using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace No_9
{
    class Program
    {

        static void Main(string[] args)
        {
            var path = @"D:\Product.csv";
            var reader = new StreamReader(File.OpenRead(path));
            var SKU = new List<String>();
            var Name = new List<String>();
            var Price = new List<String>();
        
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                SKU.Add(values[0]);
                Name.Add(values[1]);
                Price.Add(values[2]);
            }
            var firstSKU = SKU.ToArray();
            var firstName = Name.ToArray();
            var firstPrice = Price.ToArray();

            double total = 0.00;
            int k = 1;
            int runnumber = 0;

            ArrayList product_List = new ArrayList();
            Console.WriteLine("Products in your cart are\nnone");
            Console.WriteLine("---\nTotal amount: 0.00 baht");

            do
            {
                Console.WriteLine("Please input a product key:");
                String idproduct = Console.ReadLine();
               

                for (int i = 0; i < firstSKU.Length; i++)
                {
                    if(idproduct == firstSKU[i])
                    { 
                        runnumber++;
                        product_List.Add(runnumber + "." + firstName[i] + "\t" + firstPrice[i]);
                        total += Int32.Parse(firstPrice[i]);
                    }
                }
                Console.WriteLine("\nProducts in your cart are");
                
                foreach (var item in product_List)
                {
                    Console.WriteLine(item.ToString()); // Assumes a console application
                }

                Console.WriteLine("---\nTotal amount: " + total + " baht");
            } while (k == 1);
        }
    }     
}

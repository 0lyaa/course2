using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Laba2
{
    internal class task3
    {
        static List<Product> Products = new List<Product>();

        public static void FromTxtToList(List<Product> list)
        {

            string directory = Directory.GetCurrentDirectory();
            string path = directory[0..(directory.Length - 17)] + @"\products.txt";
            if (File.Exists(path))
            {
                string s;
                using (StreamReader sw = File.OpenText(path))
                {
                    while ((s = sw.ReadLine()) != null)
                    {
                        string[] data = s.Split(',');
                        list.Add(new Product(data[0], data[1], data[2]));

                    }
                }
            }
            else
            {
                Console.WriteLine("все погано");
            }
        }

        public class Product
        {
            public string Name { get; set; }
            public string Category { get; set; }
            public float Price { get; set; }

            public Product(string name, string price, string category)
            {
                Name = name;
                Price = float.Parse(price);
                Category = category;
            }
            public override string ToString()
            {
                return Name + " " + Price + " " + Category;
            }
        }
        public static void DO()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            FromTxtToList(Products);
            var groupedProducts = Products.GroupBy(k => k.Category);
            foreach (var group in groupedProducts)
            {
                Console.WriteLine("Категорія: {0}", group.Key);
                foreach (var product in group)
                {
                    Console.WriteLine("- {0} - {1}", product.Name, product.Price.ToString("C"));
                }
                Console.WriteLine();
            }
        }
    }
}
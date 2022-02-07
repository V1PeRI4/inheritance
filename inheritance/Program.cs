using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MilkProdukt Milk = new MilkProdukt("Кубань", "Натуральное", 59, new int[] {40, 10, 5}, "До 29");
            Toy toy = new Toy("кукла", "Натуральная", 259, new int[] { 100, 10, 50 }, "Плющевая");
        }
    }
}

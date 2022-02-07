using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class MilkProdukt : Merchandise
    {
        public int volume;
        public string ageFrom;

        public MilkProdukt (string name, string description, int price, int[] size, string ageFrom) : base(name, description, price, size) {
            setValuesMerchandise(price, size);
            this.ageFrom = ageFrom;
            Console.WriteLine("Введите обьем в мл: ");
            volume = Convert.ToInt32(Console.Read()); 
        }

         
    }
}

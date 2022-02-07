using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Merchandise : Produkt
    {
        public int price;
        public int[] size = new int[3];


        public Merchandise(string name, string description, int price, int[] size) : base(name, description) 
        {
            setValuesProduct(name, description);
            setValuesMerchandise(price, size);
        }




        public void setValuesMerchandise(int price, int[] size)
        {
                this.price = price;
                this.size = size;
        }

    }
}

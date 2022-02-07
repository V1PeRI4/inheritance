using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Toy : Merchandise
    {
        public string type;
        

        

        public Toy (string name, string description, int price, int[] size, string type) : base (name, description, price, size)
        {
            this.type = type;
            
        }

        
    }
}

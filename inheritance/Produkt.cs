using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Produkt
    {

        private string name;
        private string description = "default";

        public Produkt (string name, string description)
        {
            setValuesProduct(name, description);
        }

        public void setValuesProduct(string name, string description)
        {
            this.name = name;
            this.description = description;
        }




    }
}

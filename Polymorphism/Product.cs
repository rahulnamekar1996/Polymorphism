using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public   class Product
    {

        public int id;
        public string name;
        public double price;

        public int Id { set; get; }
        public string Name { set; get; }
        public double Price{ set; get; }

        public override string ToString()
        {
            return $" product name is{name} product Id{id} price is{price}";
        }
    }
}

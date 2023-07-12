using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Product_details
    {
        private int id;
        private double price;
        private string name;
        private double dic_per;

        public int ID
        {
            set { id = value; }
            get { return id; }
        }
        public double Price
        {
            set {price   = value; }
            get { return price; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }



        }
        public double DiscountPercentage
        {
            set { dic_per = value; }
                get { return dic_per; }

        }
         public void CalculateDis()
        {
            dic_per = price * DiscountPercentage / 100;
        }
        public override string ToString()
        {
            return $"product id is{id} name is {name} priceis{price} discount is{dic_per}";
        }


    }





}
    


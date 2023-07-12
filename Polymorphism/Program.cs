using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {

           Student student  = new Student() ;    
           Console.WriteLine( student ());
           
            
            Employee employee = new Employee(102, "RAHUL", 30000, Dept.Devloper);
            employee. CalculateSal();
            Console.WriteLine(employee.ToString ());

            Product product = new Product();
            product .name = " haier";
            product.id = 12;
            product.price = 13000;
            product.ToString();
            Console .WriteLine (product.ToString ());
                
          
           Product_details p2= new Product_details();
            p2.ID = 101;
            p2.Name = "samsung";
            p2.Price = 10000;
            p2.DiscountPercentage = 30;
            p2.CalculateDis();
            p2.ToString();
            Console.WriteLine (p2.ToString ());

            
           

            Employee emp1=new Employee (01,"rahul",10000,Dept.Devloper);
           emp1 .CalculateSal();
            Console .WriteLine ( emp1 .ToString ());


            string str1 = "Hello";
            Console.WriteLine(str1 );
            Console.WriteLine(str1.GetHashCode());

            str1 = "Hello To all";
            string str2 = "good evenning";
            Console.WriteLine(str1 );
            Console.WriteLine(str1.GetHashCode());

          
            string str3 = string.Concat(str1, str2);
            Console.WriteLine(str3.IndexOf('o'));
            Console .WriteLine (str3.LastIndexOf ("o"));
            Console.WriteLine(str3);


                
          
              
        }
    }
}

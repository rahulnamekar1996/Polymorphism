using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public enum Dept { sales,admin,testing,Devloper}

    public    class Employee
    {   
        private int id, bs;
        private string name;
        private double hra, gs, pf, ta;
        private  Dept dept;

        public Employee(int id,string name,int bs,Dept dept )
        {
            this.id = id;
            this.bs = bs;
            this.name = name;
            this.dept  = dept;
        }
        public void CalculateSal()
        {
            hra = bs * 0.40;
            ta = bs * 0.20;
            pf = bs * 0.12;
            gs = (hra + ta) - pf;



        }
        public override  string ToString()
        {
            return $"name is {name}id is {id}gross sallary is{gs} Dept{dept}";
        }


    
    
    
    
    }
}

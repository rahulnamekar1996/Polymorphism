using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public  class Employee1
    {
        protected string name;
        protected int id;
        protected double bs, hra, ta, da, pf, gs, tatal;
        private static int count;

        public Employee1(string name,int bs)

        {
            count++;
            this.name = name;
            this.bs = bs;
            this.id = count;
             
        }

        public static int Getcount()
        {
            return count;
        }
    }
}

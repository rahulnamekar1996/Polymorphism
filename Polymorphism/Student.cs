using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
        
{
    public class student1
    {
        private int id;
        private int rollno;
        private string name;
        private int age;
        private static int count;

        public student1(string name, int rollno)
        {
            count++;
            this.id = count;
            this.name = name;
            this.rollno = rollno;

        }
        public static int GetCount()
        {
            return count;
        }

        public override string ToSring()
        {
            return $" name is {name} rollno is {rollno} id is {id}";

        }

    }






    }

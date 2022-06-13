using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2108M_solution.Project1
{
   abstract class Human
    {
       public string name;
        int age;

        public abstract void showInfo();

        public virtual void running()
        {
            Console.WriteLine("Running...");
        }
    }
}

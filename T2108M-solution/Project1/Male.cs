﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2108M_solution.Project1
{
    class Male : Human, IXmen 
    {
        public Male()
        {

        }

        public Male(int food)
        {

        }
        public void Study()
        {

        }
        
        public override void showInfo()
        {
            
        }
        public override void running()
        {
            base.running();
            Console.WriteLine(this.name);
        }

        public void Eat()
        {

        }
        public void Eat(int food)
        {

        }

    }
}

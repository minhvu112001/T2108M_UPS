﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2108M_solution.Project1
{
     class Car
    {


        
    
        string brand;
        int year;
        decimal price;
        List<string> owners = new List<string>();

       public List<string> Owners
        {
            get => owners;
            
        }
        
        public void AddOwner(string s)
        {
            Owners.Add(s);
        }

        public string this[int index]
        {
            get => owners[index];
            set => owners[index] = value;
        }

        // property
        public string Brand
        {
            get {
                return Brand;  
            }
            set{
                this.brand = value;
            }
        }

        public int Year
        {
            get => year;
            set => year = value;
        }

        public decimal Price
        {
            get => price;
            set
            {
                if(value > 0)
                {
                    price = value;
                }
                else
                {
                    price = 0;
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2108M_ConsoleApp.Project1;

namespace T2108M_ConsoleApp.Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("x + i = " + (x + i));
            }
            Male m = new Male();
            Male m1 = new Male(20);
            Car c = new Car();
            c.Brands = new Brands;
            Console.WriteLine(c.Brands);
            List<Car> arr = new List<Car>();
            arr.Add(c);
            arr.Add(new Car());

            Car d = new Car();
            d.Owners.Add("Nguyen Van A");
            d.Owners.Add("Nguyen Van B");

            for(int i = 0, i < d.Owners.Count; i++)
            {
                Console.WriteLine(d.Owners[i]);
                Console.WriteLine(d[i]);
            }
            d.Owners[0] = "Do Van Huy";
            d[0] = "Do Van Huy";
        }
    }
}

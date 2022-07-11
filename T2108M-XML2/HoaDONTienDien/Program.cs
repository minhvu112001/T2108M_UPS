using System;
using System.Collections.Generic;
using System.Text;


namespace T2108M_XML2.HoaDONTienDien
{
  public  class Program
    {
         private static void Main(string[] args)
        {
            const int gia1 = 500, gia2 = 600, gia3 = 800, gia4 = 1000;
            const int dm1 = 100, dm2 = 250, dm3 = 300;
            Double thanhtien;

            Console.WriteLine("Tinh tien dien");
            Console.WriteLine("Ho ten khach hang: ");
            string ho_ten = Convert.ToString(Console.ReadLine());
            Console.Write("ma dien ke:");
            string ma_dk = Convert.ToString(Console.ReadLine());
            Console.Write("Chi so dau:");
            string csd = Console.ReadLine();
            Console.Write("Chi so cuoi:");
            string csc = Console.ReadLine();

            Double kw = 0;
               
            if ((kw > 0) && (kw <= dm1))
                thanhtien = gia1 * kw;
            else
                if (kw <= dm2)
                thanhtien = (dm1 * gia1) + (kw - dm1) * gia2;
            else
                    if (kw <= dm3)
                thanhtien = (dm1 * gia1) + (dm2 * gia2) + (kw - dm2) * gia3;
            else
                thanhtien = (dm1 * gia1) + (dm2 * gia2) + (dm3 * gia3) + (kw - dm3) * gia4;
            Console.WriteLine("so tien phai tra {0}", thanhtien);
            Console.ReadLine();

        }
    }
}
    
         


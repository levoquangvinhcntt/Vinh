using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;
            Nhap(out b);         
       

        }
        public static void Nhap( out int a)
        {
            try
            {
                Console.Write("Nhap so nguyen a: "); a = int.Parse(Console.ReadLine());
            }
            catch(Exception sx)
            {
                Console.WriteLine("Kieu du lieu nhap khong hop le !");
                Nhap(out a);
            }
        }
    }
}

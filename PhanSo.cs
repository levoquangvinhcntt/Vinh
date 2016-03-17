using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PhanSo
{
    class PhanSo
    {
        
        private int tuso, mauso;
        public int TuSo
        {
            set { tuso = value; }
            get { return tuso; }
        }
        public int MauSo
        {
            set { mauso = value; }
            get { return mauso; }
        }
        public PhanSo(int a=0, int b=0)
        {
            tuso = a;
            mauso = b;
        }

         ~PhanSo()
        {
            tuso = 0;
            mauso = 0;
        }
        public bool RutGon()
        {
            bool flag = true;
            if (this.tuso == 0)
            {
                this.tuso = 0;
                this.mauso = 0;
            }

            if (this.mauso == 0)
            {
                this.tuso = 0;
                this.mauso = 0;
                Console.Write("Phan so khong xac dinh !");
                flag = false;
            }


            if (flag)
            {
                int a, b;
                a = Math.Abs(this.tuso);
                b = Math.Abs(this.mauso);
                while (a != b)
                {
                    if (a > b)
                        a -= b;
                    else
                        if (a < b)
                            b -= a;
                }
                this.tuso = tuso / a;
                this.mauso = mauso / a;
            }
            return flag;

           
        }
        public void Display()
        {
            if(this.RutGon())
            Console.Write(this.tuso + "/" + this.mauso);
            
           
        }
        public void Input()
        {
            try
            {
                Console.Write("Nhap tu so: "); this.tuso = int.Parse(Console.ReadLine());
                Console.Write("Nhap mau so: "); this.mauso = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Nhap khong hop le !");
                Console.ReadLine();
                Console.Clear();
                this.Input();
            }
        }
        public static PhanSo operator+(PhanSo a,PhanSo b)
        {
            //PhanSo add = new PhanSo();
            //add.mauso = a.mauso * b.mauso;
            //add.tuso = a.tuso * b.mauso + a.mauso * b.tuso;
            //return add;           
            return new PhanSo(a.tuso * b.mauso + a.mauso * b.tuso, a.mauso * b.mauso);
        }
        public static PhanSo operator-(PhanSo a,PhanSo b)
        {
            PhanSo temp =new PhanSo();
            temp.mauso = a.mauso * b.mauso;
            temp.tuso = a.tuso * b.mauso - b.tuso * a.mauso;
            return temp;
        }
        public static PhanSo operator*(PhanSo a, PhanSo b)
        {
            PhanSo temp = new PhanSo();
            temp.tuso = a.tuso * b.tuso;
            temp.mauso = b.mauso * a.mauso;
            return temp;
        }
        public static PhanSo operator/(PhanSo a, PhanSo b)
        {
            PhanSo temp = new PhanSo();
            temp.tuso = a.tuso * b.mauso;
            temp.mauso = a.mauso * b.tuso;
            return temp;
        }
        public static implicit operator PhanSo(int a)
        {
            return new PhanSo(a,1);
        }
        public static implicit operator PhanSo(double a)
        {
            a = a * 1000000;
            return new PhanSo((int)a, 1000000);
        }
    }
}

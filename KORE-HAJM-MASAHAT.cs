using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classTest
{
     class Class1
    {
        private double r;
        double pi = 3.14;
        public double R
        {
            get { return r; }

            set
            {
                if (value > 0)
                { r = value; }
            }
        }

        public Class1() { }
        public Class1(double R)
        {
            r = R;
        }

        public double Area()
        {
            double area =  pi * Math.Pow(r, 2)* 4;
            return area;
        }

        public double Hajm()
        {
            double area = pi * Math.Pow(r, 3) * 4.3;
            return area;
        }
    }
     class Class2
    {
        public static void Main()
        {
            Console.WriteLine("ENTER R : ");
            int R = Convert.ToInt32(Console.ReadLine());
            Class1 miad = new Class1(R);
            double area = miad.Area();
            Console.WriteLine("Masahat:" + area); 
            double hajm = miad.Hajm();
            Console.WriteLine("Hajm:" + hajm);
            Console.ReadKey();
        }
    }
}

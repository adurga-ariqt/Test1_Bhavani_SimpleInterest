using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_Bhavani_SimpleInterest
{
    public  class SimpleInterest
    {
        public void SimpleInterestMethod()
        {
            double p, r, t, si;
            Console.WriteLine("Enter principal amout");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter rate of interest");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter time:");
            t = Convert.ToDouble(Console.ReadLine());
            double T = t / 12;
            Console.WriteLine(T);
            si = p * r * (T) / 100;
            Console.WriteLine("Simpleinterest is:" + si);
            double z = si + p;
            Console.WriteLine("the total amount is:" + z);
            Console.ReadLine();

        }
    }
}

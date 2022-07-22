using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stackarray kia = new Stackarray(8);
            kia.push(1);
            kia.push(2);
            kia.push(3);
            kia.push(4);
            kia.push(5);
            kia.push(6);
            kia.push(7);
            kia.push(8);
            Console.WriteLine("----------------------------------------------------------------");
            kia.pop();
            kia.pop();
            kia.pop();
            kia.pop();
            kia.pop();
            kia.pop();
            kia.pop();
            kia.pop();
            Console.ReadKey();

        }
    }


}

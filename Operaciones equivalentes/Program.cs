using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones_equivalentes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Introduce el primer número");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el tercer número");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Resultado entre la operación {0}, {1}, {2}, (a+b)*c es {3} y a*b + a*c es {4}", 
                num1, num2, num3, ((num1+num2) * num3), (num1 * num3 + num2 * num3));
            Console.ReadLine();
        }
    }
}

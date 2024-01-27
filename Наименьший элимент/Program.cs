using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наименьший_элимент
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину последовательности: ");
            
            int order = int.Parse(Console.ReadLine());

            int min = int.MaxValue;

            int i = 1;

            while (i <= order)
            {
                Console.WriteLine("Введите целое число");
                
                int number = int.Parse(Console.ReadLine());
                
                if (number < min)
                {
                    min = number;
                    
                }
                i++;
                

            }
            Console.WriteLine("Минимальное число: " + min);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    /// <summary>
    /// Найти минимальную величину из двух целых переменных a, b, 
    /// используя вспомогательные методы (ввода аргументов, нахождения минимальной величины, вывода результата).
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = Input("a=");
            int b = Input("b=");
            int result = Min(a, b);
            Output(result);
            Console.ReadKey();

        }
        public static int Min(int a, int b)
        {
            return a < b ? a : b;
        }
            public static int Input(string x)
            {
                Console.Write(x);
                return int.Parse(Console.ReadLine()); }
            public static void Output(int result)
            {
                Console.WriteLine(result);
            }

                
            }

           

            }
            
        
    
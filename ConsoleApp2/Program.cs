using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите скорость:");
            double S = 0;
            string strV = Console.ReadLine();
            Console.WriteLine("Введите тип дорожного покрытия:");
            Console.WriteLine("1 - обледеневшее\n" +
                "2 - заснеженное\n" +
                "3 - влажное\n" +
                "4 - чистое и сухое");
            string typeStr = Console.ReadLine();
            float type = 0;
            if (int.TryParse(strV, out int V))
            {
                switch (typeStr)
                {
                    case "1":
                        type = 0.1f;
                        break;
                    case "2":
                        type = 0.2f;
                        break;
                    case "3":
                        type = 0.4f;
                        break;
                    case "4":
                        type = 0.7f;
                        break;
                        default:
                        Console.WriteLine("Ошибка");
                        Environment.Exit(0);
                        break;

                }
                S = ((1 / (254 * type)) * (float)(Math.Sqrt(V))) * 1000;
                Console.WriteLine("Тормозной путь: " + S + "м");
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }
    }
}

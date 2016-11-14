using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int MyDel(int x, int y)
        {
            return x / y;
        }

        static void Main()
        {
            try
            {
                Console.Write("Введите x: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Введите y: ");
                int y = int.Parse(Console.ReadLine());

                int result = MyDel(x, y);
                Console.WriteLine("Результат: " + result);
            }
            // Обрабатываем исключение возникающее при делении на ноль
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на 0 detected!!!\n");
                Main();
            }
            // Обрабатываем исключение при неккоректном вводе числа в консоль
            catch (FormatException)
            {
                Console.WriteLine("Это НЕ число!!!\n");
                Main();
            }

            Console.ReadLine();
        }
    }
}
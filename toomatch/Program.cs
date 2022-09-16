using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace toomatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2.1; Имя пользователя");
            Console.WriteLine("Введите свое имя!");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет,{name}");
            Console.ReadKey();
            Console.WriteLine("Задание 2.2;Деление");
            Console.WriteLine("Введите первое число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = int.Parse(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine("На ноль делить нельзя!");
            }
            else
            {
                double c = (double)a / b;
                Console.WriteLine($"Результат от деления:{c}");
            }
            Console.ReadKey();
            Console.WriteLine("Домашнее задание 2.1 Найти следующую букву");
            Console.WriteLine("Введите любую букву латинского алфавита");
            string input = Console.ReadLine();
            input = input.ToLower(); // делаем букву строчной
            if (input == "z")
            {
                Console.WriteLine("Следуюущая буква - а");
                Console.ReadKey();
            }
            else
            {
                int value = char.Parse(input);  //получаем код буквы в юникоде 
                Console.WriteLine("Седуюущая буква - " + (char)(value + 1));
                Console.ReadKey();
            }
            Console.WriteLine("Домашнее задание 2.2 решение квадратного уравнения");
            Console.WriteLine("Введите первый коэфицент(A)");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй коэфицент(B)");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третий коэфицент(C)");
            int C = int.Parse(Console.ReadLine());
            int D = Convert.ToInt32(Math.Sqrt(B * B - 4 * A * C));// нашли  корень из d
            Console.WriteLine("Первый корень:" + (-B + D) / 2 * A);
            Console.WriteLine("второй корень:" + (-B - D) / 2 * A);
            Console.ReadKey();
        }
    }
}
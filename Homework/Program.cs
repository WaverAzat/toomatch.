using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("задание 1. число E ");
            double x = Math.E;
            Console.WriteLine("E={0:F1}", x);

            Console.WriteLine("задание 2. 50 и 10 ");
            Console.WriteLine(50 + "\n" + 10);

            Console.WriteLine("задание 3. любые числа в столбик ");
            Console.WriteLine("введите 4 любых числа");
            string inp = Console.ReadLine();
            string[] outp = inp.Split(' ');
            foreach (var q in outp)
            {
                Console.WriteLine(q);
            }

            Console.WriteLine("задание 4. число + 10 ");
            Console.WriteLine("Введите число");
            int chislo = int.Parse(Console.ReadLine());
            Console.WriteLine(chislo + 10);

            Console.WriteLine("задание 5. Периметр квадрата ");
            Console.WriteLine("Введите сторону квадрата");
            int storona = int.Parse(Console.ReadLine());
            Console.WriteLine("Периметр квадрата: " + storona * 4);

            Console.WriteLine("задание 6. Длина и площадь круга ");
            Console.WriteLine("Введите радиус круга");
            int radius = int.Parse(Console.ReadLine());
            double pi = Math.PI; 
            Console.WriteLine("Длина окружности: " + Math.Round(2 * pi * radius));
            Console.WriteLine("Плоащадь окружности: " + Math.Round(pi * radius * radius));

            Console.WriteLine("задание 7. Cosinus ");
            Console.WriteLine("Введите значение Х");
            int ugol = int.Parse(Console.ReadLine());
            Console.WriteLine("Значение косинуса равно: " + Math.Cos(ugol));

            Console.WriteLine("задание 8. Периметр трапеции ");
            Console.WriteLine("Введите значение высоты");
            int H = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение верхнего основания");
            int osnV = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение нижнего основания");
            int osnN = int.Parse(Console.ReadLine());
            Console.WriteLine("Периметр равен: " + (Math.Sqrt(Math.Pow((osnN - osnV) / 2, 2) + Math.Pow(H, 2))) * 2 + osnN + osnV);


            Console.WriteLine("задание 9. яюлоки, печенье,конфеты ");
            Console.WriteLine("Введите вес ваших покупок через пробел (конфеты, печенье, яблоки)\r\nБудем считать, что цены таковы: яблоки - 140р; конфеты - 60р; печенье - 120р");
            double[] products = Console.ReadLine().Split(' ').Select(s => double.Parse(s)).ToArray();
            Console.WriteLine("Итоговая стоимость: " + (products[0] * 60 + products[1] * 120 + products[2] * 140));

            Console.WriteLine("задание 10. мир труд май ");
            Console.WriteLine("Мир" + " " + "Труд" + " " + "Май");
            Console.WriteLine("Мир" + "\n" + "  " + "Труд" + "\n" + "       " + "Май");

            Console.WriteLine("задание 11. смена местами переменных");
            Console.WriteLine("Введите 1 число:");
            string userinp1 = Console.ReadLine();
            Console.WriteLine("Введите 2 число:");
            string userinp2 = Console.ReadLine();
            userinp1 = userinp1.Replace(',', '.');
            userinp2 = userinp2.Replace(',', '.');
            double usersnum1;
            double usersnum2;
            bool isVerifyNumber = true;
            if (!double.TryParse(userinp1, out usersnum1))
            {
                Console.WriteLine("Неправильный ввод");
                isVerifyNumber = false;
            }
            if (!double.TryParse(userinp2, out usersnum2))
            {
                Console.WriteLine("Неправильный ввод");
                isVerifyNumber = false;
            }
            if (isVerifyNumber == true)
            {
                double replace = usersnum1;
                usersnum1 = usersnum2;
                usersnum2 = replace;
                Console.WriteLine("числа успешно поменялись местами!");
                Console.WriteLine($"число 1: {usersnum1}");
                Console.WriteLine($"число 2: {usersnum2}");
            }

            Console.WriteLine("задание 12. площади фигур");
            Console.WriteLine("выберите фигуру (0 - треугольник / 1 - четырёхугольник / 2 - круг)");
            int vvodF = int.Parse(Console.ReadLine());
            if (vvodF == 0)
            {
                Console.WriteLine("выберите что вы хотите найти (0 - периметр / 1 - площадь)");
                int vvodPS1 = int.Parse(Console.ReadLine());
                if (vvodPS1 == 0)
                {
                    Console.WriteLine("введите значения трёх сторон треугольника через пробел");
                    int[] vvod1 = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
                    Console.WriteLine("периметр равен: " + (vvod1[0] + vvod1[1] + vvod1[2]));
                }
                else
                {
                    Console.WriteLine("введите значения трёх сторон треугольника через пробел");
                    int[] vvod2 = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
                    Console.WriteLine("площадь равна: " + Math.Sqrt(((vvod2[0] + vvod2[1] + vvod2[2]) / 2) * ((vvod2[0] + vvod2[1] + vvod2[2]) / 2 - vvod2[0]) * ((vvod2[0] + vvod2[1] + vvod2[2]) / 2 - vvod2[1]) * ((vvod2[0] + vvod2[1] + vvod2[2]) / 2 - vvod2[2])));
                }
            }
            if (vvodF == 1)
            {
                Console.WriteLine("выберите что вы хотите найти (0 - периметр / 1 - площадь)");
                int vvodPS2 = int.Parse(Console.ReadLine());
                if (vvodPS2 == 0)
                {
                    Console.WriteLine("введите значения сторон четырёхугольника через пробел");
                    int[] vvod3 = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
                    Console.WriteLine("периметр равен: " + 2 * (vvod3[0] + vvod3[1]));
                }
                else
                {
                    Console.WriteLine("введите значения сторон четырёхугольника через пробел");
                    int[] vvod4 = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
                    Console.WriteLine("плоащадь равна: " + (vvod4[0] * vvod4[1]));
                }
            }
            if (vvodF == 2)
            {
                Console.WriteLine("выберите что вы хотите найти (0 - периметр / 1 - площадь)");
                int vvodPS3 = int.Parse(Console.ReadLine());
                if (vvodPS3 == 0)
                {
                    Console.WriteLine("введите значение радиуса круга");
                    int rad = int.Parse(Console.ReadLine());
                    Console.WriteLine("периметр равен: " + Math.Round(2 * (rad * Math.PI)));
                }
                else
                {
                    Console.WriteLine("введите значение радиуса круга");
                    int rad = int.Parse(Console.ReadLine());
                    Console.WriteLine("плоащадь равна: " + Math.Round(Math.PI * Math.Pow(rad, 2)));
                }
            }

            Console.WriteLine("задание 13. вы ввели... ");
            Console.WriteLine("введите число");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"вы ввели число {c}");

            Console.WriteLine("задание 14. 2 kg");
            string[] arr = { "2 кг", "13 17" };
            Console.WriteLine(arr[0] + "\n" + arr[1]);

            Console.WriteLine("задание 15. рандомные числа в столбик ");
            Random rnd = new Random();
            int value = rnd.Next(0, 100);  
            int value1 = rnd.Next(0, 100);
            int value2 = rnd.Next(0, 100);
            int value3 = rnd.Next(0, 100);
            Console.WriteLine(value + "\n" + value1 + "\n" + value2 + "\n" + value3);

            Console.WriteLine("задание 16. квадратное уравнение");

            Console.WriteLine("задание 17. ср. арифметическое и геометрическое ");
            Console.WriteLine("Введите первое число");
            int ch1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int ch2 = int.Parse(Console.ReadLine());
            Console.WriteLine("среднее арифметическое: " + (ch1 + ch2) / 2 + "\n" + "среднее геометрическое: " + Math.Sqrt(ch1 * ch2));

            Console.WriteLine("задание 18. расстояние между точками");
            Console.WriteLine("введите координаты первой точки через пробел(x , y)");
            int[] xy1 = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            Console.WriteLine("введите координаты второй точки через пробел(x , y)");
            int[] xy2 = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            Console.WriteLine("Расстояние между точками: " + Math.Sqrt(Math.Pow((xy2[0] - xy1[0]), 2) + Math.Pow((xy2[1] - xy1[1]), 2))); 

            Console.WriteLine("задание 19. замена значений переменных");
            int a = 1;
            int b = 2;
            int c1 = 3;
            int t = 1;
            Console.WriteLine($"a = {a}  b = {b}  c = {c1}");
            t = b;
            b = c1;
            c = a;
            a = t;
            Console.WriteLine($"пункт А: a = {a}  b = {b}  c = {c1}");
            a = 1;
            b = 2;
            c1 = 3;
            t = 1;
            t = b;
            b = a;
            a = c1;
            c1 = t;
            Console.WriteLine($"пункт Б: a = {a}  b = {b}  c = {c1}");

            Console.WriteLine("задание 20. секунды");
            Console.WriteLine("Введите число секунд");
            int sec = int.Parse(Console.ReadLine());
            Console.WriteLine("прошло часов: " + sec / (60 * 60));
            Console.WriteLine("прошло полных минуt с начала очередного часа: " + ((sec / 60) - ((sec / 60) / 60) * 60));
            Console.WriteLine("прошло секунд с начала последней минуты: " + sec % 60);

            Console.WriteLine("задание 21. прямоугольник");
            Console.WriteLine("Можно вырезать " + (543 / 130) + " квадратов");

            Console.WriteLine("задание 22. меняем цифры в трёхзначном числе");
            Console.WriteLine("введите трёхначное число");
            int inpt = int.Parse(Console.ReadLine());
            Console.WriteLine($"{inpt % 10}{inpt / 10}");

            Console.WriteLine("задание 23. меняем цифры в трёхзначном числе");
            Console.WriteLine("введите число > 999");
            int inpt1 = int.Parse(Console.ReadLine());
            Console.WriteLine("a) число сотен: " + (inpt1 / 100) % 10);
            Console.WriteLine("b) число тысяч: " + (inpt1 / 1000));

            Console.WriteLine("задание 24. меняем цифры в трёхзначном числе");
            Console.WriteLine("введите число > 999");
            string inpt2 = Console.ReadLine();
            string outpt2 = "";
            for (int i = inpt2.Length - 1; i >= 0; i--)
            {
                outpt2 += inpt2[t];
            }
            Console.WriteLine("a) " + outpt2);
            if ((int.Parse(inpt2) / 100) % 10 == 0)
            {
                Console.WriteLine("b) " + inpt2[0] + inpt2[2] + inpt2[3]);
            }
            else
            {
                Console.WriteLine("b) " + inpt2[1] + inpt2[0] + inpt2[2] + inpt2[3]);
            }
            Console.WriteLine("c) " + inpt2[0] + inpt2[2] + inpt2[1] + inpt2[3]);
            if ((int.Parse(inpt2) / 10) % 10 == 0)
            {
                Console.WriteLine("d) " + inpt2[3] + inpt2[0] + inpt2[1]);
            }
            else
            {
                Console.WriteLine("d) " + inpt2[2] + inpt2[3] + inpt2[0] + inpt2[1]);
            }
            Console.WriteLine("задание 25.");
            Console.WriteLine("введите число 100 <= n =< 999");
            string inpt3 = Console.ReadLine();
            if ((int.Parse(inpt3) / 10) % 10 == 0)
            {
                Console.WriteLine("введите другое число");
            }
            else
            {
                Console.WriteLine("x = " + inpt3[1] + inpt3[2] + inpt3[0]);
            }
            Console.WriteLine("задание 26.");
            Console.WriteLine("Введите время: часы, минуты, секунды");
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            if (hour > 11)
            {
                hour -= 12;
            }
            Console.WriteLine("cейчас угол между положением стрелки на началr дня и временем ввреденным вами равен: " + ((360 / 12) * hour + (0.5 * minutes) + (0.0083 * seconds)));


            Console.WriteLine("задание 28. меньшее из трёх по мудулю");
            Console.WriteLine("введите 3 числа через пробел");
            int[] abs = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            int[] abs2 = { Math.Abs(abs[0]), Math.Abs(abs[1]), Math.Abs(abs[2]) };
            Console.WriteLine("меньшее из трёх: " + abs2.Min());

            Console.WriteLine("задание 29. сумма наибольшего и наименьшего их трёх");
            Console.WriteLine("введите 3 числа через пробел");
            int[] abs3 = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            Console.WriteLine("сумма наибольшего и наименьшего : " + (abs3.Min() + abs3.Max()));

            Console.WriteLine("задание 30. количество делителей натурального числа");
            Console.WriteLine("Введите целое число");
            int count = 0;
            int val;
            if (Int32.TryParse(Console.ReadLine(), out val))
            {
                Console.WriteLine("Делители числа" + val);
                for (int m = 1; m <= val; m++)
                    if (val % m == 0)
                    {
                        count++;
                    }
                Console.WriteLine("Количество делителей числа " + val + " : " + count);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("введите число!!");

            }
            Console.WriteLine("задание 31. кубическое уравнение");
            Console.WriteLine("введите коэффициенты уравнения (a,b,c,d)");
            int[] coef = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            for (int otr = -100; otr <= 100; otr++)
            {
                double result = coef[0] * Math.Pow(otr, 3) + coef[1] * otr * otr + coef[2] * otr + coef[3];
                if (result == 0)
                {
                    Console.WriteLine("X = " + otr);
                }
            }

            Console.WriteLine("задание 32");
            Console.WriteLine("Введите первый элемент последовательности");
            double seq1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй элемент последовательности");
            double seq2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер элемента последовательности, который желаете найти");
            double NumOfSeq = double.Parse(Console.ReadLine());
            double elemen = seq1 + ((seq2 - seq1) * (NumOfSeq - 1));
            Console.WriteLine($"Элемент последовательности с номером {NumOfSeq} равен {elemen}");

            Console.WriteLine("задание 33. кредит в банке");
            Console.WriteLine("Дайте ответы на вопросы");
            Console.WriteLine("Являетесь ли вы пенсионером? (1 - да / 0 - нет)");
            int pensioners = int.Parse(Console.ReadLine());
            Console.WriteLine("Являетесь ли вы студентом? (1 - да / 0 - нет)");
            int student = int.Parse(Console.ReadLine());
            Console.WriteLine("Вы тродоустроены? (1 - да / 0 - нет)");
            int yn = int.Parse(Console.ReadLine());
            if (((pensioners == 1 && yn == 0) || (student == 1 && yn == 0)) && (pensioners == 0 || student == 0))
            {
                Console.WriteLine("Поздравляю вам одобрен кредит)");
            }
            else
            {
                Console.WriteLine("Кредит не одобрен, сожалею(");
            }
            Console.WriteLine("задание 34. имя человека");
            Console.WriteLine("введите имя");
            string name = Console.ReadLine();
            Console.WriteLine($"a) {name}");
            Console.WriteLine("введите имя");
            string name2 = Console.ReadLine();
            Console.WriteLine($"б) Привет, {name2}!");
        }
    }
}
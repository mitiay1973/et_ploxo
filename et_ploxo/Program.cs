using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace et_ploxo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите задание");
            int var = Convert.ToInt32(Console.ReadLine());
            int aa = 0;
            int bb = 0;
            int cc = aa + bb; // неиспользуемый код
            if (var == 1) // if
            {
                Console.WriteLine("Введите первое число");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                double b = Convert.ToDouble(Console.ReadLine());
                double c = Math.Pow(a, b);
                Console.WriteLine("Ответ: " + c);
            }
            else if (var == 2)
            {
                Console.WriteLine("Формула не найдена, выберите другую задачу");
            }
            else if (var == 3)
            {
                Console.WriteLine("Введите число");
                double q = Convert.ToDouble(Console.ReadLine());
                double otvet = q % 2;
                double otvet1 = q % 3;
                if (otvet == otvet1)
                {
                    Console.WriteLine("Одинаковый остаток = " + otvet);
                }
                else
                {
                    Console.WriteLine("Остатки различаются");
                }
            }
            else if (var == 4)
            {
                Console.WriteLine("Введите число");
                int t = Convert.ToInt32(Console.ReadLine());
                int otv;
                Console.WriteLine("Результат:");
                for (int n = 1; n <= 10; n++)
                {
                    otv = Convert.ToInt32(Math.Pow(t, n));
                    Console.WriteLine(otv);
                }
            }
            else if (var == 5)
            {
                Console.WriteLine("Введите X");
                double x1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите Y");
                double y1 = Convert.ToDouble(Console.ReadLine());
                double otv1 = (1 + Math.Sin(Math.Sqrt(x1 + 1))) / (Math.Cos((12 * y1) - 4));
                Console.WriteLine("Ответ: " + otv1);
            }
            else if (var == 7)
            {
                Console.WriteLine("Введите количество чисел");
                int f = Convert.ToInt32(Console.ReadLine());
                int s = 0;
                int s1 = 1;
                Console.WriteLine("Числа Фибоначчи");
                Console.WriteLine("1 индекс 2");
                for (int i = 2; i < f * 2; i++)
                {
                    s = s + s1;
                    if (i % 2 != 0)
                    {
                        int ind = i + 1;
                        Console.WriteLine(s + " индекс " + ind);
                    }
                }
            }
            else if (var == 7)
            {
                Console.WriteLine("Введите количество чисел");
                int f1 = Convert.ToInt32(Console.ReadLine());
                double res = 0;
                double m = 1;
                double v = 2;
                for (int i = 0; i < f1; i++)
                {
                    res += m / v;
                    m++;
                    v++;
                }
                Console.WriteLine("Результат: " + res);
            }
            else if (var == 8)
            {
                int ind1;
                int[] sec = new int[3];
                int yc = 0;
                int secl = 0;
                foreach (int i in sec) //foreach
                {
                    int j = 0;
                    ind1 = j + 1;
                    Console.WriteLine("Время " + ind1 + " спортсмена\n Введите секунды");
                    sec[j] = Convert.ToInt32(Console.ReadLine());
                    j++;
                }
                foreach (int i in sec) //foreach
                {
                    int jj = 0; // код для извлечения в метод
                    if (i == 0)
                    {
                        secl = i;
                        yc = jj + 1;
                    }
                    if (i != 0)
                    {
                        if (secl > i)
                        {
                            secl = i;
                            yc = jj + 1;
                        }
                    }
                    jj++;
                }
                Console.WriteLine("Победил плавец под номером " + yc + " его время " + secl + " сек");
            }
            Console.ReadKey();
        }
    }
}

using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            while (!endApp)
            {
                double num_1;
                double num_2;
                int num_3;
                Console.WriteLine("Выберите операцию:\r\n1. Сложить 2 числа\r\n2. Вычесть первое из второго\r\n3. Перемножить два числа\r\n4. Разделить первое на второе\r\n5. Возвести в степень N первое число\r\n6. Найти квадратный корень из числа\r\n7. Найти 1 процент от числа\r\n8. Найти факториал из числа\r\n9. Завершить работу калькулятора");
                int oper;
                oper = Convert.ToInt32(Console.ReadLine());
                switch (oper)
                {
                    case 1:
                        Console.WriteLine("Введите первое число: ");
                        num_1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        num_2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(num_1 + num_2);
                        break;
                    case 2:
                        Console.WriteLine("Введите первое число: ");
                        num_1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        num_2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(num_1 - num_2);
                        break;
                    case 3:
                        Console.WriteLine("Введите первое число: ");
                        num_1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        num_2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(num_1 * num_2);
                        break;
                    case 4:
                        Console.WriteLine("Введите первое число: ");
                        num_1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        num_2 = Convert.ToDouble(Console.ReadLine());
                        if (num_2 == 0)
                            Console.WriteLine("Деление на ноль невозможно.");
                        else
                        {
                            Console.WriteLine(num_1 / num_2);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Введите первое число: ");
                        num_1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второе число: ");
                        num_2 = Convert.ToDouble(Console.ReadLine());
                        double result = Math.Pow(num_1, num_2);
                        Console.WriteLine(result);
                        break;
                    case 6:
                        Console.WriteLine("Введите число у которого будет найден квадратный корень: ");
                        num_1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(Math.Sqrt(num_1));
                        break;
                    case 7:
                        Console.WriteLine("Введите число у которого будет найден 1%");
                        num_1 = Convert.ToDouble(Console.ReadLine());
                        double result_1 = (num_1 / 100.0) * 1.0;
                        Console.WriteLine("1% от введенного число состовляет: " + result_1);
                        break;
                    case 8:
                        Console.WriteLine("Введите целое число из которого будет найден факториал");
                        num_3 = Convert.ToInt32(Console.ReadLine());
                        long fact = (1);
                        if (fact == 0)
                        {
                            Console.WriteLine("Факториал равен 1");
                        }
                        else
                            for (int i = 1; i <= num_3; i++)
                            {
                                fact *= i;
                            }
                        Console.WriteLine(fact);
                        break;
                    case 9:
                        Console.WriteLine("Если вы уверены, что хотите завершить работу калькулятора, введите 'да'");
                        if (Console.ReadLine() == "да") endApp = true;
                        Console.WriteLine("\n");
                        break;
                    default:
                        Console.WriteLine("Введена не существующая операция.");
                        break;
                }
            }
            return;
        }
    }
}
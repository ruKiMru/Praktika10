using System;

namespace Praktika10
{
    class Program
    {
            static void Main(string[] args)
            {
                Point test, mark;
                Random rnd = new Random();
                int N, temp, sum = 1;

                //ввод
                Console.WriteLine("Введите количество элементов");
                N = int.Parse(Console.ReadLine());
                while (N < 2)
                {
                    Console.WriteLine("Формула не может быть посчитана для данного числа элементов");
                    Console.WriteLine("Введите количество элементов");
                    N = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("1 - Заполнить в ручную");
                Console.WriteLine("Не 1 - Случайное заполнение списка");

                temp = int.Parse(Console.ReadLine());
                if (temp == 1)
                {
                    Console.WriteLine("Введите элемент, осталось: {0}", N);
                    test = new Point(int.Parse(Console.ReadLine()));
                    mark = test;
                    N--;
                    do
                    {
                        Console.WriteLine("Введите элемент, осталось: {0}", N);
                        mark.Next = new Point(int.Parse(Console.ReadLine()), mark);
                        mark = mark.Next;
                        N--;
                    } while (N != 0);
                }
                else
                {

                    test = new Point(rnd.Next(-10, 11));
                    mark = test;
                    N--;
                    do
                    {
                        mark.Next = new Point(rnd.Next(-10, 11), mark);
                        mark = mark.Next;
                        N--;
                    } while (N != 0);
                }
                mark = test;
                temp = 1;
                Console.Clear();
                while (mark != null)
                {
                    Console.WriteLine("{0, 3}: {1, -3}", temp, mark.Info);
                    mark = mark.Next;
                    temp++;
                }

                mark = test;

                while (mark.Next != null)
                    mark = mark.Next;

                test = test.Next;

                while (test != null)
                {
                    sum = sum * (test.Previous.Info + test.Info + 2 * mark.Info);
                    mark = mark.Previous;
                    test = test.Next;
                }
                Console.WriteLine("Результат: {0}", sum);
            }
        
    }
}


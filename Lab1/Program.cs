using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
       

            static void Main(string[] args)
            {

                //11 Заполнить массив:
                //а) двадцатью первыми натуральными числами, делящимися нацело на 13 или на 17 и большими 300;
                //б) тридцатью первыми простыми числами.

                task11();
                Console.WriteLine("\ntask11 Закончил свою работу!");

                //18 Дан массив A. Определить сумму знакочередующейся последовательности A[1] – А[2] + А[3] – A[4] + ... .
                //Условную инструкцию и операцию возведения в степень не использовать.

                task18();
                Console.WriteLine("task18 Закончил свою работу!");


                //37 Даны натуральные числа а1, а2, ..., an.
                //Указать те из них, у которых остаток от деления на М равен L(0 ≤ L ≤ M – 1).

                task37();
                Console.WriteLine("\ntask37 Закончил свою работу!");

                //74 Дана последовательность вещественных чисел а1, a2, ..., а15.
                //Определить, есть ли в последовательности отрицательные числа.
                //В случае положительного ответа определить порядковый номер первого из них.

                task74();
                Console.WriteLine("task74 Закончил свою работу!");

                //135 Каждый солнечный день улитка, сидящая на дереве, поднимается вверх на 2 см, а каждый пасмурный день опускается вниз на 1 см.
                //В начале наблюдения улитка находилась на расстоянии А см от земли на 5 - метровом дереве.
                //Имеется 30 - элементный массив, содержащий сведения о том, был ли соответствующий день наблюдения пасмурным или солнечным.
                //Написать программу, определяющую местоположение улитки к концу 30 - го дня наблюдения.

                task135();
                Console.WriteLine("task135 Закончил свою работу!");



                Console.ReadLine();
            }



            static void task11()
            {

                Console.WriteLine("Задание 11");
                Console.WriteLine("а)Заполнить массив: двадцатью первыми натуральными числами, делящимися нацело на 13 или на 17 и большими 300;");
                Random random = new Random();
                int[] ArrayOfNaturalNumbers = new int[20];
                int counter = 0, currentNumber = 301;

                //Внутри цикла есть проверка на числа которые делятся нацело на 13 и 17, если результат true, то в массив записывается натуральное число.
                while (counter < 20)
                {
                    if (currentNumber % 13 == 0 || currentNumber % 17 == 0)
                    {
                        ArrayOfNaturalNumbers[counter] = currentNumber;
                        Console.Write(" " + ArrayOfNaturalNumbers[counter]);
                        counter++;

                    }
                    currentNumber++;
                }


                Console.WriteLine("\nб)Заполнить массив: тридцатью первыми простыми числами.");

                int[] ArrayOfPrimeNumbers = new int[30];
                int counterTwo = 0, currentNumberTwo = 2;

                while (counterTwo < 30)
                {
                    if (IsPrime(currentNumberTwo))
                    {
                        ArrayOfPrimeNumbers[counterTwo] = currentNumberTwo;
                        Console.Write(ArrayOfPrimeNumbers[counterTwo] + " ");
                        counterTwo++;
                    }
                    currentNumberTwo++;
                }
            }
            /// <summary>
            /// Функция определяет простые числа
            /// </summary>
            /// <param name="currentNumberTwo">Число с помощью которого происходит вычисления простых чисел</param>
            /// <returns>Возвращает bool значение, после которого определятся будет ли число записано в массив простых чисел</returns>
            static bool IsPrime(int currentNumberTwo)
            {
                if (currentNumberTwo == 2)
                {
                    return true;
                }
                if (currentNumberTwo % 2 == 0)
                {
                    return false;
                }
                for (int i = 3; i * i <= currentNumberTwo; i += 2)
                {
                    if (currentNumberTwo % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }

            static void task18()
            {
                Console.WriteLine("\nЗадание 18");
                Random random = new Random();
                int[] ArrayAlternatingSequence = new int[random.Next(10)];
                int sum = 0, sign = 1;
                Console.Write("Ваш массив: ");
                for (int i = 0; i < ArrayAlternatingSequence.Length; i++)
                {
                    ArrayAlternatingSequence[i] = random.Next(50);
                    Console.Write(ArrayAlternatingSequence[i] + " ");
                }
                //Внутри второго цикла выполняется знакочередование, с помощью изменения и умножения sign(которые меняет знаки) на значение массива.
                for (int i = 0; i < ArrayAlternatingSequence.Length; i++)
                {
                    sum += sign * ArrayAlternatingSequence[i];
                    sign = -sign;
                }

                Console.WriteLine("\nCумма знакочередующейся последовательности = " + sum);
            }

            static void task37()
            {
                Console.WriteLine("\nЗадание 37");
                Random random = new Random();
                int[] ArrayOfNaturalNumbersTwo = new int[random.Next(15)];

                //Задаем рандомом переменну М и L по условию (0 ≤ L ≤ M – 1)
                int M = random.Next(3, 8), L = random.Next(1, M - 1);
                Console.Write($"M = {M} L = {L} \nВаш массив: ");

                for (int i = 0; i < ArrayOfNaturalNumbersTwo.Length; i++)
                {
                    ArrayOfNaturalNumbersTwo[i] = random.Next(1, 30);
                    Console.Write(ArrayOfNaturalNumbersTwo[i] + " ");
                }

                //Внутри цикла с помощью условной конструкции if происходит проверка заданного условия при котором мы добавляем наши числа в массив.
                //Была создана переменная foundNumbers, которая позволяет на определять есть ли хотя бы одно число подходящее, если нет foundNumbers остается со значением false
                // и выводиться сообщение о том что таких чисел нет.
                Console.Write("\nРезультат: ");
                bool foundNumbers = false;
                for (int i = 0; i < ArrayOfNaturalNumbersTwo.Length; i++)
                {
                    if (ArrayOfNaturalNumbersTwo[i] % M == L)
                    {
                        Console.Write(ArrayOfNaturalNumbersTwo[i] + " ");
                        foundNumbers = true;
                    }
                }
                if (!foundNumbers)
                {
                    Console.Write("Таких чисел нет");
                }

            }

            static void task74()
            {
                Console.WriteLine("\nЗадание 74");
                Random random = new Random();
                double[] ArrayOfRealNumbers = new double[15];
                Console.WriteLine("Ваш массив: ");
                for (int i = 0; i < ArrayOfRealNumbers.Length; i++)
                {
                    ArrayOfRealNumbers[i] = -50 + random.NextDouble() * (50 + 50);
                    ArrayOfRealNumbers[i] = Math.Round(ArrayOfRealNumbers[i], 2);
                    Console.Write(ArrayOfRealNumbers[i] + "  ");
                }

                for (int i = 0; i < ArrayOfRealNumbers.Length; i++)
                {
                    if (ArrayOfRealNumbers[i] < 0)
                    {

                        Console.WriteLine("\nИндекс первого отрицательного числа: " + i);
                        return;
                    }

                }
                Console.WriteLine("\nНет отрицательных значений");

            }

            static void task135()
            {
                Console.WriteLine("\nЗадание 135");
                Random random = new Random();
                int[] ArrayOfDays = new int[30];
                int A = random.Next(500);

                Console.WriteLine($"В начале наблюдения улитка находилась на расстоянии {A} см от земли на 5 - метровом дереве.");

                Console.WriteLine("\nКак продвигалась улитка в течении 30 дней (0 - пасмурный день, 1 - солнечный день): ");

                for (int i = 0; i < ArrayOfDays.Length; i++)
                {
                    ArrayOfDays[i] = random.Next(0, 2);
                    if (ArrayOfDays[i] == 0 && A > 0)
                    {
                        A -= 1;
                    }
                    else if (ArrayOfDays[i] == 1 && A < 500)
                    {
                        A = A == 499 ? (A += 1) : (A += 2);
                    }

                    Console.Write(A + " ");

                }
                Console.WriteLine();
                for (int i = 0; i < ArrayOfDays.Length; i++)
                {
                    Console.Write(ArrayOfDays[i] + " ");
                }
                Console.WriteLine($"\nК концу 30 - го дня наблюдения улитка находилась на высоте {A} см от земли на 5 - метровом дереве ");

            }


        }
    }


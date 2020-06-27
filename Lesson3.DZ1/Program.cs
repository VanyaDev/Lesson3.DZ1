using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Lesson3.DZ1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                 Задание: Написать консольно приложение "Игровой автомат"
               */
            Console.WriteLine("игровой автомат");
            Console.WriteLine("Введите ваше имя и возраст (имя -Enter- возраст):");
            string name = Console.ReadLine();
            string age = Console.ReadLine();
            int ag = int.Parse(age.Replace(".", ","));


            if (ag < 18)
            {
                Console.Clear();
                Console.WriteLine("лица до 18 лет к игре не допускаются!");
            }
            else if (ag > 130)
            {
                Console.WriteLine("Вы обманываете :)");
            }
            else
            {
            Start:
                Console.Clear();

                Console.WriteLine("Введите вашу ставку ( от 5$ до 100$ ):");

                string stavka = Console.ReadLine();
                int v = int.Parse(stavka);

                if (v > 100)
                {
                    Console.WriteLine("Ставка от 5$ до 100$!");
                }
                if (v < 5)
                {
                    Console.WriteLine("Ставка от 5$ до 100$!");
                    Console.WriteLine("Нажмите -Enter- чтобы выбрать другую ставку");
                    Console.ReadKey();
                    goto Start;
                }
                else if (v <= 100 && v >= 5)
                {
                    Random rnd = new Random();
                    string[] firstNumber = { "1", "2", "3", "4",
                          "5", "6", "7", "8",
                          "9" };
                    string[] secondNumber = { "1", "2", "3", "4",
                          "5", "6", "7", "8",
                          "9" };
                    string[] thirdNumber = { "1", "2", "3", "4",
                          "5", "6", "7", "8",
                          "9" };

                    int mIndex = rnd.Next(1, 10);
                    int fIndex = rnd.Next(1, 10);
                    int nIndex = rnd.Next(1, 10);

                    Console.WriteLine("Вам выпало: ");
                    Console.WriteLine("   Первое число:   " + mIndex);
                    Console.WriteLine("   Второе число:   " + fIndex);
                    Console.WriteLine("   Третье число:   " + nIndex);



                    if (mIndex == 1 && fIndex == 1 && nIndex == 1)
                    {
                        float c;
                        float result;
                        float percent = 0.03f;
                        float a = 10;   
                        float b = 1.5f;
                        c = a * b;
                        result = c - percent;
                        result *= 10;
                        Math.Truncate(result);
                        result /= 10;
                        Console.WriteLine("Вы выиграли +" + result + "$");
                        Console.WriteLine($"Ещё раз? 1 - Да / 2 - Нет");
                        string YesNo = Console.ReadLine();
                        int one = int.Parse(YesNo);
                        int two = int.Parse(YesNo);
                        if (one == 1)
                        {
                            goto Start;
                        }
                        if (two == 2)
                        {
                            MessageBox.Show("Ждём вас снова, пока)");
                        }
                    }
                    else if (mIndex == 2 && fIndex == 2 && nIndex == 2)
                    {
                        float c;
                        float result;
                        float percent = 0.06f;
                        float a = 20;
                        float b = 1.5f;
                        c = a * b;
                        result = c - percent;
                        result *= 10;
                        Math.Truncate(result);
                        result /= 10;
                        Console.WriteLine("Вы выиграли +" + result + "$");
                        Console.WriteLine($"Ещё раз? 1 - Да / 2 - Нет");
                        string YesNo = Console.ReadLine();
                        int one = int.Parse(YesNo);
                        int two = int.Parse(YesNo);
                        if (one == 1)
                        {
                            goto Start;
                        }
                        if (two == 2)
                        {
                            MessageBox.Show("Ждём вас снова, пока)");
                        }
                    }
                    else if (mIndex == 3 && fIndex == 3 && nIndex == 3)
                    {
                        float c;
                        float result;
                        float percent = 0.09f;
                        float a = 30;
                        float b = 1.5f;
                        c = a * b;
                        result = c - percent;
                        result *= 10;
                        Math.Truncate(result);
                        result /= 10;
                        Console.WriteLine("Вы выиграли +" + result + "$");
                        Console.WriteLine($"Ещё раз? 1 - Да / 2 - Нет");
                        string YesNo = Console.ReadLine();
                        int one = int.Parse(YesNo);
                        int two = int.Parse(YesNo);
                        if (one == 1)
                        {
                            goto Start;
                        }
                        if (two == 2)
                        {
                            MessageBox.Show("Ждём вас снова, пока)");
                        }
                    }
                    else if (mIndex == 4 && fIndex == 4 && nIndex == 4)
                    {
                        float c;
                        float result;
                        float percent = 0.12f;
                        float a = 40;
                        float b = 1.5f;
                        c = a * b;
                        result = c - percent;
                        result *= 10;
                        Math.Truncate(result);
                        result /= 10;
                        Console.WriteLine("Вы выиграли +" + result + "$");
                        Console.WriteLine($"Ещё раз? 1 - Да / 2 - Нет");
                        string YesNo = Console.ReadLine();
                        int one = int.Parse(YesNo);
                        int two = int.Parse(YesNo);
                        if (one == 1)
                        {
                            goto Start;
                        }
                        if (two == 2)
                        {
                            MessageBox.Show("Ждём вас снова, пока)");
                        }
                    }
                    else if (mIndex == 5 && fIndex == 5 && nIndex == 5)
                    {
                        float c;
                        float result;
                        float percent = 0.15f;
                        float a = 50;
                        float b = 1.5f;
                        c = a * b;
                        result = c - percent;
                        result *= 10;
                        Math.Truncate(result);
                        result /= 10;
                        Console.WriteLine("Вы выиграли +" + result + "$");
                        Console.WriteLine($"Ещё раз? 1 - Да / 2 - Нет");
                        string YesNo = Console.ReadLine();
                        int one = int.Parse(YesNo);
                        int two = int.Parse(YesNo);
                        if (one == 1)
                        {
                            goto Start;
                        }
                        if (two == 2)
                        {
                            MessageBox.Show("Ждём вас снова, пока)");
                        }
                    }
                    else if (mIndex == 6 && fIndex == 6 && nIndex == 6)
                    {
                        float c;
                        float result;
                        float percent = 0.18f;
                        float a = 60;
                        float b = 1.5f;
                        c = a * b;
                        result = c - percent;
                        result *= 10;
                        Math.Truncate(result);
                        result /= 10;
                        Console.WriteLine("Вы выиграли +" + result + "$");
                        Console.WriteLine($"Ещё раз? 1 - Да / 2 - Нет");
                        string YesNo = Console.ReadLine();
                        int one = int.Parse(YesNo);
                        int two = int.Parse(YesNo);
                        if (one == 1)
                        {
                            goto Start;
                        }
                        if (two == 2)
                        {
                            MessageBox.Show("Ждём вас снова, пока)");
                        }
                    }
                    else if (mIndex == 7 && fIndex == 7 && nIndex == 7)
                    {
                        float c;
                        float result;
                        float percent = 0.45f;
                        float a = 150;
                        float b = 1.5f;
                        c = a * b;
                        result = c - percent;
                        result *= 10;
                        Math.Truncate(result);
                        result /= 10;
                        Console.WriteLine("Вы выиграли +" + result + "$");
                        Console.WriteLine($"Ещё раз? 1 - Да / 2 - Нет");
                        string YesNo = Console.ReadLine();
                        int one = int.Parse(YesNo);
                        int two = int.Parse(YesNo);
                        if (one == 1)
                        {
                            goto Start;
                        }
                        if (two == 2)
                        {
                            MessageBox.Show("Ждём вас снова, пока)");
                        }
                    }
                    else if (mIndex == 8 && fIndex == 8 && nIndex == 8)
                    {
                        float c;
                        float result;
                        float percent = 0.24f;
                        float a = 80;
                        float b = 1.5f;
                        c = a * b;
                        result = c - percent;
                        result *= 10;
                        Math.Truncate(result);
                        result /= 10;
                        Console.WriteLine("Вы выиграли +" + result + "$");
                        Console.WriteLine($"Ещё раз? 1 - Да / 2 - Нет");
                        string YesNo = Console.ReadLine();
                        int one = int.Parse(YesNo);
                        int two = int.Parse(YesNo);
                        if (one == 1)
                        {
                            goto Start;
                        }
                        if (two == 2)
                        {
                            MessageBox.Show("Ждём вас снова, пока)");
                        }
                    }
                    else if (mIndex == 9 && fIndex == 9 && nIndex == 9)
                    {
                        float c;
                        float result;
                        float percent = 0.27f;
                        float a = 90;
                        float b = 1.5f;
                        c = a * b;
                        result = c - percent;
                        result *= 10;
                        Math.Truncate(result);
                        result /= 10;
                        Console.WriteLine("Вы выиграли +" + result + "$");
                        Console.WriteLine($"Ещё раз? 1 - Да / 2 - Нет");
                        string YesNo = Console.ReadLine();
                        int one = int.Parse(YesNo);
                        int two = int.Parse(YesNo);
                        if (one == 1)
                        {
                            goto Start;
                        }
                        if (two == 2)
                        {
                            MessageBox.Show("Ждём вас снова, пока)");
                        }
                    }
                    else if (mIndex == 1 && fIndex == 1)
                    {
                        float c;
                        float result;
                        float percent = 0.0025f;
                        float a = 1;
                        float b = 1.25f;
                        c = a * b;
                        result = c - percent;
                        result *= 10;
                        Math.Truncate(result);
                        result /= 10;
                        Console.WriteLine("Вы выиграли +" + result + "$");
                        Console.WriteLine($"Ещё раз? 1 - Да / 2 - Нет");
                        string YesNo = Console.ReadLine();
                        int one = int.Parse(YesNo);
                        int two = int.Parse(YesNo);
                        if (one == 1)
                        {
                            goto Start;
                        }
                        if (two == 2)
                        {
                            MessageBox.Show("Ждём вас снова, пока)");
                        }
                    }
                    else if (mIndex == 2 && fIndex == 2)
                    {
                        float c;
                        float result;
                        float percent = 0.005f;
                        float a = 2;
                        float b = 1.25f;
                        c = a * b;
                        result = c - percent;
                        result *= 10;
                        Math.Truncate(result);
                        result /= 10;
                        Console.WriteLine("Вы выиграли +" + result + "$");
                        Console.WriteLine($"Ещё раз? 1 - Да / 2 - Нет");
                        string YesNo = Console.ReadLine();
                        int one = int.Parse(YesNo);
                        int two = int.Parse(YesNo);
                        if (one == 1)
                        {
                            goto Start;
                        }
                        if (two == 2)
                        {
                            MessageBox.Show("Ждём вас снова, пока)");
                        }
                    }
                    else if (mIndex == 3 && fIndex == 3)
                    {
                        float c;
                        float result;
                        float percent = 0.0075f;
                        float a = 3;
                        float b = 1.25f;
                        c = a * b;
                        result = c - percent;
                        result *= 10;
                        Math.Truncate(result);
                        result /= 10;
                        Console.WriteLine("Вы выиграли +" + result + "$");
                        Console.WriteLine($"Ещё раз? 1 - Да / 2 - Нет");
                        string YesNo = Console.ReadLine();
                        int one = int.Parse(YesNo);
                        int two = int.Parse(YesNo);
                        if (one == 1)
                        {
                            goto Start;
                        }
                        if (two == 2)
                        {
                            MessageBox.Show("Ждём вас снова, пока)");
                        }
                    }
                    else if (mIndex == 4 && fIndex == 4)
                    {
                        float c;
                        float result;
                        float percent = 0.01f;
                        float a = 4;
                        float b = 1.25f;
                        c = a * b;
                        result = c - percent;
                        result *= 10;
                        Math.Truncate(result);
                        result /= 10;
                        Console.WriteLine("Вы выиграли +" + result + "$");
                        Console.WriteLine($"Ещё раз? 1 - Да / 2 - Нет");
                        string YesNo = Console.ReadLine();
                        int one = int.Parse(YesNo);
                        int two = int.Parse(YesNo);
                        if (one == 1)
                        {
                            goto Start;
                        }
                        if (two == 2)
                        {
                            MessageBox.Show("Ждём вас снова, пока)");
                        }
                    }
                    else if (mIndex == 5 && fIndex == 5)
                    {
                        float c;
                        float result;
                        float percent = 0.0125f;
                        float a = 5;
                        float b = 1.25f;
                        c = a * b;
                        result = c - percent;
                        result *= 10;
                        Math.Truncate(result);
                        result /= 10;
                        Console.WriteLine("Вы выиграли +" + result + "$");
                        Console.WriteLine($"Ещё раз? 1 - Да / 2 - Нет");
                        string YesNo = Console.ReadLine();
                        int one = int.Parse(YesNo);
                        int two = int.Parse(YesNo);
                        if (one == 1)
                        {
                            goto Start;
                        }
                        if (two == 2)
                        {
                            MessageBox.Show("Ждём вас снова, пока)");
                        }
                    }
                    else if (mIndex == 6 && fIndex == 6)
                    {
                        float c;
                        float result;
                        float percent = 0.015f;
                        float a = 6;
                        float b = 1.25f;
                        c = a * b;
                        result = c - percent;
                        result *= 10;
                        Math.Truncate(result);
                        result /= 10;
                        Console.WriteLine("Вы выиграли +" + result + "$");
                        Console.WriteLine($"Ещё раз? 1 - Да / 2 - Нет");
                        string YesNo = Console.ReadLine();
                        int one = int.Parse(YesNo);
                        int two = int.Parse(YesNo);
                        if (one == 1)
                        {
                            goto Start;
                        }
                        if (two == 2)
                        {
                            MessageBox.Show("Ждём вас снова, пока)");
                        }
                    }
                    else if (mIndex == 7 && fIndex == 7)
                    {
                        float c;
                        float result;
                        float percent = 0.0375f;
                        float a = 15;
                        float b = 1.25f;
                        c = a * b;
                        result = c - percent;
                        result *= 10;
                        Math.Truncate(result);
                        result /= 10;
                        Console.WriteLine("Вы выиграли +" + result + "$");
                        Console.WriteLine($"Ещё раз? 1 - Да / 2 - Нет");
                        string YesNo = Console.ReadLine();
                        int one = int.Parse(YesNo);
                        int two = int.Parse(YesNo);
                        if (one == 1)
                        {
                            goto Start;
                        }
                        if (two == 2)
                        {
                            MessageBox.Show("Ждём вас снова, пока)");
                        }
                    }
                    else if (mIndex == 8 && fIndex == 8)
                    {
                        float c;
                        float result;
                        float percent = 0.02f;
                        float a = 8;
                        float b = 1.25f;
                        c = a * b;
                        result = c - percent;
                        result *= 10;
                        Math.Truncate(result);
                        result /= 10;
                        Console.WriteLine("Вы выиграли +" + result + "$");
                        Console.WriteLine($"Ещё раз? 1 - Да / 2 - Нет");
                        string YesNo = Console.ReadLine();
                        int one = int.Parse(YesNo);
                        int two = int.Parse(YesNo);
                        if (one == 1)
                        {
                            goto Start;
                        }
                        if (two == 2)
                        {
                            MessageBox.Show("Ждём вас снова, пока)");
                        }
                    }
                    else if (mIndex == 9 && fIndex == 9)
                    {
                        float c;
                        float result;
                        float percent = 0.0225f;
                        float a = 9;
                        float b = 1.25f;
                        c = a * b;
                        result = c - percent;
                        result *= 10;
                        Math.Truncate(result);
                        result /= 10;
                        Console.WriteLine("Вы выиграли +" + result + "$");
                        Console.WriteLine($"Ещё раз? 1 - Да / 2 - Нет");
                        string YesNo = Console.ReadLine();
                        int one = int.Parse(YesNo);
                        int two = int.Parse(YesNo);
                        if (one == 1)
                        {
                            goto Start;
                        }
                        if (two == 2)
                        {
                            MessageBox.Show("Ждём вас снова, пока)");
                        }
                    }
                    else if (mIndex == 7 || fIndex == 7 || nIndex == 7)
                    {
                        float c;
                        float result;
                        float percent = 0.0224f;
                        float a = 7;
                        float b = 1.6f;
                        c = a * b;
                        result = c - percent;
                        result *= 10;
                        Math.Truncate(result);
                        result /= 10;
                        Console.WriteLine("Вы выиграли +" + result + "$");
                        Console.WriteLine($"Ещё раз? 1 - Да / 2 - Нет");
                        string YesNo = Console.ReadLine();
                        int one = int.Parse(YesNo);
                        int two = int.Parse(YesNo);
                        if (one == 1)
                        {
                            goto Start;
                        }
                        if (two == 2)
                        {
                            MessageBox.Show("Ждём вас снова, пока)");
                        }
                    }
                    else if (mIndex == 9 || fIndex == 9 || nIndex == 9)
                    {
                        float c;
                        float result;
                        float percent = 0.0243f;
                        float a = 9;
                        float b = 1.35f;
                        c = a * b;
                        result = c - percent;
                        result *= 10;
                        Math.Truncate(result);
                        result /= 10;
                        Console.WriteLine("Вы выиграли +" + result + "$");
                        Console.WriteLine($"Ещё раз? 1 - Да / 2 - Нет");
                        string YesNo = Console.ReadLine();
                        int one = int.Parse(YesNo);
                        int two = int.Parse(YesNo);
                        if (one == 1)
                        {
                            goto Start;
                        }
                        if (two == 2)
                        {
                            MessageBox.Show("Ждём вас снова, пока)");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Вы проиграли - " + stavka + "$");
                        Console.WriteLine($"Ещё раз? 1 - Да / 2 - Нет");
                        string YesNo = Console.ReadLine();
                        int one = int.Parse(YesNo);
                        int two = int.Parse(YesNo);
                        if (one == 1)
                        {
                            goto Start;
                        }
                        if (two == 2)
                        {
                            MessageBox.Show("Ждём вас снова, пока)");
                        }
                    }
                }
            }
        }
    }
}




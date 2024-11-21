using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("№1");
        /*Написать программу, которая читает с экрана число от 1 до 365 (номер дня
в году), переводит этот число в месяц и день месяца. Например, число 40 соответствует 9
февраля (високосный год не учитывать).*/



        Console.Write("Введите номер дня в году (1-365): ");
        try
        {
            int dayOfYear = int.Parse(Console.ReadLine());

            if (dayOfYear < 1 || dayOfYear > 365)
            {
                Console.WriteLine("Ошибка: номер дня должен быть в диапазоне от 1 до 365.");
                return;
            }

            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int month = 0;

            for (int i = 0; i < daysInMonth.Length; i++)
            {
                if (dayOfYear <= daysInMonth[i])
                {
                    month = i + 1;
                    break;
                }
                dayOfYear -= daysInMonth[i];
            }

            Console.WriteLine($"День {dayOfYear} соответствует {month} месяцу.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: ввод должен быть числом.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");



            Console.WriteLine("№2");
            /*Добавить к задаче из предыдущего упражнения проверку числа введенного
пользователем. Если число меньше 1 или больше 365, программа должна вырабатывать
исключение, и выдавать на экран сообщение.*/


            Console.Write("Введите номер дня в году (1-365): ");
            try
            {
                int dayOfYear = int.Parse(Console.ReadLine());

                if (dayOfYear < 1 || dayOfYear > 365)
                {
                    throw new ArgumentOutOfRangeException("Номер дня должен быть в диапазоне от 1 до 365.");
                }

                int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                int month = 0;

                for (int i = 0; i < daysInMonth.Length; i++)
                {
                    if (dayOfYear <= daysInMonth[i])
                    {
                        month = i + 1;
                        break;
                    }
                    dayOfYear -= daysInMonth[i];
                }

                Console.WriteLine($"День {dayOfYear} соответствует {month} месяцу.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: ввод должен быть числом.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (Exception)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Программа завершила свою работу.");
            }
        }
        }
    }

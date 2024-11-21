using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        Console.WriteLine("№1");
        /*Дана последовательность из 10 чисел. Определить, является ли эта последовательность
упорядоченной по возрастанию. В случае отрицательного ответа определить
порядковый номер первого числа, которое нарушает данную последовательность.
Использовать break.*/


        int[] numbers = new int[10];

        Console.WriteLine("Введите 10 чисел:");
        for (int i = 0; i < 10; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        bool isOrdered = true;
        int position = -1;

        for (int i = 1; i < 10; i++)
        {
            if (numbers[i] < numbers[i - 1])
            {
                isOrdered = false;
                position = i;
                break;
            }
        }

        if (isOrdered)
        {
            Console.WriteLine("Последовательность упорядочена по возрастанию.");
        }
        else
        {
            Console.WriteLine($"Последовательность не упорядочена. Нарушение на позиции: {position + 1}");


            Console.WriteLine("№2");
            /*Игральным картам условно присвоены следующие порядковые номера в зависимости от
их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.
Порядковые номера остальных карт соответствуют их названиям («шестерка»,
«девятка» и т. п.). По заданному номеру карты k (6 <=k <= 14) определить достоинство
соответствующей карты. Использовать try-catch-finally.*/

            try
            {
                Console.Write("Введите порядковый номер карты (6 - 14): ");
                int k = int.Parse(Console.ReadLine());

                string cardValue;

                switch (k)
                {
                    case 6: cardValue = "Шестёрка"; break;
                    case 7: cardValue = "Семёрка"; break;
                    case 8: cardValue = "Восьмёрка"; break;
                    case 9: cardValue = "Девятка"; break;
                    case 10: cardValue = "Десятка"; break;
                    case 11: cardValue = "Валет"; break;
                    case 12: cardValue = "Дама"; break;
                    case 13: cardValue = "Король"; break;
                    case 14: cardValue = "Туз"; break;
                    default:
                        throw new ArgumentOutOfRangeException("Номер карты должен быть в диапазоне от 6 до 14.");
                }

                Console.WriteLine($"Достоинство карты: {cardValue}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: ввод должен быть числом.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Программа завершила свою работу.");



                Console.WriteLine("№5");
                /*Создать массив строк. При помощи foreach обойти весь массив. При встрече элемента
"Hello Kitty" или "Barbie doll" необходимо положить их в “сумку”, т.е. прибавить к
результату. Вывести на экран сколько кукол в “сумке”.*/

                {
                    {
                        string[] toys = { "Teddy Bear", "Hello Kitty", "Action Figure", "Barbie doll", "Lego", "Doll", "Barbie doll" };

                        int bagCount = 0;

                        foreach (string toy in toys)
                        {
                            if (toy == "Hello Kitty" || toy == "Barbie doll")
                            {
                                bagCount++;
                            }
                        }

                        Console.WriteLine($"В сумке {bagCount} куклы.");

                    }
                }
            }
        }
    }
}
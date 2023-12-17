//Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли.
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

//using System;

//namespace EndlessNumberInput
//{
//    class Program
////   {
//       static void Main(string[] args)
//        {
//            while (true)
//            {
//                Console.WriteLine("Введите целое число или символ 'q' для выхода:");
//                string input = Console.ReadLine();
//
//                if (input == "q")
 //               {
 //                   Console.WriteLine("Программа завершена.");
 //                   break;
 //               }

 //               int number;
 //               if (int.TryParse(input, out number))
 //               {
 //                   int sum = 0;
 //                   foreach (char digit in input)
 //                   {
  //                      if (Char.IsDigit(digit))
  //                      {
   //                         sum += int.Parse(digit.ToString());
  //                      }
 //                   }

   //                 if (sum % 2 == 0)
//                    {
   //                     Console.WriteLine("Сумма цифр числа чётная. Программа завершена.");
   //                     break;
   //                 }
 //               }
   //             else
   //             {
  //                  Console.WriteLine("Некорректный ввод. Попробуйте снова.");
   //             }
  //          }
  //      }
  //  }
//}

//Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Введите длину массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
RandonNumbers(numbers);
Console.WriteLine("В этом массиве: ");
PrintArray(numbers);

void RandonNumbers(int[] numbers)
{
    for(int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}


int count = 0;

for (int x = 0; x < numbers.Length; x++)
{
if (numbers[x] % 2 == 0)
count++;
}
Console.WriteLine($"из {numbers.Length} чисел, {count} четных");


void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

//Задача 3: Напишите программу, которая перевернёт одномерный массив 
//(первый элемент станет последним, второй – предпоследним и т.д.)
//using System;

//namespace ReverseArray
//{
  //  class Program
 //   {
  //      static void Main(string[] args)
 //       {
 //           int[] array = { 1, 3, 5, 6, 7, 8};
 //           Console.WriteLine("Исходный массив:");
 //           PrintArray(array);

 //           ReverseArray(array);

 //           Console.WriteLine("Перевернутый массив:");
 //           PrintArray(array);
 //       }

  //      static void ReverseArray(int[] arr)
  //      {
 //           int start = 0;
//            int end = arr.Length - 1;
 //           while (start < end)
  //          {
 //               int temp = arr[start];
 //               arr[start] = arr[end];
 //               arr[end] = temp;
 //               start++;
 //               end--;
 //           }
 //       }

 //       static void PrintArray(int[] arr)
 //       {
//            foreach (int i in arr)
//            {
 //               Console.Write(i + " ");
//            }
 //           Console.WriteLine();
//        }
//    }
//}

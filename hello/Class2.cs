/* using System;
using System.Collections.Generic;
using System.Text;

namespace hello
{
    class Class2
    {
        static void Main(string[] args)
        {
            //Ввод
            int[] nums = new int[7];
            Console.WriteLine("Weite seven numbers");
            for(int i = 0; i<nums.Length; i++) //длина массива
            {
                Console.Write("{0} number: ", i + 1); //ввод числа в массив
                nums[i] = Int32.Parse(Console.ReadLine()); //ввод числа с клавы. парс это коротка версия той ебалы с конвертацией
            }

            //Сортировка
            int temp; //ввод переменной для обмена данными
            for (int i=0; i < nums.Length-1; i ++) //сравнивоемое число
            {
                for(int j=i+1; j<nums.Length; j++) //число в массиве с которым будет сравниваться
                {
                    if(nums[i] > nums[j]) //если массив и > массива ж, то...
                    {
                        temp = nums[i]; //temp сравниваемое число
                        nums[i] = nums[j]; //два числа меняются местами
                        nums[j] = temp; //ж должно быть равно темпу
                        
                        //в итоге, числа просто поменяли свои позиции
                    }
                }
            }

            //Вывод
            Console.WriteLine("Sorted array output");
            for(int i=0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadLine();
        }
    }
}
*/
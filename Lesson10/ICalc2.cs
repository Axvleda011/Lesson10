using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10
{
    internal interface ICalc2
    {

        interface ICalc2
        {
            int CountDistinct();
            int EqualToValue(int valueToCompare);
        }

        class MyArray : ICalc2
        {
            private int[] numbers;

            public  MyArray(int[] numbers)
            {
                this.numbers = numbers;
            }

            public int CountDistinct()
            {
                int count = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    bool isUnique = true;

                    for (int j = 0; j < i; j++)
                    {
                        if (numbers[i] == numbers[j])
                        {
                            isUnique = false;
                            break;
                        }
                    }

                    if (isUnique)
                    {
                        count++;
                    }
                }

                return count;
            }

            public int EqualToValue(int valueToCompare)
            {
                int count = 0;

                foreach (int number in numbers)
                {
                    if (number == valueToCompare)
                    {
                        count++;
                    }
                }

                return count;
            }
        }

        class Program
        {
            static void Main()
            {
                int[] numbers = { 1, 2, 3, 2, 4, 1, 5, 2, 6 };

                MyArray myarray = new MyArray(numbers);

                Console.WriteLine(
                    "უნიკალური მნიშვნელობების რაოდენობა: "
                    + myarray.CountDistinct());

                Console.WriteLine(
                    "რიცხვი 2 მასივში გვხვდება "
                    + myarray.EqualToValue(2) + "-ჯერ.");

                Console.ReadKey();
            }
        }
    }
}

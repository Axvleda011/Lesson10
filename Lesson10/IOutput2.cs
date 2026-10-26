using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10
{
    internal interface IOutput2
    {

        interface IOutput2
        {
            void ShowEven();
            void ShowOdd();
        }

        class MyArray : IOutput2
        {
            private int[] numbers;

            public MyArray(int[] numbers)
            {
                this.numbers = numbers;
            }

            public void ShowEven()
            {
                Console.WriteLine("ლუწი რიცხვები:");

                foreach (int number in numbers)
                {
                    if (number % 2 == 0)
                    {
                        Console.Write(number + " ");
                    }
                }

                Console.WriteLine();
            }

            public void ShowOdd()
            {
                Console.WriteLine("კენტი რიცხვები:");

                foreach (int number in numbers)
                {
                    if (number % 2 != 0)
                    {
                        Console.Write(number + " ");
                    }
                }

                Console.WriteLine();
            }
        }

        class Program
        {
            static void Main()
            {
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                MyArray myarray = new MyArray(numbers);

                myarray.ShowEven();
                myarray.ShowOdd();

                Console.ReadKey();
            }
        }
    }
}

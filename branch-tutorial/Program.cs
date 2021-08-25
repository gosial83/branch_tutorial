using System;

namespace branch_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExploreIf();
            //ExploreLoops();
            branchesAndLoops();
            


            void ExploreIf()
            {
                int a = 5;
                int b = 3;
                if (a + b > 10)
                {
                    Console.WriteLine("The answer is greater than 10");
                }
                else
                {
                    Console.WriteLine("The answer is not greater than 10");
                }

                int c = 4;
                if ((a + b + c > 10) && (a > b))
                {
                    Console.WriteLine("The answer is greater than 10");
                    Console.WriteLine("And the first number is greater than the second");
                }
                else
                {
                    Console.WriteLine("The answer is not greater than 10");
                    Console.WriteLine("Or the first number is not greater than the second");
                }

                if ((a + b + c > 10) || (a > b))
                {
                    Console.WriteLine("The answer is greater than 10");
                    Console.WriteLine("Or the first number is greater than the second");
                }
                else
                {
                    Console.WriteLine("The answer is not greater than 10");
                    Console.WriteLine("And the first number is not greater than the second");
                }
            }

            void ExploreLoops()
            {
                int counter = 10;
                while (counter < 15)
                {
                    Console.WriteLine($"Hello World! The counter is {counter}");
                    counter++;
                }

                int counter_do_while = 20;
                do
                {
                    Console.WriteLine($"Hello World! The counter_do_while is {counter_do_while}");
                    counter_do_while++;
                } while (counter_do_while < 30);

                for (int index = 100; index < 110; index++)
                {
                    Console.WriteLine($"Hello World! The index is {index}");
                }

                for (char column = 'a'; column < 'k'; column++)
                {
                    for (int row = 1; row < 11; row++)
                    {
                        Console.WriteLine($"The cell is ({row}, {column})");
                    }
                }
            }

            // sum of all integers 1 through 20 that are divisible by 3
            void branchesAndLoops()
            {
                int sum = 0;
                
                for (int i = 0; i <= 20; i++)
                {
                    if (i % 3 == 0)
                        sum += i;
                }

                Console.WriteLine($"Sum: {sum}");
            }


        }
    }
}

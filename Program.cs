using System;

namespace ExceptionAndExceptionHeadling3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write($"Enter First no.: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write($"Enter First no.: ");
                int b = int.Parse(Console.ReadLine());

                if (b%2>0)
                {
                    throw new ApplicationException("Divisor value can't be odd no.");
                }
                int c = a / b;
                Console.WriteLine($"The Result is: {c}");
            }
            catch (DivideByZeroException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch (FormatException ex2)
            {
                Console.WriteLine("Input must be numeric");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block is executed.");
            }
            Console.WriteLine("End of the Program");
            Console.ReadLine();
        } 
    }
}

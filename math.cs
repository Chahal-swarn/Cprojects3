using System;

namespace MathOperationApp
{
    public class MathOperations
    {
        public void Performoperation( int num1, int num2,)
        {
            int result = num1 *2;
            Console.WriteLine("The second integer is: " + num2);

            console.WriteLine("The result of multiplying the first integer by 2 is:" + result);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            MathOperations mathOps= new MathOperations();
            mathOps.PerformOperation(5, 10);
            MathOps.PerformOperation(num1: 8, num2: 15);
            Console.ReadLine();
        }
    }
}
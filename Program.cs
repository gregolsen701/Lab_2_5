using System;

namespace Lab_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            int firstNumber;
            int secondNumber;
            Console.WriteLine("Enter a number.");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second number.");
            secondNumber = int.Parse(Console.ReadLine());

            int answer = firstNumber + secondNumber;
            Console.WriteLine("The result of adding the two numbers is " + answer);

            answer = firstNumber - secondNumber;
            Console.WriteLine("The result of subtracting the two numbers is " + answer);

            answer = firstNumber * secondNumber;
            Console.WriteLine("The result of multiplying the two numbers is " + answer);

            double answer1 = (double)firstNumber / (double)secondNumber;
            Console.WriteLine("The result of dividing the two numbers is " + answer1);

            //2.
            string yourName;
            Console.WriteLine("What is your name?");
            yourName = Console.ReadLine();
            Console.WriteLine("Hello " + yourName + "!");

            //3.
            int valueOne;
            int valueTwo;
            int valueThree;
            Console.WriteLine("Enter Three Numbers to Multiply");
            Console.WriteLine("What is your first number?");
            valueOne = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your second number?");
            valueTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your third number?");
            valueThree = int.Parse(Console.ReadLine());
            Console.WriteLine("The answer is " + (valueOne * valueTwo * valueThree));

            //4.
            int age;
            Console.WriteLine("How old are you?");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Hmmmm...You look younger than " + age);

        }
    }
}

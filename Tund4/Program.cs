using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tund4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inimene sisestab 3 numbrit ja programm ütleb kõige suurema numbri.
            /*Console.WriteLine("Hello!");
            Console.WriteLine("Insert three numbers. Numbers have to be in range 1 to 10.");
            int firstNumber;
            int secondNumber;
            int thirdNumber;

            Console.WriteLine("Enter first number");
            firstNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            secondNumber =Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number");
            thirdNumber =Int32.Parse(Console.ReadLine());

            if (firstNumber > secondNumber && firstNumber>thirdNumber)
            {
                Console.WriteLine($"{firstNumber} is largerst number.");
            }
            if (secondNumber > firstNumber && secondNumber>thirdNumber)
            {
                Console.WriteLine($"{secondNumber} is largest number.");
            }
            if (thirdNumber > firstNumber && thirdNumber > secondNumber)
            {
                Console.WriteLine($"{thirdNumber} is largest number");
            }
            Console.ReadLine(); */


            //Randon number generator
            /*Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 11);
            Console.WriteLine(randomNumber);

            Console.ReadLine();*/

            //Arvuti genereerib numbreid 1st 6ni ja inimene lisab ka ühe numbri ja programm peab vaatama kumb number on suurem.

            /*Console.WriteLine("Hello! Throw a dice (Write any number what is in range 1 to 6.)");
            int anyNumber;

            Console.WriteLine("Insert number:");
            anyNumber = Int32.Parse(Console.ReadLine());

            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 7);
            Console.WriteLine(randomNumber);

            if (randomNumber > anyNumber)
            {
                Console.WriteLine($"{randomNumber} is larger than {anyNumber}.You lost.");
            }
            else if (anyNumber>randomNumber)
            {
                Console.WriteLine($"{anyNumber} is larger than {randomNumber}.You won!");
            }
            else (anyNumber == randomNumber)
            {
                Console.WriteLine("Numbers are equal!");
            }

            Console.ReadLine();*/

            //3 katsega täringu viskamine
            /*int userRoll;
            int cpuRoll;
            int rolls =0;
            int userScore =0;
            int cpuScore =0;

            Random rnd = new Random();

            while(rolls <3)
            {
                userRoll = rnd.Next(1, 7);
                cpuRoll = rnd.Next(1, 7);

                Console.WriteLine($"You rolled {userRoll}, CPU rolls {cpuRoll}");

                if(userRoll>cpuRoll)
                {
                    userScore++;
                }
                else if (userRoll<cpuRoll)
                {
                    cpuScore++;
                }
                else
                {
                    continue;
                }

                rolls++;
                Console.ReadLine();
            }

            if(userScore>cpuScore)
            {
                Console.WriteLine("Concrats! You won!");
            }
            else if(userScore <cpuScore)
            {
                Console.WriteLine("You lose! Try again.");
            }
            else
            {
                Console.WriteLine("Tie!");
            }
            Console.WriteLine($"You scored {userScore}, CPU scored {cpuScore}");

            Console.ReadLine();*/

            //Uus ülesanne switchiga
            /*Random rnd = new Random();
            int randomNumber = rnd.Next(1, 6);
            Console.WriteLine($"CPU generated{randomNumber}");

            switch(randomNumber)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                default:
                    Console.WriteLine("CPU generated nothing");
                    break;
            }
            Console.ReadLine("One");*/

            //Sõnadega switch

            Console.WriteLine("Pic a color (red, black, blue):");
            string answer = Console.ReadLine();

            switch(answer)
            {
                case "red":
                    Console.WriteLine("You are romantic type");
                    break;
                case "black":
                    Console.WriteLine("You are a loner");
                    break;
                case "blue":
                    Console.WriteLine("You are like sea");
                    break;
                default:
                    Console.WriteLine("No color dedected");
                    break;
            }
            Console.ReadLine();


            




            

        }
    }
}

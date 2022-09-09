using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Firstproject.Calc
{
    public class Calculator
    {
        public void RunCalculation()
        {
            // variable declarations
            string[] allowedOper = new string[4] { "+", "-", "*", "/" };
            string type;
            int num1;
            int num2;
            int answer;
            string restartCheck;

            // Operator type
            Console.WriteLine("What type of calculation do you want to perform? (+, -, *, or /)");
            type = GetCalcType(allowedOper);

            // We get the first number
            Console.WriteLine("Write the first number and press enter.");
            num1 = GetCalcNum();

            // We get the second number
            Console.WriteLine("Write the second numberand press enter.");
            num2 = GetCalcNum();

            // calculation get running
            answer = Calculate(num1, num2, type);

            // ANswer
            Console.WriteLine("The answer is " + answer + "\r\n Write 'yes' to restart application.");

            //checks if the user wants to restart app
            restartCheck = Console.ReadLine();
            if (restartCheck == "yes") 
            {
                RunCalculation();
            }
            {
                Environment.Exit(0);
            }
        }
        private string GetCalcType(string[] allowedOper)
        {
            // We get the operator
            string type = Console.ReadLine();

            //checked if valid operator is selected
            while (!allowedOper.Contains(type))
            {
                Console.WriteLine("Choose a valid operator type!");
                type = Console.ReadLine();
            }
            return type;
        }
        private int GetCalcNum()
        {
            int num;
            // checking if the pare is successful
            //returns a boolean
            bool parseCheck = Int32.TryParse(Console.ReadLine(), out num);

            //If boolean is false, keeps looping the input
            while (!parseCheck)
            {
                Console.WriteLine("Try again! This time with actual numbers... (1,2,3....)");
                parseCheck = Int32.TryParse(Console.ReadLine(), out num);
            }

            return num;
        }
        public int Calculate(int num1, int num2, string type)
        {
            // we declare our variables
            int result;

            // Check the operator type
            if (type == "+")
            {
                result = num1 + num2;
                return result;
            }
            else if (type == "-")
            {
                result = num1 - num2;
                return result;
            }
            else if (type == "*")
            {
                result = num1 * num2;
                return result;
            }
            else
            {
                result = num1 / num2;
                return result;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace InvestmentCalculator
{

    //Student name: Sandra Isabel Yanza Hernandez
    //Student code: C0888063

    internal class Program
    {
        //The main entry point for the program.
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! This program is a Future Investment Calculator\n" );

            int investment = GetAndValidDataInvestment();
            decimal interestRate = GetAndValidDataInterest();
            int years = GetAndValidDataYears();

            decimal futureInvestment = ComputeFutureInvestmentValue(investment, interestRate, years);
            Console.WriteLine("Result-> The future investment value is: {0:C}\n", futureInvestment);
            Console.WriteLine("Press any key to Exit.");
            Console.ReadKey();
        }


        /* GetAndValidDataInvestment: This method get and validate the investment value.
         * Input: no input.
         * Output: integer investment.
         */
        public static int GetAndValidDataInvestment()
        {
            bool success = false;
            int investment = 0;

            //Prompt user for value
            Console.Write("1.Enter the investment. This value must be an integer from 100 to 100,000: ");

            //A loop for validate the input user.
            do
            {
                // TryParse returns a boolean value: true if the conversion was successful or false if not.
                success = int.TryParse(Console.ReadLine(), out investment);

                //Validate the value within the range. 
                if (success && (investment >= 100 && investment <= 100000))
                    break;
                else
                {
                    Console.WriteLine("**Please, enter the investment again. Integer from 100 to 100,000: ");
                    investment = 0;
                    success = false;
                }
            } while (!success);

            return investment; 
        }

        /* This method get and validate the interest value.
         * Input: no input.
         * Output: decimal interest.
         */
        public static decimal GetAndValidDataInterest()
        {
            bool success = false;
            decimal interest = 0m;

            //Prompt user for value
            Console.Write("2.Enter the interest rate. This value must be a value from 0.1 to 12: ");

            //A loop for validate the input user.
            do
            {
                // TryParse returns a boolean value: true if the conversion was successful or false if not.
                success = decimal.TryParse(Console.ReadLine(), out interest);

                //Validate the value within the range.
                if (success && (interest >= 0.1m && interest <= 12m))
                    break;
                else
                {
                    Console.WriteLine("**Please, enter the interest rate again. Value from 0.1 to 12: ");
                    interest = 0m;
                    success = false;
                }
            } while (!success);

            return interest; 
        }

        /* This method get and validate the years value.
         * Input: no input.
         * Output: integer years.
         */
        public static int GetAndValidDataYears()
        {
            bool success = false;
            int years = 0;

            //Prompt user for value
            Console.Write("3.Enter the years. This value must be an integer from 1 to 30: ");

            //A loop for validate the input user.
            do
            {
                // TryParse returns a boolean value: true if the conversion was successful or false if not.
                success = int.TryParse(Console.ReadLine(), out years);

                //Validate the value within the range.
                if (success && (years >= 1 && years <= 30))
                    break;
                else
                {
                    Console.WriteLine("**Please, enter the years again. Integer from 1 to 30: ");
                    years = 0;
                    success = false;
                }
            } while (!success);

            return years; 
        }

        /* This method compute the future investment value.
         * Input: integer investment, decimal interest, integer years.
         * Output: decimal future investment value.
         */
        public static decimal ComputeFutureInvestmentValue(int investment, decimal interest, int years)
        {
            decimal futureInvestment = 0m;
            futureInvestment = investment * (decimal)Math.Pow((double)(1 + interest), years);
            return futureInvestment;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{

    //Student name: Sandra Isabel Yanza Hernandez
    //Student code: C0888063
    //This program is an unit converter with four different options.
    internal class Program
    {
        //Constant to manage the conversion.
        public const double gallons_to_litres = 0.264172052;
        public const double litres_to_gallons = 3.78541;
        public const double miles_to_km = 0.621371;
        public const double km_to_miles = 1.60934;

        //The main entry point for the program.
        static void Main(string[] args)
        {
            int option = GetAndValidOption();
            double value = GetAndValidValueToConverter(option);
            string conversionResult = CalculateConversion(option, value);
            
            Console.WriteLine(conversionResult);
            Console.WriteLine("Press any key to Exit.");
            Console.ReadKey();

        }


        /* GetAndValidOption: This method get and validate the option for using the Unit Converter.
         * Input: no input.
         * Output: integer value. It is the selected option for the user.
         */
        public static int GetAndValidOption()
        {
            Console.WriteLine("Welcome! This program is a Unit Converter. The options are: \n");
            bool success = false;
            int option = 0;

            //Prompt user for value.
            Console.Write("1.Litres to Gallons\n");
            Console.Write("2.Gallons to Litres\n");
            Console.Write("3.KM to Miles\n");
            Console.Write("4.Miles to KMs\n\n");
            Console.Write("---------------------\n");
            Console.WriteLine("Please, choose an option:\n");

            //A loop for validate the input user.
            do
            {
                // TryParse returns a boolean value: true if the conversion was successful or false if not.
                success = int.TryParse(Console.ReadLine(), out option);

                //Validate the value within the range. 
                if (success && (option >= 1 && option <= 4))
                    break;
                else
                {
                    //If the user enters incorrect option or no numeric value.
                    Console.WriteLine("**Please, enter a valid option. Any option from 1 to 4: ");
                    option = 0;
                    success = false;
                }
            } while (!success);

            return option;
        }


        /* GetAndValidValueToConverter: This method get and validate the value to converter.
         * Input: integer option.
         * Output: double value.
         */
        public static double GetAndValidValueToConverter(int option)
        {
            bool success = false;
            double value = 0;
            //This array is used to show the selected option to the user.
            string[] cars = { "Litres to Gallons", "Gallons to Litres", "KM to Miles", "Miles to KMs" };

            //Prompt user for value
            Console.Write("Your option is: " + cars[option - 1] + ". Enter the value to converter: ");

            //A loop for validate the input user.
            do
            {
                // TryParse returns a boolean value: true if the conversion was successful or false if not.
                success = double.TryParse(Console.ReadLine(), out value);

                //Validate the parse. 
                if (success)
                    break;
                else
                {
                    //If the user enters incorrect option or no numeric value.
                    Console.WriteLine("**Please, enter the value again. It must be a numeric value: ");
                    value = 0;
                    success = false;
                }
            } while (!success);

            return value;
        }


        /* CalculateConversion: This method calculate the conversion.
         * Input: integer option, double value to converter.
         * Output: converted value. This output is a string.
         */
        public static string CalculateConversion(int option, double value)
        {
            string conversionResult = "";
            //This switch allows to call the appropriate method according to the option selected by the user.
            switch (option)
            {
                case 1:
                    conversionResult = ConvertLitresToGallons(value);
                    break;
                case 2:
                    conversionResult = ConvertGallonsToLitres(value);
                    break;
                case 3:
                    conversionResult = ConvertKmToMiles(value);
                    break;
                case 4:
                    conversionResult = ConvertMilesToKm(value);
                    break;
                default:
                    conversionResult = "Conversion not possible";
                    break;
            }

            return conversionResult;
        }

        /* ConvertLitresToGallons: This method calculate the conversion of litres to gallons.
         * Input: double value to converter.
         * Output: conversion result.
         */
        public static string ConvertLitresToGallons(double value)
        {
            double gallons = value * gallons_to_litres;
            string result = value + " Litres is equal to " + gallons + " Gallons.";
            return result;

        }

        /* ConvertGallonsToLitres: This method calculate the conversion of gallons to litres.
         * Input: double value to converter.
         * Output: conversion result.
         */
        public static string ConvertGallonsToLitres(double value)
        {
            double litres = value * litres_to_gallons;
            string result = value + " Gallons is equal to " + litres + " Litres.";
            return result;

        }

        /* ConvertKmToMiles: This method calculate the conversion of kilometers to miles.
         * Input: double value to converter.
         * Output: conversion result.
         */
        public static string ConvertKmToMiles(double value)
        {
            double miles = value * miles_to_km;
            string result = value + " Kilometers is equal to " + miles + " Miles.";
            return result;

        }

        /* ConvertMilesToKm: This method calculate the conversion of miles to kilometers.
         * Input: double value to converter.
         * Output: conversion result.
         */
        public static string ConvertMilesToKm(double value)
        {
            double km = value * km_to_miles;
            string result = value + " Miles is equal to " + km + " Kilometers.";
            return result;

        }

    }
}

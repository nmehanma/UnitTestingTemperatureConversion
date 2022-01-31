﻿using System;

namespace Prog8170Assign2
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversion temperatureConverter = new Conversion();
            Console.WriteLine("Please enter the value to be converted, it must be an integer greater than zero.");                   
            
            temperatureConverter.TemperatureInput = Int32.Parse(Console.ReadLine());

            validTemp(temperatureConverter.TemperatureInput);

            int userSelection = Int32.Parse(Console.ReadLine());

            double newNumber = validUserSelection(userSelection);

            switch (newNumber)
            {
                case 1:
                    Console.WriteLine($"{temperatureConverter.ConvertCelciusToFahrenheit()}");
                    Console.WriteLine("Press Any Key to Quit");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine($"{temperatureConverter.ConvertCelciusToKelvin()}");
                    Console.WriteLine("Press Any Key to Quit");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine($"{temperatureConverter.ConvertFahrenheitToCelsius()}");
                    Console.WriteLine("Press Any Key to Quit");
                    Console.ReadKey();
                    break;

                case 4:
                    Console.WriteLine($"{temperatureConverter.ConvertFahrenheitToKelvin()}");
                    Console.WriteLine("Press Any Key to Quit");
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine($"{temperatureConverter.ConvertKelvinToCelsius()}");
                    Console.WriteLine("Press Any Key to Quit");
                    Console.ReadKey();
                    break;
                case 6:
                    Console.WriteLine($"{temperatureConverter.ConvertKelvinToFahrenheit()}");
                    Console.WriteLine("Press Any Key to Quit");
                    Console.ReadKey();
                    break;
                case 7:                    
                    return;               
            }
        }
        public static double validTemp(int number)
        {
            if (number < 1)
            {
                Console.WriteLine("Please enter an integer value greater than 0");
                number = Int32.Parse(Console.ReadLine());
            }
            else
            { 
                Console.WriteLine("Please select one of the 7 options to convert your input:");
                Console.WriteLine("1. Convert Celsius to Fahrenheit");
                Console.WriteLine("2. Convert Celsius to Kelvin");
                Console.WriteLine("3. Convert Fahrenheit to Celsius");
                Console.WriteLine("4. Convert Fahrenheit to Kelvin");
                Console.WriteLine("5. Convert Kelvin to Celsius");
                Console.WriteLine("6. Convert Kelvin to Fahrenheit");
                Console.WriteLine("7. Exit");
                return number;
                                                            
            }
            return validTemp(number);
        }
        public static double validUserSelection(int number)
        {
            if (number != 1 && number != 2 && number != 3 && number != 4 && number != 5 && number != 6 && number != 7)
            {
                Console.WriteLine("Please select one of the 7 options to convert your input:");
                Console.WriteLine("1. Convert Celsius to Fahrenheit");
                Console.WriteLine("2. Convert Celsius to Kelvin");
                Console.WriteLine("3. Convert Fahrenheit to Celsius");
                Console.WriteLine("4. Convert Fahrenheit to Kelvin");
                Console.WriteLine("5. Convert Kelvin to Celsius");
                Console.WriteLine("6. Convert Kelvin to Fahrenheit");
                Console.WriteLine("7. Exit");
                number = Int32.Parse(Console.ReadLine());
            }
            else
            {

               
                return number;
            }            
            return validUserSelection(number);
        }
    }
}

// System namespace needed to use Console class.
using System;

// My collection of classes for this project.
namespace Operators_Sadler_Madison
{
    // Main class for the program
    class Program
    {
        // The Main method is executed when the application starts
        static void Main(string[] args)
        {
            // Initializes an integer named intMult and multiplies two numbers to get the integer
            int intMult = 13 * 69;
            // Initializes an integer named intAdd and adds two numbers to get an integer
            int intAdd = -7 + 420;

            // Prints out the max of intMult and intAdd and figures the max of both variables
            Console.WriteLine($"The max of {intMult} and {intAdd} is {Math.Max(intMult, intAdd)}.");
            // Prints out the min of intMult and intAdd and figures the min of both variables
            Console.WriteLine($"The min of both values is {Math.Min(intMult, intAdd)}.");

            // Initializes a boolean named isIntGreater to see if intMult is greater than intAdd
            bool isIntGreater = intMult > intAdd;
            // Prints out the boolean and states intMult is greater than intAdd
            Console.WriteLine($"{intMult} is greater than {intAdd}, {isIntGreater}.");


            // Initializes a short variable named shortMult and multiplies two numbers to get the short variable
            short shortMult = 50 * 420;
            // Initializes a short variable named shortAdd and adds two numbers to get a short variable
            short shortAdd = -50 + 5000;

            // Prints out the max of shortMult and shortAdd and figures the max of both variables
            Console.WriteLine($"The max of {shortMult} and {shortAdd} is {Math.Max(shortMult, shortAdd)}.");
            // Prints out the min of shortMult and shortAdd and figures the min of both variables
            Console.WriteLine($"The min of both values is {Math.Min(shortMult, shortAdd)}.");

            // Initializes a boolean named isshortGreater to see if shortMult is greater than shortAdd
            bool isshortGreater = shortMult > shortAdd;
            // Prints out the boolean and states shortMult is greater than shortAdd
            Console.WriteLine($"{shortMult} is greater than {shortAdd}, {isshortGreater}.");


            // Initializes a long variable named longMult and multiplies two numbers to get the long variable
            long longMult = 123456789L * 1010L;
            // Initializes a long variable named longAdd and adds two numbers to get a long variable
            long longAdd = -987654321L + 456456456790L;

            // Prints out the max of longMult and longAdd and figures the max of both variables
            Console.WriteLine($"The max of {longMult} and {longAdd} is {Math.Max(longMult, longAdd)}.");
            // Prints out the min of longMult and longAdd and figures the min of both variables
            Console.WriteLine($"The min of both values is {Math.Min(longMult, longAdd)}.");

            // Initializes a boolean named islongGreater to see if longMult is greater than longAdd
            bool islongGreater = longMult > longAdd;
            // Prints out the boolean and states longMult is greater than longAdd
            Console.WriteLine($"{longMult} is greater than {longAdd}, {islongGreater}.");


            // Initializes a float variable named floatMult and multiplies two numbers to get the float variable
            float floatMult = 2.9F * 1.8F;
            // Initializes a float variable named floatAdd and adds two numbers to get a float variable
            float floatAdd = 36.5F + 9.4F;

            // Prints out the max of floatMult and floatAdd and figures the max of both variables
            Console.WriteLine($"The max of {floatMult} and {floatAdd} is {Math.Max(floatMult, floatAdd)}.");
            // Prints out the min of floatMult and floatAdd and figures the min of both variables
            Console.WriteLine($"The min of both values is {Math.Min(floatMult, floatAdd)}.");

            // Initializes a boolean named isfloatGreater to see if floatMult is greater than floatAdd
            bool isfloatGreater = floatMult > floatAdd;
            // Prints out the boolean and states floatMult is greater than floatAdd
            Console.WriteLine($"{floatMult} is greater than {floatAdd}, {isfloatGreater}.");


            // Initializes a double variable named doubleMult and multiplies two numbers to get the double variable
            double doubleMult = 14.9876 * 31.4839;
            // Initializes a double variable named doubleAdd and adds two numbers to get a double variable
            double doubleAdd = -39.2047 + 58.393749;

            // Prints out the max of doubleMult and doubleAdd and figures the max of both variables
            Console.WriteLine($"The max of {doubleMult} and {doubleAdd} is {Math.Max(doubleMult, doubleAdd)}.");
            // Prints out the min of doubleMult and doubleAdd and figures the min of both variables
            Console.WriteLine($"The min of both values is {Math.Min(doubleMult, doubleAdd)}.");

            // Initializes a boolean named isdoubleGreater to see if doubleMult is greater than doubleAdd
            bool isdoubleGreater = doubleMult > doubleAdd;
            // Prints out the boolean and states doubleMult is greater than doubleAdd
            Console.WriteLine($"{doubleMult} is greater than {doubleAdd}, {isdoubleGreater}.");


            // Initializes a decimal variable named decimalMult and multiplies two numbers to get the decimal variable
            decimal decimalMult = (decimal)(6.543 * 48.294739);
            // Initializes a decimal variable named decimalAdd and adds two numbers to get a decimal variable
            decimal decimalAdd = (decimal)(9.47594 + 39.4839);

            // Prints out the max of decimalMult and decimalAdd and figures the max of both variables
            Console.WriteLine($"The max of {decimalMult} and {decimalAdd} is {Math.Max(decimalMult, decimalAdd)}.");
            // Prints out the min of decimalMult and decimalAdd and figures the min of both variables
            Console.WriteLine($"The min of both values is {Math.Min(decimalMult, decimalAdd)}.");

            // Initializes a boolean named isdecimalGreater to see if decimalMult is greater than decimalAdd
            bool isdecimalGreater = decimalMult > decimalAdd;
            // Prints out the boolean and states decimalMult is greater than decimalAdd
            Console.WriteLine($"{decimalMult} is greater than {decimalAdd}, {isdecimalGreater}.");
        }
    }
}

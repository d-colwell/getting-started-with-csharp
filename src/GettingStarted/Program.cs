using System;

namespace GettingStarted {
    class Program {
        static void Main(string[] args) { 
            Console.Write("Please type your input: ");
            string input = Console.ReadLine();
            if (!System.IO.File.Exists("sample.csv")) {
                Console.Error.WriteLine("Expected to find a file called 'sample.csv'");
                Console.ReadKey();
            }
            //Read the CSV file here
            //Find the record where the first value is the 'input' value that the user typed
            //Store the second value in that record in the outputValue string below

            string outputValue = ""; // The value from the CSV second column goes here when you find it
            Console.WriteLine(outputValue);
        }
    }
}

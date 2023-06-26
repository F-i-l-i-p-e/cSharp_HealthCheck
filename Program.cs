// Assignment 1 - ASP206-Group 8
// Main Program File
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter patient's age: ");
        int age = GetValidIntInput();  // Age input

        Console.Write("Enter patient's first name: ");
        string firstName = Console.ReadLine();  // Firstname input

        Console.Write("Enter patient's last name: ");
        string lastName = Console.ReadLine();  // Lastname input

        Console.Write("Enter patient's weight (in KG): ");
        double weight = GetValidDoubleInput();  // Weight input

        Console.Write("Enter patient's height (in CM): ");
        double height = GetValidDoubleInput();  // Height input

        Console.Write("Enter patient's Systolic Blood Pressure: ");
        int systolic = GetValidIntInput();  // Systolic input

        Console.Write("Enter patient's Diastolic Blood Pressure: ");
        int diastolic = GetValidIntInput();  // Diastolic input

        Patient patient = new Patient(firstName, lastName, age, weight, height);  // Patient creation
        patient.PrintPatientInfo(systolic, diastolic);  // Print information
    }

    static int GetValidIntInput()
    {
        int output;
        while (!int.TryParse(Console.ReadLine(), out output) || output < 0)
        {
            Console.WriteLine("Invalid input. Enter a positive number.");
        }
        return output;  // Return integer
    }

    static double GetValidDoubleInput()
    {
        double output;
        while (!double.TryParse(Console.ReadLine(), out output) || output < 0.0)
        {
            Console.WriteLine("Invalid input. Enter a positive number.");
        }
        return output;  // Return double
    }
}

// BloodPressure Enum
public enum BloodPressureCategory
{
    Normal,
    Elevated,
    HypertensionStage1,
    HypertensionStage2,
    HypertensiveCrisis,
    Unknown
}

// BMI Enum
public enum BMICategory
{
    Underweight,
    Normal,
    Overweight,
    Unknown
}

// Patient class
public class Patient
{
    private string FirstName { get; set; } // First name
    private string LastName { get; set; }  // Last name
    private int Age { get; set; }  // Age
    private double Weight { get; set; }  // Weight
    private double Height { get; set; }  // Height

    // Constructor
    public Patient(string firstName, string lastName, int age, double weight, double height)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Weight = weight;
        Height = height;
    }

    // BP calculation
    public BloodPressureCategory CalculateBloodPressure(int systolic, int diastolic)
    {
        if (systolic < 120 && diastolic < 80) return BloodPressureCategory.Normal;
        if (systolic >= 120 && systolic < 130 && diastolic < 80) return BloodPressureCategory.Elevated;
        if ((systolic >= 130 && systolic < 140) || (diastolic >= 80 && diastolic < 90)) return BloodPressureCategory.HypertensionStage1;
        if (systolic >= 140 || diastolic >= 90) return BloodPressureCategory.HypertensionStage2;
        if (systolic > 180 || diastolic > 120) return BloodPressureCategory.HypertensiveCrisis;
        return BloodPressureCategory.Unknown;
    }

    // BMI calculation
    public double CalculateBMI()
    {
        double heightInMeter = Height / 100;
        return Weight / (heightInMeter * heightInMeter);
    }

    // BMI status
    public BMICategory GetBMIStatus(double bmi)
    {
        if (bmi < 18.5) return BMICategory.Underweight;
        if (bmi >= 18.5 && bmi < 24.9) return BMICategory.Normal;
        return BMICategory.Overweight;
    }

    // Info printing
    public void PrintPatientInfo(int systolic, int diastolic)
    {
        Console.WriteLine($"Full Name: {FirstName} {LastName}");
        Console.WriteLine($"Age: {Age} years");
        Console.WriteLine($"Weight: {Weight} KG");
        Console.WriteLine($"Height: {Height} CM");
        Console.WriteLine($"Blood Pressure: {CalculateBloodPressure(systolic, diastolic)}");
        double bmi = CalculateBMI();
        Console.WriteLine($"BMI: {bmi}");
        Console.WriteLine($"BMI Status: {GetBMIStatus(bmi)}");
    }
}

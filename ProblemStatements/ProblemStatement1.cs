using System;

public class DataProcessor
{
    public int Operand;
    public double DecimalData;
    public string ConvertedInput;

    public void CalculateSum(int firstNumber, int secondNumber)
    {
        int sum = firstNumber + secondNumber;
        Console.WriteLine("Result: " + sum);
    }

    public void ConvertStringToUppercase(string input)
    {
        ConvertedInput = input.ToUpper();
        Console.WriteLine("Updated String: " + ConvertedInput);
    }
}

public class DataHandler
{
    public static void Main(string[] args)
    {
        DataProcessor dataProcessor = new DataProcessor();
        dataProcessor.Operand = 10;
        dataProcessor.DecimalData = 20.5;
        dataProcessor.ConvertedInput = "hello";

        dataProcessor.CalculateSum(dataProcessor.Operand, 5);
        dataProcessor.ConvertStringToUppercase("world");
    }
}
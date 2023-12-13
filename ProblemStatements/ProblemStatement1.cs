using System;

public class DataProcessor
{
    public int IntegerData;
    public double DecimalData;
    public string StringData;

    public void CalculateSum(int firstNumber, int secondNumber)
    {
        int sum = firstNumber + secondNumber;
        Console.WriteLine("Result: " + sum);
    }

    public void ConvertStringToUppercase(string input)
    {
        StringData = input.ToUpper();
        Console.WriteLine("Updated String: " + StringData);
    }
}

public class DataHandler
{
    public static void Main(string[] args)
    {
        DataProcessor dataProcessor = new DataProcessor();
        dataProcessor.IntegerData = 10;
        dataProcessor.DecimalData = 20.5;
        dataProcessor.StringData = "hello";

        dataProcessor.CalculateSum(dataProcessor.IntegerData, 5);
        dataProcessor.ConvertStringToUppercase("world");
    }
}
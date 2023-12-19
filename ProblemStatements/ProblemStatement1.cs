using System;

public class DataProcessor
{
    public int firstOperand;
    public double secondfirstOperand;
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
        dataProcessor.firstOperand = 10;
        dataProcessor.secondfirstOperand = 20.5;
        dataProcessor.ConvertedInput = "hello";

        dataProcessor.CalculateSum(dataProcessor.firstOperand, 5);
        dataProcessor.ConvertStringToUppercase("world");
    }
}
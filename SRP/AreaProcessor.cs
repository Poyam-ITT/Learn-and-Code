using System;

public class AreaProcessor
{
    private static double _area;

    public static void Main()
    {
        Rectangle rectangle = new Rectangle(5.0, 3.0);

        _area = CalculateArea(rectangle);
        WriteAreaToFile();
        PrintArea(_area);
    }

    private static double CalculateArea(Rectangle rectangle)
    {
        return rectangle.Length * rectangle.Width;
    }

    private static void PrintArea(double area)
    {
        Console.WriteLine("Area is: " + area);
    }

    private static void WriteAreaToFile()
    {
        try
        {
            File.WriteAllText("AreaDetails.txt", _area);
        }
        catch (IOException exception)
        {
            Console.WriteLine("Error writing to file: " + exception.Message);
        }
    }
}
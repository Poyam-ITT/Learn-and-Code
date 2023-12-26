using System;

public class AreaProcessor
{
    private static double Area;

    public static void Main()
    {
        Rectangle rectangle = new Rectangle(5.0, 3.0);

        Area = calculateArea(rectangle);
        writeAreaToFile();
        printArea(Area);
    }

    private static double calculateArea(Rectangle rectangle)
    {
        return rectangle.Length * rectangle.Width;
    }

    private static void printArea(double area)
    {
        Console.WriteLine("Area is: " + area);
    }

    private static void writeAreaToFile()
    {
        try
        {
            File.WriteAllText("AreaDetails.txt", Area);
        }
        catch (IOException exception)
        {
            Console.WriteLine("Error writing to file: " + exception.Message);
        }
    }
}
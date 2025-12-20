using GeometryGuru.Domain.Models;

namespace GeometryGuru.Application.Services;

public class RectangleService
{
    public double GetRectangleFromUser()
    {
        double width = GetValidDeminsion("width");
        double length = GetValidDeminsion("length");

        Rectangle rectangle = new Rectangle
        {
            RectangleWidth = width,
            RectangleLength = length
        };
        
        return RectangleArea(rectangle);
    }

    public double RectangleArea(Rectangle rectangle)
    {
        return rectangle.RectangleWidth * rectangle.RectangleLength;
    }

    public double GetValidDeminsion(string name)
    {
        double value = 0;
        bool isValid = false;

        while (!isValid)
        {
            Console.Write($"Enter {name}: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out value) && value > 0)
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine($"Try again, {name} must be a positive number!");
            }
        }
        return value;
    }
}

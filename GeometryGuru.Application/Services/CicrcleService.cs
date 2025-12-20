using GeometryGuru.Domain.Models;

namespace GeometryGuru.Application.Services;

public class CicrcleService
{
  
    public double CircleArea(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    public Circle GetCircleFromUser()
    {
        double radius = 0;
        bool isInValid = false;

        while (!isInValid)
        {
            Console.Write("Enter Radius:");
            string input = Console.ReadLine();

            if (double.TryParse(input, out radius))
            {
                if (radius > 0)
                {
                    isInValid = true;
                }
                else
                {
                    Console.WriteLine("Please, enter it again");
                }
            }
            else
            {
                Console.WriteLine("Please, enter number");
            }
        }
        return new Circle { CircleRadius = radius };
    }
}

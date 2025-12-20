using GeometryGuru.Domain.Models;

namespace GeometryGuru.Application.Services;

public class TriangleSidesService
{
    public TriangleSides GetTranglesFromUser()
    {
        var triangle = new TriangleSides();

        while (triangle.TrianglesSideOne <= 0)
        {
            Console.Write("Enter first side : ");
            double.TryParse(Console.ReadLine(), out double sideone);
            if (sideone > 0)
                triangle.TrianglesSideOne = sideone;
            else
                Console.WriteLine("Invelid input!, Enter it again");
        }
        while (triangle.TriangleSideTwo <= 0)
        {
            Console.Write("Enter second side :");
            double.TryParse(Console.ReadLine(), out double sidetwo);
            if (sidetwo > 0)
                triangle.TriangleSideTwo = sidetwo;
            else
                Console.WriteLine("Invalid input!, Enter it again"); 

        }
        return triangle;
    }
    public string PossibleThirdSide(TriangleSides triangleSide)
    {

        double min = Math.Abs(triangleSide.TrianglesSideOne - triangleSide.TriangleSideTwo);
        double max = triangleSide.TrianglesSideOne + triangleSide.TriangleSideTwo;

        return $"Third side must satisfy : {min} < x < {max} " ;
    }
}

using GeometryGuru.Application.Services;
using GeometryGuru.Domain.Models;

namespace GeometryGuru.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            RunApp();
        }

        static void RunApp()
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("\t\t=== GEOMETRY GURU ===");
                Console.WriteLine("1. Circle Area");
                Console.WriteLine("2. Rectangle Area");
                Console.WriteLine("3. Triangle Possible Third Side");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ShowCircle();
                        break;

                    case "2":
                        ShowRectangle();
                        break;

                    case "3":
                        ShowTriangle();
                        break;

                    case "4":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please select 1-4.");
                        Pause();
                        break;
                }
            }
        }

        static void Pause()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        static void ShowCircle()
        {
            var circleService = new CicrcleService();

            Circle circle = circleService.GetCircleFromUser();

            double Area = circleService.CircleArea(circle.CircleRadius);

            Console.WriteLine($"Circle area is: {Area}");
            Pause();
        }
        static void ShowRectangle()
        {
            var rectangleService = new RectangleService();

            double rectangleArea = rectangleService.GetRectangleFromUser();

            Console.WriteLine($"Rectangle area is: {rectangleArea}");

            Pause();
        }
        static void ShowTriangle()
        {
            var triangleService = new TriangleSidesService();

            var triangle = triangleService.GetTranglesFromUser();

            string result = triangleService.PossibleThirdSide(triangle);

            Console.WriteLine(result);
            Pause();
        }
    }
}

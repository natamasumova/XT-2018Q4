using System;

namespace Epam.Task2._7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Choose your shape: ");
                    Console.WriteLine($"1 - Line{Environment.NewLine}" +
                                      $"2 - Circle{Environment.NewLine}" +
                                      $"3 - Rectangle{Environment.NewLine}" +
                                      $"4 - Round{Environment.NewLine}" +
                                      $"5 - Ring");
                    int input = int.Parse(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            Console.WriteLine("Enter width: ");
                            double lineWidth = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter start X coordinate: ");
                            double startX = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter start Y coordinate: ");
                            double startY = double.Parse(Console.ReadLine());
                            
                            Console.WriteLine("Enter end X coordinate: ");
                            double endX = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter end Y coordinate: ");
                            double endY = double.Parse(Console.ReadLine());

                            Line line = new Line(lineWidth, startX, startY, endX, endY);
                            Console.WriteLine(line.ToString());
                            break;
                        case 2:
                            Console.WriteLine("Enter the X center coordinate: ");
                            double centerX = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the Y center coordinate: ");
                            double centerY = double.Parse(Console.ReadLine());

                            Console.WriteLine("Enter radius: ");
                            int circleRadius = int.Parse(Console.ReadLine());

                            Circle circle = new Circle(circleRadius, centerX, centerY);
                            Console.WriteLine(circle.ToString());
                            break;
                        case 3:
                            Console.WriteLine("Enter the X center coordinate: ");
                            centerX = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the Y center coordinate: ");
                            centerY = double.Parse(Console.ReadLine());

                            Console.WriteLine("Enter width: ");
                            int rectangleWidth = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter height: ");
                            int rectangleHeight = int.Parse(Console.ReadLine());

                            Rectangle rectangle = new Rectangle(rectangleWidth, rectangleHeight, centerX, centerY);
                            Console.WriteLine(rectangle.ToString());
                            break;
                        case 4:
                            Console.WriteLine("Enter the X center coordinate: ");
                            centerX = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the Y center coordinate: ");
                            centerY = double.Parse(Console.ReadLine());

                            Console.WriteLine("Enter radius: ");
                            int roundRadius = int.Parse(Console.ReadLine());

                            Round round = new Round(roundRadius, centerX, centerY);
                            Console.WriteLine(round.ToString());
                            break;
                        case 5:
                            Console.WriteLine("Enter the X center coordinate: ");
                            centerX = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the Y center coordinate: ");
                            centerY = double.Parse(Console.ReadLine());

                            Console.WriteLine("Enter ring radius: ");
                            int ringRadius = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter inner radius: ");
                            int innerRadius = int.Parse(Console.ReadLine());

                            Ring ring = new Ring(ringRadius, innerRadius, centerX, centerY);
                            Console.WriteLine(ring.ToString());
                            break;
                        default:
                            throw new Exception("Incorrect input! Try again, please");
                    }
                    Console.WriteLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrect input! Try again, please.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}

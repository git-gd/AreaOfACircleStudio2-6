using System;

namespace AreaOfACircleStudio2_6
{
    class Circle
    {
        public Circle(double radius)
        {
            Radius = radius;
            Diameter = radius * 2;
            Circumference = 2 * Math.PI * radius;
            Area = Math.PI * radius * radius;

        }

        public double Radius, Diameter, Circumference, Area;

    }

    class Program
    {
        static void Main(string[] args)
        {
            //  A = pi * r * r where pi is 3.14 and r is the radius.

            double radius, area, circumference, mpg, gallons, diameter;

            do
            {
                Console.WriteLine("Enter the radius (0 to exit):");
                try // can the input be parsed into a double?
                {
                    radius = double.Parse(Console.ReadLine());
                }
                catch // if not set radius to 0
                {
                    radius = -1;
                }
            } while (radius < 0); // loop while raidus is negative

            if (radius > 0) // if radius is > 0 continue, else end the program
            {
                area = Math.PI * radius * radius;

                Console.WriteLine("Area: " + area);

                circumference = 2 * Math.PI * radius;

                Console.WriteLine("Circumference: " + circumference);

                diameter = 2 * radius;

                Console.WriteLine($"Diameter = {diameter}");

                do
                {
                    Console.WriteLine("Enter the miles per gallon of your vehicle (0 to exit):");
                    try
                    {
                        mpg = double.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        mpg = -1;
                    }
                } while (mpg < 0);

                if (mpg > 0)
                {
                    gallons = circumference / mpg;

                    Console.WriteLine($"It will take {gallons} gallons of gas to travel {circumference} miles in your vehicle that gets {mpg} mpg.");
                }


                // use our Circle class

                Circle myCircle = new Circle(radius);

                Console.WriteLine($"The myCircle variable has a diameter of {myCircle.Diameter}, radius of {myCircle.Radius}, circumference of {myCircle.Circumference} and area of {myCircle.Area}");
            }
        }
    }
}

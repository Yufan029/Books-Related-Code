using System.Xml.Linq;

namespace Tuple
{
    internal class Program
    {
        // record can have behavior (method)
        public record Point(int X, int Y)
        {
            public double Slope() => (double)Y / (double)X;
        }

        static void Main(string[] args)
        {
            var pt = (X: 1, Y: 2);

            var slope = (double)pt.Y / (double)pt.X;
            Console.WriteLine($"A line from the origin to the point {pt} has a slope of {slope}.");
            // A line from the origin to the point (1, 2) has a slope of 2.

            pt.X = pt.X + 5;
            Console.WriteLine($"The point is now at {pt}.");
            // The point is now at (6, 2).

            var pt2 = pt with { Y = 10 };
            Console.WriteLine($"The point 'pt2' is at {pt2}.");
            // The point 'pt2' is at(6, 10).

            var subscript = (A: 0, B: 0);
            subscript = pt;
            Console.WriteLine(subscript);
            // (6, 2)

            var namedData = (Name: "Morning observation", Temp: 17, Wind: 4);
            var person = (FirstName: "", LastName: "");
            var order = (Product: "guitar picks", style: "triangle", quantity: 500, UnitPrice: 0.10m);

            // tuple has no behavior
            Console.WriteLine($"named data: {namedData}");
            Console.WriteLine($"Person: {person}");
            Console.WriteLine($"order: {order}");
            // named data: (Morning observation, 17, 4)
            // Person: (, )
            // order: (guitar picks, triangle, 500, 0.10)

            // this is record
            Point point = new Point(1, 1);
            var point2 = point with { Y = 10 };
            Console.WriteLine($"The two points are {point} and {point2}");
            // The two points are Point { X = 1, Y = 1 } and Point { X = 1, Y = 10 }

            double recordSlope = point.Slope();
            Console.WriteLine($"The slope of {point} is {recordSlope}");
            // The slope of Point { X = 1, Y = 1 } is 1
        }
    }
}

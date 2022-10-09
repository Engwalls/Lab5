using System;

namespace Lab5
{
    class Program                                          // Erik Engvall NET22
    {
        static void Main(string[] args)                                 
        {
            Circle Circle1 = new Circle(5);                             // Creating a new object
            Console.WriteLine("Arean är " + Circle1.GetArea());         // Typing out the area on the circle

            Circle Circle2 = new Circle(6);                             // Creating a new object
            Console.WriteLine("Arean är " + Circle2.GetArea());         // Typing out the area on the circle

            Console.WriteLine("Volymen är " + Circle1.GetVolume());     // Typing out the volume on the sphere
            Console.WriteLine("Volymen är " + Circle2.GetVolume());     // Typing out the volume on the sphere

            Console.WriteLine("Omkretsen är " + Circle1.GetOmkrets());  // Typing out the "Omkrets" on the circle
            Console.WriteLine("Omkretsen är " + Circle2.GetOmkrets());  // Typing out the "Omkrets" on the circle

            Triangle Triangle1 = new Triangle(5, 6);                    // Creating a new object
            Console.WriteLine("Arean är " + Triangle1.TriangleArea());  // Typing out the area on the triangle
        }
    }
}

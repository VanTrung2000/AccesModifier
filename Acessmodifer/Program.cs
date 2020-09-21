using System;

namespace Acessmodifer
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle ci1 = new Circle();
            ci1.setColor("red");
            ci1.setRadius(2.0);
            Console.WriteLine(ci1.getColor());
            Console.WriteLine(ci1.getRadius());
        }
    }
}

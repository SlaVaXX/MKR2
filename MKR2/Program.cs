using System;
using System.Numerics;

namespace MKR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sections section = new Sections(new Vector2(3,5), new Vector2(5,8));
            Console.WriteLine(section.GetAngle());
            Console.WriteLine(section.GetLineLength());
        }
    }
}
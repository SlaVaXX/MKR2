using System;
using System.Numerics;

namespace MKR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sections section = new Sections(new Vector2(0,0), new Vector2(0,10));
            Console.WriteLine(section.GetAngle());
            Console.WriteLine(section.GetLineLength());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine($"This motorcycle is drivin' baby!");
        }
        public bool HasSidecar { get; set; } = true;

        public override void DriveVirtual()
        {
            Console.WriteLine($"this {GetType().Name} is a {GetType().BaseType.Name} that is virtually driving!");
        }
    }
}

using System;
using Internal;

namespace RobotFactory
{
    public abstract class Robot
    {
        public string ModelName { get; set; } = "";
        public int BatteryCapacity { get; set; }
        public string SoftwareVersion { get; set; } = "";

        public abstract Robot Clone();

        public virtual void Display()
        {
            Console.WriteLine("Model Name: " + ModelName);
            Console.WriteLine("Battery Capacity: " + BatteryCapacity + " hours");
            Console.WriteLine("Software Version: " + SoftwareVersion);
        }
    }
}
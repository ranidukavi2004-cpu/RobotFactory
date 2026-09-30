using System;

namespace RobotFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== ROBOT FACTORY SYSTEM =====\n");

            // Original Service Robot
            ServiceRobot serviceRobot = new ServiceRobot
            {
                ModelName = "SR-100",
                BatteryCapacity = 12,
                SoftwareVersion = "1.0",
                ServiceTask = "Hospital Assistance"
            };

            Console.WriteLine("Original Service Robot");
            serviceRobot.Display();

            Console.WriteLine();

            // Clone Service Robot
            ServiceRobot clonedServiceRobot = (ServiceRobot)serviceRobot.Clone();
            clonedServiceRobot.BatteryCapacity = 15;
            clonedServiceRobot.SoftwareVersion = "1.1";

            Console.WriteLine("Cloned Service Robot");
            clonedServiceRobot.Display();

            Console.WriteLine("\n====================================\n");

            // Original Industrial Robot
            IndustrialRobot industrialRobot = new IndustrialRobot
            {
                ModelName = "IR-200",
                BatteryCapacity = 20,
                SoftwareVersion = "2.0",
                IndustrialTask = "Welding"
            };

            Console.WriteLine("Original Industrial Robot");
            industrialRobot.Display();

            Console.WriteLine();

            // Clone Industrial Robot
            IndustrialRobot clonedIndustrialRobot = (IndustrialRobot)industrialRobot.Clone();
            clonedIndustrialRobot.BatteryCapacity = 25;
            clonedIndustrialRobot.SoftwareVersion = "2.1";

            Console.WriteLine("Cloned Industrial Robot");
            clonedIndustrialRobot.Display();

            Console.WriteLine("\n====================================\n");

            // Original Entertainment Robot
            EntertainmentRobot entertainmentRobot = new EntertainmentRobot
            {
                ModelName = "ER-300",
                BatteryCapacity = 10,
                SoftwareVersion = "3.0",
                EntertainmentFeature = "Dance Performance"
            };

            Console.WriteLine("Original Entertainment Robot");
            entertainmentRobot.Display();

            Console.WriteLine();

            // Clone Entertainment Robot
            EntertainmentRobot clonedEntertainmentRobot = (EntertainmentRobot)entertainmentRobot.Clone();
            clonedEntertainmentRobot.BatteryCapacity = 14;
            clonedEntertainmentRobot.SoftwareVersion = "3.1";

            Console.WriteLine("Cloned Entertainment Robot");
            clonedEntertainmentRobot.Display();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
using System;


namespace RobotFactory
{
    public class IndustrialRobot : Robot
    {
        public string IndustrialTask { get; set; }

        public override Robot Clone()
        {
            return (Robot)this.MemberwiseClone();
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Industrial Task: " + IndustrialTask);
        }
    }
}
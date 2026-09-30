using System;


namespace RobotFactory
{
    public class ServiceRobot : Robot
    {
        public string ServiceTask { get; set; }

        public override Robot Clone()
        {
            return (Robot)this.MemberwiseClone();
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Service Task: " + ServiceTask);
        }
    }
}
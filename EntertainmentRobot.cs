using System;


namespace RobotFactory
{
    public class EntertainmentRobot : Robot
    {
        public string EntertainmentFeature { get; set; } = "";

        public override Robot Clone()
        {
            return (Robot)this.MemberwiseClone();
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Entertainment Feature: " + EntertainmentFeature);
        }
    }
}
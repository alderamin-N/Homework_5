namespace Homework_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var Quadcopter = new Quadcopter();
            Quadcopter.Charge();
            PrintGetRobotType(Quadcopter);
            IFlyingRobot Quadcopter2 = new Quadcopter();

        }
        static void PrintGetRobotType(IFlyingRobot robot)
        {
            Console.WriteLine(robot.GetRobotType());
        }
    }
}
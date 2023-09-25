using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    internal interface IFlyingRobot : IRobot
    {
        //Создать интерфейс IFlyingRobot как наследник IRobot с дефолтной реализацией GetRobotType(), возвращающей строку "I am a flying robot.".
        public string GetRobotType()
        {
            return "I am a flying robot.";
        }
    }
}

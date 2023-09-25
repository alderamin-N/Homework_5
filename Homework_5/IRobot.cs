using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    internal interface IRobot
    {
       // Создать интерфейс IRobot с публичным методами string GetInfo() и List GetComponents(), а также string GetRobotType() с дефолтной реализацией,
       // возвращающей значение "I am a simple robot.".
         public string GetInfo();
         public List<string> GetComponents();
         public string GetRobotType()
        { 
            return "I am a simple robot.";
        }


        
    }
}

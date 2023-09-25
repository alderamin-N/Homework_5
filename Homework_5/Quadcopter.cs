using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    internal class Quadcopter : IFlyingRobot, IChargeable
    {
        // Создать класс Quadcopter, наследующий IFlyingRobot и IChargeable.
        // В нём создать список компонентов List _components = new List { "rotor1", "rotor2", "rotor3", "rotor4" } и возвращать его из метода GetComponents().
        //Реализовать метод Charge() должен писать в консоль "Charging..." и через 3 секунды "Charged!". Ожидание в 3 секунды реализовать через Thread.Sleep(3000).

        private List<string> _components = new List<string> { "rotor1", "rotor2", "rotor3", "rotor4" };       

        public void Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charge!");
        }
        string IChargeable.GetInfo()
        {
            throw new NotImplementedException();
        }

        string IRobot.GetInfo()
        {
            throw new NotImplementedException();
        }
        public List<string> GetComponents()
        {
            return _components;
        }

    }
}

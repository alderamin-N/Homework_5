using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    internal interface IChargeable
    {
        //Создать интерфейс IChargeable с методами void Charge() и string GetInfo().
       public void Charge();
       public string GetInfo();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderOnline
{
    internal class ClassHelper
    {
        public static List<OrderClass> orders= new List<OrderClass>() 
        {
            new OrderClass(){ ImagePath = @"C:\Users\Game\source\repos\MDK0202\OrderOnline\example.jpg", Title = "Сосиски с сыром",Cost = 320},
            new OrderClass(){ Title = "Му-му",Cost = 3200},
            new OrderClass(){ Title = "Наушники",Cost = 11320},
        };
    }
}

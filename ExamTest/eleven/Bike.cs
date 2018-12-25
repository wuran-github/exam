using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTest.eleven
{
    public class Bike : Vehicle
    {
        public void Start(string str)
        {
            Console.WriteLine("这是Bike的Strat方法，" + str);
        }

        public void Stop(string str)
        {
            Console.WriteLine("这是Bike的Stop方法，" + str);
        }
    }
}

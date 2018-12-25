using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTest.eleven
{
    public class InterfaceDemo
    {
        public void _Main()
        {
            Vehicle v1 = new Bike();
            Vehicle v2 = new Bus();
            v1.Start("V1");
            v1.Stop("v1");
            v2.Start("v2");
            v2.Stop("v2");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTest.twelve
{
    public abstract class Door : IDoor
    {
        public void CloseDoor()
        {
            Console.WriteLine("{0}开门了", this.GetType().Name);
        }

        public void OpenDoor()
        {
            Console.WriteLine("{0}关门了", this.GetType().Name);
        }
        public abstract void Proof();
    }
}

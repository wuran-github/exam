using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamTest.eleven;
using ExamTest.twelve;
namespace ExamTest
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstPart firstPart = new FirstPart();
            firstPart.One();
            firstPart.Two();
            firstPart.Three();
            firstPart.Four();
            firstPart.Five();

            InterfaceDemo interfaceDemo = new InterfaceDemo();
            interfaceDemo._Main();

            Door door = new PlusDoor();
            door.OpenDoor();
            door.CloseDoor();
            door.Proof();


            Console.ReadKey();
        }
    }
}

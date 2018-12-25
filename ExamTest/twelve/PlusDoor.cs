using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTest.twelve
{
    public class PlusDoor : Door
    {
        public override void Proof()
        {
            BulletProof();
            FireProof();
        }
        private void BulletProof()
        {
            Console.WriteLine("防弹");
        }
        private void FireProof()
        {
            Console.WriteLine("防火");
        }
    }
}

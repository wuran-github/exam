using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTest
{
    public class SecondPart
    {
        public void Seven()
        {
            Console.WriteLine("Seven:");
            Console.Write("请输入a,b,c，用,隔开");
            string read = Console.ReadLine();
            var nums=read.Split(',');
            if (nums.Length == 3)
            {
                decimal a = decimal.Parse(nums[0]);
                decimal b = decimal.Parse(nums[1]);
                decimal c = decimal.Parse(nums[2]);
                decimal delta = (b * b - 4 * a * c);
                if (delta < 0)
                {
                    Console.WriteLine("该方程无实数根");
                }
                if (delta > 0)
                {
                    decimal temp = Convert.ToDecimal(Math.Sqrt(Convert.ToDouble(delta)));
                    decimal x1 = (-b + temp) /(2*a);
                    decimal x2 = (-b - temp) /(2*a);
                    Console.WriteLine("该方程有两个根，x1:{0},x2:{1}", x1, x2);
                }
                if (delta == 0)
                {
                    decimal x = -b / (2 * a);
                    Console.WriteLine("该方程有两个相等的根，x:{0}", x);
                }
            }
        }
    }
}

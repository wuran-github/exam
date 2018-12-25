using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTest
{
    public class FirstPart
    {
        public void One()
        {
            int sum = 0;
            for(int i = 1; i <= 200; i++)
            {
                string istr = i.ToString();

                if (istr[istr.Length - 1] == '5')
                {
                    sum += i;
                }
            }
            Console.WriteLine("One:" + sum);
        }
        public void Two()
        {
            int sum = 1;
            int num = 24;
            for(int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum *= i;
                }
            }
            Console.WriteLine("Two:" + sum);
        }
        public void Three()
        {
            Console.WriteLine("请输入一个字母");
            string read = Console.ReadLine();
            int span = 32;
            string result = string.Empty;
            //65-90 大写
            if (read[0]>=65 && read[0]<=90){

                //int num=read[0] + span;
                result=read.ToLower();
            }
            //97-122 xiaoxie
            else if (read[0] >= 97 && read[0] <= 122)
            {
                //int num=read[0] - span;
                result = read.ToUpper();
            }
            Console.WriteLine("three: input:{0},output:{1}", read, result);
        }
        public void Four()
        {
            Console.WriteLine("Four:");
            Console.WriteLine("请输入一个数字");
            string read = Console.ReadLine();
            double dnum = double.Parse(read);
            int len =Convert.ToInt32(Math.Sqrt(dnum));
            int num = Convert.ToInt32(dnum);
            bool isPN = true;
            int firstFactor = 0;

            for(int i = 2; i < len; i++)
            {
                if (num % i == 0)
                {
                    isPN = false;
                    firstFactor = i;
                    break;
                }
                
            }
            if (!isPN)
            {
                Console.WriteLine("该数字不是素数，第一个因子是{0}",firstFactor);
            }
            else
            {
                Console.WriteLine("该数字是素数");
            }
        }
        private int Cube(int num)
        {
            return num * num * num;
        }
        public void Five()
        {
            Console.WriteLine("Five:");
            int num = 1;
            for(int i = 100; i <= 999; i++)
            {
                int h = i / 100;
                int t = i % 100 / 10;
                int s = i% 10;
                if (i == (Cube(h) + Cube(t) + Cube(s)))
                {
                    Console.Write(i + " ");
                    num++;
                }
                if (num == 10)
                {
                    num = 1;
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
        public void Six()
        {
            Console.WriteLine("Six:");
            Console.WriteLine("请输入一个圆的直径");
            string read = Console.ReadLine();
            decimal d = decimal.Parse(read);
            decimal r = d / 2;
            decimal pai = 3.14m;

            Console.WriteLine("周长：{0},面积：{1}", pai * d, pai * r * r);
        }

    }
}

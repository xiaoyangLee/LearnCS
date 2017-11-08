using System;

namespace LearnCS
{
    //求阶乘
    class Factorial
    {
        //使用递归求解一个函数的阶乘。返回值需要为long类型，否则int长度不够存储阶乘后得到的结果。
        public static long factorial(int num)
        {
            if(num==1)
            {
                return 1;
            }
            else
            {
                return factorial(num - 1) * num;
            }
        }

        static void Main(string[] args)
        {
  
            Console.WriteLine("请输入一个整数:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("整数{0}的阶乘的值为{1}",n,factorial(n));
            for(int i = n;i>1;i--)
            {
                Console.Write("{0}x",i);
            }
            Console.Write("1 = {0}",factorial(n));
            Console.WriteLine();
        }
    }
}

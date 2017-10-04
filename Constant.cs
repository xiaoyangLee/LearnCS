using System;

namespace Constant
{
    class Constant
    {
        static void Main(string[] args)
        {
            //讲解常量
            //定义整数常量,后面可以加u和l，但是不能重复
            const long a = 0xFeel; //十六进制的long型整数常量
            const uint b = 215u;   //uint类型的整型常量b
            const int c = 076;     //八进制的整型常量c
            Console.WriteLine("{0}  {1}  {2}",a,b,c);
            //定义浮点数常量
            const double pi = 3.14159;       /* 合法 */
            const double pii = 314159E-5;   /* 合法 */
            Console.WriteLine("{0}  {1}",pi,pii);

            //定义字符串常量
            const string str1 = @"我是字符串常量，不带转义的\\";
            const string str2 = "\"我是要转义的\"";
            Console.WriteLine("{0}\n{1}",str1,str2);


            //计算圆的面积
            double r;
            Console.WriteLine("请输出圆的半径值:");
            r = Convert.ToDouble(Console.ReadLine());
            double area = pi * r * r;
            Console.WriteLine("圆的面积是:{0},半径是:{1}",area,r);

        }
    }
}

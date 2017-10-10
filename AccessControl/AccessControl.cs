using System;

namespace AccessControl
{
    //c#的封装
    class AccessControl
    {
        //public private protected 与java语言基本无异同
        //Internal：同一个程序集的对象可以访问；
        //Protected internal：该程序集内的派生类访问，是protected和internal的交集；
        internal double length;
        internal double width;

        //如果不加修饰符，默认是private
        double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("长度： {0}", length);
            Console.WriteLine("宽度： {0}", width);
            //这里可以使用private 修饰的GetArea()方法，因为是在同一个类中
            Console.WriteLine("面积： {0}", GetArea());
        }

    }
    class ExecuteAccessControl
    {
        static void Main(string[] args)
        {
            AccessControl ac = new AccessControl();
            Console.WriteLine("输入矩形的长度:");
            ac.length = double.Parse(Console.ReadLine());
            Console.WriteLine("输入矩形的宽度:");
            ac.width = double.Parse(Console.ReadLine());
            Console.WriteLine("在这个类中就无法使用AccessControl类中private修饰的GetArea()方法");
            ac.Display();
            
        }
    }
}

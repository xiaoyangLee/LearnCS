using System;


namespace LearnCS
{
    class Boxing
    {
        //装箱是指将一个值类型隐式或者显式地转换成一个object类型，或者转换成一个被该值类型应用的接口类型      
        static void Main(String[] args)
        {
            int i = 10;
            object obj = i; //隐式装箱
            //object obj1 = object(i); //显式装箱 (报错)
            object obj1 = (object)i;  //正确
            if (obj1 is int) //使用is可以判断原始类型是否是给定的原子类型(这里是int)
                Console.WriteLine("OK");
            Console.WriteLine(obj.GetType()); //System.Int32
        }
    }
    class unBoxing
    {
        //拆箱转换是指将一个对象类型显式地转换成一个值类型
        static void Main(String[] args)
        {
            int i = 10;
            object obj = i;
            int j = (int)obj;
        }
    }
}

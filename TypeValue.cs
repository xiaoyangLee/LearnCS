using System;

namespace TypeValue
{
    class TypeValue
    {
        String value = "我是属性value";
        int num;
        int count;
        public TypeValue()
        {
            Console.WriteLine("我是TypeValue的构造方法");
        }
    }
    public struct Typevalue
    {
        public char myChar1;
        public int myInt;
        public char myChar2;
    }

    class ExecuteTypeValue
    {
        static void Main(string[] args)
        {
            //C#中的整形类型：byte short int long sbyte(8位有符号) ushort uint ulong 
            byte a = 255; //byte类型值范围0~255
            short b = 32767; //short类型-32768到32767
            int c = 123456; // int 类型占4字节32位  -2^32~2^32-1
            long d = 123456789; // long类型8字节64位  -2^64~2^64-1

            double e = 3.141592654;  //double类型64位双精度浮点型
            float f =(float)3.141592754;  //float类型32位单精度浮点型,这里值只显示小数点后6位

            char g = 'a'; //char类型，只能用单引号输入一个字符

            string str = "这是字符串，是一种引用类型"; //字符串和类一样是一种引用类型
        

            Console.WriteLine("byte类型占的存储:{0} 字节,变量a的值为:{1}", sizeof(byte),a);
            Console.WriteLine("short类型占的存储:{0} 字节,变量b的值为:{1}", sizeof(short), b);
            Console.WriteLine("int类型占的存储:{0} 字节,变量c的值为:{1}", sizeof(int), c);
            Console.WriteLine("long类型占的存储:{0} 字节,变量d的值为:{1}", sizeof(long), d);

            Console.WriteLine("double类型占的存储:{0} 字节,变量e的值为:{1}", sizeof(double), e);
            Console.WriteLine("float类型占的存储:{0} 字节,变量f的值为:{1}", sizeof(float), f);

            Console.WriteLine("char类型占的存储:{0} 字节,变量g的值为:{1}", sizeof(char), g);
            Console.WriteLine("string类型占的存储:{0} 字节,变量str的值为:{1}", str.Length, str); //这里要用str对象的属性Length值，无法使用sizeof。

            TypeValue tv = new TypeValue(); //会执行构造方法
            Typevalue tve = new Typevalue(); //将Struct类型的实例化

            //想要成功使用这个，需要项目里勾选运行使用不安全代码
            unsafe
            {
                Console.WriteLine("Struct构造出的类所占的空间大小为:{0}",sizeof(Typevalue));
            }
            
          
        }
    }
}

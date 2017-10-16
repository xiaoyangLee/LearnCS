using System;

namespace LearnCS
{
    //C#函数参数的调用
    class FunctionArgs
    {
        //实参传递给形参，只是值的复制，并不影响到实参
        void SwapCp(int x,int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        //按引用传递参数，会影响到实参（拥有共同的内存地址）,ref用来声明引用参数
        void SwapQuote(ref int x,ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }

        //按输出参数传递，输出参数会把方法输出的数据赋给自己
        void OutArgs(out int x,out int y)
        {
            Console.WriteLine("请输入x的值:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入y的值:");
            y = Convert.ToInt32(Console.ReadLine());
        }

        static void Main(String[] args)
        {
            FunctionArgs fa = new FunctionArgs();
            int x1 = 12, y1 = 34;
            Console.WriteLine("实参传递形参不影响实参的值！");
            Console.WriteLine("交换之前的X值为:{0},Y的值为{1}",x1,y1);
            fa.SwapCp(x1, y1);
            Console.WriteLine("交换之后的X值为:{0},Y的值为{1}",x1,y1);

            int x2 = 12, y2 = 34;
            Console.WriteLine("按引用传递参数会改变实参的值！");
            Console.WriteLine("交换之前的X值为:{0},Y的值为{1}", x2, y2);
            fa.SwapQuote(ref x2, ref y2);
            Console.WriteLine("交换之后的X值为:{0},Y的值为{1}", x2, y2);

            int x3, y3;
            Console.WriteLine("x和y原本尚未赋值");
            fa.OutArgs(out x3, out y3);
            Console.WriteLine("按输出传递参数之后，X值为:{0},Y的值为{1}", x3, y3);


        }
    }
}

using System;

namespace RectangleApplication
{
    //创建Rectangle矩形类
    class Rectangle
    {
        //成员变量
        double width;
        double height;

        //为成员变量赋值，读入用户从键盘输入的值
        public void GetValue()
        {
            try
            {
                Console.WriteLine("请输入长方形的宽:");
                //将ReadLine读取到的字符串转为double类型
                this.width = double.Parse(Console.ReadLine());
                Console.WriteLine("长方形的宽度是:{0}", width);
                Console.WriteLine("请输入长方形的长:");

                this.height = double.Parse(Console.ReadLine());
                Console.WriteLine("长方形的长度是:{0}", height);
            }
            catch (Exception ex)
            {
                Console.WriteLine("请输入数字！");
            }

        }
        //计算面积
        public double GetArea()
        {
            return width * height;
        }
        //显示结果

        public void Display()
        {
            Console.WriteLine("此长方形的面积为：{0}", this.GetArea());
        }
         

    }

    class ExecuteRectangle
    {
         static void Main()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.GetValue();
            rectangle.Display();
           
        }
    }
}

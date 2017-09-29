using System;

namespace RectangleApplication
{   
    //创建Rectangle矩形类
    class Rectangle
    {
        //成员变量
        double width;
        double height;

        public void GetValue()
        {
            Console.WriteLine("请输入长方形的宽:");
            this.width = Console.Read();
            Console.WriteLine("长方形的宽度是:{0}", width);
            Console.WriteLine("请输入长方形的长:");
            this.height = Console.Read();
            Console.WriteLine("长方形的长度是:{0}",height);
        }



    }

    class ExecuteRectangle
    {
         static void Main()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.GetValue();
        }
    }
}

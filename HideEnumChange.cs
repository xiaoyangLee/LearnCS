using System;

namespace LearnCS
{
    //隐式枚举转换
    class HideEnumChange
    {
        enum Days
        {
            Sunday,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday
        }
        /*
         * 在C#中，隐式枚举转换允许把十进制整数0转换成任何枚举类型，而其他整数则不存在这种隐式转换
         */
       static void Main(String[] args)
        {
            Days currentDay;
            //currentDay = 1; //如果赋值为1则会报错
            currentDay = 0;
            Console.WriteLine(currentDay);
        }
    }
}

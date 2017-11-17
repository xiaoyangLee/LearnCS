using System;

namespace LearnCS
{
    class Foreach
    {
        static void Main(String[] args)
        {   
            //斐波那契数列
            int[] fibarray = new int[] { 0, 1, 2, 3, 5, 8, 13 };
            //使用foreach遍历数组
            foreach(int i in fibarray)
            {
                Console.Write("{0} ",i);
            }
            /*
             * foreach遍历集合,集合的类型应为interface，class或struct
             * 包括返回值类型为GetEnumerator的实例方法
             * Enumerator类型（类或者结构）
             */
            //foreach(ItemType item in myCollection)
        }
    }
}

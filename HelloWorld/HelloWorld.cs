using System;

/**
 * namespace命名空间，这里我的理解是如同java的package 
 */
namespace HelloWorldApplication
{   
    //CS无需类名与文件名同名
    class HelloWorldApp
    {
        static void Main(string[] args)
        {   
            //在命令行输出HelloWorld并换行
            Console.WriteLine("Hello World");
            //如果命令窗口一闪而过，那么久需要使用ReadKey()来保持窗口存在
            //Console.ReadKey();
        }
    }
}

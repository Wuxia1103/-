using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单计算器
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please input x,y and (+/-/*//)");
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string m = Console.ReadLine();
            switch (m)
            {
                case "+": { Console.WriteLine("输出的结果:{0}", Operation.jiafa(x, y)); } break;
                case "-": { Console.WriteLine("输出的结果为：{0}", Operation.Jiefa(x, y)); } break;
                    //case "*": Console.WriteLine("输出的结果为：{0}", Operation.chengfa(x, y)); break;
                    //case "/": Console.WriteLine("输出的结果为：{0}", Operation.chufa(x, y)); break;
            }
        }
    }
}

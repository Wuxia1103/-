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
            Console.WriteLine("please input x,y and (+/-/*/'/'/%/&)");

            string x = Console.ReadLine();
            int X = int.Parse(x);
      
            string y = Console.ReadLine();
            int Y = int.Parse(y);
            
            string m = Console.ReadLine();
            switch (m)
            {
                case "+": { Console.WriteLine("输出的结果:{0}", Operation.jiafa(X, Y)); } break;
                case "-": { Console.WriteLine("输出的结果为：{0}", Operation.jiefa(X, Y)); } break;
                case "*": Console.WriteLine("输出的结果为：{0}", Operation.chengfa(X, Y)); break;
                case "/": Console.WriteLine("输出的结果为：{0}", Operation.chufa(X, Y)); break;
                case "%": Console.WriteLine("输出的结果为：{0}", Operation.Quyu(X, Y)); break;
                case "&": Console.WriteLine("输出的结果为：{0}", Operation.Anwei(X, Y)); break;
            }
        }
    }
}

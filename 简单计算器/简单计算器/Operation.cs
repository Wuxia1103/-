using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单计算器
{
    class Operation
    {

        //public static int jiafa(int x, int y)
        //{
        //    return x + y;
        //}
        //public static int jiefa(int x, int y)
        //{
        //    return x - y;
        //}
        //public static int chengfa(int x, int y)
        //{
        //    return x * y;
        //}
        //public static int chufa(int x, int y)
        //{
        //    return x / y;
        //}
        public static string jiafa(string x, string y)
        {
            string m;
            m = x + y;
            StringBuilder MyStringBuilder = new StringBuilder();
            MyStringBuilder.Append(x);
            MyStringBuilder.Append(y);
            m = MyStringBuilder.ToString();
            return m;
        }
        public static string Jiefa(string x, string y)
        {
            string r = null;
            // string source1 = "abscd";
            // string source2 = "asd";
            char[] ss = x.ToCharArray();
            char[] bb = y.ToCharArray();
            List<char> L = new List<char>();
            for (int k = 0; k < ss.Length; k++)
            {
                L.Add(ss[k]);
            }
            for (int i = 0; i < bb.Length; i++)
            {
                for (int j = 0; j < ss.Length; j++)
                {
                    if (bb[i] == ss[j])
                    {
                        L.Remove(ss[j]);
                    }
                }
            }

            foreach (char c in L)
            {
                r = r + c;
            }
            return r;
        }
    }
}

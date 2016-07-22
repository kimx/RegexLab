using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegexLab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Begin");
            TestReplaceSymbol();
            Console.WriteLine("End");
            Console.ReadLine();
        }

        private static void TestReplaceSymbol()
        {
            string value = "#Column#_#Test#";

            Console.WriteLine("TestReplaceSymbol-Begin");
            string fixdeValue = value;
            if (fixdeValue.StartsWith("#"))
                fixdeValue = "@@@@@" + fixdeValue;
            string[] values = fixdeValue.Split(new string[] { "#" }, StringSplitOptions.RemoveEmptyEntries);
            List<string> list = new List<string>();
            for (int i = 0; i < values.Length; i++)
            {
                if (i % 2 == 0)
                    continue;

                var t = string.Format("#{0}#", values[i]);
                if (list.IndexOf(t) > -1)
                    continue;
                list.Add(t);
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("TestReplaceSymbol-End");
        }


    }
}

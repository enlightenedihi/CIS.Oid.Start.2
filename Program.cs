using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS.Oid.Start._2
{
    static class Program
    {
        private static string DNA =
        "using System;" +
        "namespace Oid" +
        "{" +
        "    class Program" +
        "    {" +
        "        static void Main(string[] args)" +
        "        {" +
        "        }" +
        "    }" +
        "}";

        private static void Main(string[] args)
        {
            Console.WriteLine(DNA);

            //  ANALYZE & MODIFICATION
            ////////////////////////////////////

            //  change signature class
            int position = DNA.IndexOf("class");
            DNA = DNA.Insert(position - 1, "private");

            Console.ReadLine();
        }
    }
}

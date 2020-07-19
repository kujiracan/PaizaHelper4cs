using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;

namespace Net.Kujiracan.Paiza.Common
{
    public class PaizaHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="assemblyName"></param>
        /// <param name="tryNum"></param>
        /// <param name="inputString"></param>
        public static void Exec(string type, string assemblyName, int tryNum, string inputString)
        {
            Console.WriteLine(">>> exec {0}.Main", type);
            Console.WriteLine("args:");
            Console.WriteLine(inputString);
            Type t = Type.GetType(type + "," + assemblyName);
            MethodInfo m = t.GetMethod("Main");
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < tryNum; i++)
            {
                Console.WriteLine(">>> start");
                Console.SetIn(new StringReader(inputString));
                m.Invoke(null, null);
            }
            sw.Stop();
            Console.WriteLine(">>> done {0} times in {1}ms.", tryNum, sw.ElapsedMilliseconds);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="assemblyName"></param>
        /// <param name="tryNum"></param>
        /// <param name="filePath"></param>
        public static void Exec2(string type, string assemblyName, int tryNum, string filePath)
        {
            using (System.IO.StreamReader sr = new System.IO.StreamReader(filePath))
            {
                Exec(type, assemblyName, tryNum, sr.ReadToEnd());
            }
        }
    }
}

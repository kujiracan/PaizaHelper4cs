using Net.Kujiracan.Paiza.Common;
using System;

namespace Com.Example.Paiza.Sample
{
    public class EntryPoint
    {
        public static void Main(string[] args)
        {
            PaizaHelper.Exec("Com.Example.Paiza.Sample.Sample1", "Sample", 1, "1 2\naaaa\nbbbb");
            PaizaHelper.Exec2("Com.Example.Paiza.Sample.Sample1", "Sample", 1, @"D:\data.txt");
        }
    }
}

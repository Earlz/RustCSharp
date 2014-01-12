using System;
using System.Runtime.InteropServices;

namespace RustCsharpTest
{
    class MainClass
    {
        [DllImport ("libtest.so")]
        private static extern void foorust();
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World C#!");
            foorust();
            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }
}

using System;
using System.Runtime.InteropServices;

namespace RustCsharpTest
{
    static class RustExports
    {
        [DllImport ("libtest.so")]
        public static extern void foorust();
        [DllImport("libtest.so")]
        public static extern int rust_add(int op1, int op2);

    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World C#!");
            RustExports.foorust();
            Console.WriteLine("10+5000={0}", RustExports.rust_add(10, 5000));
            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }
}

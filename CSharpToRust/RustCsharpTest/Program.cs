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
        [DllImport("libtest.so")]
        public static extern int rust_strings([MarshalAs(UnmanagedType.LPStr)] string str);
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World C#!");
            RustExports.foorust();
            Console.WriteLine("10+5000={0}", RustExports.rust_add(10, 5000));
            Console.WriteLine("rust_strings: {0}", RustExports.rust_strings("foobar!"));
            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }
}

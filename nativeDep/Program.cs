using System;
using System.Runtime.InteropServices;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SNIInitialize(IntPtr.Zero);
        }

        [DllImport("sni.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern uint SNIInitialize([In] IntPtr pmo);
    }
}

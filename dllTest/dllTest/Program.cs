using System;
using System.Runtime.InteropServices;

namespace dllTest
{
    class Program
    {
        [DllImport("User32.Dll")]
        public static extern int MessageBox(int h, string m, string c, int type);
        static void Main(string[] args)
        {
            MessageBox(0, "heool!!!!!!!!", "In C#######", 0);
        }
    }
}

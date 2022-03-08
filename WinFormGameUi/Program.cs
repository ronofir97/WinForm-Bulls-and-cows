using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinFormGameUi
{
    public static class Program
    {
        public static void Main()
        {
           Run();
        }

        public static void Run()
        {
            Start start = new Start();
            start.ShowDialog();
        }
    }
}

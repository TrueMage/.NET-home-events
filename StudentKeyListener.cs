using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace home_Events
{
    internal class StudentKeyListener
    {
        public delegate void Del(ConsoleKeyInfo key);
        public event Del onKey;
        public void Listen()
        {
            while (true)
            {
                var key = Console.ReadKey();
                onKey(key);
            }
        }
    }
}

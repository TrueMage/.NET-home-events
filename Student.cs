using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_Events
{
    internal class Student
    {
        private string _status;

        public void HandleKey(ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.Escape:
                    Sleep();
                    break;

                case ConsoleKey.Enter:
                    Select();
                    break;

                case ConsoleKey.F1:
                    PrintStatus();
                    break;
                case ConsoleKey.Spacebar:
                    Jump();
                    break;

                case ConsoleKey.DownArrow:
                case ConsoleKey.UpArrow:
                case ConsoleKey.LeftArrow: 
                case ConsoleKey.RightArrow:
                    Move();
                    break;
            }
        }

        public void Jump()
        {
            _status = "The student is jumping";
            Console.WriteLine("The student is jumping");
        }

        public void Select()
        {
            Console.WriteLine("The student is selected");
        }

        public void Sleep()
        {
            _status = "The student is sleeping";
            Console.WriteLine("The student is sleeping");
        }

        public void Move()
        {
            _status = "The student is on the move";
            Console.WriteLine("The student is moving");
        }

        public void PrintStatus()
        {
            Console.WriteLine(_status);
        }
    }
}

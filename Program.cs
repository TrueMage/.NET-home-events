using System.Runtime.InteropServices;

namespace home_Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentKeyListener listener = new StudentKeyListener();
            Student student = new Student();

            listener.onKey += student.HandleKey;

            listener.Listen();
        }
    }
}
using Timer = System.Timers.Timer;

namespace DotNet_Timer
{
    internal class Program
    {
        private static readonly Timer _timer = new() { Interval = 100 };
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Press ENTER to quit...");


            _timer.Elapsed += PrintTime;
            _timer.Start();

            Console.ReadLine();
        }

        private static void PrintTime(object? sender, System.Timers.ElapsedEventArgs e)
        {
            Console.SetCursorPosition(0, 2);
            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }
    }
}

//Using delegates write a class Timer that has can execute certain method at each t seconds.

using System;
using System.Threading;

class Timers
{
    public static void PrintOut(object state)
    {
        Console.WriteLine(DateTime.Now);
    }

    static void Main()
    {
        TimerCallback callback = new TimerCallback(PrintOut);
        Timer newTimer = new Timer(callback, "ops, it did it again", 0, 500);

        //Press any key to end the program.
        Console.ReadKey(true);
    }
}
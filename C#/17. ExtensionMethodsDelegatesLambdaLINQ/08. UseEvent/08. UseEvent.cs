//* Read in MSDN about the keyword event in C# and how to publish events. 
//Re-implement the above using .NET events and following the best practices.


using System;
using System.Linq;
using System.Timers;

//Seriously, why the hell I'd use this bunch of code to do the same thing as in problem 7?
public delegate void CallBack();

public class TimeEventHandler
{
    public CallBack ToInvokeMethod;
    private Timer time = new Timer();

    public void Start(int ticks)
    {
        time.Elapsed += new ElapsedEventHandler(ActionEvent);
        time.Interval = ticks;
        time.Enabled = true;
    }

    public void ActionEvent(object sourse, ElapsedEventArgs e)
    {
        ToInvokeMethod.Invoke();
    }
}

class TestCallBack
{
    private static TimeEventHandler invoke;

    static void Call()
    {
        invoke = new TimeEventHandler();
        invoke.ToInvokeMethod += delegate { Console.WriteLine(DateTime.Now); };
        invoke.Start(500);
    }

    static void Main()
    {
        Call();
        Console.Read();
    }
}
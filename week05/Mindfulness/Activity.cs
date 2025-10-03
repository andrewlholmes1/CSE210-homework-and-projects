abstract class Activity
{
    protected int duration;

    public void Run()
    {
        Console.Clear();
        DisplayStartMessage();
        Console.Write("Enter duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        PerformActivity();
        DisplayEndMessage();
        ShowSpinner(3);
    }

    protected abstract void PerformActivity();

    protected void DisplayStartMessage()
    {
        Console.WriteLine($"Starting {GetType().Name}...");
    }

    protected void DisplayEndMessage()
    {
        Console.WriteLine($"Well done! You completed {duration} seconds of {GetType().Name}.");
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
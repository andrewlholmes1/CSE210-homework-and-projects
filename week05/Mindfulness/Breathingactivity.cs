class BreathingActivity : Activity
{
    protected override void PerformActivity()
    {
        int cycles = duration / 10;
        for (int i = 0; i < cycles; i++)
        {
            Console.Write("Breathe in... ");
            Countdown(4);
            Console.Write("Breathe out... ");
            Countdown(6);
            Console.WriteLine();
        }
    }
}
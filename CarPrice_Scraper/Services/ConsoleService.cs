
using CarPrice_Scraper.Services.Interfaces;

public class ConsoleService : IConsoleService
{
    private Timer? timer;
    private readonly object lockObject = new object();

    public ConsoleService()
    {
        timer = new Timer(ShowMessage, null, Timeout.Infinite, Timeout.Infinite);
    }

    public void Start()
    {
        lock (lockObject)
        {
            timer?.Change(TimeSpan.Zero, TimeSpan.FromSeconds(30));
            if (timer == null || timer.Equals(null))
            {
                //Start of the timer
                timer = new Timer(ShowMessage, null, TimeSpan.Zero, TimeSpan.FromSeconds(30));
            }
        }
    }

    public void Stop()
    {
        lock (lockObject)
        {
            timer?.Change(Timeout.Infinite, Timeout.Infinite);
        }
    }

    public bool IsRunning
    {
        get
        {
            lock (lockObject)
            {
                return timer != null;
            }
        }
    }

    private void ShowMessage(object? state)
    {
        Console.WriteLine("API is running...");
    }
}

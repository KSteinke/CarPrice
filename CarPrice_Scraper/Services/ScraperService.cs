public class ScraperService : IHostedService, IDisposable
{
    private Timer _timer;

    public Task StartAsync(CancellationToken cancellationToken)
    {
        // Uruchomienie timera, który wykona się co dzień o konkretnej godzinie
        DateTime now = DateTime.Now;
        DateTime scheduledTime = new DateTime(now.Year, now.Month, now.Day, 3, 0, 0); // Przykładowa godzina: 3:00 AM

        if (now > scheduledTime)
        {
            scheduledTime = scheduledTime.AddDays(1); // Jeśli już minęła wyznaczona godzina, przesuń na kolejny dzień
        }

        int millisecondsUntilScheduledTime = (int)(scheduledTime - now).TotalMilliseconds;

        _timer = new Timer(DoWork, null, millisecondsUntilScheduledTime, (int)TimeSpan.FromDays(1).TotalMilliseconds);

        return Task.CompletedTask;
    }

    private void DoWork(object state)
    {
        // Tutaj umieść kod, który ma być wykonywany raz dziennie

        Console.WriteLine("Wykonywanie pracy w tle...");

        // Możesz dodać swoją logikę biznesową lub wywołać inny serwis API itp.
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _timer?.Change(Timeout.Infinite, 0);

        return Task.CompletedTask;
    }

    public void Dispose()
    {
        _timer?.Dispose();
    }
}
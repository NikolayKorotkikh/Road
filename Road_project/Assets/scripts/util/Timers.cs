using System.Timers;

/// <summary>
/// 
/// </summary>
public class Timers {
    private bool _elapse;
    private Timer _timer;

    public void StartTimer (int interval) {
        _elapse = false;
        _timer = new Timer();
        _timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
        _timer.Interval += interval;
	}

    public bool Elapse
    {
        get { return _elapse; }
    }

    private void OnTimedEvent(object source, ElapsedEventArgs e)
    {
        _elapse = true;
        _timer.Stop();
    }
}

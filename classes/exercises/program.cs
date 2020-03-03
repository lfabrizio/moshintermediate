// Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should provide two methods: Start and Stop. We call the start method ﬁrst, and the stop method next. Then we ask the stopwatch about the duration between start and stop. Duration should be a value in TimeSpan. Display the duration on the console. We should also be able to use a stopwatch multiple times. So we may start and stop it and then start and stop it again. Make sure the duration value each time is calculated properly. We should not be able to start a stopwatch twice in a row (because that may overwrite the initial start time). So the class should throw an InvalidOperationException if its started twice. 

using System;

public class Stopwatch
{

private DateTime = _startDate;
private DateTime = _endDate;
private bool = _isRunning;

public void Start()
{
    if(_isRunning)
    throw new InvalidOperationException("Stopwatch is running");
    _startDate = DateTime.Now;
    _isRunning = true;
}

public void Stop()
{
    if(!_isRunning)
    throw new InvalidOperationException("Stopwatch is not running");
    _endDate = DateTime.Now;
    _isRunning = false;
}

public TimeSpan GetDuration()
{
return _endDate - _startDate;
}
}
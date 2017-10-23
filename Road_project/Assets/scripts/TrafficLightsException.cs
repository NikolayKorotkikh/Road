using System;

/// <summary>
/// 
/// </summary>
public class TrafficLightsException : Exception {

    public TrafficLightsException() { }
    public TrafficLightsException(string message)
        : base(message)
    { }
}

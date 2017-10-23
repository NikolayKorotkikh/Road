using System;
using System.Collections.Generic;

/// <summary>
/// 
/// </summary>
public class СrossRoads {
    private List<Svetofor> crossRoad;
    private int countTrafficLights;

    public СrossRoads(int countTrafficLights) {
        crossRoad = new List<Svetofor>();
        this.countTrafficLights = countTrafficLights;
    }

    public int CountTrafficLights
    {
        get { return countTrafficLights; }
    }

    public List<Svetofor> CrossRoad
    {
        get { return crossRoad; }
    }

    public void AddTrafficLight(Svetofor trafficLight)
    {
        if (crossRoad.Count == countTrafficLights)
            throw new TrafficLightsException("We don't add new traffic light");
        if (trafficLight == null)
            throw new NullReferenceException();
        crossRoad.Add(trafficLight);
    }

    public void AddTrafficLights(List<Svetofor> trafficLights)
    {
        if (countTrafficLights - crossRoad.Count < trafficLights.Count)
            throw new TrafficLightsException("We don't add new range traffic lights");
        if (trafficLights == null)
            throw new NullReferenceException();
        crossRoad.AddRange(trafficLights);
    }
}

using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class СrossRoads {

    private static int _countСrossRoads = 0;
    private int _id;
    private byte _countTrafficLights;
    private byte _countCars;
    private byte _countPeople;

    public List<TrafficLight> trafficLights;

    public СrossRoads(byte _countTrafficLights) {
        _id = _countСrossRoads;
        _countСrossRoads++;
        trafficLights = new List<TrafficLight>();
        this._countTrafficLights = _countTrafficLights;
    }

    public int Id
    {
        get { return _id; }
    }

    public byte CountTrafficLights
    {
        get { return _countTrafficLights; }
    }

    public byte CountCars
    {
        get { return _countCars; }
        set { _countCars = value; }
    }

    public byte CountPeople
    {
        get { return _countPeople; }
        set { _countPeople = value; }
    }

    public void AddTrafficLight(TrafficLight trafficLight)
    {
        if (trafficLights.Count == _countTrafficLights)
            throw new TrafficLightsException("We don't add new traffic light");
        if (trafficLight == null)
            throw new NullReferenceException();
        trafficLights.Add(trafficLight);
    }

    public void AddTrafficLights(List<TrafficLight> trafficLights)
    {
        if (_countTrafficLights - trafficLights.Count < trafficLights.Count)
            throw new TrafficLightsException("We don't add new range traffic lights");
        if (trafficLights == null)
            throw new NullReferenceException();
        trafficLights.AddRange(trafficLights);
    }

    public override string ToString()
    {
        return "ID: " + _id.ToString() + ", Count traffic lights: " + _countTrafficLights +
               ", Count cars: " + _countCars + ", Count people: " + _countPeople;
    }
}

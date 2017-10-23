using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopLine : MonoBehaviour {

    //ссылка на свой светофор
    public TrafficLight sv;

    public LightsEnum _signalCar;
    public LightsEnum _signalHum;

    void Start()
    {
        _signalCar = sv.signalCar;
        _signalHum = sv.signalHum;
    }

    void Update()
    {
        
    }
}

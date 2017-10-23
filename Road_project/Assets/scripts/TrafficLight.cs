using UnityEngine;
using System;

[Serializable]
public class TrafficLight : MonoBehaviour {

    public LightsEnum signalCar = LightsEnum.Red;
    public LightsEnum signalHum = LightsEnum.Green;

    [SerializeField]
    Collider StopLineCar;
    [SerializeField]
    Collider StopLineHum;

    void Start ()
    {
        signalCar = LightsEnum.Red;
        signalHum = LightsEnum.Green;
	}
}

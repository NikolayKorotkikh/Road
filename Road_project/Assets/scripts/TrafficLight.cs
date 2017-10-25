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
    [SerializeField]
    Light RedLightCar;
    [SerializeField]
    Light YellowLightCar;
    [SerializeField]
    Light GreenLightCar;
    [SerializeField]
    Light RedLightHum;
    [SerializeField]
    Light GreenLightHum;

    void Start ()
    {
        signalCar = LightsEnum.Red;
        signalHum = LightsEnum.Green;
	}

    void Update()
    {

        //установка освещения светофора для машин, в зависиости от значения сигнала в нем
        if (signalCar == LightsEnum.Red)//красный
        {
            RedLightCar.GetComponent<Light>().enabled = true;
            YellowLightCar.GetComponent<Light>().enabled = false;
            GreenLightCar.GetComponent<Light>().enabled = false;
        }
        if (signalCar == LightsEnum.Yellow)//желтый
        {
            RedLightCar.GetComponent<Light>().enabled = false;
            YellowLightCar.GetComponent<Light>().enabled = true;
            GreenLightCar.GetComponent<Light>().enabled = false;
        }
        if (signalCar == LightsEnum.Green)//зеленый
        {
            RedLightCar.GetComponent<Light>().enabled = false;
            YellowLightCar.GetComponent<Light>().enabled = false;
            GreenLightCar.GetComponent<Light>().enabled = true;
        }


        //установка сигнала светофора для пешеходов, в зависимости от значения сигнала в нем
        if (signalHum == LightsEnum.Red)//красный
        {
            RedLightHum.GetComponent<Light>().enabled = true;
            GreenLightHum.GetComponent<Light>().enabled = false;
        }
        if (signalHum == LightsEnum.Green)//зеленый
        {
            RedLightHum.GetComponent<Light>().enabled = false;
            GreenLightHum.GetComponent<Light>().enabled = true;
        }
        // Debug.Log(name+"сигнал: "+ signalHum);
    }
}

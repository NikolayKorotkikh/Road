using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Svetofor : MonoBehaviour {

    public enum signalcar : byte
    {
        red,
        yellow,
        green
    }
    public enum signalhum : byte
    {
        red,
        green
    }

    [SerializeField]
    public signalcar signalCar;
    [SerializeField]
    public signalhum signalHum;

    [SerializeField]
    Collider StopLineCar;
    [SerializeField]
    Collider StopLineHum;

    //указываем ссылки на экземпляры источников света
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

    // Use this for initialization
    void Start ()
    {
        signalCar=signalcar.red;
        signalHum = signalhum.green;
    }


    void Update()
    {

        //установка освещения светофора для машин, в зависиости от значения сигнала в нем
        if (signalCar == signalcar.red)//красный
        {
            RedLightCar.GetComponent<Light>().enabled = true;
            YellowLightCar.GetComponent<Light>().enabled = false;
            GreenLightCar.GetComponent<Light>().enabled = false;
        }
        if (signalCar==signalcar.yellow)//желтый
        {
            RedLightCar.GetComponent<Light>().enabled = false;
            YellowLightCar.GetComponent<Light>().enabled = true;
            GreenLightCar.GetComponent<Light>().enabled = false;
        }
        if (signalCar ==signalcar.green)//зеленый
        {
            RedLightCar.GetComponent<Light>().enabled = false;
            YellowLightCar.GetComponent<Light>().enabled = false;
            GreenLightCar.GetComponent<Light>().enabled = true;
        }


        //установка сигнала светофора для пешеходов, в зависимости от значения сигнала в нем
        if (signalHum == signalhum.red)//красный
        {
            RedLightHum.GetComponent<Light>().enabled = true;
            GreenLightHum.GetComponent<Light>().enabled = false;
        }
        if (signalHum == signalhum.green)//зеленый
        {
            RedLightHum.GetComponent<Light>().enabled = false;
            GreenLightHum.GetComponent<Light>().enabled = true;
        }
       // Debug.Log(name+"сигнал: "+ signalHum);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Svetofor : MonoBehaviour {


    [SerializeField]
    public byte signalCar;
    [SerializeField]
    public byte signalHum;
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
        signalCar = 1;
        signalHum = 3;
    }


    void Update()
    {

        //установка освещения светофора для машин, в зависиости от значения сигнала в нем
        if (signalCar == 1)//красный
        {
            RedLightCar.GetComponent<Light>().enabled = true;
            YellowLightCar.GetComponent<Light>().enabled = false;
            GreenLightCar.GetComponent<Light>().enabled = false;
        }
        if (signalCar==2)//желтый
        {
            RedLightCar.GetComponent<Light>().enabled = false;
            YellowLightCar.GetComponent<Light>().enabled = true;
            GreenLightCar.GetComponent<Light>().enabled = false;
        }
        if (signalCar == 3)//зеленый
        {
            RedLightCar.GetComponent<Light>().enabled = false;
            YellowLightCar.GetComponent<Light>().enabled = false;
            GreenLightCar.GetComponent<Light>().enabled = true;
        }


        //установка сигнала светофора для пешеходов, в зависимости от значения сигнала в нем
        if (signalHum == 1)//красный
        {
            RedLightHum.GetComponent<Light>().enabled = true;
            GreenLightHum.GetComponent<Light>().enabled = false;
        }
        if (signalHum == 3)//зеленый
        {
            RedLightHum.GetComponent<Light>().enabled = false;
            GreenLightHum.GetComponent<Light>().enabled = true;
        }
       // Debug.Log(name+"сигнал: "+ signalHum);
    }
}

using UnityEngine;
using System;

[Serializable]
public class TrafficLight : MonoBehaviour {

<<<<<<< HEAD:Road_project/Assets/scripts/TrafficLight.cs
    public LightsEnum signalCar = LightsEnum.Red;
    public LightsEnum signalHum = LightsEnum.Green;

    [SerializeField]
=======
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
>>>>>>> upstream/master:Road_project/Assets/scripts/Svetofor.cs
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
<<<<<<< HEAD:Road_project/Assets/scripts/TrafficLight.cs
        signalCar = LightsEnum.Red;
        signalHum = LightsEnum.Green;
	}
=======
        signalCar=signalcar.red;
        signalHum = signalhum.green;
    }

>>>>>>> upstream/master:Road_project/Assets/scripts/Svetofor.cs

    void Update()
    {

        //установка освещения светофора для машин, в зависиости от значения сигнала в нем
<<<<<<< HEAD:Road_project/Assets/scripts/TrafficLight.cs
        if (signalCar == LightsEnum.Red)//красный
=======
        if (signalCar == signalcar.red)//красный
>>>>>>> upstream/master:Road_project/Assets/scripts/Svetofor.cs
        {
            RedLightCar.GetComponent<Light>().enabled = true;
            YellowLightCar.GetComponent<Light>().enabled = false;
            GreenLightCar.GetComponent<Light>().enabled = false;
        }
<<<<<<< HEAD:Road_project/Assets/scripts/TrafficLight.cs
        if (signalCar == LightsEnum.Yellow)//желтый
=======
        if (signalCar==signalcar.yellow)//желтый
>>>>>>> upstream/master:Road_project/Assets/scripts/Svetofor.cs
        {
            RedLightCar.GetComponent<Light>().enabled = false;
            YellowLightCar.GetComponent<Light>().enabled = true;
            GreenLightCar.GetComponent<Light>().enabled = false;
        }
<<<<<<< HEAD:Road_project/Assets/scripts/TrafficLight.cs
        if (signalCar == LightsEnum.Green)//зеленый
=======
        if (signalCar ==signalcar.green)//зеленый
>>>>>>> upstream/master:Road_project/Assets/scripts/Svetofor.cs
        {
            RedLightCar.GetComponent<Light>().enabled = false;
            YellowLightCar.GetComponent<Light>().enabled = false;
            GreenLightCar.GetComponent<Light>().enabled = true;
        }


        //установка сигнала светофора для пешеходов, в зависимости от значения сигнала в нем
<<<<<<< HEAD:Road_project/Assets/scripts/TrafficLight.cs
        if (signalHum == LightsEnum.Red)//красный
=======
        if (signalHum == signalhum.red)//красный
>>>>>>> upstream/master:Road_project/Assets/scripts/Svetofor.cs
        {
            RedLightHum.GetComponent<Light>().enabled = true;
            GreenLightHum.GetComponent<Light>().enabled = false;
        }
<<<<<<< HEAD:Road_project/Assets/scripts/TrafficLight.cs
        if (signalHum == LightsEnum.Green)//зеленый
=======
        if (signalHum == signalhum.green)//зеленый
>>>>>>> upstream/master:Road_project/Assets/scripts/Svetofor.cs
        {
            RedLightHum.GetComponent<Light>().enabled = false;
            GreenLightHum.GetComponent<Light>().enabled = true;
        }
        // Debug.Log(name+"сигнал: "+ signalHum);
    }
}

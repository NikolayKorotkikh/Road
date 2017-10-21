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

    // Use this for initialization
    void Start ()
    {
        signalCar = 1;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //установка значений для пешеходного светофора на основе машинного
        //1-красный, 2-желтый, 3-зеленый
        if (signalCar == 1) { signalHum = 3; }
        else if (signalCar == 2 || signalCar == 3) { signalHum = 1; }
        else { signalHum = 1; Debug.Log("Подан неверный сигнал для светофора!"); }
	}
}

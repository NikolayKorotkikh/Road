using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCar : MonoBehaviour {

    [SerializeField]
    public byte CountCar;
	// Update is called once per frame
    
    void OnTriggerEnter(Collider collider)
    {
        Car car = collider.GetComponent<Car>();
        if (car)
        {
            CountCar++;
            Debug.Log("машина попала в зону подсчета, сейчас их " + CountCar);
        }
    }

    void OnTriggerExit(Collider collider)
    {
        Car car = collider.GetComponent<Car>();
        if (car)
        {
            CountCar--;
            Debug.Log("машина вышла из зоны подсчета, сейчас их " + CountCar);
        }
    }
}

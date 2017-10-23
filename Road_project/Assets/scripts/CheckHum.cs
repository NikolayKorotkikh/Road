using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckHum : MonoBehaviour {

    [SerializeField]
    public byte CountHum;
    // Update is called once per frame

    void OnTriggerEnter(Collider collider)
    {
        Human hum = collider.GetComponent<Human>();
        if (hum)
        {
            CountHum++;
            //Debug.Log(collider.name + " попал в зону подсчета пешеходов, сейчас их " + CountHum);
        }
    }

    void OnTriggerExit(Collider collider)
    {
        Human hum = collider.GetComponent<Human>();
        if (hum)
        {
            CountHum--;
            //Debug.Log(collider.name + " вышел из зоны подсчета пешеходов, сейчас их " + CountHum);
        }
    }
}

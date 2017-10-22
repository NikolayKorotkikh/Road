using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopLine : MonoBehaviour {

    //ссылка на свой светофор
    [SerializeField]
    Svetofor sv;

    public byte _signalCar;
    public byte _signalHum;
    
    void Update()
    {
        _signalCar = sv.signalCar;
        _signalHum = sv.signalHum;
    }

}

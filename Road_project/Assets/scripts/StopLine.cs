using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopLine : MonoBehaviour {

    //ссылка на свой светофор
    [SerializeField]
    Svetofor sv;

    public Svetofor.signalcar _signalCar;
    public Svetofor.signalhum _signalHum;
    
    void Update()
    {
        _signalCar = sv.signalCar;
        _signalHum = sv.signalHum;
    }

}

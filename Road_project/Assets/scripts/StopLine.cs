using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopLine : MonoBehaviour {

    //ссылка на свой светофор
    public TrafficLight sv;

<<<<<<< HEAD
    public LightsEnum _signalCar;
    public LightsEnum _signalHum;

    void Start()
=======
    public Svetofor.signalcar _signalCar;
    public Svetofor.signalhum _signalHum;
    
    void Update()
>>>>>>> upstream/master
    {
        _signalCar = sv.signalCar;
        _signalHum = sv.signalHum;
    }

    void Update()
    {
        
    }
}

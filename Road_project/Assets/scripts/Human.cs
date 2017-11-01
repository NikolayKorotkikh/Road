﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour {

    public float speed;
    private Vector3 movement; //движение
    public Rigidbody rb;
    public Vector3 napravlenie;
    float tempspeed;

    void Start()
    {
        speed = 4.0F;
        tempspeed = speed;
        napravlenie = new Vector3(0, 0, 1);
        rb = GetComponent<Rigidbody>();
    }

    void Update()//перемещение
    {
        movement = new Vector3(0, 0, speed * napravlenie.z);//будем двигаться только по оси z
    }

    void FixedUpdate()
    {
        //применить движение к rigitbody
        rb.velocity = movement;
    }

    private void OnTriggerStay(Collider collider)
    {
        StopLine stop = collider.GetComponent<StopLine>();
<<<<<<< HEAD
        if (stop && stop._signalHum == LightsEnum.Red) //при красном сигнале скорость=0
        {
            speed = 0;
            Debug.Log("красный для " + collider.name);

        }

        if (stop && stop._signalHum == LightsEnum.Green)//при зеленом сигнале восстанавливается начальная скорость
=======
        if (stop && (stop._signalHum == Svetofor.signalhum.red)) //при красном сигнале скорость=0
        {
            speed = 0;
            // Debug.Log("красный или желтый для " + collider.name);
        }

        if (stop && stop._signalHum == Svetofor.signalhum.green)//при зеленом сигнале восстанавливается начальная скорость
>>>>>>> upstream/master
        {
            speed = tempspeed;
            //Debug.Log("зеленый для " + collider.name);
        }
    }
}


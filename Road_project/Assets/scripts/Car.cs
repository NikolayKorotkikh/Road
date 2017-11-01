﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {

    public float speed;
    private Vector3 movement; //движение
    public Rigidbody rb;
    public Vector3 napravlenie;
    public float tempspeed;


    void Start()
    {
        //speed = 8.0F;
        //tempspeed = speed;
        //napravlenie = new Vector3(1, 0, 0);
        rb = GetComponent<Rigidbody>();
    }

    void Update()//перемещение
    {
        movement = new Vector3(speed * napravlenie.x, 0, 0);//будем двигаться только по оси х
    }

    void FixedUpdate()
    {
        //применить движение к rigitbody
        rb.velocity = movement;
    }

    private void OnTriggerStay(Collider collider)
    {
        StopLine stop = collider.GetComponent<StopLine>();
        Car car = collider.GetComponent<Car>();
        if (car||stop && (stop._signalCar==Svetofor.signalcar.red||stop._signalCar==Svetofor.signalcar.yellow)) //при красном или желтом сигнале скорость=0
        {
            speed = 0;
           //Debug.Log("красный или желтый для " + collider.name);
        }

        if (stop && stop._signalCar == Svetofor.signalcar.green)//при зеленом сигнале восстанавливается начальная скорость
        {
            speed = tempspeed;
           // Debug.Log("зеленый для " + collider.name);
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("Collided with " + collision.gameObject.name);
    //    Car car = collision.collider.GetComponent<Car>();
    //    if (car)
    //    {
    //        speed=0;
    //    }
    //}

}

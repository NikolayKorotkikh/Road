using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {


    public float speed;
    private Vector3 movement; //движение
    public Rigidbody rb;
    public Vector3 napravlenie;
    float tempspeed;

    void Start()
    {
    speed = 8.0F;
    tempspeed = speed;
    napravlenie = new Vector3(1, 0, 0);
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
        if (stop && stop._signalCar==1) //при красном или желтом сигнале скорость=0
        {
            speed = 0;
            Debug.Log("остановился, потому что красный или желтый");
        }

        if (stop && stop._signalCar == 3)//при зеленом сигнале восстанавливается начальная скорость
        {
            speed = tempspeed;
            Debug.Log("поехал, потому что сигнал изменился на зеленый");
        }
    }
}

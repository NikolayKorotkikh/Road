using System.Collections;
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
        if (stop && stop._signalHum == 1) //при красном сигнале скорость=0
        {
            speed = 0;
            Debug.Log("остановился, потому что красный или желтый");
        }

        if (stop && stop._signalHum == 3)//при зеленом сигнале восстанавливается начальная скорость
        {
            speed = tempspeed;
            Debug.Log("поехал, потому что сигнал изменился на зеленый");
        }
    }
}

using System.Collections;
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
        //napravlenie = new Vector3(1,0,0);
        rb = GetComponent<Rigidbody>();
        
    }

    void Update()//перемещение
    {
        movement = new Vector3(speed * napravlenie.x, 0, 0);//будем двигаться только по оси х
        //Debug.Log(movement);
    }

    void FixedUpdate()
    {
        //применить движение к rigitbody
        rb.velocity = movement;
    }

    private void OnTriggerStay(Collider collider)
    {
        StopLine stop = collider.GetComponent<StopLine>();
        Svetofor svetofor = collider.GetComponent<Svetofor>();
        if ((collider.GetComponent<Car>()) || (stop && (stop._signalCar==Svetofor.signalcar.red||stop._signalCar==Svetofor.signalcar.yellow))) //при красном или желтом сигнале скорость=0
        {
            speed = 0;
        }
        else if ((stop && stop._signalCar == Svetofor.signalcar.green))//при зеленом сигнале восстанавливается начальная скорость
        {
            speed = tempspeed;
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        speed = tempspeed;
      //  Debug.Log("едет " + speed);
    }


}

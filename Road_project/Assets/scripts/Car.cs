using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {


    public float speed;
    private Vector3 movement; //движение
    public Rigidbody rb;
    public Vector3 napravlenie;

    void Start()
    {
    speed = 1.0F;
    napravlenie = new Vector3(1, 0, 0);
    rb = GetComponent<Rigidbody>();
    }
	
	void Update ()//перемещение
    {
        movement = new Vector3(speed*napravlenie.x,0,0);//будем двигаться только по оси х
	}

    void FixedUpdate()
    {
        //применить движение к rigitbody
        rb.velocity = movement;
    }
}

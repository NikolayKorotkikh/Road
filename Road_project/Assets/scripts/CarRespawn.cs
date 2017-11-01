using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarRespawn : MonoBehaviour {


    float time;//счетчик времени
    float savetime;
    System.Random rnd = new System.Random();
    int RndTime;//время в промежутках между генерацией, будет высчитываьбтся рандомно
    float RndSpeed;
    [SerializeField]
    Vector3 GenNapr;
    [SerializeField]
    Car Carclone;

    void Start()
    {
        RndTime = 0;
        savetime = 0;
    }

    void Update()
    {   //обновление времени
        time = Time.time;
        //Debug.Log(time);
        //если текущее время равно последнему сохраненному времени + генерированное случайное число, то создать экземпляр машинки с заданными параметрами
        if (time >= RndTime + savetime)
        {
            CreateCar();
            RndTime = rnd.Next(1, 5);
            savetime = time;
            Debug.Log("через "+RndTime+" секунд поедет следующая машинка");
            Debug.Log("сохраненное время"+time);
        }
    }

    void CreateCar()
    {
        Debug.Log("создаю машинку");
        Instantiate(Carclone);
        RndSpeed = rnd.Next(5, 15);
        Debug.Log("скорость машинки: "+RndSpeed);
        Carclone.speed = RndSpeed;
        Carclone.tempspeed = Carclone.speed;
        Carclone.napravlenie = GenNapr;
    }

}
	


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SvetoforManager : MonoBehaviour {



    [SerializeField]
    Svetofor svetofor1;
    [SerializeField]
    Svetofor svetofor2;
    [SerializeField]
    CheckCar checkcar1;
    [SerializeField]
    CheckCar checkcar2;
    [SerializeField]
    CheckHum checkhum1;
    [SerializeField]
    CheckHum checkhum2;

    //общие данные сигналов светофоров для данного перекрестка
    [SerializeField]
    byte signalcar;
    [SerializeField]
    byte signalhum;

    //обобщенные данные количества машин и людей со всех светофоров
    [SerializeField]
    int countcar;
    [SerializeField]
    int counhum;


    // Use this for initialization
    void Start ()
    {
        signalcar = 1;
        signalhum = 3;
    }
	
	private void Update ()
    {
        //установка значений светофорам для машин 
        svetofor1.signalCar = signalcar;
        svetofor2.signalCar = signalcar;
        //подсчет общего количества машин и людей на светофорах
        countcar= checkcar1.CountCar + checkcar2.CountCar;
        counhum = checkhum1.CountHum + checkhum2.CountHum;


        //установка значений для пешеходного светофора на основе машинного
        //1-красный, 2-желтый, 3-зеленый
        if (signalcar == 1) { signalhum = 3; }
        else if (signalcar == 2 || signalcar == 3) { signalhum = 1; }
        else { signalhum = 1; Debug.Log("Подан неверный сигнал для светофора!"); }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SvetoforManagerScript : MonoBehaviour {



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
    Svetofor.signalcar signalcar;
    [SerializeField]
    Svetofor.signalhum signalhum;

    //обобщенные данные количества машин и людей со всех светофоров
    [SerializeField]
    int countcar;
    [SerializeField]
    int counhum;


    // Use this for initialization
    void Start ()
    {
        signalcar = Svetofor.signalcar.red;
        signalhum = Svetofor.signalhum.green;
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
        if (signalcar == Svetofor.signalcar.red) { signalhum = Svetofor.signalhum.green; }
        else if (signalcar == Svetofor.signalcar.yellow || signalcar==Svetofor.signalcar.green) { signalhum = Svetofor.signalhum.red; }

        //передача сигналов пешеходного светофора в светофоры
        svetofor1.signalHum = signalhum;
        svetofor2.signalHum = signalhum;
    }
}

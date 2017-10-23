using UnityEngine;

/// <summary>
/// 
/// </summary>
public class TrafficLightManager : MonoBehaviour {

    public byte countTrafficLights = 2;
    public TrafficLight trafficLightLeft;
    public TrafficLight trafficLightRight;
    public CheckCar checkCarLeft;
    public CheckCar checkCarRight;
    public CheckHum checkPeopleLeft;
    public CheckHum checkPeopleRight;

    private СrossRoads _crossRoads;
    private int _countCar;
    private int _countPeople;
    private LightsEnum _lightCar;
    private LightsEnum _lightPeople;

    void Start()
    {
        Initialize();
    }

    void Update()
    {
        SetLigths();
        CalcCountCarsAndPeople();
    }

    private void Initialize()
    {
        _countCar = 0;
        _countPeople = 0;
        _lightCar = LightsEnum.Red;
        _lightPeople = LightsEnum.Green;
        _crossRoads = new СrossRoads(countTrafficLights);
        _crossRoads.AddTrafficLight(trafficLightLeft);
        _crossRoads.AddTrafficLight(trafficLightRight);
    }

    private void SetLigths()
    {
        //установка значений светофорам для машин 
        trafficLightLeft.signalCar = _lightCar;
        trafficLightRight.signalCar = _lightCar;

        //установка значений для пешеходного светофора на основе машинного
        if (_lightCar == LightsEnum.Red)
            _lightPeople = LightsEnum.Green;
        else if (_lightCar == LightsEnum.Yellow || _lightCar == LightsEnum.Green)
            _lightPeople = LightsEnum.Red;
        else
        {
            _lightPeople = LightsEnum.Red;
            Debug.Log("Подан неверный сигнал для светофора!");
        }
    }

    private void CalcCountCarsAndPeople()
    {
        //подсчет общего количества машин и людей на светофорах
        _countCar = checkCarLeft.CountCar + checkCarRight.CountCar;
        _countPeople = checkPeopleLeft.CountHum + checkPeopleRight.CountHum;
    }
}

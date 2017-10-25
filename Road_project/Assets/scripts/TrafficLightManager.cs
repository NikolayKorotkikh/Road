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
    public CrossRoad _crossRoad;

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
        _lightCar = LightsEnum.Red;
        _lightPeople = LightsEnum.Green;
        _crossRoad.AddTrafficLight(trafficLightLeft);
        _crossRoad.AddTrafficLight(trafficLightRight);
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
        trafficLightLeft.signalHum = _lightPeople;
        trafficLightRight.signalHum = _lightPeople;
    }

    private void CalcCountCarsAndPeople()
    {
        //подсчет общего количества машин и людей на светофорах
        _crossRoad.CountCars = (byte)(checkCarLeft.CountCar + checkCarRight.CountCar);
        _crossRoad.CountPeople = (byte)(checkPeopleLeft.CountHum + checkPeopleRight.CountHum);
    }
}

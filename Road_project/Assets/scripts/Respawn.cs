using System.Collections.Generic;

/// <summary>
/// 
/// </summary>
public class Respawn {

    private Queue<Car> _queueCars;
    private Timers timer;
    private int _time;

    public Respawn(int _time) {
        _queueCars = new Queue<Car>();
        timer = new Timers();
        this._time = _time;
    }

    public int Time
    {
        get { return _time; }
        set { Time = value; }
    }

    public int QueueCarsLength {
        get { return _queueCars.Count; }
    }

    public void Push(Car car) {
        _queueCars.Enqueue(car);
    }

    public void Push(List<Car> cars)
    {
        foreach(Car car in cars)
            _queueCars.Enqueue(car);
    }

    public Car Pop() {
        timer.StartTimer(_time);
        while (!timer.Elapse) { }
        return _queueCars.Dequeue();
    }
}

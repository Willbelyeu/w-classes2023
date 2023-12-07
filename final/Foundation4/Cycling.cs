public class Cycling:Activity{
    private double _speed;
    public Cycling(string date, double speed, double timeSpent, string activity):base(date, timeSpent, activity){
        _speed=speed;
        _pace=GetPace();
    }
    public override double GetPace(){
        double pace= _timeSpent/GetDistance();
        return pace;
    }
    public override double GetDistance(){
        double distance=_speed*_timeSpent/60;
        return distance;
    }
    public override double GetSpeed(){
        double speed= 60/_pace;
        return speed;
    }
}
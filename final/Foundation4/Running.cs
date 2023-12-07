using System.IO.Pipes;
using System.Reflection.Metadata.Ecma335;

public class Running:Activity{
    private double _speed;
    public Running(string date, double speed, double timeSpent, string activity):base(date, timeSpent, activity){
        _speed=speed;
        _pace=GetPace();
    }
    //decimaltostring
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
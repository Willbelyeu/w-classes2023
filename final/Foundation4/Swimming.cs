public class Swimming:Activity{
    private double _swimmingLaps; 
    public Swimming(string date, double timeSpent, double swimmingLaps, string activity):base(date, timeSpent, activity){
        _swimmingLaps=swimmingLaps;
        _pace=GetPace();
    }
    public override double GetPace(){
        double pace= 60/GetSpeed();
        return pace;
    }
    public override double GetSpeed(){
        double speed= GetDistance()/_timeSpent*60;
        return speed;
    }
    public override double GetDistance(){
        double distance=_swimmingLaps * 50 / 1000 * 0.62;
        return distance;
    }
}
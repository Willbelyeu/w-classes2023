public class Activity{
    protected string _date;
    protected double _timeSpent;
    protected string _activityType;
    protected double _pace;
    public Activity(string date, double timeSpent, string activityType){
        _date=date;
        _timeSpent=timeSpent;
        _activityType=activityType;
        _pace=GetPace();
    }
    public virtual double GetPace(){
        double pace= _timeSpent/GetDistance();
        return pace;
    }
    public virtual double GetDistance(){
        double distance=_timeSpent*GetSpeed();
        return distance;
    }
    public virtual double GetSpeed(){
        double speed= 60/_pace;
        return speed;
    }
    public string GetSummary(){
        string summary=$"{_date} {_activityType} ({_timeSpent} min)- Distance {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {(GetPace()).ToString("#.##")} min per mile";
        return summary;
    }
}
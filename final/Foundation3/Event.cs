using System.Reflection;

public class Event{
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    public Event(string title, string description, string date, string time, Address address){
        _eventTitle=title;
        _description=description;
        _date=date;
        _time=time;
        _address=address;
    }

    public string StandardDetails(){
        string details=$"   {_eventTitle} {_description} {_date} {_time} Meeting address {_address.MeetingAddress()}";
        return details;
    }
}

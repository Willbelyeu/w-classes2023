public class OutDoorGathering:Event{
    private string _weather;

    public OutDoorGathering(string weather, string title, string description, string date, string time, Address address):base(title, description, date, time, address){
        _eventTitle=title;
        _description=description;
        _date=date;
        _time=time;
        _address=address;
        _weather=weather;
    }
        public string FullDetails(){
        string detailsFull=$"{  _eventTitle} {_description}. This event will be held on {_date} at {_time} The address is {_address.MeetingAddress()}. For this outdoor activity, expect {_weather} weather.";
        return detailsFull;        
    }
    public string ShortDescription(){
        string detailsShort=$"  Outdoor gathering for {_eventTitle} on {_date}.";
        return detailsShort;        
    }
}
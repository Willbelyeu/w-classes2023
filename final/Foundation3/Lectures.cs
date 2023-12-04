public class Lecture:Event{
    private string _speaker;
    private int _maxCapacity;
    public Lecture(string speaker, int maxCapacity, string title, string description, string date, string time, Address address):base(title, description, date, time, address){
        _eventTitle=title;
        _description=description;
        _date=date;
        _time=time;
        _address=address;
        _speaker=speaker;
        _maxCapacity=maxCapacity;
    }
    public string FullDetails(){
        string detailsFull=$"   {_eventTitle}. {_description}. This event will be held on {_date} at {_time}, at {_address.MeetingAddress()}. Lecture by {_speaker} with seating for {_maxCapacity}.";
        return detailsFull;        
    }
    public string ShortDescription(){
        string detailsShort=$"  {_eventTitle} on {_date}.";
        return detailsShort;        
    }
}
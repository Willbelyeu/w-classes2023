public class Reception:Event{
    private string _email;
    public Reception(string email, string title, string description, string date, string time, Address address):base(title, description, date, time, address){
        _eventTitle=title;
        _description=description;
        _date=date;
        _time=time;
        _address=address;
        _email=email;
    }
    public string FullDetails(){
        string detailsFull=$"   {_eventTitle}. {_description}. This event will be held on {_date} at {_time}, at {_address.MeetingAddress()}. To reserve a seat reach out to us at {_email}.";
        return detailsFull;        
    }
    public string ShortDescription(){
        string detailsShort=$"  {_eventTitle} on {_date}.";
        return detailsShort;        
    }
}
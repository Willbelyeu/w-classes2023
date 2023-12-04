public class Address{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvance;
    private string _country;
    public Address(string streetAddress, string city, string state, string country){
        _streetAddress=streetAddress;
        _city=city;
        _stateOrProvance=state;
        _country=country;
    }
    public string MeetingAddress(){
        string meetingAddress=$"{_streetAddress} {_city} {_stateOrProvance} {_country}";
        return meetingAddress;
    }
}
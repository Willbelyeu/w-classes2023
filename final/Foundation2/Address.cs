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
    public string UserAddress(){
        string userAddress=$"{_streetAddress} {_city} {_stateOrProvance} {_country}";
        return userAddress;
    }
    public bool inAmerica(){
        bool inUS;
        if (_country=="America"){
            inUS=true;
        }
        else{
            inUS=false;
        }
        return inUS;
    }
}
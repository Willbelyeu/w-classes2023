public class Customer{
    private string _name;
    private Address _address;
    public Customer(string name, string streetAddress, string city, string stateOrProvance, string country){
        _name=name;
        Address address=new Address(streetAddress, city, stateOrProvance, country);
        _address=address;
    }
    public string getName(){
        return _name;
    }
    public bool inAmerica(){
        bool isInAmerica;
        isInAmerica=_address.inAmerica();
        return isInAmerica;
    }
    public Address getAddress(){
        return _address;
    }
}
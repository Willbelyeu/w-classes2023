using System.Security.Cryptography.X509Certificates;

public class Order{
    private Customer _customer;
    private List<Product> _orderList=new List<Product>();
    public Order(Customer customer, List<Product> orderList){
        _customer=customer;
        _orderList=orderList;
    }
    public double FinalPrice(){
        double totalSum=0.00;
        foreach(var product in _orderList){
            totalSum+=(product.PriceGetter()*product.QuantityGetter());
        }
        //call customer and see if the address is in the states.
        bool inStates;
        inStates=_customer.inAmerica();
        if (inStates==true){
        totalSum+=5;    
        }
        else{
        totalSum+=35;   
        }
        return totalSum;
    }
    public string PackingLabel(){
        string productLabel = "";
        foreach(var product in _orderList)
        {
            productLabel += $" {product.NameGetter()} {product.IDGetter()}";
        }
        return productLabel;
    }
    public string ShippingLabel(){
        Address newAddress=_customer.getAddress();
        string customerAddress=newAddress.UserAddress();
        string shippingAddress = $"{_customer.getName()} {customerAddress}";
        return shippingAddress;
    }
}
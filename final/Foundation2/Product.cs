public class Product{
    private string _name;
    private string _productID;
    private double _price;
    private int _quantity;
    public Product(string name, string productID, double price, int quantity){
        _name=name;
        _productID=productID;
        _price=price;
        _quantity=quantity;
    }
    public double PriceGetter(){
        return _price;
    }
    public double QuantityGetter(){
        return _quantity;
    }
    public string NameGetter(){
        return _name;
    }
    public string IDGetter(){
        return _productID;
    }
}
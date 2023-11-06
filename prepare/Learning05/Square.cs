using System.Drawing;
using System.Formats.Asn1;

class Square:Shape{
    private int _side;
    public Square(string color, int side):base(color){
        _color=color;
        _side=side;
    }
    public override double GetArea(){
        double area=_side*_side;
        return area;
    }
}
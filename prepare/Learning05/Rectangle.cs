using System.Drawing;
using System.Formats.Asn1;

class Rectangle:Shape{
    private int _side;
    private int _topSide;
    public Rectangle(string color, int side, int topSide):base(color){
        _color=color;
        _side=side;
        _topSide=topSide;
    }
    public override double GetArea(){
        double area=_side*_topSide;
        return area;
    }
}
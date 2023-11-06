using System.Drawing;
using System.Formats.Asn1;

class Circle:Shape{
    private int _radius;
    public Circle(string color, int radius):base(color){
        _color=color;
        _radius=radius;
    }
    public override double GetArea(){
        double area=_radius*_radius*3.14;
        return area;
    }
}
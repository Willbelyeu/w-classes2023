using System.Reflection.Metadata.Ecma335;

public class Fraction{
    private int _numerator;
    private int _denominator;
    public Fraction(){
        _numerator=1;
        _denominator=1;
    }
    public Fraction(int enteredNumber){
        _numerator=enteredNumber;
        _denominator=1;
    }
    public Fraction(int enteredNumberTop, int enteredNumberBottom){
        _numerator=enteredNumberTop;
        _denominator=enteredNumberBottom;
    }
    public string GetFractionString(){
        string fractionDisplayed=$"{_numerator}/{_denominator}";
        return fractionDisplayed;
    }
    public double GetDecimalValue(){
        //what is a double? Is it different than a float?
        return (double)_numerator/(double)_denominator;
    }
}
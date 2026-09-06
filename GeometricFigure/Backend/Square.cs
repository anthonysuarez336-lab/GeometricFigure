namespace Backend;

public class Square : GeometricFigure
{
    //Fields
    private double _a;

    //Constructors

    public Square(string name, double a) : base(name)
    {
        A = a;
    }

    //Properties
    public double A 
    { 
        get => _a; 
        set => _a = ValidateA(value);
    }

    //Public Methods

    public override double GetArea() => A * A;
    public override double GetPerimeter() => 4 * A;
  

    //Private Methods
    private double ValidateA(double a)
    {
        if (a <= 0)
        {
            throw new Exception($"The Side {a} is not valid.");
        }
        return a;
    }

}







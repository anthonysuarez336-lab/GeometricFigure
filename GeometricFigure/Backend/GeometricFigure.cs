namespace Backend;

public abstract class GeometricFigure
{
      
//Properties
    public string Name { get; set; } = null!;


//Public Methods
    
    public abstract double GetArea();
    public abstract double GetPerimeter();
    public override string ToString()
    {
        return Name;
    }
}   


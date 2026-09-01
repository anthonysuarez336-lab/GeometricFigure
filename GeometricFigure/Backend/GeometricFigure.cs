namespace Backend;

public abstract class GeometricFigure
{
      
//Properties
    public string Name { get; set; } = null!;


//Public Methods
    
    public abstract decimal GetArea();
    public abstract decimal GetPerimeter();
    public override string ToString()
    {
        return Name;
    }
}   


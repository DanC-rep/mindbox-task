namespace FiguresAreas;

public class Circle : IFigure
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if (!IsValidCircle(radius))
            throw new ArgumentException("Radius of circle is wrong.");
        
        Radius = radius;
    }

    private bool IsValidCircle(double radius) => radius >= Constants.Epsilon;
    
    
    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}
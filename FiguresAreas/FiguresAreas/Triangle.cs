namespace FiguresAreas;

public class Triangle : IFigure
{
    public double A { get; }
        
    public double B { get; }
        
    public double C { get; }
    
    public bool IsRightTriangle { get; }

    public Triangle(double a, double b, double c)
    {
        CheckTriangleIsValid(a, b, c);
        
        A = a;
        B = b;
        C = c;

        IsRightTriangle = GetIsRightTriangle();
    }

    private void CheckTriangleIsValid(double a, double b, double c)
    {
        if (a < Constants.Epsilon)
            throw new ArgumentException("Side is indicated incorrectly.", nameof(a));
        
        if (b < Constants.Epsilon)
            throw new ArgumentException("Side is indicated incorrectly.", nameof(b));
        
        if (c < Constants.Epsilon)
            throw new ArgumentException("Side is indicated incorrectly.", nameof(c));

        if (a + b < c || a + c < b || b + c < a)
            throw new ArgumentException("The largest side must be less than the sum of other 2");
    }

    private bool GetIsRightTriangle()
    {
        var maxSide = A;
        var b = B;
        var c = C;

        if (b - maxSide > Constants.Epsilon)
            (maxSide, b) = (b, maxSide);

        if (c - maxSide > Constants.Epsilon)
            (maxSide, c) = (c, maxSide);

        return Math.Abs(Math.Pow(maxSide, 2) - Math.Pow(b, 2) - Math.Pow(c, 2)) < Constants.Epsilon;
    }
    
    public double CalculateArea()
    {
        var perimeter = A + B + C;
        var halfPerimeter = perimeter / 2;

        return Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
    }
}
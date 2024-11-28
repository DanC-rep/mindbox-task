using FiguresAreas;
using FluentAssertions;

namespace UnitTests;

public class TriangleTests
{
    [InlineData(-1, -1, -1)]
    [InlineData(0, 0, 0)]
    [Theory]
    public void Init_Triangle_With_Wrong_Input(double a, double b, double c)
    {
        Action act = () => new Triangle(a, b, c);
        act.Should().Throw<ArgumentException>();
    }

    [InlineData(1, 1, 4)]
    [InlineData(4, 1, 1)]
    [InlineData(1, 4, 1)]
    [Theory]
    public void Init_Not_Triangle(double a, double b, double c)
    {
        Action act = () => new Triangle(a, b, c);
        act.Should().Throw<ArgumentException>();
    }

    [Fact]
    public void Calculate_Triangle_Area()
    {
        // arrange
        IFigure figure = new Triangle(14, 13, 15);
        
        // act
        var area = figure.CalculateArea();

        // assert
        area.Should().Be(84);
    }
    
    [InlineData(3, 4, 5, true)]
    [InlineData(3, 4, 5 + 1e-7, false)]
    [Theory]
    public void Check_Triangle_Is_Right(double a, double b, double c, bool expected)
    {
        // arrange
        var triangle = new Triangle(a, b, c);
        
        // arrange
        var isRight = triangle.IsRightTriangle;
        
        // assert
        isRight.Should().Be(expected);
    }
}
using FiguresAreas;
using FluentAssertions;

namespace UnitTests;

public class CircleTests
{
    [InlineData(-1)]
    [InlineData(0)]
    [Theory]
    public void Init_Circle_With_Wrong_Input(double radius)
    {
        Action act = () => new Circle(radius);
        act.Should().Throw<ArgumentException>();
    }
    
    [Fact]
    public void Calculate_Circle_Area()
    {
        // arrange
        var radius = 5;
        IFigure figure = new Circle(radius);
        var expectedResult = Math.PI * Math.Pow(radius, 2);
        
        // act
        var area = figure.CalculateArea();

        // assert
        area.Should().Be(expectedResult);
    }
}
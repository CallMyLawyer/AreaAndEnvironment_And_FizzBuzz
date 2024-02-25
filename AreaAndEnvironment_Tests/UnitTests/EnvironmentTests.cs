namespace Area_Test_Units;
using FluentAssertions;
using Model.Contracts.Exceptions;
using Model.Contracts.Exceptions.Rectangle;
using Model.Contracts.Exceptions.Square;
using Model.Contracts.Exceptions.Triangle;
public class EnvironmentTests
{
    [Fact]
    public void Circle_Calculate_The_environment_of_circle()
    {
        var radius = 3;
        var expected = 18.84;
        var calculator = new Model.Calculator();
        var act = calculator.CircleEnvironment(radius);
        act.Should().Be(expected);
    }
    [Fact]
    public void CircleEnvironment_throws_exception_when_radius_is_zero_or_negative()
    {
        var radius = 0;
        var calculator = new Model.Calculator();
        var act = () => calculator.CircleEnvironment(radius);
        act.Should().ThrowExactly<CircleRadiusOfCircleCanNotBeZeroOrNegativeException>();
    }
    [Fact]
    public void Rectangle_Calculate_the_environment_of_rectangle()
    {
        var length = 2;
        var width = 2;
        var expected = 8;
        var calculator = new Model.Calculator();

        var act = calculator.RectangleEnvironment(length, width);
        act.Should().Be(expected);
    }
    [Fact]
    public void RectangleEnvironment_Throws_Exception_When_length_is_zero_or_negative()
    {
        var length = -1;
        var width = 4;
        var calculator = new Model.Calculator();
        var act = () => calculator.RectangleEnvironment(length, width);
        act.Should().ThrowExactly<RectangleLengthCanNotBeZeroOrNegativeException>();
    }

    [Fact]
    public void RectangleEnvironment_throws_exception_when_width_is_zero_or_negative()
    {
        var length = 4;
        var width = -3;
        var calculator = new Model.Calculator();
        var act = () => calculator.RectangleEnvironment(length, width);
        act.Should().ThrowExactly<RectangleWidthCanNotBeZeroOrNegativeException>();
    }
    [Fact]
    public void Square_calculate_the_environment_of_square()
    {
        var length = 6;
        var expected = 24;
        var calculator = new Model.Calculator();
        var act = calculator.SquareEnvironment(length);
        act.Should().Be(expected);
    }
    [Fact]
    public void SquareEnvironment_throws_exception_when_length_is_zero_or_negative()
    {
        var length = -2;
        var calculator = new Model.Calculator();
        var act = () => calculator.SquareEnvironment(length);
        act.Should().ThrowExactly<SquareLengthCanNotBeZeroOrNegativeException>();
    }
    [Fact]
    public void Triangle_calculate_the_environment_of_triangle()
    {
        var length = 4;
        var expected = 12;
        var calculator = new Model.Calculator();
        var act = calculator.TriangleEnvironment(length);
        act.Should().Be(expected);
    }

    [Fact]
    public void Triangle_Throws_exception_when_length_is_zero_or_negative()
    {
        var length = -2;
        var calculator = new Model.Calculator();
        var act = () => calculator.TriangleEnvironment(length);
        act.Should().ThrowExactly<TriangleLengthCanNotBeZeroOrNegativeException>();
    }
}
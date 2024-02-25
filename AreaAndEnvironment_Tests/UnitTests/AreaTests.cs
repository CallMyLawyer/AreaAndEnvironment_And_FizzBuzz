using FluentAssertions;
using Model.Contracts.Exceptions;
using Model.Contracts.Exceptions.Rectangle;
using Model.Contracts.Exceptions.Square;
using Model.Contracts.Exceptions.Triangle;

namespace Area_Test_Units.UnitTests;

public class AreaTests
{
    [Fact]
    public void Circle_Calculate_The_Area_of_circle()
    {
        var radius = 3;
        var expected = 28.26;
        var calculator = new Model.Calculator();
        var act = calculator.CircleArea(radius);
        act.Should().Be(expected);
    }

    [Fact]
    public void CircleArea_throws_exception_when_radius_is_zero_or_negative()
    {
        var radius = 0;
        var calculator = new Model.Calculator();
        var act = () => calculator.CircleArea(radius);
        act.Should().ThrowExactly<CircleRadiusOfCircleCanNotBeZeroOrNegativeException>();
    }
    [Fact]
    public void Rectangle_Calculate_the_area_of_rectangle()
    {
        var length = 2;
        var width = 2;
        var expected = 4;
        var calculator = new Model.Calculator();

        var act = calculator.RectangleArea(length, width);
        act.Should().Be(expected);
    }
    [Fact]
    public void RectangleArea_Throws_Exception_When_length_is_zero_or_negative()
    {
        var length = -1;
        var width = 4;
        var calculator = new Model.Calculator();
        var act = () => calculator.RectangleArea(length, width);
        act.Should().ThrowExactly<RectangleLengthCanNotBeZeroOrNegativeException>();
    }

    [Fact]
    public void RectangleArea_throws_exception_when_width_is_zero_or_negative()
    {
        var length = 4;
        var width = -3;
        var calculator = new Model.Calculator();
        var act = () => calculator.RectangleArea(length, width);
        act.Should().ThrowExactly<RectangleWidthCanNotBeZeroOrNegativeException>();
    }

    [Fact]
    public void Square_calculate_the_area_of_square()
    {
        var length = 6;
        var expected = 36;
        var calculator = new Model.Calculator();
        var act = calculator.SquareArea(length);
        act.Should().Be(expected);
    }
    [Fact]
    public void SquareArea_throws_exception_when_length_is_zero_or_negative()
    {
        var length = -2;
        var calculator = new Model.Calculator();
        var act = () => calculator.SquareArea(length);
        act.Should().ThrowExactly<SquareLengthCanNotBeZeroOrNegativeException>();
    }

    [Fact]
    public void Triangle_calculate_the_area_of_triangle()
    {
        var Base = 4;
        var height = 4;
        var expected = 8;
        var calculator = new Model.Calculator();
        var act = calculator.TriangleArea(Base, height);
        act.Should().Be(expected);
    }

    [Fact]
    public void Triangle_throws_exception_when_base_is_zero_or_negative()
    {
        var Base = -1;
        var height = 6;
        var calculator = new Model.Calculator();
        var act = () => calculator.TriangleArea(Base, height);
        act.Should().ThrowExactly<TriangleBaseCanNotBeZeroOrNegativeException>();
    }

    [Fact]
    public void Triangle_throws_exception_when_height_is_zero_or_negative()
    {
        var Base = 6;
        var height = -2;
        var calculator = new Model.Calculator();
        var act = () => calculator.TriangleArea(Base, height);
        act.Should().ThrowExactly<TriangleHeightCanNotBeZeroOrNegativeException>();
    }
}
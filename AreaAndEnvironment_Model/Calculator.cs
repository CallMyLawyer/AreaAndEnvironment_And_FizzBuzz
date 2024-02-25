using Model.Contracts.Exceptions;
using Model.Contracts.Exceptions.Rectangle;
using Model.Contracts.Exceptions.Square;
using Model.Contracts.Exceptions.Triangle;

namespace Model;

public class Calculator
{
    public object CircleArea(int radius)
    {
        if (radius<=0)
        {
            throw new CircleRadiusOfCircleCanNotBeZeroOrNegativeException();
        }
        return ((radius * radius) * (3.14));
    }

    public object CircleEnvironment(int radius)
    {
        if (radius<=0)
        {
            throw new CircleRadiusOfCircleCanNotBeZeroOrNegativeException();
        }
        return (radius * 2) * 3.14;
    }

    public object RectangleArea(int length, int width)
    {
        if (length<=0)
        {
            throw new RectangleLengthCanNotBeZeroOrNegativeException();
        }

        if (width<=0)
        {
            throw new RectangleWidthCanNotBeZeroOrNegativeException();
        }
        return length * width;
    }

    public object RectangleEnvironment(int length, int width)
    {
        if (length<=0)
        {
            throw new RectangleLengthCanNotBeZeroOrNegativeException();
        }

        if (width<=0)
        {
            throw new RectangleWidthCanNotBeZeroOrNegativeException();
        }
        return (length + width) * 2;
    }

    public object SquareArea(int length)
    {
        if (length<=0)
        {
            throw new SquareLengthCanNotBeZeroOrNegativeException();
        }
        return length * length;
    }

    public object SquareEnvironment(int length)
    {
        if (length<=0)
        {
            throw new SquareLengthCanNotBeZeroOrNegativeException();
        }
        return length * 4; 
    }

    public object TriangleArea(int Base, int height)
    {
        if (Base<=0)
        {
            throw new TriangleBaseCanNotBeZeroOrNegativeException();
        }

        if (height<=0)
        {
            throw new TriangleHeightCanNotBeZeroOrNegativeException();
        }
        return (Base / 2) * height;
    }
    public object TriangleEnvironment(int length)
    {
        if (length<=0)
        {
            throw new TriangleLengthCanNotBeZeroOrNegativeException();
        }
        return length*3;
    }
}
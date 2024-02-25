using FizzBuzz_Model.Contracts.Exceptions;
using FluentAssertions;

namespace FizzBuzz_Tests.UnitTests;

public class FizzBuzzTests
{
    [Fact]
    public void FizzBuzz_when_the_number_is_a_multiple_of_three()
    {
        var number = 9;
        var expected = "Fizz";
        var calculator = new FizzBuzz_Model.Calculator();
        var act = calculator.FizzBuzz(number);
        act.Should().Be(expected);
    }

    [Fact]
    public void FizzBuzz_when_the_number_is_a_multiple_of_five()
    {
        var number = 10;
        var expected = "Buzz";
        var calculator = new FizzBuzz_Model.Calculator();
        var act = calculator.FizzBuzz(number);
        act.Should().Be(expected);
    }

    [Fact]
    public void FizzBuzz_when_the_number_is_a_multiple_of_three_and_five()
    {
        var number = 15;
        var expected = "FizzBuzz";
        var calculator = new FizzBuzz_Model.Calculator();
        var act = calculator.FizzBuzz(number);
        act.Should().Be(expected);
    }

    [Fact]
    public void FizzBuzz_Throw_exception_when_number_is_less_than_zero()
    {
        var number = 0;
        var calculator = new FizzBuzz_Model.Calculator();
        var act = () => calculator.FizzBuzz(number);
        act.Should().ThrowExactly<FizzBuzzTheNumberCanNotBeZeroOrNegativeException>();
    }
}
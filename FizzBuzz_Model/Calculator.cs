using FizzBuzz_Model.Contracts.Exceptions;

namespace FizzBuzz_Model;

public class Calculator
{
    public object FizzBuzz(int number)
    {
        if (number<=0)
        {
            throw new FizzBuzzTheNumberCanNotBeZeroOrNegativeException();
        }
        var answer = "mio";

        if (number%3==0)
        {
            answer = "Fizz";
        }

        if (number%5==0)
        {
            answer ="Buzz";
        }
        if (number%3==0 && number%5==0)
        {
            answer ="FizzBuzz";
        }

        return answer;
    }
}
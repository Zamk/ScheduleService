using CSharpFunctionalExtensions;

namespace ScheduleService.Domain.ValueObjects;

public class PhoneNumber
{
    public string Number { get; }

    private PhoneNumber(string number)
    {
        Number = number;
    }

    public static Result<PhoneNumber> Create(string number)
    {
        if (string.IsNullOrEmpty(number))
        {
            return Result.Failure<PhoneNumber>($"'{nameof(number)}' cannot be null or empty");
        }

        return new PhoneNumber(number);
    }
    
    public override bool Equals(object obj)
    {
        if (obj is PhoneNumber other)
        {
            return Number == other.Number;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return Number.GetHashCode();
    }
}
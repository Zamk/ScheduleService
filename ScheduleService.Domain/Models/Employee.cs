using CSharpFunctionalExtensions;
using ScheduleService.Domain.ValueObjects;

namespace ScheduleService.Domain.Models;

public class Employee
{
    public Guid Id { get; }
    public string Name { get; }
    
    public PhoneNumber PhoneNumber { get; }

    private Employee(Guid id, string name, PhoneNumber phoneNumber)
    {
        Id = id;
        Name = name;
        PhoneNumber = phoneNumber;
    }

    public static Result<Employee> Create(string name, PhoneNumber phoneNumber)
    {
        if (string.IsNullOrEmpty(name))
        {
            return Result.Failure<Employee>($"'{nameof(name)}' cannot be null or empty");
        }

        return new Employee(Guid.NewGuid(), name, phoneNumber);
    }
}
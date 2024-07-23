using ScheduleService.Domain.Interfaces.Repositories;
using ScheduleService.Domain.Models;

namespace ScheduleService.Persistence.Repositories;

public class EmployeeRepository : IEmployeeRepository
{
    public Task Add(Employee employee)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<Employee>> Get()
    {
        throw new NotImplementedException();
    }

    public Task<Employee> GetById(Guid id)
    {
        throw new NotImplementedException();
    }
}
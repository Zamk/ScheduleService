using ScheduleService.Domain.Models;

namespace ScheduleService.Domain.Interfaces.Repositories;

public interface IEmployeeRepository
{
    public Task Add(Employee employee);
    public Task<IReadOnlyList<Employee>> Get();
    public Task<Employee> GetById(Guid id);
}
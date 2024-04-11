namespace Day2.Assignment3.Practice6.Service;

public interface IDepartmentService : IService<Department>
{
    bool Create(Department student);
    Department Read(int id);
    bool Update(Department obj);
    bool Delete(int id);
    List<Department> GetAll();
}
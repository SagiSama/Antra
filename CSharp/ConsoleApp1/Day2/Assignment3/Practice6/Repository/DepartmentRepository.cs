using Day2.Assignment3.Practice6.Service;

namespace Day2.Assignment3.Practice6.Repository;

public class DepartmentRepository : IDepartmentService
{
    private List<Department> departments = new List<Department>();

    public bool Create(Department department)
    {
        departments.Add(department);
        return true;
    }
    public Department Read(int id)
    {
        foreach(Department s in departments)
        {
            if (s.Id == id) return s;
        }
        return null;
    }
    public bool Update(Department obj)
    {
        Department s = Read(obj.Id);
        if (s == null) return false;
        s.Id = obj.Id;
        s.Name = obj.Name;
        return true;
    }
    public bool Delete(int id)
    {
        Department s = Read(id);
        if (s == null) return false;
        departments.Remove(s);
        return true;
    }
    public List<Department> GetAll()
    {
        return departments;
    }
}
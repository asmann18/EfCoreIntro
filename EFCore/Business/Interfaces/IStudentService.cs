using EFCore.Entities;

namespace EFCore.Business.Interfaces;

public interface IStudentService
{
    Task<List<Student>> GetAllStudents();
    Task<Student> GetStudentById(int id);
    Task CreateStudent(Student student);
    Task UpdateStudent(Student student);
    Task DeleteStudent(int id);

}

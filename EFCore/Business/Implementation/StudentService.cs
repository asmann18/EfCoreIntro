using EFCore.Business.Interfaces;
using EFCore.DAL;
using EFCore.Entities;
using EFCore.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Business.Implementation;

public class StudentService : IStudentService
{
    private readonly AppDbContext _appDbContext=new();

    public async Task CreateStudent(Student student)
    {

        await _appDbContext.Students.AddAsync(student);
        await _appDbContext.SaveChangesAsync();
    }

    public async Task DeleteStudent(int id)
    {
        var student=await GetStudentById(id);
        _appDbContext.Students.Remove(student);
        _appDbContext.SaveChanges();
    }

    public async Task<List<Student>> GetAllStudents()
    {
        var Students=await _appDbContext.Students.ToListAsync();
        return Students;
    }

    public async Task<Student> GetStudentById(int id)
    {
        var student=await _appDbContext.Students.FirstOrDefaultAsync(x => x.Id == id);

        if (student is null)
        {
            throw new StudentNotFoundException();
        }
        return student;
    }

    public async Task UpdateStudent(Student student)
    {
        var existStudent=await GetStudentById(student.Id);
        existStudent.Name = student.Name;
        existStudent.Surname = student.Surname;
        existStudent.AvgPoint = student.AvgPoint;
        _appDbContext.SaveChanges();
    }
}

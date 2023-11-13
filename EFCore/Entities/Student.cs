using System.ComponentModel.DataAnnotations;

namespace EFCore.Entities;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    [Range(0,100)]
    public int AvgPoint { get; set; }

}

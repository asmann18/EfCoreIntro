using EFCore.Business.Implementation;
using EFCore.Entities;

namespace EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentService studentService = new StudentService();
            Student student1 = new Student()
            {
                Name = "Asiman",
                Surname="Qasimzada",
                AvgPoint=99
            };

            Student student2 = new Student()
            {
                Name = "Zulfiyya",
                Surname = "Qurbanova",
                AvgPoint = 100
            };


            Student student3 = new Student()
            {
                Name = "Sabuhi",
                Surname = "Camalzada",
                AvgPoint = 69
            };
            //Create
            //studentService.CreateStudent(student1).Wait();
            //studentService.CreateStudent(student2).Wait();
            //studentService.CreateStudent(student3).Wait();

            //GetAll
            //Task<List<Student>> students=studentService.GetAllStudents();
            //foreach (var item in students.Result)
            //{
            //    Console.WriteLine(item.Name+" "+item.Surname);
            //}


            //GetById
            //var existStudent = studentService.GetStudentById(1).Result;
            //Console.WriteLine(existStudent.Name+" "+existStudent.Surname);

            //Delete
            //studentService.DeleteStudent(3).Wait();

            //Update
            studentService.UpdateStudent(new() { Id = 1, Name = "Asiman Updated", Surname = "Asiman Updated", AvgPoint = 100 }).Wait();



        }
    }
}
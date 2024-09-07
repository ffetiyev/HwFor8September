using Domain.Entities;
using Repository.Exceptions;
using Service.Services;
using Service.Services.Interfaces;

namespace StudentApp.Controllers
{
    internal class StudentController
    {
        private readonly IStudentService _studentService;

        public StudentController()
        {
            _studentService=new StudentService();
        }

        public void GetAll()
        {
            var students = _studentService.Getall();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id} {student.Name} {student.Surname} {student.Address}");
            }
        }

        public void Search()
        {
            Console.WriteLine("Add search text:");
            string text = Console.ReadLine();
            var students = _studentService.Search(text);

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id} {student.Name} {student.Surname} {student.Address}");
            }
        }

        public void GetByid()
        {
            try
            {
                Console.WriteLine("Enter Id:");
                Id: string idStr = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(idStr))
                {
                    Console.WriteLine("ïnput cant be empty, plese add id again");
                    goto Id;
                }
                int id = int.Parse(idStr);
                var student = _studentService.GetById(id);
                Console.WriteLine($"Name: {student.Name}, Surname {student.Surname}, Adress {student.Address}, Age: {student.Age}");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}

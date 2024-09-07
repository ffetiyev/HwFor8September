using Service.Services;
using Service.Services.Interfaces;
using StudentApp.Controllers;

StudentController studentController=new StudentController();
//studentController.GetAll();
//studentController.GetByid();
//studentController.Search();
FactorialController factorialController=new FactorialController();
Console.WriteLine(factorialController.Factorial());
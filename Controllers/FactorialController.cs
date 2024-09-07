using Repository.Exceptions;
using Service.Services;
using Service.Services.Interfaces;

namespace StudentApp.Controllers
{
    internal class FactorialController
    {
        private readonly IFactorialService _factorialService;

        public FactorialController()
        {
            _factorialService = new FactorialService();
        }

        public void Factorial()
        {
            try
            {
                 Console.WriteLine("add number:");
                int a = int.Parse(Console.ReadLine());
                if (a < 0)
                {
                    throw new FactorialException("Enter Positive number!");

                }
                var res = _factorialService.Factorial(a);

                  Console.WriteLine(res);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

           
        }
    }
}

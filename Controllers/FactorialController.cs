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

        public int Factorial()
        {
            Console.WriteLine("add number:");
            int a =int.Parse(Console.ReadLine());
            var res = _factorialService.Factorial(a);

            return res;
        }
    }
}

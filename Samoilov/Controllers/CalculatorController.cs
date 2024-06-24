using Microsoft.AspNetCore.Mvc;

namespace Samoilov.Controllers
{
    public class CalculatorController : Controller
    {
        public String Index(int a, int b)
        {
            return a + " + " + b + " = " + (a + b);
        }
    }
}
//https://localhost:7124/calculator/index/1/
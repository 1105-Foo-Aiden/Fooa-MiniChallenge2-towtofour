using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;

namespace Fooa_MiniChallenge2_towtofour.Controllers;
[ApiController]
[Route("[controller]")]
public class MainController
{
    public MainController()
    {
        [HttpPost]
        [Route("/AddNumbers/{num1}/{num2}")]
        
        string addNumbers(double num1, double num2)
        {
            Convert.ToDouble(num1);
            Convert.ToDouble(num2);
            double num3 = num1 + num2;
            Convert.ToString(num3);
            return $"The sum of {num1} {num2} is {num3}";
        }
    }
}

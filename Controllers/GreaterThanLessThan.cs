using Fooa_MiniChallenge2_towtofour.Service.numbers;
using Microsoft.AspNetCore.Mvc;
namespace Fooa_MiniChallenge2_towtofour.Controllers;
[ApiController]
[Route("[controller]")]
public class GreaterThanLessThan
{
    public iGTLT GTLT { get; }
    public GreaterThanLessThan(iGTLT gTLT)
    {
        GTLT = gTLT;
    }
    [HttpGet]
    [Route("/CompareNumbers/{num1}/{num2}")]
    public string CompareNumbers(double num1, double num2)
    {
        return GTLT.CompareNumbers(num1, num2);
    }
}

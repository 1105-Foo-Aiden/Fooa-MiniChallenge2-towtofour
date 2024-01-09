using Fooa_MiniChallenge2_towtofour.Service.numbers;
using Microsoft.AspNetCore.Mvc;
namespace Fooa_MiniChallenge2_towtofour.Controllers;
[ApiController]
[Route("[controller]")]
public class MainController
{
  public readonly iAddNum AddNum;
  public MainController(iAddNum addNum)
  {
    AddNum = addNum;
  }
  [HttpGet]
  [Route("/AddNumbers/{num1}/{num2}")]
  
  public string AddNumbers(double num1, double num2)
  {
      return AddNum.AddNumbers(num1, num2);
  }

}

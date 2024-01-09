using Fooa_MiniChallenge2_towtofour.Service.numbers;
using Microsoft.AspNetCore.Mvc;

namespace Fooa_MiniChallenge2_towtofour.Controllers;
[ApiController]
[Route("[controller]")]

public class MainController
{
    public iAddNum AddNum { get; }
    public MainController(iAddNum addNum)
    {
        AddNum = addNum;
    }
    [HttpGet]
    [Route("/AddNumbers/{num1}/{num2}")]
    public string AddNumbers(int num1, int num2)
    {
        return AddNumbers(num1, num2);
    }

}

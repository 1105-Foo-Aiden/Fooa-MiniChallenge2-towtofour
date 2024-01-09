using Fooa_MiniChallenge2_towtofour.Service.numbers;
using Microsoft.AspNetCore.Mvc;

namespace Fooa_MiniChallenge2_towtofour.Controllers;
[ApiController]
[Route("[controller]")]
public class TwoQuestions
{
    public iTQuestions TQuestions { get; }
    public TwoQuestions(iTQuestions tQuestions)
    {
        TQuestions = tQuestions;
    }
    [HttpGet]
    [Route("/{Name}/{WakeUpTime}")]

    public string twoQuestions(string name, string wakeUpTime)
    {
        return twoQuestions(name, wakeUpTime);
    }


}

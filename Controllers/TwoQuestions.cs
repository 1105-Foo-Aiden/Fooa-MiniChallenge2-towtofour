using Fooa_MiniChallenge2_towtofour.Service.numbers;
using Microsoft.AspNetCore.Mvc;

namespace Fooa_MiniChallenge2_towtofour.Controllers;
[ApiController]
[Route("[controller]")]

public class TwoQuestions
{
    public readonly iTQuestions TQuestions;
    public TwoQuestions(iTQuestions tQuestions)
    {
        TQuestions = tQuestions;
    }
    [HttpGet]
    [Route("/TwoQuestions/{Name}/{WakeUpTime}")]

    public string twoQuestions(string name, int wakeUpTime)
    {
        return TQuestions.twoQuestions(name, wakeUpTime);
    }


}

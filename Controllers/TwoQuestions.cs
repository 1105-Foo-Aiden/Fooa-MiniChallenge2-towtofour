using Microsoft.AspNetCore.Mvc;

namespace Fooa_MiniChallenge2_towtofour.Controllers;
[ApiController]
[Route("[controller]")]

public class TwoQuestions
{
    public TwoQuestions()
    {
        [HttpPost]
        [Route("TwoQustions/{Name}/{WakeUpTime}")]
        
        string TwoQuestions(string name, string wakeUpTime){
            return $"your name is {name} and you woke up at {wakeUpTime}";
        }
    }
    

}

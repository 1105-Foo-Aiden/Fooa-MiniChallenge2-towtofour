using System.Reflection.Metadata.Ecma335;

namespace Fooa_MiniChallenge2_towtofour.Service.numbers;

public class TQuestions : iTQuestions
{
    public string twoQuestions(string name, string wakeUpTime)
    {
        int.TryParse(wakeUpTime, out int result);
        return result > 0 ? $"your name is {name} and you woke up at {wakeUpTime}" : "Please enter a valid time";
    }
}

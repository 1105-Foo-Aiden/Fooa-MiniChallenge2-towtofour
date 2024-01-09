using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fooa_MiniChallenge2_towtofour.Service.numbers
{
    public class TQuestions : iTQuestions
    {
        public string TwoQuestions(string name, string wakeUpTime)
        {
            return $"your name is {name} and you woke up at {wakeUpTime}";
        }
    }
}
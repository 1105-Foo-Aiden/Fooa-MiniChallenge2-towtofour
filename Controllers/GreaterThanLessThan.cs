using Microsoft.AspNetCore.Mvc;


namespace Fooa_MiniChallenge2_towtofour.Controllers;
[ApiController]
[Route("[controller]")]
public class GreaterThanLessThan
{
    [Route("/CompareNumbers/{num1}/{num2}")]
    string CompareNumbers(double num1, double num2){
        if(num1 > num2){
            return $"{num1} is greater than {num2}\n {num2} is less than {num1}";
        }
        else if(num1 < num2){
            return $"{num2} is greater than {num1} \n {num1} is less than {num2}";
        }
        else{
            return $"{num1} and {num2} are the same value";
        }
    }
}

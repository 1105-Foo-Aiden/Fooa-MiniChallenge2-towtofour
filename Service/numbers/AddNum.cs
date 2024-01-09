namespace Fooa_MiniChallenge2_towtofour.Service.numbers;
public class AddNum : iAddNum
{
    public string AddNumbers(double num1, double num2)
    {
        return $"The sum of {num1} and {num2} is {num1 + num2}";
    }
}

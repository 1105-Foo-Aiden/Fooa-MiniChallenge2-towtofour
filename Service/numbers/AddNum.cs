namespace Fooa_MiniChallenge2_towtofour.Service.numbers;

public class AddNum : iAddNum
{
    public string addNumbers(double num1, double num2)
    {
        double num3 = num1 + num2;
        return $"The sum of {num1}and {num2} is {num3}";
    }
}

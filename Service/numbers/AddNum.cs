namespace Fooa_MiniChallenge2_towtofour.Service.numbers;

public class AddNum : iAddNum
{
    public string addNumbers(int num1, int num2)
    {
        int num3 = num1 + num2;
        return $"The sum of {num1}and {num2} is {num3}";
    }
}

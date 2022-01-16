namespace FizzBuzzGame;

public class Game
{
    private string _version;

    public Game(string version = "FizzBuzz")
    {
        _version = version;
    }

    public string GetFizzBuzz(int max)
    {
        string output = "";

        for (int i = 0; i < max; i++)
        {
            int number = i + 1;
            string text = "";

            output = AddComma(output);

            text = ApplyFizz(number, text);
            text = ApplyBuzz(number, text);
            text = ApplyFuzz(number, text);

            if (!string.IsNullOrEmpty(text))
            {
                output += text;
                continue;
            }

            output += number.ToString();
        }

        return output;
    }

    private static string ApplyFizz(int number, string text)
    {
        if (number % 3 == 0)
        {
            text += "fizz";
        }

        return text;
    }

    private static string ApplyBuzz(int number, string text)
    {
        if (number % 5 == 0)
        {
            text += "buzz";
        }

        return text;
    }

    private string ApplyFuzz(int number, string text)
    {
        if (_version == "FizzBuzzFuzz")
        {
            if (number % 7 == 0)
            {
                text += "fuzz";
            }
        }

        return text;
    }

    private static string AddComma(string output)
    {
        if (output.Length > 0)
        {
            string outputWithComma = output + ",";
            return outputWithComma;
        }

        return output;
    }
}

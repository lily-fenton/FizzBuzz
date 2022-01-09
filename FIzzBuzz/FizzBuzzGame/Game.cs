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

            output = AddComma(output);

            if (number % 3 == 0)
            {
                output += "fizz";
                continue;
            }

            if (number % 5 == 0)
            {
                output += "buzz";
                continue;
            }
           
            if (_version == "FizzBuzzFuzz")
            {
                if (number % 7 == 0)
                {
                    output += "fuzz";
                    continue;
                }
            }

            output += number.ToString();
        }

        return output;
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

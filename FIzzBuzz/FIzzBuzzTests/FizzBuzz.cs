using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTests;

[TestClass]
public class FizzBuzz
{
    [TestMethod]
    public void CheckFizzBuzz_1_10()
    {
        var expected = "1,2,fizz,4,buzz,fizz,7,8,fizz,buzz";

        var actual = GetFizzBuzz(10);

        Assert.AreEqual(expected, actual);
    }


    private string GetFizzBuzz(int max)
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

            output += number.ToString();
        }

        return output;
    }

    private static string AddComma(string output)
    {
        if (output.Length > 0)
        {
            output += ",";
        }

        return output;
    }
}

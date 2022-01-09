using FizzBuzzGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTests;

[TestClass]
public class FizzBuzz
{
    [TestMethod]
    public void NextSteps()
    {
        Assert.Fail("Need to convert FizzBuzzFuzz test to be data driven, like FizzBuzz.");
        Assert.Fail("Need to add cases for 15, 21, 35, 105 to both sets based on our matrix.");
        Assert.Fail("Create the tests in SpecFlow.");
    }

    [TestMethod]
    [DataRow(1, "1")]
    [DataRow(2, "2")]
    [DataRow(3, "fizz")]
    [DataRow(4, "4")]
    [DataRow(5, "buzz")]
    [DataRow(6, "fizz")]
    [DataRow(7, "7")]
    [DataRow(8, "8")]
    [DataRow(9, "fizz")]
    [DataRow(10, "buzz")]
    public void FizzBuzzWith(int input, string expected)
    {
        var game = new Game();

        var output = game.GetFizzBuzz(input);

        string actual = GetItemAt(output, input);

        Assert.AreEqual(expected, actual);
    }

    private string GetItemAt(string output, int position)
    {
        return output.Split(',')[position - 1];
    }

    [TestMethod]
    public void CheckFizzBuzzFuzz_1_10()
    {
        var expected = "1,2,fizz,4,buzz,fizz,fuzz,8,fizz,buzz";

        var game = new Game("FizzBuzzFuzz");

        var actual = game.GetFizzBuzz(10);

        Assert.AreEqual(expected, actual);
    }
}


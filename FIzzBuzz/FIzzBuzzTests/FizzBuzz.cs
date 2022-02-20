using FizzBuzzGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace FizzBuzzTests;

[TestClass]
public class FizzBuzz
{
    [TestMethod]
    public void NextSteps()
    {
        Assert.Inconclusive("Create the tests in SpecFlow.");
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
    [DataRow(15, "fizzbuzz")]
    [DataRow(21, "fizz")]
    [DataRow(35, "buzz")]
    [DataRow(105, "fizzbuzz")]
    public void FizzBuzzWith(int input, string expected)
    {
        var game = new Game();

        var output = game.GetFizzBuzz(input);

        GetItemAt(output, input).ShouldBe(expected);
    }

    [TestMethod]
    [DataRow(1, "1")]
    [DataRow(2, "2")]
    [DataRow(3, "fizz")]
    [DataRow(4, "4")]
    [DataRow(5, "buzz")]
    [DataRow(6, "fizz")]
    [DataRow(7, "fuzz")]
    [DataRow(8, "8")]
    [DataRow(9, "fizz")]
    [DataRow(10, "buzz")]
    [DataRow(15, "fizzbuzz")]
    [DataRow(21, "fizzfuzz")]
    [DataRow(35, "buzzfuzz")]
    [DataRow(105, "fizzbuzzfuzz")]
    public void FizzBuzzFuzzWith(int input, string expected)
    {
        var game = new Game("FizzBuzzFuzz");

        var output = game.GetFizzBuzz(input);

        GetItemAt(output, input).ShouldBe(expected);
    }

    private string GetItemAt(string output, int position)
    {
        return output.Split(',')[position - 1];
    }
}

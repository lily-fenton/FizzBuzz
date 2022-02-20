using FizzBuzzGame;
using Shouldly;

namespace FizzBuzz.Specs.StepDefinitions
{
    [Binding]
    public sealed class FizzBuzzStepDefinitions
    {
        private Game _game;
        private int _input;
        private string _output;

        [Given("I am playing (.*)")]
        public void GivenTheFirstNumberIs(string name)
        {
            _game = new Game(name);
        }

        [When("I get to the number in the column named (.*)")]
        public void GivenTheSecondNumberIs(int input)
        {
            _input = input;
            _output = _game.GetFizzBuzz(input);
        }

        [Then("I should say the answer in the column named (.*)")]
        public void ThenTheResultShouldBe(string expected)
        {
            GetItemAt(_output, _input).ShouldBe(expected);
        }

        private string GetItemAt(string output, int position)
        {
            return output.Split(',')[position - 1];
        }
    }
}
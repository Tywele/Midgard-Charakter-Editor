using MidgardCharakterEditor.Generators;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Tests
{
    public class DiceGeneratorTests
    {
        [Fact]
        public void RollDiceTest1()
        {
            var diceGenerator = new DiceGenerator(2, 6);

            var result = diceGenerator.RollDice();

            Assert.InRange(result, 2, 12);
        }

        [Fact]
        public void RollDiceTest2()
        {
            var diceGenerator = new DiceGenerator(1, 100);

            var result = diceGenerator.RollDice();

            Assert.InRange(result, 1, 100);
        }

        [Fact]
        public void RollDiceTest3()
        {
            var diceGenerator = new DiceGenerator(4, 10);

            var result = diceGenerator.RollDice();

            Assert.InRange(result, 4, 40);
        }

        [Fact]
        public void RollSeparateDiceTest1()
        {
            var diceGenerator = new DiceGenerator(2, 6);

            var results = diceGenerator.RollSeparateDice();

            foreach (var result in results)
                Assert.InRange(result, 1, 6);
        }

        [Fact]
        public void RollSeparateDiceTest2()
        {
            var diceGenerator = new DiceGenerator(1, 100);

            var results = diceGenerator.RollSeparateDice();

            foreach (var result in results)
                Assert.InRange(result, 1, 100);
        }

        [Fact]
        public void RollSeparateDiceTest3()
        {
            var diceGenerator = new DiceGenerator(4, 10);

            var results = diceGenerator.RollSeparateDice();

            foreach(var result in results)
                Assert.InRange(result, 1, 10);
        }
    }
}

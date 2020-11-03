using MidgardCharakterEditor.Utilities;
using Xunit;

namespace Tests
{
    public class DiceGeneratorTests
    {
        private readonly Die _die;

        public DiceGeneratorTests()
        {
            _die = new Die();
        }

        [Fact]
        public void RollDiceTest1()
        {
            int result = 0;

            for (int i = 0; i < 2; i++)
                result += _die.Roll(6);

            Assert.InRange(result, 2, 12);
        }

        [Fact]
        public void RollDiceTest2()
        {
            int result = _die.Roll(100);

            Assert.InRange(result, 1, 100);
        }

        [Fact]
        public void RollDiceTest3()
        {
            int result = 0;
            for (int i = 0; i < 4; i++)
                result = _die.Roll(10);

            Assert.InRange(result, 4, 40);
        }

        [Fact]
        public void RollSeparateDiceTest1()
        {
            for (int i = 0; i < 2; i++)
            {
                int result = _die.Roll(6);
                Assert.InRange(result, 1, 6);
            }
        }

        [Fact]
        public void RollSeparateDiceTest2()
        {
            for (int i = 0; i < 1; i++)
            {
                int result = _die.Roll(100);
                Assert.InRange(result, 1, 100);
            }
        }

        [Fact]
        public void RollSeparateDiceTest3()
        {
            for (int i = 0; i < 4; i++)
            {
                int result = _die.Roll(10);
                Assert.InRange(result, 1, 10);
            }
        }
    }
}
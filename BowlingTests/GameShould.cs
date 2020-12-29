using System;
using Xunit;
using Bowling;

namespace Bowling
{
    public class GameShould
    {
        [Fact]
        public void BeWiredCorrectly()
        {
            var game = new Game();
            Assert.True(game.checkProjectConnection());
        }
    }
}

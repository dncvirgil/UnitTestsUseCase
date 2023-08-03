using App;

namespace Tests
{
    public class PlayerAnalyzerTests
    {
        private readonly PlayerAnalyzer _analyzer;
        public PlayerAnalyzerTests()
        {
            _analyzer = new PlayerAnalyzer();
        }

        [Theory]
        [MemberData(nameof(PlayerAnalyzerData.Data), MemberType = typeof(PlayerAnalyzerData))]
        public void CalculateScore_ReturnsCorrectScore(List<Player> players, double expectedScore)
        {
            //Act
            var result = _analyzer.CalculateScore(players);

            //Assert
            Assert.Equal(expectedScore, result);
        }


        [Fact]
        public void CalculateScore_InputIsEmpty_ReturnsEmpty()
        {
            //Arrange
            List<Player> input = new List<Player>();

            //Act 
            var result = _analyzer.CalculateScore(input);

            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void CalculateScore_InputIsNUll_Throws()
        {
            //Arrange
            List<Player> input = null;

            //Act //Assert
            Assert.Throws<NullReferenceException>(() => _analyzer.CalculateScore(input));
        }
    }
}

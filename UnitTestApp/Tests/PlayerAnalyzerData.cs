using App;

namespace Tests
{
    public class PlayerAnalyzerData
    {
        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { new List<Player> { new Player { Age = 25, Experience = 5, Skills = new List<int> { 2, 2, 2 }}}, 250 },
            new object[] { new List<Player> { new Player { Age = 15, Experience = 3, Skills = new List<int> { 3, 3, 3 }}}, 67.5 },
            new object[] { new List<Player> { new Player { Age = 35, Experience = 15, Skills = new List<int> { 4, 4, 4 }}}, 2520 },
            new object[] { GetMultiplePlayerData(), 2837.5 }
        };

        private static List<Player> GetMultiplePlayerData()
        {
            return new List<Player>
            {
               new Player { Age = 25, Experience = 5, Skills = new List<int> { 2, 2, 2 }},
               new Player { Age = 15, Experience = 3, Skills = new List<int> { 3, 3, 3 }},
               new Player { Age = 35, Experience = 15, Skills = new List<int> { 4, 4, 4 }}
            };
        }
    }
}

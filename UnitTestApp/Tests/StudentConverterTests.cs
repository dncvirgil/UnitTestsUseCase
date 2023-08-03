using App;

namespace Tests
{
    public class StudentConverterTests
    {
        private readonly StudentConverter _converter;
        public StudentConverterTests()
        {
            _converter = new StudentConverter();
        }

        [Theory]
        [InlineData(91, 21)]
        [InlineData(91, 50)]
        public void ConvertStudents_ReturnsHonorRoll_True(int grade, int age)
        {
            //Arrange
            List<Student> input = GetStudent(grade, age);

            //Act
            var result = _converter.ConvertStudents(input);

            //Assert
            Assert.True(result.First().HonorRoll);
        }

        [Theory]
        [InlineData(90, 30)]
        [InlineData(91, 20)]
        public void ConvertStudents_ReturnsHonorRoll_False(int grade, int age)
        {
            //Arrange
            List<Student> input = GetStudent(grade, age);

            //Act
            var result = _converter.ConvertStudents(input);

            //Assert
            Assert.False(result.First().HonorRoll);
        }

        [Theory]
        [InlineData(91, 20, true)]
        [InlineData(90, 21, false)]
        public void ConvertStudents_ReturnsExceptional(int grade, int age, bool expectedExceptional)
        {
            //Arrange
            List<Student> input = GetStudent(grade, age);

            //Act
            var result = _converter.ConvertStudents(input);

            //Assert
            Assert.Equal(expectedExceptional, result.First().Exceptional);
        }

        [Theory]
        [InlineData(71, 25)]
        [InlineData(90, 30)]
        public void ConvertStudents_ReturnsPassed_True(int grade, int age)
        {
            //Arrange
            List<Student> input = GetStudent(grade, age);

            //Act
            var result = _converter.ConvertStudents(input);

            //Assert
            Assert.True(result.First().Passed);
        }

        [Theory]
        [InlineData(70, 20)]
        [InlineData(91, 20)]
        public void ConvertStudents_ReturnsPassed_False(int grade, int age)
        {
            //Arrange
            List<Student> input = GetStudent(grade, age);

            //Act
            var result = _converter.ConvertStudents(input);

            //Assert
            Assert.False(result.First().Passed);
        }

        [Fact]
        public void ConvertStudents_InputIsEmpty_ReturnsEmpty()
        {
            //Arrange
            List<Student> input = new List<Student>();

            //Act 
            var result = _converter.ConvertStudents(input);

            //Assert
            Assert.Empty(result);
        }

        [Fact]
        public void ConvertStudents_InputIsNUll_Throws()
        {
            //Arrange
            List<Student> input = null;

            //Act //Assert
            Assert.Throws<ArgumentNullException>(() => _converter.ConvertStudents(input));
        }

        private static List<Student> GetStudent(int grade, int age)
        {
            var studentBuilder = new StudentBuilder();
            var input = new List<Student>
            {
                studentBuilder.AddGrade(grade).AddAge(age).Build()
            };
            return input;
        }
    }
}
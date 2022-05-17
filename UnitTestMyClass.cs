using ConsoleApp;
using Xunit;

namespace TestConsoleApp
{
    public class UnitTestMyClass
    {
        [Fact]
        public void hasAllUniqueCharacters_StringHasAllUniqueCharacters_ReturnsTrue()
        {
            //Arrange
            string input = "abcdefgh123!*@";

            //Act
            var result = MyClass.hasAllUniqueCharacters(input);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void hasAllUniqueCharacters_StringHasRepeatingCharacters_ReturnsFalse()
        {
            //Arrange
            string input = "abdeff1122333";

            //Act
            var result = MyClass.hasAllUniqueCharacters(input);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void hasAllUniqueCharacters_StringIsEmpty_ReturnsTrue()
        {
            //Arrange
            string input = "";

            //Act
            var result = MyClass.hasAllUniqueCharacters(input);

            //Assert
            Assert.True(result);
        }
    }
}

using CoreLibrary;

// Arrange, Act, Assert
// We have the expected value and the actual value

namespace DemoLibrary.Test
{
    public class DisplayMessagesTest
    {
        [Fact]
        public void GreetingShouldReturnGoodMorningMessage()
        {
            // Arrange
            Displaymessages displaymessages = new Displaymessages();
            string expected = "Go to bed Zadok";

            // Act
            string actual = displaymessages.Greeting("Zadok", 2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory] // A theory is like a fact except that it has parameters to pass into
        [InlineData("Tim", 0, "Go to bed Tim")]
        [InlineData("Tim", 1, "Go to bed Tim")]
        [InlineData("Tim", 2, "Go to bed Tim")]
        [InlineData("Tim", 3, "Go to bed Tim")]
        [InlineData("Tim", 4, "Go to bed Tim")]
        [InlineData("Tim", 5, "Good morning Tim")]
        [InlineData("Tim", 6, "Good morning Tim")]
        [InlineData("Tim", 7, "Good morning Tim")]
        [InlineData("Tim", 8, "Good morning Tim")]
        [InlineData("Tim", 9, "Good morning Tim")]
        [InlineData("Tim", 10, "Good morning Tim")]
        [InlineData("Tim", 11, "Good morning Tim")]
        [InlineData("Tim", 12, "Good afternoon Tim")]
        [InlineData("Tim", 13, "Good afternoon Tim")]
        [InlineData("Tim", 14, "Good afternoon Tim")]
        [InlineData("Tim", 15, "Good afternoon Tim")]
        [InlineData("Tim", 16, "Good afternoon Tim")]
        [InlineData("Tim", 17, "Good afternoon Tim")]
        [InlineData("Tim", 18, "Good evening Tim")]
        [InlineData("Tim", 19, "Good evening Tim")]
        [InlineData("Tim", 20, "Good evening Tim")]
        [InlineData("Tim", 21, "Good evening Tim")]
        [InlineData("Tim", 22, "Good evening Tim")]
        [InlineData("Tim", 23, "Good evening Tim")]
        public void GreetingShouldReturnExpectedValue( string firstName, int hourOfTheDay, string expected)
        {
            // Arrange
            Displaymessages displaymessages = new Displaymessages();

            // Act
            string actual = displaymessages.Greeting(firstName, hourOfTheDay);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}

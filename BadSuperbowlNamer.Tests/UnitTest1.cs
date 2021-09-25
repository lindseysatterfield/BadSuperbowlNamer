using System;
using Xunit;

namespace BadSuperbowlNamer.Tests
{
    // test classes must be public
    public class NumberToRomanNumeralTests
    {
        // need to have a fact attribute and needs to be public
        [Fact]
        public void the_number_1_is_translated_into_the_letter_I()
        {
            // Arrange -> context that the test is run inside of
            var numberToTranslate = 1;
            var expectedResult = "I";
            var translator = new NumberTranslator();

            // Act -> the actual thing we're testing, do the thing
            string actualResult = translator.Translate(numberToTranslate);

            // Assert -> lay out the expectations in such a way that if not met, exceptions are thrown
            if (actualResult != expectedResult)
            {
                throw new Exception($"This is wrong. {actualResult} is not equal to {expectedResult}");
            }

            Assert.True(actualResult == expectedResult);

            // tests pass if no exceptions are thrown while the test is running
            // tests fail if any exceptions are thrown while the test is running
            // throw new Exception("This test is bad and should feel bad.");
        }

        [Fact]
        public void the_number_4_should_be_translated_to_IV()
        {
            // Arrange
            var numberToTranslate = 4;
            var expectedResult = "IV";
            var translator = new NumberTranslator();

            // Act
            var actualResult = translator.Translate(numberToTranslate);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}

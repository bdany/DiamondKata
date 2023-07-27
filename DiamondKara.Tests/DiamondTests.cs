namespace DiamondKara.Tests
{
    [TestClass]
    public class DiamondTests
    {

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Generate_WithNumberAsInput_ThrowsArgumentException()
        {
            // Arrange
            char target = '1'; // Invalid input, should be an uppercase letter

            // Act
            Diamond.BuildDiamond(target);

            // The method should throw an ArgumentException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Generate_WithLowerCaseInput_ThrowsArgumentException()
        {
            // Arrange
            char target = 'a'; // Invalid input, should be an uppercase letter

            // Act
            Diamond.BuildDiamond(target);

            // The method should throw an ArgumentException
        }

        [TestMethod]
        public void A_Should_Give_Character_sequenceA()
        {
            // Arrange
            char target = 'A';
            string expectedOutput = "A";
                            
            // Act
            string result = Diamond.BuildDiamond(target);

            // Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void A_Diferent_Separator_Should_Give_Character_SequenceA()
        {
            // Arrange
            char target = 'A';
            char separator = '.';
            string expectedOutput = "A";

            // Act
            string result = Diamond.BuildDiamond(target, separator);

            // Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void Generate_WithValidInput_ReturnsDiamondPattern()
        {
            // Arrange
            char target = 'E';
            string expectedOutput =   "    A    " +
                                    "\n   B B   " +
                                    "\n  C   C  " +
                                    "\n D     D " +
                                    "\nE       E" +
                                    "\n D     D " +
                                    "\n  C   C  " +
                                    "\n   B B   " +
                                    "\n    A    ";

            // Act
            string result = Diamond.BuildDiamond(target);

            // Assert
            Assert.AreEqual(expectedOutput, result);
        }
        [TestMethod]
        public void Generate_WithValidInput_ReturnsDiamondPattern_DotSeparator()
        {
            // Arrange
            char target = 'B';
            char separator = '.';
            string expectedOutput =   ".A." +
                                    "\nB.B" +
                                    "\n.A.";

            // Act
            string result = Diamond.BuildDiamond(target, separator);

            // Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void Generate_WithValidInput_Different_Separator_SholdFail()
        {
            // Arrange
            char target = 'B';
            string expectedOutput =   ".A." +
                                    "\nB.B" +
                                    "\n.A.";

            // Act
            string result = Diamond.BuildDiamond(target);

            // Assert
            Assert.AreNotEqual(expectedOutput, result);
        }

    }
}
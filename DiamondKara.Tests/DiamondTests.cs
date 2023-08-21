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
            new Diamond(target);

            // The method should throw an ArgumentException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Generate_WithLowerCaseInput_ThrowsArgumentException()
        {
            // Arrange
            char target = 'a'; // Invalid input, should be an uppercase letter

            // Act
            new Diamond(target);

            // The method should throw an ArgumentException
        }

        [TestMethod]
        public void A_Should_Give_Character_sequenceA()
        {
            // Arrange
            char target = 'A';
            string expectedOutput = "A";
                            
            // Act
            var diamond = new Diamond(target);
            string result = diamond.ToString();

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
            var diamond = new Diamond(target, separator);
            string result = diamond.ToString();

            // Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void Generate_WithValidInput_ReturnsDiamondPattern()
        {
            // Arrange
            char target = 'C';
            string expectedOutput =   "  A  " +
                                    "\n B B " +
                                    "\nC   C" +
                                    "\n B B " +
                                    "\n  A  ";

            // Act
            var diamond = new Diamond(target);
            string result = diamond.ToString();

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
            var diamond = new Diamond(target, separator);
            string result = diamond.ToString();

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
            var diamond = new Diamond(target);
            string result = diamond.ToString();

            // Assert
            Assert.AreNotEqual(expectedOutput, result);
        }


        [DataTestMethod]
        [DataRow('A')]
        [DataRow('C')]
        [DataRow('Z')]
        public void Generate_WithValidInput_DynamicTest(char input)
        {
            // Arrange
            char target = input; 
            
            // Act
            var diamond = new Diamond(target);
            
            // Assert
            Assert.AreEqual((int)(target - 'A') * 2 + 1, diamond.DiamondLines.Length);

            //check if the diamond is symetric
            for (int i = 0; i < diamond.DiamondLines.Length / 2 + 1;i++)
            {
                Assert.AreEqual(diamond.DiamondLines[i], diamond.DiamondLines[diamond.DiamondLines.Length - 1 - i]);
            }
            // check if each line is symetric (palindrome)
            foreach (var line in diamond.DiamondLines)
            {
                var result = string.Compare(line, string.Concat(line.Reverse())) == 0;
                Assert.IsTrue(result);
            }
        }

    }
}
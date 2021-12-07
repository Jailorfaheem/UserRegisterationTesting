using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegularExpression00;

namespace ExceptionTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidFirstNameOfUser()
        {
            //AAA method
            //Arrange
            string name = "faheem";
            string expected = "invalid";
            //creating object of moodanalyzer class and passing message
            //RegularExpression regularExpression = new RegularExpression(name);

            //Act
            string actual = RegularExpression.FirstNameValid(name);

            //Assert
            //comparing actual and expected value
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidLastNameOfUser()
        {
            //AAA method
            //Arrange
            string lastName = "faheem";
            string expected = "invalid";

            //Act
            string actual = RegularExpression.LastNameNameValid(lastName);

            //Assert
            //comparing actual and expected value
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidEmailIdOfUser()
        {
            //AAA method
            //Arrange
            string emailId = " ";
            string expected = "invalid";

            //Act
            string actual = RegularExpression.EmailValid(emailId);

            //Assert
            //comparing actual and expected value
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidMobileNumOfUser()
        {
            //AAA method
            //Arrange
            string num = " ";
            string expected = "invalid";
            //Act
            string actual = RegularExpression.MobileNumValid(num);

            //Assert
            //comparing actual and expected value
            Assert.AreEqual(expected, actual);
        }
    }
}
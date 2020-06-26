using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace appunittest
{
    [TestClass]
    public class AppUnitTest
    {
        [TestMethod]
        public void Return_A_TrueCondition_Pass()
        {
            //Assign
            int x = 1; 
            int result = 2;
            //Arrange
            
            var y = ++x;

            //Assert
            Assert.AreEqual(result, y);

        }

        public void Return_A_FalseCondition_Pass()
        {
             //Assign
            int x = 1; 
             int result = 3;
            //Arrange
            
            var y = x++;

            //Assert
            Assert.AreNotEqual(result, y);

        }
    }
}

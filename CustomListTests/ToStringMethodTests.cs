using CustomList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListTests
{
    [TestClass]
    public class ToStringMethodTests
    {
        [TestMethod]
        public void ToStringStringifyValuesInt_ReturnCombinedInOneString()
        {
            //Arrange
            CustomList<int> myList = new();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            //Act 
            string result = myList.ToString();
            //Assert
            Assert.AreEqual("123", result);
        }
        [TestMethod]
        public void ToStringStringifyValuesString_ReturnCombinedInOneString()
        {
            //Arrange
            CustomList<string> myList = new();
            myList.Add("Hello");
            myList.Add("World");
            //Act 
            string result = myList.ToString();
            //Assert
            Assert.AreEqual("HelloWorld", result);
        }
        [TestMethod]
        public void ToStringStringifyValuesEmpty_ReturnEmptyString()
        {
            //Arrange
            CustomList<string> myList = new();
            //Act 
            string result = myList.ToString();
            //Assert
            Assert.AreEqual("", result);
        }


    }
}

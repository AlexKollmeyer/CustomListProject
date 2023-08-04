using CustomList;
namespace CustomListTests
{
    [TestClass]
    public class RemoveMethodTests
    {
        [TestMethod]
        public void RemoveMethod_RemoveOnlyItemInList_CountEquals0()
        {
            //Arrange
            CustomList<string> customList1 = new CustomList<string>();
            customList1.Add("e");

            //Act
            customList1.Remove("e");

            //Assert
            Assert.AreEqual(0, customList1.Count);
        }
        [TestMethod]
        public void RemoveMethod_RemoveOneOutOfTwoItemInList_CountEquals1()
        {
            //Arrange
            CustomList<string> customList1 = new CustomList<string>();
            customList1.Add("e");
            customList1.Add("greg");

            //Act
            customList1.Remove("e");

            //Assert
            Assert.AreEqual(1, customList1.Count);
        }
        [TestMethod]
        public void RemoveMethod_RemoveOneOutOfTwoItemInList_ReturnsTrue()
        {
            //Arrange
            CustomList<string> customList1 = new CustomList<string>();
            customList1.Add("e");
            customList1.Add("F");

            //Act
            bool Return =customList1.Remove("e");

            //Assert
            Assert.AreEqual(true,Return );
        }
        [TestMethod]
        public void RemoveMethod_RemoveOneOutOfTwoItemInList_CountEquals2()
        {
            //Arrange
            CustomList<string> customList1 = new CustomList<string>();
            customList1.Add("e");
            customList1.Add("greg");

            //Act
            customList1.Remove("Apple");

            //Assert
            Assert.AreEqual(2, customList1.Count);
        }
        [TestMethod]
        public void RemoveMethod_RemoveOneOutOfTwoItemInList_Index0EqualsF()
        {
            //Arrange
            CustomList<string> customList1 = new CustomList<string>();
            customList1.Add("e");
            customList1.Add("F");

            //Act
            customList1.Remove("e");

            //Assert
            Assert.AreEqual("F", customList1.Items[0]);
        }
        [TestMethod]
        public void RemoveMethod_RemoveEWhenEAppearsMultipleTimes_CountOnlyDecrementsBy1()
        {
            //Arrange
            CustomList<string> customList1 = new CustomList<string>();
            customList1.Add("E");
            customList1.Add("F");
            customList1.Add("E");
            customList1.Add("E");
            customList1.Add("E");


            //Act
            customList1.Remove("E");

            //Assert
            Assert.AreEqual(4,customList1.Count);
        }
        public void RemoveMethod_RemoveEWhenEAppearsMultipleTimes_Index0EqualsF()
        {
            //Arrange
            CustomList<string> customList1 = new CustomList<string>();
            customList1.Add("E");
            customList1.Add("F");
            customList1.Add("E");
            customList1.Add("E");
            customList1.Add("E");


            //Act
            customList1.Remove("E");

            //Assert
            Assert.AreEqual("F", customList1.Items[0]);
        }
        public void RemoveMethod_RemoveEWhenEAppearsMultipleTimes_Index1EqualsE()
        {
            //Arrange
            CustomList<string> customList1 = new CustomList<string>();
            customList1.Add("E");
            customList1.Add("F");
            customList1.Add("E");
            customList1.Add("E");
            customList1.Add("E");


            //Act
            customList1.Remove("E");

            //Assert
            Assert.AreEqual("E", customList1.Items[1]);
        }
        public void RemoveMethod_RemoveEWhenEAppearsMultipleTimes_SecondRemoveEReturnsTrue()
        {
            //Arrange
            CustomList<string> customList1 = new CustomList<string>();
            customList1.Add("E");
            customList1.Add("F");
            customList1.Add("E");
            customList1.Add("E");
            customList1.Add("E");


            //Act
            customList1.Remove("E");
            bool tf =customList1.Remove("E");

            //Assert
            Assert.AreEqual(true,tf);
        }
    }
}

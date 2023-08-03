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
            customList1.Add("greg");

            //Act
            customList1.Remove("e");

            //Assert
            Assert.AreEqual(true, );
        }

    }
}

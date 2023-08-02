using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class AddMethodTests
    {
        [TestMethod]
        public void AddMethod_AddMethodInt1ToCustomList_CountIncrementsBy1()
        {
            //Arrange
            CustomList<int> customlist1 = new CustomList<int>();



            //Act
            customlist1.Add(1);


            //Assert
            Assert.AreEqual(1, customlist1.Count);
        }
        [TestMethod]
        public void AddMethod_AddMethod1And5And7_1IsAtIndex0()
        {
            //Arrange
            CustomList<int> customlist1 = new CustomList<int>();



            //Act
            customlist1.Add(1);
            customlist1.Add(5);
            customlist1.Add(7);


            //Assert
            Assert.AreEqual(1, customlist1.Items[0] );
        }
    }
}

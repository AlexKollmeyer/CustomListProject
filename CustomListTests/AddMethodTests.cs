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
        public void AddMethod_AddMethodStrEAndStrAPPleToCustomList_CountIncrementsBy2()
        {
            //Arrange
            CustomList<string> customlist1 = new CustomList<string>();



            //Act
            customlist1.Add("E");
            customlist1.Add("Apple");


            //Assert
            Assert.AreEqual(2, customlist1.Count);
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
            Assert.AreEqual(1, customlist1.Items[0]);
        }
        [TestMethod]
        public void AddMethod_AddMethod1And5And7_5IsAtIndex1()
        {
            //Arrange
            CustomList<int> customlist1 = new CustomList<int>();



            //Act
            customlist1.Add(1);
            customlist1.Add(5);
            customlist1.Add(7);


            //Assert
            Assert.AreEqual(5, customlist1.Items[1]);
        }
        [TestMethod]
        public void AddMethod_AddMethodStrEAndStrAPPleToCustomList_AppleIsAtIndex1()
        {
            //Arrange
            CustomList<string> customlist1 = new CustomList<string>();



            //Act
            customlist1.Add("E");
            customlist1.Add("Apple");


            //Assert
            Assert.AreEqual("Apple", customlist1.Items[1]);
        }
        [TestMethod]
        public void AddMethod_AddMethod1And5And7And6And12_CapacityDoubles()
        {
            //Arrange
            CustomList<int> customlist1 = new CustomList<int>();



            //Act
            customlist1.Add(1);
            customlist1.Add(5);
            customlist1.Add(7);
            customlist1.Add(6);
            customlist1.Add(12);


            //Assert
            Assert.AreEqual(8, customlist1.Capacity);
        }
        [TestMethod]
        public void AddMethod_AddMethod1And5And7And6And12_7IsAtIndex2()
        {
            //Arrange
            CustomList<int> customlist1 = new CustomList<int>();



            //Act
            customlist1.Add(1);
            customlist1.Add(5);
            customlist1.Add(7);
            customlist1.Add(6);
            customlist1.Add(12);


            //Assert
            Assert.AreEqual(7, customlist1.Items[2]);
        }
    }
}

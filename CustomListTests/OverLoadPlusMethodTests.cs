using CustomList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListTests
{
    [TestClass]
    public class OverLoadPlusMethodTests
    {
        [TestMethod]
        public void OverLoadPlusMethodTest_AddingTwoEmptyLists_ResultIsSingleEmptyCustomList()
        {
            //Arrange
            CustomList<string> customlist1 = new CustomList<string>();
            CustomList<string> customList2 = new CustomList<string>();
            //Act
            CustomList<string> customListCombined = customlist1 + customList2;
            //Assert}
            Assert.AreEqual(0, customListCombined.Count);
        }
        [TestMethod]
        public void OverLoadPlusMethodTest_AddingOneIntCustomListToEmptyCustomList_ResultIsSingleCustomListWithWithCountOF2()
        {
            //Arrange
            CustomList<int> customlist1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            customlist1.Add(1);
            customlist1.Add(2);
            //Act
            CustomList<int> customListCombined = customlist1 + customList2;
            //Assert}
            Assert.AreEqual(2, customListCombined.Count);
        }
        [TestMethod]
        public void OverLoadPlusMethodTest_AddingTwoStringListsWith2ItemsEach_ResultIsSingleCustomListWith4Items()
        {
            //Arrange
            CustomList<string> customlist1 = new CustomList<string>();
            CustomList<string> customList2 = new CustomList<string>();
            customlist1.Add("hello");
            customlist1.Add("world");
            customList2.Add("Hello");
            customList2.Add("World");
            //Act
            CustomList<string> customListCombined = customlist1 + customList2;
            //Assert}
            Assert.AreEqual(4, customListCombined.Count);
        }
        [TestMethod]
        public void OverLoadPlusMethodTest_AddingTwoStringListsWith2ItemsEach_ResultIsSingleCustomListHasItemInCorrectSpot()
        {
            //Arrange
            CustomList<string> customlist1 = new CustomList<string>();
            CustomList<string> customList2 = new CustomList<string>();
            customlist1.Add("hello");
            customlist1.Add("world");
            customList2.Add("Hello");
            customList2.Add("World");
            //Act
            CustomList<string> customListCombined = customlist1 + customList2;
            //Assert}
            Assert.AreEqual("World", customListCombined[3]);

        }
    }
}

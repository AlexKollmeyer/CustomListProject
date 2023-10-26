using CustomList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListTests
{
    [TestClass]
    public class MinusOverloadOperatorMethodTests
    {
        [TestMethod]
        public void OverLoadMinusMethodTest_SubtractingTwoEmptyLists_ResultIsSingleEmptyCustomList()
        {
            //Arrange
            CustomList<string> customlist1 = new CustomList<string>();
            CustomList<string> customList2 = new CustomList<string>();
            //Act
            CustomList<string> customListSubtracted = customlist1 - customList2;
            //Assert}
            Assert.AreEqual(0, customListSubtracted.Count);
        }
        [TestMethod]
        public void OverLoadMinusMethodTest_SubtractingOneIntCustomListToEmptyCustomList_ResultIsSingleCustomListWithWithCountOF2()
        {
            //Arrange
            CustomList<int> customlist1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            customlist1.Add(1);
            customlist1.Add(2);
            //Act
            CustomList<int> customListSubtracted = customlist1 + customList2;
            //Assert}
            Assert.AreEqual(2, customListSubtracted.Count);
        }
        [TestMethod]
        public void OverLoadMinusMethodTest_SubtractingTwoStringListsWith2ItemsEachOneOfSecondListIsDuplicate_ResultIsSingleCustomListWith1Item()
        {
            //Arrange
            CustomList<string> customlist1 = new CustomList<string>();
            CustomList<string> customList2 = new CustomList<string>();
            customlist1.Add("hello");
            customlist1.Add("world");
            customList2.Add("hello");
            customList2.Add("World");
            //Act
            CustomList<string> customListSubtracted = customlist1 - customList2;
            //Assert}
            Assert.AreEqual(1, customListSubtracted.Count);
        }
        [TestMethod]
        public void OverLoadMinusMethodTest_AddingTwoStringListsWith2ItemsEachOneOfSecondListIsDuplicate_ResultIsSingleCustomListHasCountOf1()
        {
            //Arrange
            CustomList<string> customlist1 = new CustomList<string>();
            CustomList<string> customList2 = new CustomList<string>();
            customlist1.Add("hello");
            customlist1.Add("world");
            customList2.Add("hello");
            customList2.Add("World");
            //Act
            CustomList<string> customListSubtracted = customlist1 - customList2;
            //Assert}
            Assert.AreEqual(1, customListSubtracted.Count);
        }
        [TestMethod]
        public void OverLoadMinusMethodTest_AddingTwoIntListsWith2ItemsAllOfSecondListisDuplicate_ResultIsSingleCustomListHasOnly2Count()
        {
            //Arrange
            CustomList<int> customlist1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            customlist1.Add(1);
            customlist1.Add(2);
            customList2.Add(1);
            customList2.Add(2);
            //Act 
            CustomList<int> customListCombined = customlist1 - customList2;
            //Assert}
            Assert.AreEqual(0, customListCombined.Count);
        }
    }
}

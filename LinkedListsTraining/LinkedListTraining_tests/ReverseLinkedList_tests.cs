using LinkedListsTraining.ReverseLinkedList;
using LinkedListTraining_tests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTraining_tests
{
    [TestClass]
    public class ReverseLinkedLists_tests
    {
        [TestMethod]
        public void ReverseList_EmptyItem_ReturnsReverseLists()
        {
            //Arrange
            var input = LinkedListBuilder.CreateSinglyLinkedList(new int[] {});
            var expected = LinkedListBuilder.CreateSinglyLinkedList(new int[] {});
            var sut = new Solution();
            //Act
            var actual = sut.ReverseList(input);
            //Assert
            AssertLinkedLists.NodesHaveEqualValue(expected, actual);
        }

        [TestMethod]
        public void ReverseList_SingleItem_ReturnsReverseLists()
        {
            //Arrange
            var input = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 1 });
            var expected = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 1 });
            var sut = new Solution();
            //Act
            var actual = sut.ReverseList(input);
            //Assert
            AssertLinkedLists.NodesHaveEqualValue(expected, actual);
        }

        [TestMethod]
        public void ReverseList_MultiItems_ReturnsReverseLists()
        {
            //Arrange
            var input = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            var expected = LinkedListBuilder.CreateSinglyLinkedList(new int[] {10, 9, 8, 7, 6, 5, 4, 3, 2, 1 });
            var sut = new Solution();
            //Act
            var actual = sut.ReverseList(input);
            //Assert
            AssertLinkedLists.NodesHaveEqualValue(expected, actual);
        }
    }
}

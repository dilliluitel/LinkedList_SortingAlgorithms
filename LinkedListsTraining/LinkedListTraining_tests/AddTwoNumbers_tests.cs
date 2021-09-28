using LinkedListsTraining.AddTwoNumbers;
using LinkedListTraining_tests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedListTraining_tests
{
    [TestClass]
    public class AddTwoNumbers_tests
    {
        [TestMethod]
        public void AddTwoNumbers_BothEmptyList_ReturnsAddedNumbers()
        {
            //Arrange
            var input_l1 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { });
            var input_l2 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { });
            var expected = LinkedListBuilder.CreateSinglyLinkedList(new int[] { });
            var sut = new Solution();
            //Act
            var actual = sut.AddTwoNumbers(input_l1, input_l2);
            //Assert
            AssertLinkedLists.NodesHaveEqualValue(expected, actual);
        }

        [TestMethod]
        public void AddTwoNumbers_FirstEmptyList_ReturnsAddedNumbers()
        {
            //Arrange
            var input_l1 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { });
            var input_l2 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 3 });
            var expected = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 3 });
            var sut = new Solution();
            //Act
            var actual = sut.AddTwoNumbers(input_l1, input_l2);
            //Assert
            AssertLinkedLists.NodesHaveEqualValue(expected, actual);
        }

        [TestMethod]
        public void AddTwoNumbers_SecondEmptyList_ReturnsAddedNumbers()
        {
            //Arrange
            var input_l1 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 0 });
            var input_l2 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { });
            var expected = LinkedListBuilder.CreateSinglyLinkedList(new int[] { });
            var sut = new Solution();
            //Act
            var actual = sut.AddTwoNumbers(input_l1, input_l2);
            //Assert
            AssertLinkedLists.NodesHaveEqualValue(expected, actual);
        }
        [TestMethod]
        public void AddTwoNumbers_SingleDigits_ReturnsAddedNumbers()
        {
            //Arrange
            var input_l1 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 1 });
            var input_l2 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 2 });
            var expected = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 3 });
            var sut = new Solution();
            //Act
            var actual = sut.AddTwoNumbers(input_l1, input_l2);
            //Assert
            AssertLinkedLists.NodesHaveEqualValue(expected, actual);
        }

        [TestMethod]
        public void AddTwoNumbers_MultipleDigits_ReturnsAddedNumbers()
        {
            var input_l1 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 1, 1, 1 });
            var input_l2 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 2, 2, 2 });
            var expected = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 3, 3, 3 });
            var sut = new Solution();

            var actual = sut.AddTwoNumbers(input_l1, input_l2);

            AssertLinkedLists.NodesHaveEqualValue(expected, actual);
        }

        [TestMethod]
        public void AddTwoNumbers_WithCarryOver_ReturnsAddedNumbers()
        {
            var input_l1 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 2, 2, 8 });
            var input_l2 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 2, 2, 3 });
            var expected = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 4, 4, 1, 1 });
            var sut = new Solution();

            var actual = sut.AddTwoNumbers(input_l1, input_l2);

            AssertLinkedLists.NodesHaveEqualValue(expected, actual);
        }

        [TestMethod]
        public void AddTwoNumbers_WithMultipleCarryOvers_ReturnsAddedNumbers()
        {
            var input_l1 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 9, 9, 9, 9, 9, 9, 9 });
            var input_l2 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 9, 9, 9 });
            var expected = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 8, 9, 9, 0, 0, 0, 0, 1 });
            var sut = new Solution();

            var actual = sut.AddTwoNumbers(input_l1, input_l2);

            AssertLinkedLists.NodesHaveEqualValue(expected, actual);
        }

        [TestMethod]
        public void AddTwoNumbers_LongNumbers_ReturnsAddedNumbers()
        {
            var input_l1 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 });
            var input_l2 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 });
            var expected = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 8, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 1 });
            var sut = new Solution();

            var actual = sut.AddTwoNumbers(input_l1, input_l2);

            AssertLinkedLists.NodesHaveEqualValue(expected, actual);
        }
    }
}

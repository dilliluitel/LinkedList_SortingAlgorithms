using LinkedListsTraining;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListTraining_tests.Helpers;


namespace LinkedListTraining_tests
{
    [TestClass]
    public class MyLinkedList_tests
    {
        [TestMethod]
        public void AddAtHead_OneNumber_CanReturnNumber()
        {
            var input = 2;
            var expected = 2;
            var sut = new MyLinkedList();

            sut.AddAtHead(input);

            var actual = sut.Get(0);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Get_EmptyItemList_ReturnsAflagValue()
        {
            var input = 0;
            var expected = -1;
            var sut = new MyLinkedList();

            var actual = sut.Get(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddAtHead_AddMultipleItems_ReturnsNewList()
        {
            //Arrange
            var sut = new MyLinkedList();

            var expected = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 1, 2, 3 });
            
            //Act
            sut.AddAtHead(3);
            sut.AddAtHead(2);
            sut.AddAtHead(1);

            var actual = sut.Head;

            //Assert
            AssertLinkedLists.NodesHaveEqualValue(expected, actual);
        }

        [TestMethod]
        public void AddAtTail_AddMultipleItems_ReturnsNewList()
        {
            //Arrange
            var sut = new MyLinkedList();

            var expected = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 1, 2, 3 });

            //Act
            sut.AddAtTail(1);
            sut.AddAtTail(2);
            sut.AddAtTail(3);

            var input = sut.Head;

            //Assert
            AssertLinkedLists.NodesHaveEqualValue(expected, input);
        }


        [TestMethod]
        public void AddAtIndex_AddMultipleItems_ReturnsNewList()
        {
            //Arrange
            var sut = new MyLinkedList();

            var expected = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 1, 2, 3 });

            //Act

            sut.AddAtIndex(0, 2);
            sut.AddAtIndex(1, 3);
            sut.AddAtIndex(0, 1);

            var input = sut.Head;

            //Assert
            AssertLinkedLists.NodesHaveEqualValue(expected, input);
        }

        [TestMethod]
        public void DeleteAtIndex_DeleteItemAtTail_ReturnsNewList()
        {
            //Arrange
            var sut = new MyLinkedList();

            var expected = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 1, 2, 3 });

            //Act

            sut.AddAtIndex(0, 2);
            sut.AddAtIndex(1, 3);
            sut.AddAtIndex(2, 4);
            sut.AddAtIndex(0, 1);
            sut.DeleteAtIndex(3);

            var input = sut.Head;

            //Assert
            AssertLinkedLists.NodesHaveEqualValue(expected, input);
        }
        [TestMethod]
        public void DeleteAtIndex_DeleteItemAtHead_ReturnsNewList()
        {
            //Arrange
            var sut = new MyLinkedList();

            var expected = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 1, 2, 3 });

            //Act

            sut.AddAtIndex(0, 2);
            sut.AddAtIndex(1, 3);
            sut.AddAtHead(1);
            sut.AddAtIndex(0, 4);
            sut.DeleteAtIndex(0);

            var input = sut.Head;

            //Assert
            AssertLinkedLists.NodesHaveEqualValue(expected, input);
        }
       
    }
}

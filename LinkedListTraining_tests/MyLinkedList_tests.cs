using LinkedListsTraining;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void GetFromEmptyList()
        {
            var inputIndex = 0;
            var expected = -1;

            var sut = new MyLinkedList();
            var actual = sut.Get(inputIndex);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void AddAtHead_TwoNumbers_GetOutOffRange()
        {
            var input1 = 1;
            var input2 = 2;
            var inputIndex = 3;
            var expected = -1;

            var sut = new MyLinkedList();
            sut.AddAtHead(input1);
            sut.AddAtHead(input2);
            var actual = sut.Get(inputIndex);

            Assert.AreEqual(actual, expected);
            // Test list is always OK
            Assert.AreEqual(input2, sut.Get(0));
        }

        [TestMethod]
        public void AddAtTail_ThreeNumbers_GetLast()
        {
            var input1 = 1;
            var input2 = 2;
            var input3 = 3;
            var inputIndex = 2;
            var expected = 3;

            var sut = new MyLinkedList();
            sut.AddAtTail(input1);
            sut.AddAtTail(input2);
            sut.AddAtTail(input3);
            var actual = sut.Get(inputIndex);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void AddAtTail_ThreeNumbers_DeleteMiddle_GetOneTh()
        {
            var input1 = 1;
            var input2 = 2;
            var input3 = 3;
            var nodeToDeleteindex = 1;
            var nodeToGetIndex = 1;
            var expected = 3;

            var sut = new MyLinkedList();
            sut.AddAtTail(input1);
            sut.AddAtTail(input2);
            sut.AddAtTail(input3);

            sut.DeleteAtIndex(nodeToDeleteindex);
            var actual = sut.Get(nodeToGetIndex);

            Assert.AreEqual(actual, expected);
        }


        [TestMethod]
        public void AddAtTail_ThreeNumbers_DeleteFirst_GetNewFirst()
        {
            var input1 = 1;
            var input2 = 2;
            var input3 = 3;
            var nodeToDeleteindex = 0;
            var nodeToGetIndex = 0;
            var expected = 2;

            var sut = new MyLinkedList();
            sut.AddAtTail(input1);
            sut.AddAtTail(input2);
            sut.AddAtTail(input3);

            sut.DeleteAtIndex(nodeToDeleteindex);
            var actual = sut.Get(nodeToGetIndex);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void AddAtTail_ThreeNumbers_DeleteLast_GetOldLastIndexNumber()
        {
            var input1 = 1;
            var input2 = 2;
            var input3 = 3;
            var nodeToDeleteindex = 2;
            var nodeToGetIndex = 2;
            var expected = -1;

            var sut = new MyLinkedList();
            sut.AddAtTail(input1);
            sut.AddAtTail(input2);
            sut.AddAtTail(input3);

            sut.DeleteAtIndex(nodeToDeleteindex);
            var actual = sut.Get(nodeToGetIndex);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void AddAtTail_ThreeNumbers_AddAtIndexZero_GetZero()
        {
            var input1 = 1;
            var input2 = 2;
            var input3 = 3;
            var input4 = 4;
            var nodeToAddindex = 0;
            var nodeToGetIndex = 0;
            var expected = 4;

            var sut = new MyLinkedList();
            sut.AddAtTail(input1);
            sut.AddAtTail(input2);
            sut.AddAtTail(input3);
            sut.AddAtIndex(nodeToAddindex, input4);

            var actual = sut.Get(nodeToGetIndex);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void AddAtTail_ThreeNumbers_AddAtIndexOne_GetSecond()
        {
            var input1 = 1;
            var input2 = 2;
            var input3 = 3;
            var input4 = 4;
            var nodeToAddindex = 1;
            var nodeToGetIndex = 1;
            var expected = 4;

            var sut = new MyLinkedList();
            sut.AddAtTail(input1);
            sut.AddAtTail(input2);
            sut.AddAtTail(input3);
            sut.AddAtIndex(nodeToAddindex, input4);

            var actual = sut.Get(nodeToGetIndex);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void AddAtTail_ThreeNumbers_AddAtIndexListSize_GetLast()
        {
            var input1 = 1;
            var input2 = 2;
            var input3 = 3;
            var input4 = 4;
            var nodeToAddindex = 3;
            var nodeToGetIndex = 3;
            var expected = 4;

            var sut = new MyLinkedList();
            sut.AddAtTail(input1);
            sut.AddAtTail(input2);
            sut.AddAtTail(input3);
            sut.AddAtIndex(nodeToAddindex, input4);

            var actual = sut.Get(nodeToGetIndex);

            Assert.AreEqual(actual, expected);
        }
    }
}

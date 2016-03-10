using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedStackClass.Tests
{
    [TestClass]
    public class LinkedStackTests
    {
        [TestMethod]
        public void CreateNewLinkStackElementPushPopTestByCountOfElements()
        {
            var test = new LinkedStack<int>();
            Assert.AreEqual(0, test.Count, string.Format("Generated object and the count of the elements are {0}, expecting {1}", test.Count, 0));
            test.Push(1);
            Assert.AreEqual(1, test.Count, string.Format("Generated object and the count of the elements are {0}, expecting {1}", test.Count, 1));
            test.Pop();
            Assert.AreEqual(0, test.Count, string.Format("Generated object and the count of the elements are {0}, expecting {1}", test.Count, 0));
        }

        [TestMethod]

        public void CreateNewLinkStacOfTypeStringsPushThousandPopThousandTestByCountOfElements()
        {
            var test = new LinkedStack<string>();
            Assert.AreEqual(0, test.Count, string.Format("Generated object and the count of the elements are {0}, expecting {1}", test.Count, 0));

            for (int i = 0; i < 1000; i++)
            {
                test.Push(Convert.ToString(i));
            }
            Assert.AreEqual(1000, test.Count, string.Format("Generated object and the count of the elements are {0}, expecting {1}", test.Count, 1000));

            for (int i = 0; i < 1000; i++)
            {
                test.Pop();
            }

            Assert.AreEqual(0, test.Count, string.Format("value", "Generated object and the count of the elements are {0}, expecting {1}", test.Count, 0));
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException), "throw incorect exception")]
        public void PopFromNullLinkStacObjectShouldThrowException()
        {
            var test = new LinkedStack<char>();
            test.Pop();
        }

        [TestMethod]
        public void CheckToArrayMethodOfLinkStac()
        {
            var test = new LinkedStack<int>();
            int[] testArrToPush = new int[] { 3, 5, -2, 7 };

            foreach (var item in testArrToPush)
            {
                test.Push(item);
            }

            Array.Reverse(testArrToPush);

            var toArrArray = test.ToArray();

            CollectionAssert.AreEqual(testArrToPush, toArrArray, String.Format("Generated object is {0}, expected object is {1}", toArrArray, testArrToPush));
        }

        [TestMethod]
        public void CheckToArrayOfLinkStacWithEmptyStackExpectEmptyArray()
        {
            var test = new LinkedStack<DateTime>();

            var toArrArray = test.ToArray();

            CollectionAssert.AreEqual(new DateTime[] { }, toArrArray, String.Format("Generated object is {0}, expected object is {1}", toArrArray, new DateTime[] { }));
        }
    }
}

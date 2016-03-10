using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _07_LinkedQueue;

namespace _08_LinkedQueue.Tests
{
    [TestClass]
    public class LinkedQueueTests
    {
        [TestMethod]
        public void CreateNewLinkedQueueElementPushPopTestByCountOfElements()
        {
            var test = new LinkedQueue<int>();
            Assert.AreEqual(0, test.Count, string.Format("Generated object and the count of the elements are {0}, expecting {1}", test.Count, 0));
            test.Enqueue(1);
            Assert.AreEqual(1, test.Count, string.Format("Generated object and the count of the elements are {0}, expecting {1}", test.Count, 1));
            test.Dequeue();
            Assert.AreEqual(0, test.Count, string.Format("Generated object and the count of the elements are {0}, expecting {1}", test.Count, 0));
        }

        [TestMethod]
        public void CreateNewLinkedQueueOfTypeStringsPushThousandPopThousandTestByCountOfElements()
        {
            var test = new LinkedQueue<string>();
            Assert.AreEqual(0, test.Count, string.Format("Generated object and the count of the elements are {0}, expecting {1}", test.Count, 0));

            for (int i = 0; i < 1000; i++)
            {
                test.Enqueue(Convert.ToString(i));
            }
            Assert.AreEqual(1000, test.Count, string.Format("Generated object and the count of the elements are {0}, expecting {1}", test.Count, 1000));

            for (int i = 0; i < 1000; i++)
            {
                test.Dequeue();
            }

            Assert.AreEqual(0, test.Count, string.Format("value", "Generated object and the count of the elements are {0}, expecting {1}", test.Count, 0));
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException), "throw incorect exception")]
        public void PopFromNullLinkedQueueObjectShouldThrowException()
        {
            var test = new LinkedQueue<char>();
            test.Dequeue();
        }

        [TestMethod]
        public void CheckToArrayMethodOfLinkStac()
        {
            var test = new LinkedQueue<int>();
            int[] testArrToPush = new int[] { 3, 5, -2, 7 };

            foreach (var item in testArrToPush)
            {
                test.Enqueue(item);
            }

            var toArrArray = test.ToArray();

            CollectionAssert.AreEqual(testArrToPush, toArrArray, String.Format("Generated object is {0}, expected object is {1}", toArrArray, testArrToPush));
        }

        [TestMethod]
        public void CheckDequeueElement()
        {
            var test = new LinkedQueue<int>();
            int[] testArrToPush = new int[] { 3, 5, -2, 7 };

            foreach (var item in testArrToPush)
            {
                test.Enqueue(item);
            }
            var testValue = test.Dequeue();
            Assert.AreEqual(testArrToPush[0], testValue, string.Format("test value {0} don't mach with dequeue value {1}", testArrToPush[0], testValue));
        }
    }
}

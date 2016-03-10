using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArrStackClass //_03_Array_BasedStack.Tests
{
    [TestClass]
    public class ArrStackClassTests
    {
        [TestMethod]
        public void CreateNewElementPushPopTestByCountOfElements()
        {
            var test = new ArrayStack<int>();
            Assert.AreEqual(0, test.Count, string.Format("Generated object and the count of the elements are {0}, expecting {1}", test.Count, 0));
            test.Push(1);
            Assert.AreEqual(1, test.Count, string.Format("Generated object and the count of the elements are {0}, expecting {1}", test.Count, 1));
            test.Pop();
            Assert.AreEqual(0, test.Count, string.Format("Generated object and the count of the elements are {0}, expecting {1}", test.Count, 0));
        }

        [TestMethod]

        public void CreateNewElementsOfTypeStringsPushThousandPopThousandTestByCountOfElements()
        {
            var test = new ArrayStack<string>();
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
        public void CreateNewElementPopShouldThrowException()
        {
            var test = new ArrayStack<char>();
            test.Pop();
        }

        [TestMethod]
        public void CreateNewElementWithCapacityOnePushPopTestByCountOfElements()
        {
            var test = new ArrayStack<int>(1);
            Assert.AreEqual(0, test.Count, string.Format("Generated object and the count of the elements are {0}, expecting {1}", test.Count, 0));
            test.Push(1);
            Assert.AreEqual(1, test.Count, string.Format("Generated object and the count of the elements are {0}, expecting {1}", test.Count, 1));
            test.Push(2);
            Assert.AreEqual(2, test.Count, string.Format("Generated object and the count of the elements are {0}, expecting {1}", test.Count, 2));
            test.Pop();
            Assert.AreEqual(1, test.Count, string.Format("Generated object and the count of the elements are {0}, expecting {1}", test.Count, 0));
            test.Pop();
            Assert.AreEqual(0, test.Count, string.Format("Generated object and the count of the elements are {0}, expecting {1}", test.Count, 0));
        }

        [TestMethod]
        public void CheckToArrayMethod()
        {
            var test = new ArrayStack<int>();
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
        public void CheckToArrayWithEmptyStackExpectEmptyArray()
        {
            var test = new ArrayStack<DateTime>();
            
            var toArrArray = test.ToArray();

            CollectionAssert.AreEqual(new DateTime[] { }, toArrArray, String.Format("Generated object is {0}, expected object is {1}", toArrArray, new DateTime[] { }));
        }
        
    }
}

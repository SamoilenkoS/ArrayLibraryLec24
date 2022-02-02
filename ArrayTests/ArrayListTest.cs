using ArrayLibrary;
using NUnit.Framework;
using System;
using System.Diagnostics;

namespace ArrayTests
{
    public class ArrayListTest
    {
        //[TestCase(new int[] { })]
        [TestCase(new[] { 1, 2, 3, 4 })]
        [TestCase(new[] { 1 })]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6 })]
        public void InitializeNewArray_ShouldFillArray(int[] sourceArray)
        {
            ArrayList array = new ArrayList(sourceArray);

            CollectionAssert.AreEqual(array, sourceArray);
        }

        [TestCase(new[] { 1, 2, 3, 4 }, 0, new[] { 0, 1, 2, 3, 4 })]
        [TestCase(new[] { 1 }, 0, new[] { 0, 1 })]
        [TestCase(new int[] { }, 0, new[] { 0 })]
        public void AddValueInFront_WhenArrayFilled_ShouldAddedValueInFrontByFillArray(
            int[] sourceArray,
            int value,
            int[] expectedArray)
        {
            ArrayList array = new ArrayList(sourceArray);

            array.AddFront(value);

            CollectionAssert.AreEqual((System.Collections.IEnumerable)array, expectedArray);
        }

        [TestCase(new[] { 1, 2, 3, 4 }, 0, new[] { 1, 2, 3, 4, 0 })]
        [TestCase(new[] { 1 }, 0, new[] { 1, 0 })]
        [TestCase(new int[] { }, 0, new[] { 0 })]
        public void AddValueInBack_WhenArrayFilled_ShouldAddedValueInBackByFillArray(
            int[] sourceArray,
            int value,
            int[] expectedArray)
        {
            ArrayList array = new ArrayList(sourceArray);

            array.AddBack(value);

            CollectionAssert.AreEqual(expectedArray, array);
        }

        [TestCase(new[] { 1, 2, 3, 4 }, 0, 10, new[] { 10, 1, 2, 3, 4})]
        [TestCase(new[] { 1, 2, 3, 4 }, 1, 10, new[] { 1, 10, 2, 3, 4})]
        [TestCase(new[] { 1, 2, 3, 4 }, 2, 10, new[] { 1, 2, 10, 3, 4})]
        [TestCase(new[] { 1, 2, 3, 4 }, 3, 10, new[] { 1, 2, 3, 10, 4 })]
        [TestCase(new[] { 1, 2, 3, 4 }, 4, 10, new[] { 1, 2, 3, 4, 10 })]
        [TestCase(new[] { 1 }, 0, 2, new[] { 2, 1 })]
        [TestCase(new int[] { }, 0, 1, new[] { 1 })]
        public void AddValueByIndex_WhenArrayFilled_ShouldAddedValueByIndexInFillArray(
            int[] sourceArray,
            int index,
            int value,
            int[] expectedArray)
        {
            ArrayList array = new ArrayList(sourceArray);

            array.AddByIndex(index, value);

            CollectionAssert.AreEqual((System.Collections.IEnumerable)array, expectedArray);
        }

        [TestCase(new[] { 1, 2, 3, 4 }, new[] { 2, 3, 4 })]
        [TestCase(new[] { 1, 2, 3 }, new[] { 2, 3 })]
        [TestCase(new[] { 1, 2 }, new[] { 2 })]
        public void RemoveFromFront_WhenArrayFilled_ShouldArrayWithRemovedFirstValue(
            int[] sourceArray,
            int[] expectedArray)
        {
            ArrayList array = new ArrayList(sourceArray);

            array.RemoveFromFront();
            CollectionAssert.AreEqual((System.Collections.IEnumerable)array, expectedArray);
        }

        [TestCase(new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3 }, 4)]
        [TestCase(new[] { 1, 2, 3 }, new[] { 1, 2 }, 3)]
        [TestCase(new[] { 1, 2 }, new[] { 1 }, 2)]
        public void RemoveFromBack_WhenArrayFilled_ShouldArrayWithRemovedLastValue(
            int[] sourceArray,
            int[] expectedArray,
            int expectedRemoved)
        {
            ArrayList array = new ArrayList(sourceArray);

            int actualRemoved = array.RemoveFromBack();

            Assert.AreEqual(expectedRemoved, actualRemoved);
            CollectionAssert.AreEqual(expectedArray, array);
        }

        [TestCase(new[] { 1, 2, 3, 4 }, 0, new[] { 2, 3, 4 })]
        [TestCase(new[] { 1, 2, 3, 4 }, 1, new[] { 1, 3, 4 })]
        [TestCase(new[] { 1, 2, 3, 4 }, 2, new[] { 1, 2, 4 })]
        [TestCase(new[] { 1, 2, 3, 4 }, 3, new[] { 1, 2, 3 })]
        [TestCase(new[] { 1, 2, 3}, 2, new[] { 1, 2 })]
        [TestCase(new[] { 1, 2}, 1, new[] { 1 })]
        [TestCase(new[] { 1 }, 0, new int[] { })]
        public void RemoveByIndex_WhenArrayFilled_ShouldArrayWithRemovedValueByIndex(
            int[] sourceArray,
            int index,
            int[] expectedArray)
        {
            ArrayList array = new ArrayList(sourceArray);

            Debug.Write("Hello world!");
            array.RemoveByIndex(index);

            CollectionAssert.AreEqual((System.Collections.IEnumerable)array, expectedArray);
        }

        [TestCase(new[] { 1, 2, 3, 4 }, 2, new[] { 3, 4 })]
        [TestCase(new[] { 1 }, 0, new int[] { 1 })]
        public void RemoveFrontByCount_WhenArrayFilled_ShouldArrayWithRemovedValueByCountFromFront(
            int[] sourceArray,
            int count,
            int[] expectedArray)
        {
            ArrayList array = new ArrayList(sourceArray);

            int[] result = array.RemoveFront(count);
            CollectionAssert.AreEqual((System.Collections.IEnumerable)result, expectedArray);
        }

        [TestCase(new[] { 1, 2, 3, 4 }, 2, new[] { 1, 2 })]
        [TestCase(new[] { 1 }, 0, new int[] { 1 })]
        public void RemoveBack_WhenArrayFilled_ShouldRemoveLastElement(
            int[] sourceArray,
            int count,
            int[] expectedArray)
        {
            ArrayList array = new ArrayList(sourceArray);

            int[] result = array.RemoveBack(count);

            CollectionAssert.AreEqual((System.Collections.IEnumerable)result, expectedArray);
        }

        [TestCase(new[] { 1, 2, 3, 4, 5 }, 1, 2, new[] { 1, 4, 5 })]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 3, 2, new[] { 1, 2, 3 })]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 0, 3, new[] { 5 })]
        public void RemoveBackByCount_WhenArrayFilled_ShouldArrayWithRemovedValueByCountFromBack(
            int[] sourceArray,
            int index,
            int count,
            int[] expectedArray)
        {
            ArrayList array = new ArrayList(sourceArray);

            int[] result = array.RemoveByIndex(index, count);

            CollectionAssert.AreEqual((System.Collections.IEnumerable)result, expectedArray);
        }

        [TestCase(new[] { 1, 2, 3, 4, 5 }, 5 )]
        [TestCase(new[] { 1, 12, 3, 4, 5 }, 12 )]
        [TestCase(new[] { 31, 12, 3, 4, 5 }, 31)]
        [TestCase(new[] { 31, 12, 3, 41, 5 }, 41)]
        public void GetMaxValue_WhenArrayFilled_ShoulMaxValueInArray(
            int[] sourceArray,
            int expectedValue)
        {
            ArrayList array = new ArrayList(sourceArray);

            int result = array.Max();
            Assert.AreEqual(result, expectedValue);
        }

        [TestCase(new[] { 31 }, 0)]
        [TestCase(new[] { 1, 2, }, 1)]
        [TestCase(new[] { 1, 12, 3 }, 1)]
        [TestCase(new[] { 1, 12, 3, 4, 35 }, 4)]
        [TestCase(new[] { 31, 12, 3, 41, 5 }, 3)]
        public void GetMaxIndex_WhenArrayFilled_ShoulMaxIndexInArray(
            int[] sourceArray,
            int expectedValue)
        {
            ArrayList array = new ArrayList(sourceArray);

            int result = array.MaxI();
            Assert.AreEqual(result, expectedValue);
        }

        [TestCase(new[] { 31 }, 0)]
        [TestCase(new[] { 1, 2, }, 0)]
        [TestCase(new[] { 1, 12, -3 }, 2)]
        [TestCase(new[] { 1, 12, 3, -4, 35 }, 3)]
        public void GetMinIndex_WhenArrayFilled_ShoulMinIndexInArray(
            int[] sourceArray,
            int expectedValue)
        {
            ArrayList array = new ArrayList(sourceArray);

            int result = array.MinI();
            Assert.AreEqual(result, expectedValue);
        }

        [TestCase(new[] { 31 }, 31)]
        [TestCase(new[] { 1, 2, }, 1)]
        [TestCase(new[] { 1, 12, -3 }, -3)]
        [TestCase(new[] { 1, 12, 3, -4, 35 }, -4)]
        public void GetMinValueByIndex_WhenArrayFilled_ShoulMinValueInArray(
            int[] sourceArray,
            int expectedValue)
        {
            ArrayList array = new ArrayList(sourceArray);

            int result = array.Min();
            Assert.AreEqual(result, expectedValue);
        }

        [TestCase(new[] { 31 }, new[] { 31 })]
        [TestCase(new[] { 1, 2, }, new[] { 2, 1, })]
        [TestCase(new[] { 1, 12, -3 }, new[] { -3, 12, 1 })]
        [TestCase(new[] { 1, 12, 3, -4, 35 }, new[] { 35, -4, 3, 12, 1 })]
        public void ReverseArray_WhenArrayFilled_ShoulReverseArray(
            int[] sourceArray,
            int[] expectedArray)
        {
            ArrayList array = new ArrayList(sourceArray);

            //int[] result = array.Reverse();
            //CollectionAssert.AreEqual((System.Collections.IEnumerable)result, expectedArray);
        }

        [Test]
        public void Test()
        {
            SystemA systemA = new SystemA();
            SystemB systemB = new SystemB();

            systemB.UserUpdate();
            systemA.DataUpdate();

            DataStorage.GetInstance().DebugData();

        }

        [Test]
        public void Test2()
        {
            RoundHole roundHole = new RoundHole(10);
            SquareFigure squareFigure = new SquareFigure(6);
            SquareFigureAdapter squareFigureAdapter = new SquareFigureAdapter(squareFigure);

            Debug.WriteLine(
                roundHole.CouldInsert(squareFigureAdapter));

        }
    }
}
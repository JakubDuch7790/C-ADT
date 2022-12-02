using BasicDataStructures.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BasicDataStructures.Test
{
    public class MyQueueTest
    {
        [Fact]
        public void Enque_EmptyQueue_CorrectlyInserted()
        {
            //Arrange
            MyQueue myQueue = new MyQueue();

            var insertedValue = 25;

            // Act
            myQueue.Enque(insertedValue);

            //Assert
            Assert.NotNull(myQueue.First);
            Assert.NotNull(myQueue.Last);
            Assert.Equal(insertedValue, myQueue.First.Value);
            Assert.Equal(insertedValue, myQueue.Last.Value);
            Assert.Null(myQueue.First.Previous);
        }

        [Fact]
        public void Enque_OneElementQueue_CorrectlyInserted()
        {
            // Arrange
            MyQueue myQueue = new MyQueue();

            const int existingValue = 35;
            var insertedValue = 25;
            myQueue.Enque(existingValue);

            // Act
            myQueue.Enque(insertedValue);

            // Assert
            Assert.NotNull(myQueue.First);
            Assert.NotNull(myQueue.Last);
            Assert.Equal(insertedValue, myQueue.Last.Value);
            Assert.Equal(myQueue.First, myQueue.Last.Previous);

        }

        [Fact]
        public void Enque_MultipleElementQueue_CorrectlyInserted()
        {
            //Arrange
            MyQueue myQueue = new MyQueue();


            const int value1 = 88;
            const int value2 = 99;
            var value3 = 66;
            myQueue.Enque(value1);
            myQueue.Enque(value2);
            var lastOne = myQueue.Last;

            //Act
            myQueue.Enque(value3);

            //Assert
            Assert.NotNull(myQueue.First);
            Assert.NotNull(myQueue.Last);
            Assert.Equal(value3, myQueue.Last.Value);
            Assert.Equal(lastOne, myQueue.Last.Previous);
        }


        [Fact]
        public void Deque_TwoElementQueue_CorrectlyDequeued()
        {
            // Arrange
            MyQueue myQueue = new MyQueue();

            const int elementValue1 = 88;
            const int elementValue2 = 88;

            myQueue.Enque(elementValue1);
            myQueue.Enque(elementValue2);

            // Act
            myQueue.Deque();

            // Assert
            Assert.Equal(elementValue2, myQueue.First.Value);
            //Assert.Null(my)
        }
    }
}

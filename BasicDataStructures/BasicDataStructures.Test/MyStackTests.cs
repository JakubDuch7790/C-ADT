﻿using BasicDataStructures.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BasicDataStructures.Test
{
    public class MyStackTests
    {
        [Fact]
        public void Push_PushEmptyStack_CorrectlyPushed()
        {
            //Arrange
            MyStack myStack = new MyStack();
            var insertedValue = 88;

            //Act
            myStack.Push(insertedValue);

            //Assert
            Assert.NotNull(myStack.TopItem);
            Assert.Equal(insertedValue, myStack.TopItem.Value);
        }

        [Fact]
        public void Push_PushOneElementStack_CorrectlyPushed()
        {
            //Arrange
            MyStack myStack = new MyStack();
            const int existingStackItem = 88;
            myStack.Push(existingStackItem);
            const int insertedStackItem = 66;

            //Act
            myStack.Push(insertedStackItem);

            //Assert
            Assert.Equal(insertedStackItem, myStack.TopItem.Value);
            Assert.Equal(existingStackItem, myStack.TopItem.Below.Value);
            Assert.Null(myStack.TopItem.Below.Below);
        }

        [Fact]
        public void Pop_PopTwoElementStack_CorrectlyPopped()
        {
            //Arrange
            MyStack myStack = new MyStack();
            const int existingValue = 88;
            const int existingValue2 = 99;

            myStack.Push(existingValue);
            myStack.Push(existingValue2);

            //Act
            var poppedItem = myStack.Pop();

            //Assert
            Assert.Equal(existingValue, myStack.TopItem.Value);
            Assert.NotNull(myStack.TopItem);
            Assert.Equal(existingValue2, poppedItem.Value);
        }
    }
}

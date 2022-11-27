using BasicDataStructures.Stack;
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
            var insertedStackItem = 66;

            //Act
            myStack.Push(insertedStackItem);

            //Assert
            Assert.Equal(myStack.TopItem.Value, insertedStackItem);
            //Assert.NotEqual(myStack.TopItem.Value, existingStackItem);
        }
    }
}

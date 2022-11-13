using BasicDataStructures.LinkedList;
using Xunit;

namespace BasicDataStructures.Test;

/// <summary>
/// Testing class for LinkedList. Uses xUnit, which is an industry standard.
/// Tests are written using Arrange-Act-Assert pattern (AAA). Finish this class and write your own tests
/// for other classes as well.
/// </summary>
public class LinkedListTest
{
    [Fact]
    public void Search_EmptyList_ReturnsNull()
    {
        // Arrange
        var list = new MyLinkedList();
        const int soughtValue = 10;

        // Act
        var result = list.Search(soughtValue);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void Search_OneElementList_ExistingValue_ReturnsValidValue()
    {
        // Arrange
        var list = new MyLinkedList();

        const int soughtValue = 10;
        list.Insert(soughtValue);

        // Act
        var result = list.Search(soughtValue);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(soughtValue, result!.Value);
    }

    [Fact]
    public void Search_OneElementList_NonExistentValue_ReturnsValidValue()
    {
        // Arrange
        var list = new MyLinkedList();

        const int existingValue = 10;
        list.Insert(existingValue);

        const int soughtValue = 500;

        // Act
        var result = list.Search(soughtValue);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void Search_MultipleElementsList_ExistentValue_ReturnsValidValue()
    {
        // Arrange
        var list = new MyLinkedList();
        const int soughtValue = 3;

        list.Insert(1);
        list.Insert(2);
        list.Insert(soughtValue);

        // Act
        var result = list.Search(soughtValue);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(soughtValue, result!.Value);
    }

    [Fact]
    public void Search_MultipleElementsList_NonexistentValue_ReturnsNull()
    {
        // Arrange
        var list = new MyLinkedList();
        const int soughtValue = 500;

        list.Insert(1);
        list.Insert(2);
        list.Insert(3);

        // Act
        var result = list.Search(soughtValue);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void Insert_EmptyList_CorrectlyInserted()
    {
        // Arrange
        var list = new MyLinkedList();
        const int insertedValue = 5;

        // Act
        var result = list.Insert(insertedValue);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(list.First, result);
        Assert.Equal(list.Last, result);
    }

    [Fact]
    public void Insert_OneElementList_CorrectlyInserted()
    {
        // Arrange
        var list = new MyLinkedList();
        var first = list.Insert(1);

        const int insertedValue = 5;

        // Act
        var result = list.Insert(insertedValue);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(first, list.First);

        Assert.Equal(list.Last, result);

        Assert.Equal(list.First!.Next, result);
        Assert.Equal(list.First, result.Previous);
    }

    [Fact]
    public void Insert_MultipleElementList_CorrectlyInserted()
    {
        // Arrange
        var list = new MyLinkedList();
        var first = list.Insert(1);
        var second = list.Insert(2);

        const int insertedValue = 5;

        // Act
        var result = list.Insert(insertedValue);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(first, list.First);

        Assert.Equal(result, list.Last);

        Assert.Equal(list.First!.Next, second);
        Assert.Equal(second.Previous, list.First);

        Assert.Equal(list.Last, result);
        Assert.Equal(second, result.Previous);

        Assert.Equal(second.Next, result);
    }

    [Fact]
    public void Delete_EmptyList_CorrectlyRemoved()
    {
        // Arrange
        var list = new MyLinkedList();

        var node = new MyLinkedListNode
        {
            Value = 10
        };

        // Act
        list.Delete(node);


        // Assert
        Assert.Null(list.First);
        Assert.Null(list.Last);
    }

    [Fact]
    public void Delete_OneElementList_ExistingNode_CorrectlyRemoved()
    {
        // Arrange
        var list = new MyLinkedList();

        var first = list.Insert(1);

        // Act
        list.Delete(first);

        // Assert
        Assert.Null(list.First);
        Assert.Null(list.Last);
    }

    [Fact]
    public void Delete_TwoElementList_FirstNode_CorrectlyRemoved()
    {
        // Arrange
        var list = new MyLinkedList();

        var first = list.Insert(1);
        var second = list.Insert(2);

        // Act
        list.Delete(first);

        // Assert
        Assert.Equal(list.First, second);
        Assert.Equal(list.Last, second);

        Assert.Null(second.Previous);
        Assert.Null(second.Next);
    }
}
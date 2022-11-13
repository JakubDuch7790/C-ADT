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
        var node = new MyLinkedListNode
        {
            Value = 10
        };

        list.First = node;
        list.Last = node;

        int soughtValue = node.Value;

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
        var node = new MyLinkedListNode
        {
            Value = 10
        };

        list.First = node;
        list.Last = node;

        int soughtValue = 500;

        // Act
        var result = list.Search(soughtValue);

        // Assert
        Assert.Null(result);


    }

    [Fact]
    public void Search_MultiElementList_ExistentValue_ReturnsValidValue()
    {
        // Arrange
        var list = new MyLinkedList();
        var node = new MyLinkedListNode
        {
            Value = 10
        };
        var node2 = new MyLinkedListNode
        {
            Value = 11,
            Previous = node
        };
        node.Next = node2;
        var node3 = new MyLinkedListNode
        {
            Value = 12,
            Previous = node2
        };
        node2.Next = node3;


        list.First = node;
        list.Last = node3;


        int soughtValue = node3.Value;

        // Act
        var result = list.Search(soughtValue);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(soughtValue, result.Value);
    }
    //TestovanaMetoda_kratkyOpisTestu_OcakavanyVysledok
    [Fact]
    public void Insert_EmptyList_CorrectlyInserted()
    {
        //Arrange
        var myLinkedList = new MyLinkedList();
        var node = new MyLinkedListNode()
        {
            Value = 5,
        };

        //Act
        var result = myLinkedList.Insert(node.Value);
        //Assert

        Assert.NotNull(result);
        Assert.Equal(node.Value, result.Value);
        Assert.Null(result.Next);
        Assert.Null(result.Previous);
        Assert.Equal(result, myLinkedList.First);
        Assert.Equal(result, myLinkedList.Last);
    }
    [Fact]
    public void Insert_OneElementList_CorrectInsert()
    {
        //Arrange

        var myLinkedList = new MyLinkedList();
        int randomElement = 1;
        myLinkedList.Insert(randomElement);
        var node = new MyLinkedListNode()
        {
            Value = 55
        };

        //Act

        var result = myLinkedList.Insert(node.Value);

        //Assert
        Assert.NotNull(myLinkedList.First);
        Assert.Equal(node.Value, result.Value);
        Assert.Equal(result, myLinkedList.Last);
        //Assert.NotEqual<int>(result.Value, myLinkedList.First);



        
        
    }


}
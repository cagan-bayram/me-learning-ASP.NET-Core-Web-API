using ToDoApi.Models;

namespace TodoApi.Tests;

public class TodoItemTests
{
    [Fact]
    public void NewTodoItem_ShouldStartIncomplete()
    {
        // Arrange
        var todo = new TodoItem
        {
            Name = "Learn Github Actions"
        };

        // Act
        bool actual = todo.IsComplete;

        // Assert
        Assert.False(actual);
    }
}

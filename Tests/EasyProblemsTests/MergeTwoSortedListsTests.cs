using EasyProblems.MergeTwoSortedLists;
using FluentAssertions;
using Newtonsoft.Json;
using Xunit.Abstractions;

namespace Tests.EasyProblemsTests;

public class MergeTwoSortedListsTests
{
    private readonly ITestOutputHelper _output;
    public static IEnumerable<object?[]> ListsData =>
        new List<object?[]>
        {
            new object?[]
            {
                new ListNode(1, new ListNode(2, new ListNode(3))),
                new ListNode(1, new ListNode(3, new ListNode(4))),
                new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3, new ListNode(4))))))
            },
            new object?[]
            {
                null,
                new ListNode(0),
                new ListNode(0)
            },
            new object?[]
            {
                new ListNode(2),
                new ListNode(1),
                new ListNode(1, new ListNode(2))
            }
        };

    public MergeTwoSortedListsTests(ITestOutputHelper output)
    {
        _output = output;
    }
    
    [Theory]
    [MemberData(nameof(ListsData))]
    public void Solution_ReturnsExpected_WhenThisTestCases(ListNode? list1, ListNode? list2, ListNode? expected)
    {
        // Arrange
        var mergeTwoSortedLists = new MergeTwoSortedLists();
        
        // Act
        var result = mergeTwoSortedLists.Solution(list1, list2);

        // Assert
        while (result != null && expected != null)
        {
            result.val.Should().Be(expected.val);

            result = result.next;
            expected = expected.next;
        }
    }
}
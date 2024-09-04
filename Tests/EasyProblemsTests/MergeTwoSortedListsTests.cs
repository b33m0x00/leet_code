using EasyProblems.MergeTwoSortedLists;
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
        _output.WriteLine(JsonConvert.SerializeObject(list1));
    }
}
using Xunit;
using SearchLibrary;

public class LinearSearchTests
{
    [Fact]
    public void ElementFound()
    {
        var ls = new LinearSearch();
        int[] arr = {1,2,3,4,5};
        Assert.Equal(2, ls.Search(3, arr));
    }

    [Fact]
    public void ElementNotFound()
    {
        var ls = new LinearSearch();
        int[] arr = {1,2,3,4,5};
        Assert.Equal(-1, ls.Search(10, arr));
    }
}
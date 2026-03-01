using Xunit;
using SearchLibrary;

public class JumpSearchTests
{
    [Fact]
    public void ElementFound()
    {
        var js = new JumpSearch();
        int[] arr = {1,2,3,4,5,6,7,8,9};
        Assert.Equal(4, js.Search(5, arr));
    }

    [Fact]
    public void ElementNotFound()
    {
        var js = new JumpSearch();
        int[] arr = {1,2,3,4,5,6,7,8,9};
        Assert.Equal(-1, js.Search(20, arr));
    }
}
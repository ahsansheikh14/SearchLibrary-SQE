using Xunit;
using SearchLibrary;

public class BinarySearchTests
{
    [Fact]
    public void Search_Found()
    {
        var bs = new BinarySearch();
        int[] arr = {1,2,3,4,5};

        int result = bs.Search(3, arr);

        Assert.Equal(2, result);
    }

    [Fact]
    public void Search_NotFound()
    {
        var bs = new BinarySearch();
        int[] arr = {1,2,3,4,5};

        int result = bs.Search(10, arr);

        Assert.Equal(-1, result);
    }

    [Fact]
    public void Search_EmptyArray()
    {
        var bs = new BinarySearch();
        int[] arr = { };

        int result = bs.Search(3, arr);

        Assert.Equal(-1, result);
    }
}
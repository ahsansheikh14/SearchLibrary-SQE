using Xunit;
using SearchLibrary;

public class BinarySearchTests
{
    [Fact]
    public void Search_ElementFound()
    {
        var bs = new BinarySearch();
        int[] arr = {1,2,3,4,5};
        Assert.Equal(2, bs.Search(3, arr));
    }

    [Fact]
    public void Search_ElementNotFound()
    {
        var bs = new BinarySearch();
        int[] arr = {1,2,3,4,5};
        Assert.Equal(-1, bs.Search(10, arr));
    }

    [Fact]
    public void Search_EmptyArray()
    {
        var bs = new BinarySearch();
        int[] arr = {};
        Assert.Equal(-1, bs.Search(3, arr));
    }

    [Fact]
    public void Search_SingleElement_Found()
    {
        var bs = new BinarySearch();
        int[] arr = {7};
        Assert.Equal(0, bs.Search(7, arr));
    }

    [Fact]
    public void Search_SingleElement_NotFound()
    {
        var bs = new BinarySearch();
        int[] arr = {7};
        Assert.Equal(-1, bs.Search(5, arr));
    }

    [Fact]
    public void Search_FirstElement()
    {
        var bs = new BinarySearch();
        int[] arr = {1,2,3,4,5};
        Assert.Equal(0, bs.Search(1, arr));
    }

    [Fact]
    public void Search_LastElement()
    {
        var bs = new BinarySearch();
        int[] arr = {1,2,3,4,5};
        Assert.Equal(4, bs.Search(5, arr));
    }
}
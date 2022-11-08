using System.Collections.Generic;
using Xunit;
using Src;

namespace Tests;

public class ResultTest
{
    [Fact]
    public void Test1()
    {
        var grid = new List<string> { "abc", "ade", "efg" };

        var expected = "YES";
        var actual = Result.gridChallenge(grid);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        var grid = new List<string> { "kc", "iu" };

        var expected = "YES";
        var actual = Result.gridChallenge(grid);

        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void Test3()
    {
        var grid = new List<string> { "uxf", "vof", "hmp" };

        var expected = "NO";
        var actual = Result.gridChallenge(grid);

        Assert.Equal(expected, actual);
    }
}
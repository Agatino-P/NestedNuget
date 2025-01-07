using FluentAssertions;

namespace StaticFileTest;

public class NestedNugetTest
{
    [Fact]
    public void Test1()
    {
        string content = File.ReadAllText("static.txt");
        content.Should().Be("internal");
    }
}
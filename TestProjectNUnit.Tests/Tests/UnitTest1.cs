using TestProjectNUnit.Tests.PageObjects;
using TestProjectNUnit.Tests.Utilities;

namespace TestProjectNUnit.Tests;

public class Tests : Base
{
    [Test]
    public void Test1()
    {
        var homePage = new HomePage(GetDriver());
        homePage.GetHotelsAndResort().Click();
        Assert.Pass();
    }
}
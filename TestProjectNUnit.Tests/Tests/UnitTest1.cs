using TestProjectNUnit.Tests.PageObjects;
using TestProjectNUnit.Tests.Utilities;

namespace TestProjectNUnit.Tests.Tests;

public class Tests : Base
{
    [Test]
    public void VerifyHomePageBanner()
    {
        HomePage?.GetHotelsAndResort().Click();
        HomePage?.GetResidences().Click();
        var elementVisible = Generic.ElementIsDisplayed(HomePage.GetLogoElement());
        Assert.IsTrue(elementVisible, "The Logo is not visible");
    }
}
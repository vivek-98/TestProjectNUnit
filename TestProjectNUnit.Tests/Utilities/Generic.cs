using OpenQA.Selenium;

namespace TestProjectNUnit.Tests.Utilities;

public class Generic
{
    private IWebDriver driver;

    public Generic(IWebDriver driver)
    {
        this.driver = driver;
    }
    public bool ElementIsDisplayed(By element)
    { 
        return driver.FindElement(element).Displayed;
    }
}
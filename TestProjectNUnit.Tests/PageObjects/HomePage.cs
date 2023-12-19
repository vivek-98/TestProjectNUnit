using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace TestProjectNUnit.Tests.PageObjects;

public class HomePage
{
    private IWebDriver driver;
    By logo = By.XPath("//a[@href='https://www.vidahotels.com/en/']");

    public HomePage(IWebDriver driver)
    {
        this.driver = driver;
        PageFactory.InitElements(driver, this);
    }

    [FindsBy(How = How.XPath, Using = "//a[text()='Hotels & Resorts']")]
    private IWebElement HotelsAndResort;

    [FindsBy(How = How.XPath, Using = "//a[text()='Residences']")]
    private IWebElement Residences;

    [FindsBy(How = How.XPath, Using = "//a[@href='https://www.vidahotels.com/en/']")]
    private IWebElement Logo;

    public IWebElement GetHotelsAndResort()
    {
        return HotelsAndResort;
    }

    public IWebElement GetResidences()
    {
        return Residences;
    }

    public IWebElement GetLogo()
    {
        return Logo;
    }

    public By GetLogoElement()
    {
        return logo;
    }

    public void DropDown()
    {
        SelectElement s = new SelectElement(Logo);
        IWebElement ele=s.SelectedOption;
        s.SelectByText("hello");
        
        IList<IWebElement> alloptions = s.Options;

    }
}


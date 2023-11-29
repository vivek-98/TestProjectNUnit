using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestProjectNUnit.Tests.PageObjects;

    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }

        [FindsBy(How = How.XPath, Using = "//a[text()='Hotels & Resorts']")]
        private IWebElement HotelsAndResort;
        
        [FindsBy(How = How.XPath, Using = "//a[text()='Residences']")]
        private IWebElement Residences;

        public IWebElement GetHotelsAndResort()
        {
            return HotelsAndResort;
        }
        public IWebElement GetResidences()
        {
            return Residences;
        }
    }

using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProjectNUnit.Tests.Utilities;

public class Browser
{
    public IWebDriver driver;
    
    public IWebDriver StartBrowser()
    {
        var browser = ConfigurationManager.AppSettings["browser"];
        var url=ConfigurationManager.AppSettings["url"];
        InitBrowserDriver(browser);
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        driver.Manage().Window.Maximize();
        driver.Url = $"https://{url}/";
        return driver;
    }
    
    private void InitBrowserDriver(string? name)
    {
        switch (name)
        {
            case "chrome":
                new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                driver = new ChromeDriver();
                break;
            case "firefox":
                new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                driver = new FirefoxDriver();
                break;
        }

    }

}
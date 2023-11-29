using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProjectNUnit.Tests.Utilities;

public class Base
{
    public IWebDriver driver { get; private set; }

    [SetUp]
    public void StartBrowser()
    {
        
        var browser = ConfigurationManager.AppSettings["browser"];
        var url=ConfigurationManager.AppSettings["url"];
        InitBrowser(browser);
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        driver.Manage().Window.Maximize();
        driver.Url = $"https://{url}/";
    }

    private void InitBrowser(string name)
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
    
  //  [TearDown]
    public void Cleanup()
    {
        driver.Quit();
    }}
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using TestProjectNUnit.Tests.PageObjects;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProjectNUnit.Tests.Utilities;

public class Base
{
    public IWebDriver? Driver { get; private set; }
    public HomePage? HomePage { get; set; }
    public Generic? Generic { get; set; }

    [SetUp]
    public void InitializeTestRunner()
    {
        var browser = new Browser();
        Driver = browser.StartBrowser();
        HomePage = new HomePage(Driver);
        Generic = new Generic(Driver);
    }   
  //  [TearDown]
    public void Cleanup()
    {
        Driver?.Quit();
    }}
// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class Vara1Test
{
    private IWebDriver driver;
    public IDictionary<string, object> vars { get; private set; }
    private IJavaScriptExecutor js;
    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<string, object>();
        WebDriverWeight weight = new WebDriverWeight(driver, TimeSpan.FromSeconds(150));
        //driver.Manage().Timeouts().ImplicitWait =; // Increased the implicit wait time
    }
    [TearDown]
    protected void TearDown()
    {
        driver.Quit();
    }
    [Test]
    public void vara1()
    {
        driver.Navigate().GoToUrl("https://www.calculator.net/percent-calculator.html?cpar1=34&cpar2=2&cpar3=&ctype=1&x=Calculate");
        driver.Manage().Window.Size = new System.Drawing.Size(802, 816);
        driver.FindElement(By.Name("x")).Click();
        driver.FindElement(By.Name("x")).Click();
        thread.sleep(5000);

    }
}

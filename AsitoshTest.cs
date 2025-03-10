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
public class AsitoshTest
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
    }

    [TearDown]
    protected void TearDown()
    {
        driver.Quit();
    }

    [Test]
    public void asitosh()
    {
        driver.Navigate().GoToUrl("https://www.google.com/");
        driver.Manage().Window.Size = new System.Drawing.Size(800, 816);
        driver.FindElement(By.Id("APjFqb")).SendKeys("virat");
        driver.FindElement(By.CssSelector("#jZ2SBf > .ClJ9Yb")).Click();
    }

    public static void Main(string[] args)
    {
        var test = new AsitoshTest();
        test.SetUp();
        try
        {
            test.asitosh();
        }
        finally
        {
            test.TearDown();
        }
    }
}

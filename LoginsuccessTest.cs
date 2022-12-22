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
public class LoginsuccessTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void loginsuccess() {
    driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
    driver.Manage().Window.Size = new System.Drawing.Size(1160, 816);
    driver.FindElement(By.LinkText("Log out")).Click();
    driver.FindElement(By.LinkText("Log in")).Click();
    driver.FindElement(By.Id("Email")).SendKeys("manuele.salvador@bitrock.it");
    driver.FindElement(By.Id("Password")).SendKeys("Bitrock2022!");
    driver.FindElement(By.CssSelector(".login-button")).Click();
  }
}

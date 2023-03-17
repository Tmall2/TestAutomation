using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationNewCohort.Utility;

namespace TestAutomationNewCohort.PageObject
{
    class RegistrationPage
    {
        public RegistrationPage() 
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement SignUp => driver.FindElement(By.CssSelector("body > div > app-header > nav > div > ul:nth-child(2) > li:nth-child(3) > a"));

        IWebElement Username => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[1]/input"));

        IWebElement EmailAddress => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[2]/input"));

        IWebElement Password => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[3]/input"));

        IWebElement SignUpButton => driver.FindElement(By.XPath("//button[@type=\"submit\"]"));

        IWebElement NewArticle => driver.FindElement(By.XPath("(//a[@class=\"nav-link\"])[3]"));

        public void ClickonSignUp()
        {
            SignUp.Click();
        }

        public void EnterUsername() 
        { 
            Username.SendKeys("Dejavu9010");
        }

        public void EnterEmailaddress()
        {
            EmailAddress.SendKeys("Similoluwa01281@gmail.com");
        } 

        public void EnterPassword() 
        {
            Password.SendKeys("Password01563");
        }

        public void ClickOnSignUpButton() 
        {
            SignUpButton.Click();
        }

        public void NavigateToWebsite() 
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/#/register");
        }

        public bool IsNewArticleDisplayed() 
        {
            return NewArticle.Displayed;
        }


        


    }
}

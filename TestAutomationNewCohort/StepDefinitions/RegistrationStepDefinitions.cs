using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TestAutomationNewCohort.PageObject;

namespace TestAutomationNewCohort.StepDefinitions
{
    [Binding]
    public class RegistrationStepDefinitions
    {

        RegistrationPage registrationPage;

        public RegistrationStepDefinitions()
        {
            registrationPage= new RegistrationPage();
        }


        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            registrationPage.NavigateToWebsite();
        }

        [Given(@"I click on sign up")]
        public void GivenIClickOnSignUp()
        {
            registrationPage.ClickonSignUp();
        }

        [Given(@"I enter username")]
        public void GivenIEnterUsername()
        {
            registrationPage.EnterUsername();
        }

        [Given(@"I enter email address")]
        public void GivenIEnterEmailAddress()
        {
            registrationPage.EnterEmailaddress();
        }

        [Given(@"I enter password")]
        public void GivenIEnterPassword()
        {
            registrationPage.EnterPassword();
        }

        [When(@"I click on the sign up button")]
        public void WhenIClickOnTheSignUpButton()
        {
            registrationPage.ClickOnSignUpButton();
        }

        [Then(@"I should be able to register sucessfully")]
        public void ThenIShouldBeAbleToRegisterSucessfully()
        {
            Thread.Sleep(1000);
            Assert.That(registrationPage.IsNewArticleDisplayed);
        }
    }
}

using OpenQA.Selenium;
using PDEMO1.Hooks;
using PDEMO1.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace PDEMO1.Steps
{
    [Binding]
    public class ProteinWorksSteps
    {
        public IWebDriver driver = WebHooks.driver;
        ProteinWorksPage _proteinWorksPage = new ProteinWorksPage();
        [Given(@"I fill in my details")]
        public void GivenIFillInMyDetails()
        {
            _proteinWorksPage.EnterFirstName();
            _proteinWorksPage.EnterLastName();
            _proteinWorksPage.EnterEmail();
            _proteinWorksPage.EnterPassword();
            _proteinWorksPage.EnterCPassword();
            _proteinWorksPage.SelectGender();
            _proteinWorksPage.EnterDob();
            _proteinWorksPage.EnterMobileNumber();
            _proteinWorksPage.SelectMainGoal();
            _proteinWorksPage.ClickSubscribeNo();
        }

        [When(@"I click on JOIN UP")]
        public void WhenIClickOnJOINUP()
        {
            _proteinWorksPage.ClickJoinUp();
        }
        
        [Then(@"I should be registered")]
        public void ThenIShouldBeRegistered()
        {
            ScenarioContext.Current.Pending();
        }
    }
}

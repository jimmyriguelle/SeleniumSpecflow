using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using SeleniumSpecflow.Pages;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SeleniumSpecflow.Steps
{
    [Binding]
    class LoginPageStep
    {
        IWebDriver currentDriver = null;

        LoginPage page = new LoginPage();

        [Given(@"I have navigated to the application")]
        public void GivenIHaveNavigatedToTheApplication()
        {
            Browser.Current.Navigate().GoToUrl(ConfigurationManager.AppSettings[""]);
            currentDriver = Browser.Current;
        }
        [Given(@"typed the (.*) and (.*)")]
        public void GivenTypedTheAdminAndAdmin(string userName, string password )
        {
            page.Login(userName, password);
        }
        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            page.ClickLogin();
        }
        [Then(@"I should see the EA page")]
        public void ThenIShouldSeeTheEAPage()
        {
            //ScenarioContext.Current.Pending();
        }

    }
}

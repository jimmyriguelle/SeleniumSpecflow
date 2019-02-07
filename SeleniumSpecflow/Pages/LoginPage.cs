using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSpecflow.Pages
{
    class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(Browser.Current, this);
        }

        [FindsBy(How = How.Name, Using = "userName")]
        public IWebElement txtUserName;

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement txtpassword;

        [FindsBy(How = How.Name, Using = "login")]
        public IWebElement btnLogin;

        public void Login(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtpassword.SendKeys(password);
        }

        public EAPage ClickLogin()
        {
            btnLogin.Submit();
            return new EAPage();
        }


    }
}

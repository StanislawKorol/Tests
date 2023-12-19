using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_specflow.PageObjects
{
    internal class UserLoginPageObject
    {
        private IWebDriver webDriver;
       
        public UserLoginPageObject(IWebDriver web) { webDriver = web; }
        private readonly string loginUsernameXPath = "/html/body/div/div/div[2]/div[1]/div/div/form/div[1]/input";

        private IWebElement LoginUserNameInput => webDriver.FindElement(By.XPath(loginUsernameXPath));
        public void InputName(string Name) 
        {
            LoginUserNameInput.SendKeys(Name);
            Thread.Sleep(500);
        }


        private readonly string loginUserPasswordXPath = "/html/body/div/div/div[2]/div[1]/div/div/form/div[2]/input";

        private IWebElement LoginUserPasswordInput => webDriver.FindElement(By.XPath(loginUserPasswordXPath));
        public void InputPassword(string Password)
        {
            LoginUserPasswordInput.SendKeys(Password);
            Thread.Sleep(500);
        }

        private readonly string LoginUserButtonXPath = "/html/body/div/div/div[2]/div[1]/div/div/form/input";
        private IWebElement LoginButton => webDriver.FindElement(By.XPath(LoginUserButtonXPath));
        
        public void PressLoginButton() 
        { 
            LoginButton.Click();
            Thread.Sleep(1000); 
        }


    }
}

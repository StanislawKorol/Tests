using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_specflow.PageObjects
{
	internal class MessagePageObject
	{
        private IWebDriver webDriver;

        public MessagePageObject(IWebDriver web) { webDriver = web; }
        private readonly string MessageXpath = "/html/body/div/div/div[2]/div[1]/div/div/form/div[3]/h3";
        public bool MessageIsCorrect(string Message)
        {
            try
            {
                var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(3));
                var element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(MessageXpath)));
                var tmp = element.Text.ToString();
                return(tmp == Message);
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }
    }
}

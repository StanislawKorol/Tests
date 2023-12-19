using Lab_2_specflow.PageObjects;
using Lab_2_specflow.Features;
using Lab_2_specflow.StepDefinitions;
using Lab2.Drivers;
using NUnit.Framework;

namespace Lab_2_specflow.StepDefinitions
{


    [Binding]
    public sealed class DepositStepDefinitions
    {
        private readonly UserLoginPageObject userLoginPageObject;
        private readonly MessagePageObject messagePageObject;
        private readonly ScenarioContext _scenarioContext;
        private UserLogin userLogin;

        public DepositStepDefinitions(BrowserDriver browserDriver, ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            userLoginPageObject = new UserLoginPageObject(browserDriver.Current);
            messagePageObject = new MessagePageObject(browserDriver.Current);
            userLogin = new UserLogin();

        }



        [When(@"I fill user's name input")]
        public void WhenIFillUsersNameInput()
        {
            userLoginPageObject.InputName(userLogin.Name);
        }

        [When(@"I fill user password input")]
        public void WhenIFillUserPasswordInput()
        {
            
            userLoginPageObject.InputPassword(userLogin.Password);
        }

        [When(@"I submit the form")]
        public void WhenISubmitTheForm()
        {
            userLoginPageObject.PressLoginButton();
        }

        [Then(@"Message should be ""([^""]*)""")]
        public void ThenMessageShouldBe(string message)
        {
            Assert.IsTrue(messagePageObject.MessageIsCorrect(message));
        }

		[Given(@"Customer with details:([^""]*),([^""]*)")]
		public void GivenCustomerWithDetailsLocked_Out_UserSecret_Sauce(string Name , string Password)
		{
            userLogin.Name = Name;
            userLogin.Password = Password;

		}


	}
}






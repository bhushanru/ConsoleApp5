using ConsoleApp5.Helpers;
using ConsoleApp5.Pages;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace ConsoleApp5.HookUp
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"I have Logged Into Skillswap")]
        public void GivenIHaveLoggedIntoSkillswap()
        {
            CommonDriver.driver = new ChromeDriver();
            LoginPage loginobj = new LoginPage();
            loginobj.Login(CommonDriver.driver);
        }
        
        [Given(@"I have Navigated to language Tab")]
        public void GivenIHaveNavigatedToLanguageTab()
        {
            Home obj1 = new Home();
            obj1.NavigateToLanguage(CommonDriver.driver);
        }
        
        [Given(@"I have Navigated to education Tab")]
        public void GivenIHaveNavigatedToEducationTab()
        {
            Home obj1 = new Home();
            obj1.NavigateToEdu(CommonDriver.driver);
            
        }
        
        [Given(@"I have Navigated to certification Tab")]
        public void GivenIHaveNavigatedToCertificationTab()
        {
            Home obj1 = new Home();
            obj1.NavigateToCer(CommonDriver.driver);
            
        }
        
        [Then(@"I should be able to add four languages successfully")]
        public void ThenIShouldBeAbleToAddFourLanguagesSuccessfully()
        {
            Language langobj = new Language();
            langobj.AddLanguage(CommonDriver.driver);
        }
        
        [Then(@"Close browser")]
        public void ThenCloseBrowser()
        {
            CommonDriver.driver.Close();
        }
        
        [Then(@"I should be able to add an education successfully")]
        public void ThenIShouldBeAbleToAddAnEducationSuccessfully()
        {
            Education educationobj = new Education();
            educationobj.AddEducation(CommonDriver.driver);
        }
        
        [Then(@"I should be able to add a certification successfully")]
        public void ThenIShouldBeAbleToAddACertificationSuccessfully()
        {
            Certification certificateobj = new Certification();
            certificateobj.AddCertificate(CommonDriver.driver);
        }
    }
}

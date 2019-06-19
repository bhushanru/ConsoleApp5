using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp5.Pages
{
    class LoginPage
    {
        //Funtion for Login
        public void Login(IWebDriver driver)
        {
            //Maximise Browser
            driver.Manage().Window.Maximize();

            //Navigate to the url
            driver.Navigate().GoToUrl("http://www.skillswap.pro/");
            Thread.Sleep(10000);

            //Click SignIn button
            driver.FindElement(By.PartialLinkText("Sign In")).Click();

            //Identify username textbox
            IWebElement username = driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]"));

            //Enter valid username
            username.SendKeys("bhushanru@gmail.com");

            //Identify password textbox
            IWebElement password = driver.FindElement(By.XPath("//INPUT[@type='password']"));

            //Enter password
            password.SendKeys("bhubhu");

            //Click on login button
            driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']")).Click();

            //Wait for login screen
            Thread.Sleep(10000);

            //Verify - home page 
            //string ExpectedResult = "Sign Out";
            //string ActualResult = driver.FindElement(By.XPath("//BUTTON[@class='ui green basic button'][text()='Sign Out']")).Text;
            //if (ExpectedResult == ActualResult)
            //{
            //    Console.WriteLine("Tess Pass : Logged In Successfully");
            //}
            //else
            //{
            //    Console.WriteLine("test Fail : Login Failed");
            //}
        }
    }
}

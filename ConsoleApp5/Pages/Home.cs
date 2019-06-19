using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp5.Pages
{
    class Home
    {
        //Funtion for navigatete to Language Tab
        public void NavigateToLanguage(IWebDriver driver)
        {
            //Click language tab
            Thread.Sleep(7000);
            driver.FindElement(By.PartialLinkText("Languages")).Click();

        }

        //Fuction to Navigate to Certification Tab
        public void NavigateToCer(IWebDriver driver)
        {
            //Click Certification Tab
            Thread.Sleep(7000);
            driver.FindElement(By.PartialLinkText("Certifications")).Click();
        }

        //Function to Navigate to Education Tab
        public void NavigateToEdu (IWebDriver driver)
        {
            //Click Education Tab
            Thread.Sleep(7000);
            driver.FindElement(By.LinkText("Education")).Click();
        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp5.Pages
{
    class Certification
    {

        public void AddCertificate(IWebDriver driver)

        {
            //Certification Tab Clicked
            driver.FindElement(By.PartialLinkText("Certifications")).Click();
            Console.WriteLine("Tab clicked");
            Thread.Sleep(20000);

            //Click Add New button 
            driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][contains(text(),'Add New')]")).Click();
            

            //Input 
            IWebElement Certificate_Name = driver.FindElement(By.Name("certificationName"));
            Certificate_Name.SendKeys("ISTQB");

            //Input
            IWebElement Certificate_From = driver.FindElement(By.Name("certificationFrom"));
            Certificate_From.SendKeys("GASQ");

            //Select certificate year
            IWebElement chooseyear = driver.FindElement(By.Name("certificationYear"));
            var yearvalue = driver.FindElement(By.Name("certificationYear"));
            var year = new SelectElement(yearvalue);
            year.SelectByValue("2014");

            //Click Add
            driver.FindElement(By.XPath("(//INPUT[@type='button'])[1]")).Click();

            //Verify Certification Details
            string ExpResult2 = "ISTQB has been added to your certification";
            Thread.Sleep(2000);
            string ActResult2 = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]")).Text;
            if (ExpResult2 == ActResult2)
            {
                Console.WriteLine("Test Pass : Certification added");
                //Screenshot
                Helpers.SaveScreenShotClass.SaveScreenshot(Helpers.CommonDriver.driver, "Certification Tab");
            }
            else
            {
                Console.WriteLine("Test Fail : Certification not added");
            }        


        }
    }
}

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
    class Education
    {
        //Funtion to add languages
        public void AddEducation(IWebDriver driver)
        {

            //Education Tab Clicked
            driver.FindElement(By.LinkText("Education")).Click();
            Console.WriteLine("Tab clicked");
            Thread.Sleep(20000);

            //Add Education
            driver.FindElement(By.CssSelector("div.ui:nth-child(1) div.ui.fluid.container div.ui.grid div.row div.eight.wide.column form.ui.form:nth-child(2) div.ui.bottom.attached.tab.segment.tooltip-target.active:nth-child(4) div.row div.twelve.wide.column.scrollTable div.form-wrapper table.ui.fixed.table thead:nth-child(1) tr:nth-child(1) th.right.aligned:nth-child(6) > div.ui.teal.button")).Click();

            //Add Education name
            IWebElement CollegeName = driver.FindElement(By.Name("instituteName"));
            CollegeName.SendKeys("Unitec");

            //Choose college country
            IWebElement CollegeCountry = driver.FindElement(By.Name("country"));
            var country1 = driver.FindElement(By.Name("country"));
            var country = new SelectElement(country1);
            country.SelectByValue("New Zealand");

            //Choose title
            IWebElement title = driver.FindElement(By.Name("title"));
            var title1 = driver.FindElement(By.Name("title"));
            var selecttitle = new SelectElement(title1);
            selecttitle.SelectByValue("B.Tech");

            //Add degree
            IWebElement degree = driver.FindElement(By.Name("degree"));
            degree.SendKeys("Coumpter Science");

            //Choose year
            IWebElement y = driver.FindElement(By.Name("yearOfGraduation"));
            var year1 = driver.FindElement(By.Name("yearOfGraduation"));
            var selectyear = new SelectElement(year1);
            selectyear.SelectByValue("2017");

            //Click Add in education
            driver.FindElement(By.XPath("(//INPUT[@type='button'])[1]")).Click();

            string expValue = "Education has been added";
            Thread.Sleep(2000);
            String ActValue = driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;

            if (expValue == ActValue)
            {
                //Console.WriteLine("Education has been added");
               

                //Screenshot
                Helpers.SaveScreenShotClass.SaveScreenshot(Helpers.CommonDriver.driver, "Education Tab");
            }
            else
            {
                Console.WriteLine("Education not added");
            }

        }


    }
}

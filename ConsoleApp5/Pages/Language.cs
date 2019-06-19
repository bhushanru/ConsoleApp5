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
    class Language
    {
        //Funtion to add languages
        public void AddLanguage(IWebDriver driver)
        {
            //Test1
            //Lang1
            //Identify AddNew Language button
            IWebElement element = driver.FindElement(By.XPath("(//DIV[@class='ui teal button '][text()='Add New'][text()='Add New'])[1]"));
            element.Click();
            
            
            //Input add language text box
            IWebElement addlanguage1 = driver.FindElement(By.XPath("(//INPUT[@type='text'])[4]"));
            addlanguage1.SendKeys("lang1");

            //Choose Level for language1
            IWebElement chooselanguage1 = driver.FindElement(By.XPath("//SELECT[@class='ui dropdown']"));
            var level1 = driver.FindElement(By.Name("level"));
            var select_level1 = new SelectElement(level1);
            select_level1.SelectByValue("Basic");

            //CLick Add 
            driver.FindElement(By.XPath("(//INPUT[@type='button'])[1]")).Click();
            Thread.Sleep(2000);

            //Lang2
            //Identify AddNew Language button
            element.Click();

            //Input add language text box
            IWebElement addlanguage2 = driver.FindElement(By.XPath("(//INPUT[@type='text'])[4]"));
            addlanguage2.SendKeys("lang2");

            //Choose Level for language2
            IWebElement chooselanguage2 = driver.FindElement(By.XPath("//SELECT[@class='ui dropdown']"));
            var level2 = driver.FindElement(By.Name("level"));
            var select_level2 = new SelectElement(level2);
            select_level2.SelectByValue("Conversational");

            //CLick Add
            driver.FindElement(By.XPath("(//INPUT[@type='button'])[1]")).Click();
            Thread.Sleep(2000);

            //Lang3
            //Identify AddNew Language button
            element.Click();

            //Input add language text box
            IWebElement addlanguage3 = driver.FindElement(By.XPath("(//INPUT[@type='text'])[4]"));
            addlanguage3.SendKeys("lang3");

            //Choose Level for language3
            IWebElement chooselanguage3 = driver.FindElement(By.XPath("//SELECT[@class='ui dropdown']"));
            var level3 = driver.FindElement(By.Name("level"));
            var select_level3 = new SelectElement(level3);
            select_level3.SelectByValue("Fluent");

            //CLick Add
            driver.FindElement(By.XPath("(//INPUT[@type='button'])[1]")).Click();
            Thread.Sleep(2000);

            //Lang4
            //Identify AddNew Language button
            element.Click();

            //Input add language text box
            IWebElement addlanguage4 = driver.FindElement(By.XPath("(//INPUT[@type='text'])[4]"));
            addlanguage4.SendKeys("lang4");

            //Choose Level for language4
            IWebElement chooselanguage4 = driver.FindElement(By.XPath("//SELECT[@class='ui dropdown']"));
            var level4 = driver.FindElement(By.Name("level"));
            var select_level4 = new SelectElement(level4);
            select_level4.SelectByValue("Native/Bilingual");

            //CLick Add
            driver.FindElement(By.XPath("(//INPUT[@type='button'])[1]")).Click();
            Thread.Sleep(2000);

            //Verify Language Details
            try
            {
                IWebElement csselement = driver.FindElement(By.CssSelector("div.ui:nth - child(1) div.ui.fluid.container div.ui.grid div.row div.eight.wide.column form.ui.form:nth - child(2) div.ui.bottom.attached.tab.segment.active.tooltip - target:nth - child(2) div.row div.twelve.wide.column.scrollTable div.form - wrapper table.ui.fixed.table thead:nth - child(1) tr: nth - child(1) th.right.aligned:nth - child(3) > div.ui.teal.button"));
                if (csselement.Displayed)
                {
                    Console.WriteLine("Test Fail, button displayed");
                }
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Test Pass, button not displayed");
                Helpers.SaveScreenShotClass.SaveScreenshot(Helpers.CommonDriver.driver, "Language Tab");
            }

        }

    }
}

    


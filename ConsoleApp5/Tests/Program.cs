using ConsoleApp5.Helpers;
using ConsoleApp5.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp5
{


    [TestFixture]
    class Program
    {
        static void Main(string[] args) // static with a void (or int) return type
        {
        }
        //[SetUp]
        //public void Login()
        //{
        //    CommonDriver.driver = new ChromeDriver();
        //    LoginPage loginobj = new LoginPage();
        //    loginobj.Login(CommonDriver.driver);
        //}
        //[Test]
        //public void AddLanguage()
        //{
        //    //Start Add Language test
           

        //    Home obj1 = new Home();
        //    obj1.NavigateToLanguage(CommonDriver.driver);
        //    Language langobj = new Language();
        //    langobj.AddLanguage(CommonDriver.driver);
        //}

        //[Test]
        //public void AddCertificate()
        //{
        //    //Start Add Language test
            

        //    Home obj1 = new Home();
        //    obj1.NavigateToCer(CommonDriver.driver);
        //    Certification certificateobj = new Certification();
        //    certificateobj.AddCertificate(CommonDriver.driver);
        //}

        //[Test]
        //public void AddEducation()
        //{
        //    //Start Add Language test
            

        //    Home obj1 = new Home();
        //    obj1.NavigateToEdu(CommonDriver.driver);
        //    Education educationobj = new Education();
        //    educationobj.AddEducation(CommonDriver.driver);
        //}

        //[TearDown]
        //public void FlushTest()
        //{
        //    CommonDriver.driver.Close();
        //}
       
    }
}

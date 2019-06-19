﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Helpers
{
    class CommonDriver
    {
        //Init common driver
        public static IWebDriver driver { set; get; }
    }

    //Screenshots
    #region screenshots
    public class SaveScreenShotClass
    {
        public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName) // Definition
        {
            var folderLocation = @"C:\Users\Bhushan\source\repos\ConsoleApp5\ConsoleApp5\Screenshots\";

            if (!System.IO.Directory.Exists(folderLocation))
            {
                System.IO.Directory.CreateDirectory(folderLocation);
            }

            var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
            var fileName = new StringBuilder(folderLocation);

            fileName.Append(ScreenShotFileName);
            fileName.Append(DateTime.Now.ToString("_dd-mm-yyyy_mss"));
            //fileName.Append(DateTime.Now.ToString("dd-mm-yyyym_ss"));
            fileName.Append(".jpeg");
            screenShot.SaveAsFile(fileName.ToString(), ScreenshotImageFormat.Jpeg);
            return fileName.ToString();
        }
    }
    #endregion

    
}

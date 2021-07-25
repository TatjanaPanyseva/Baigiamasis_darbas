using Baigiamasis_darbas.Page;
using Baigiamasis_darbas.Drivers;
using Baigiamasis_darbas.Tools;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Baigiamasis_darbas.Test
{
    public class BaseTest
    {
        private static IWebDriver driver;
        public static AruodasPage _aruodasPage;
        public static AruodasPage1 _aruodasPage1;
        public static AruodasPage2 _aruodasPage2;

       [OneTimeSetUp]
       public static void SetUp()
       {
        driver = CustomDriver.GetChromeDriver();
       
        _aruodasPage = new AruodasPage(driver);
        _aruodasPage1 = new AruodasPage1(driver);
        _aruodasPage2 = new AruodasPage2(driver);
        

       }
       [TearDown]
       public static void TakeScreenshot()
       {
        if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            MyScreenshot.MakeScreenshot(driver);
       }

       [OneTimeTearDown]

       public static void TearDown()
       {
        //driver.Quit();
       }
    }
   
}

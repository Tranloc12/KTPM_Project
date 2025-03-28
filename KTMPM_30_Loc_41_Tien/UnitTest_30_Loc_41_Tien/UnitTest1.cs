using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTest_30_Loc_41_Tien
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TC1_LoginSuccess_30_Loc()
        {

            IWebDriver driver_30_Loc = new ChromeDriver();
            driver_30_Loc.Navigate().GoToUrl("https://za.pinterest.com/");
            Thread.Sleep(3000);


            driver_30_Loc.FindElement(By.CssSelector("#__PWS_ROOT__ > div > div > div:nth-child(1) > div:nth-child(2) > div.QLY._he.p6V.zI7.iyn.Hsu > div > div.Eqh.Jea.KS5.s7I.zI7.iyn.Hsu > div.H-G.zI7.iyn.Hsu > button > div")).Click();
            Thread.Sleep(3000);

            driver_30_Loc.FindElement(By.Id("email")).SendKeys("mywebcnpm@gmail.com");
            driver_30_Loc.FindElement(By.Id("password")).SendKeys("Loc@123456");
            driver_30_Loc.FindElement(By.CssSelector("#__PWS_ROOT__ > div > div > div:nth-child(1) > div:nth-child(5) > div > div > div > div > div > div.KS5.jzS.un8.C9i.TB_ > div:nth-child(1) > form > div.qGb.zI7.iyn.Hsu > button > div")).Click();


        }
    }
}

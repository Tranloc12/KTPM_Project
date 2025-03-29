using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using KTMPM_30_Loc_41_Tien;
using System.Collections.Generic;
using OpenQA.Selenium.BiDi.Communication;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace UnitTest_30_Loc_41_Tien
{
    [TestClass]
    public class UnitTest_30_Loc_41_Tien
    {

<<<<<<< HEAD:KTMPM_30_Loc_41_Tien/UnitTest_30_Loc_41_Tien/UnitTest1.cs
        //test case đăng nhập thành công 
        [TestMethod]
        public void TC1_LoginSuccess_30_Loc()
        {
=======

        ////test case đăng nhập thành công 
        //[TestMethod]
        //public void TC1_LoginSuccess_30_Loc()
        //{
>>>>>>> d535d8703604d3106ec8376b2f5f060612d7bdf7:KTMPM_30_Loc_41_Tien/UnitTest_30_Loc_41_Tien/UnitTest_30_Loc_41_Tien.cs

            IWebDriver driver_30_Loc = new ChromeDriver();
            driver_30_Loc.Navigate().GoToUrl("https://tuoitre.vn/");
            driver_30_Loc.FindElement(By.CssSelector("#head_login > a > svg")).Click();
            Thread.Sleep(2000);
            driver_30_Loc.FindElement(By.Name("username")).SendKeys("mywebcnpm@gmail.com");
            driver_30_Loc.FindElement(By.Name("password")).SendKeys("Loc@123456");
            driver_30_Loc.FindElement(By.Id("button-login")).Click();



        }

        //test case đăng nhập thất bại với( email đúng - mật khẩu sai)
        [TestMethod]
        public void TC2_LoginPasswordFail_30_Loc()
        {

            IWebDriver driver_30_Loc = new ChromeDriver();
            driver_30_Loc.Navigate().GoToUrl("https://tuoitre.vn/");
            driver_30_Loc.FindElement(By.CssSelector("#head_login > a > svg")).Click();
            Thread.Sleep(2000);
            driver_30_Loc.FindElement(By.Name("username")).SendKeys("mywebcnpm@gmail.com");
            driver_30_Loc.FindElement(By.Name("password")).SendKeys("Loc@12");
            driver_30_Loc.FindElement(By.Id("button-login")).Click();

        }

        //test case đăng nhập thất bại với (email sai - mật khẩu đúng)
        [TestMethod]
        public void TC3_LoginFail_30_Loc()
        {

            IWebDriver driver_30_Loc = new ChromeDriver();
            driver_30_Loc.Navigate().GoToUrl("https://tuoitre.vn/");
            driver_30_Loc.FindElement(By.CssSelector("#head_login > a > svg")).Click();
            Thread.Sleep(2000);
            driver_30_Loc.FindElement(By.Name("username")).SendKeys("myweb@gmail.com");
            driver_30_Loc.FindElement(By.Name("password")).SendKeys("Loc@123456");
            driver_30_Loc.FindElement(By.Id("button-login")).Click();

        }

        //test case đăng nhập thất bại với (email sai - mật khẩu sai)
        [TestMethod]
        public void TC4_LoginEmailPasswordFail_30_Loc()
        {

            IWebDriver driver_30_Loc = new ChromeDriver();
            driver_30_Loc.Navigate().GoToUrl("https://tuoitre.vn/");
            driver_30_Loc.FindElement(By.CssSelector("#head_login > a > svg")).Click();
            Thread.Sleep(2000);
            driver_30_Loc.FindElement(By.Name("username")).SendKeys("myweb@gmail.com");
            driver_30_Loc.FindElement(By.Name("password")).SendKeys("Loc@123");
            driver_30_Loc.FindElement(By.Id("button-login")).Click();

        }

        //test case đăng nhập thất bại với (email rỗng - mật khẩu rỗng)
        [TestMethod]
        public void TC5_LoginEmailPasswordhollow_30_Loc()
        {

            IWebDriver driver_30_Loc = new ChromeDriver();
            driver_30_Loc.Navigate().GoToUrl("https://tuoitre.vn/");
            driver_30_Loc.FindElement(By.CssSelector("#head_login > a > svg")).Click();
            Thread.Sleep(2000);
            driver_30_Loc.FindElement(By.Name("username")).SendKeys("");
            driver_30_Loc.FindElement(By.Name("password")).SendKeys("");
            driver_30_Loc.FindElement(By.Id("button-login")).Click();

        }


        //test case tìm kiếm thông tin với từ khóa hợp lệ ("kiểm thử phần mềm ")
        [TestMethod]
        public void TC6_Search_41_Tien()
        {

            IWebDriver driver_41_Tien = new ChromeDriver();
            driver_41_Tien.Navigate().GoToUrl("https://tuoitre.vn/");




            driver_41_Tien.FindElement(By.CssSelector("#admWrapsite > div > div.header > div > div.header__top > div > div > div.header__top-right > div.header__action > div.box-search.frm-search > a:nth-child(2)")).Click();


            driver_41_Tien.FindElement(By.CssSelector("#admWrapsite > div > div.header > div > div.header__top > div > div > div.header__top-right > div.header__action > div.box-search.frm-search.show > input")).SendKeys("Kiểm Thử Phần Mềm");

            driver_41_Tien.FindElement(By.CssSelector("#admWrapsite > div > div.header > div > div.header__top > div > div > div.header__top-right > div.header__action > div.box-search.frm-search.show > a.header__search.btn-search")).Click();


            IReadOnlyCollection<IWebElement> ee_41_Tien = driver_41_Tien.FindElements(By.TagName("h3"));
            foreach (var r_41_Tien in ee_41_Tien)
            {
                Console.WriteLine(r_41_Tien.Text);
            }


        }



        //test case tìm kiếm thông tin với từ khóa không hợp lệ ("x235sd525asd ")
        [TestMethod]
        public void TC7_Search_41_Tien()
        {

            IWebDriver driver_41_Tien = new ChromeDriver();
            driver_41_Tien.Navigate().GoToUrl("https://tuoitre.vn/");




            driver_41_Tien.FindElement(By.CssSelector("#admWrapsite > div > div.header > div > div.header__top > div > div > div.header__top-right > div.header__action > div.box-search.frm-search > a:nth-child(2)")).Click();


            driver_41_Tien.FindElement(By.CssSelector("#admWrapsite > div > div.header > div > div.header__top > div > div > div.header__top-right > div.header__action > div.box-search.frm-search.show > input")).SendKeys("x235sd525asd");

            driver_41_Tien.FindElement(By.CssSelector("#admWrapsite > div > div.header > div > div.header__top > div > div > div.header__top-right > div.header__action > div.box-search.frm-search.show > a.header__search.btn-search")).Click();


            IReadOnlyCollection<IWebElement> ee_41_Tien = driver_41_Tien.FindElements(By.TagName("h3"));
            foreach (var r_41_Tien in ee_41_Tien)
            {
                Console.WriteLine(r_41_Tien.Text);
            }


        }


        //test case tìm kiếm thông tin với điều kiện không nhập từ khóa  (" ") -> Không thực hiện tìm kiếm, không có lỗi
        [TestMethod]
        public void TC8_Search_41_Tien()
        {

            IWebDriver driver_41_Tien = new ChromeDriver();
            driver_41_Tien.Navigate().GoToUrl("https://tuoitre.vn/");




            driver_41_Tien.FindElement(By.CssSelector("#admWrapsite > div > div.header > div > div.header__top > div > div > div.header__top-right > div.header__action > div.box-search.frm-search > a:nth-child(2)")).Click();


            driver_41_Tien.FindElement(By.CssSelector("#admWrapsite > div > div.header > div > div.header__top > div > div > div.header__top-right > div.header__action > div.box-search.frm-search.show > input")).SendKeys("");

            driver_41_Tien.FindElement(By.CssSelector("#admWrapsite > div > div.header > div > div.header__top > div > div > div.header__top-right > div.header__action > div.box-search.frm-search.show > a.header__search.btn-search")).Click();


            IReadOnlyCollection<IWebElement> ee_41_Tien = driver_41_Tien.FindElements(By.TagName("h3"));
            foreach (var r_41_Tien in ee_41_Tien)
            {
                Console.WriteLine(r_41_Tien.Text);
            }


        }




        //test case Đăng bình luận với điều kiện chưa đăng nhập -> bắt buộc đăng nhập
        [TestMethod]
        public void TC9_Search_41_Tien()
        {

            IWebDriver driver_41_Tien = new ChromeDriver();
            driver_41_Tien.Navigate().GoToUrl("https://tuoitre.vn/");

            driver_41_Tien.FindElement(By.TagName("h3")).Click();

            Thread.Sleep(1000);

            driver_41_Tien.FindElement(By.CssSelector("#formCmt > div.formtyping")).Click();

            driver_41_Tien.FindElement(By.CssSelector("#formCmt > div.formtyping > textarea")).SendKeys("....123xas");

            driver_41_Tien.FindElement(By.ClassName("send-comment")).Click();





        }

        ////test case Đăng bình luận với điều kiện đã đăng nhập -> đăng thành công 
        [TestMethod]
        public void TC10_Search_41_Tien()
        {

            IWebDriver driver_41_Tien = new ChromeDriver();
            driver_41_Tien.Navigate().GoToUrl("https://tuoitre.vn/");

            driver_41_Tien.FindElement(By.CssSelector("#head_login > a > svg")).Click();
            Thread.Sleep(2000);
            driver_41_Tien.FindElement(By.Name("username")).SendKeys("mywebcnpm@gmail.com");
            driver_41_Tien.FindElement(By.Name("password")).SendKeys("Loc@123456");
            driver_41_Tien.FindElement(By.Id("button-login")).Click();
            WebDriverWait wait_41_Tien = new WebDriverWait(driver_41_Tien, TimeSpan.FromSeconds(10));

            IWebElement article_41_Tien = wait_41_Tien.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("h3 a")));
            article_41_Tien.Click();
            Thread.Sleep(1000);

            driver_41_Tien.FindElement(By.CssSelector("#formCmt > div.formtyping")).Click();

            driver_41_Tien.FindElement(By.CssSelector("#formCmt > div.formtyping > textarea")).SendKeys("....123xas");

            IWebElement element_41_Tien = driver_41_Tien.FindElement(By.CssSelector(".send-comment"));
            IJavaScriptExecutor js_41_Tien = (IJavaScriptExecutor)driver_41_Tien;
            js_41_Tien.ExecuteScript("arguments[0].click();", element_41_Tien);






        }














    }
    }

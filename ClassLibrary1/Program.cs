using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Shakar.PageService;


namespace Shakar
{
    class Program:AutomatedBase
    {
        static void Main(string[] args)
        {
            new Program("http://shakarbhattarai.com.np/wordpress/");

        }

        public Program(string url) : base(url)
        {
            
            MainPage mainPage;
            ManCityPage _manCityPage;

            var currentUrl = _webDriver.Url;
            mainPage = new MainPage(_webDriver);
            mainPage.clickOnManCityTitle();
            var differenturl = _webDriver.Url;

            VerifyOnClikcingSubmitPageRedirects(currentUrl, differenturl);
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //SiteDriver.waitfor10seconds();

            _manCityPage = new ManCityPage(_webDriver);
            _manCityPage.setAuthor("Author Test");
            _manCityPage.setEmail("Test@gmail.com");
            _manCityPage.setUrl("www.test.com");
            _manCityPage.setComment("test comment");
            _manCityPage.clickSubmit();

            _webDriver.Close();
        }

        private void VerifyOnClikcingSubmitPageRedirects(string currentUrl,string differntUrl)
        {
            Assert.AreNotEqual(currentUrl, currentUrl);
        }
    }
}

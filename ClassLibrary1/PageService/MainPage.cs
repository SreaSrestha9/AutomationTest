
using OpenQA.Selenium;
using Shakar.PageObject;

namespace Shakar.PageService
{
    class MainPage
    {
       
        IWebDriver webDriver;

        public MainPage(IWebDriver webdriver) {
            this.webDriver = webdriver;
        }


        public void clickOnManCityTitle() {
            webDriver.FindElement(By.CssSelector(MainPageObjects.cssManCity)).Click();
        }
    }
}

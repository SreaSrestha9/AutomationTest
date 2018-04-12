
using OpenQA.Selenium;
using Shakar.PageObject;

namespace Shakar.PageService
{
    class ManCityPage
    {
        ManCityPageObjects mcp = new ManCityPageObjects();
        IWebDriver webDriver;

        public ManCityPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
        public void setAuthor(string strAuthor) {
            webDriver.FindElement(By.CssSelector(mcp.css_txtAuthor)).SendKeys(strAuthor);
        }

        public void setEmail(string strEmail)
        {
            webDriver.FindElement(By.CssSelector(mcp.css_txtemail)).SendKeys(strEmail);
        }

        public void setUrl(string strUrl)
        {
            webDriver.FindElement(By.CssSelector(mcp.css_txtUrl)).SendKeys(strUrl);
        }

        public void setComment(string strComment)
        {
            webDriver.FindElement(By.CssSelector(mcp.css_txtComment)).SendKeys(strComment);
        }

        public void clickSubmit()
        {
            webDriver.FindElement(By.CssSelector(mcp.css_btnSubmit)).Click();
        }

    
    }
}

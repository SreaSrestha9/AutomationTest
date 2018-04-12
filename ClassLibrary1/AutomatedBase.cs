using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Shakar
{
    class AutomatedBase
    {
        public IWebDriver _webDriver;

        public AutomatedBase(string url)
        {
            _webDriver= new ChromeDriver();
            _webDriver.Manage().Window.Maximize();
            _webDriver.Url = url;
        }
      
       
    }
}

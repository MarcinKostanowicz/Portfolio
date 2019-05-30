using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Portfolio.selenium
{
    public static class WebDriverFactory
    {
        
        public static IWebDriver CreateDriver(BrowserType browserType)
        {
            //gdzies tu trzeba wywolac stworzona metoda i przekazac optionsy do driverow

            switch (browserType)
            {
                case BrowserType.Chrome:
                    return new ChromeDriver();
                case BrowserType.Firefox:
                    return new FirefoxDriver();
                default:
                    return new ChromeDriver();
            }    
        }
        //DriverOptions;

        //ChromeOptions;

        //FirefoxOptions;

        //CreateOptions;


    }

}

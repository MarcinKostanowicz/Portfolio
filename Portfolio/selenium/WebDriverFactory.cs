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

            var options = CreateDriverOptions(browserType);

            switch (browserType)
            {
                case BrowserType.Chrome:
                    return new ChromeDriver((ChromeOptions)options);
                case BrowserType.Firefox:
                    return new FirefoxDriver((FirefoxOptions)options);
                default:
                    return new ChromeDriver((ChromeOptions)options);
            }
        }

        private static DriverOptions CreateDriverOptions(BrowserType bt)
        {
            switch (bt)
            {
                case BrowserType.Chrome:
                    return new ChromeOptions();
                case BrowserType.Firefox:
                    return new FirefoxOptions();
                default:
                    return new ChromeOptions();
            }
        }

      


    }

}

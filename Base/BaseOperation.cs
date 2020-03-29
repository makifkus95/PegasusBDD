using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;

namespace PegasusBDD.Base
{
    class BaseOperation
    {
        IWebDriver driver;
        WebDriverWait wait;
        IReadOnlyList<IWebElement> result, result2;
        IJavaScriptExecutor scriptExecutor;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BaseOperation(IWebDriver driver)
        {
            this.driver = driver;
            //elementi bulması için 30sn bekler
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        public IWebElement FindElement(By by)
        {
            //elementin var olmasını bekliyor.
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(by));
            HighLightElement(by);

            log.Info("Aranılan element: " + by);
            return driver.FindElement(by);
        }

        public void ClickElement(By by)
        {
            Thread.Sleep(5);
            FindElement(by).Click();
            //Thread.Sleep(5);
        }

        public void SendKeys(By by, string str)//str = istanbul-
        {
            FindElement(by).SendKeys(str);
           // Enter(by);
            FindElement(by).SendKeys(Keys.Enter);
        }


        public void CalenderSelect(string str,string[] arr)
        {
            if (str.Contains("Gidiş Bilet"))
            {
                //Gidiş Bilet, 2022,  Takvimddeki Yıl'ın xpath'i
                YearSelect(str, arr[2], "//*[@id='search-flight-datepicker-departure']/div/div[1]/div/div/span[2]");
                //Gidiş Bilet, Nisan,  Takvimddeki Ay'ın xpath'i
                MonthSelect(str, arr[1], "//*[@id='search-flight-datepicker-departure']/div/div[1]/div/div/span[1]");
                //Gidiş Bilet, 10,  Takvimddeki Gün'ün xpath'i
                DaySelect(str, arr[0], "//*[@id='search-flight-datepicker-departure']/div/div[1]//tbody//a");
            }
            else if (str.Contains("Dönüş Bileti"))
            {
                YearSelect(str, arr[2], "//*[@id='search-flight-datepicker-arrival']/div/div[1]/div/div/span[2]");
                MonthSelect(str, arr[1], "//*[@id='search-flight-datepicker-arrival']/div/div[1]/div/div/span[1]");
                DaySelect(str, arr[0], "//*[@id='search-flight-datepicker-arrival']/div/div[1]//tbody//a");
                
            }

        }

        public void YearSelect(string rightclick, string year, string xpath)
        {
            if (rightclick.Contains("Gidiş Bilet"))
                SelectYear(By.XPath(xpath), year, "//*[@id='search-flight-datepicker-departure']/div/div[2]/div/a");
            else if (rightclick.Contains("Dönüş Bileti"))
                SelectYear(By.XPath(xpath), year, "//*[@id='search-flight-datepicker-arrival']/div/div[2]/div/a");
        }

        public void MonthSelect(string rightclick, string mounth, string xpath)
        {
            if (rightclick.Contains("Gidiş Bilet"))
                SelectMouth(By.XPath(xpath), mounth, "//*[@id='search-flight-datepicker-departure']/div/div[2]/div/a");
            else if (rightclick.Contains("Dönüş Bileti"))
                SelectMouth(By.XPath(xpath), mounth, "//*[@id='search-flight-datepicker-arrival']/div/div[2]/div/a");
            
        }

        public void DaySelect(string clickday, string day, string xpath)
        {
            SelectDay(xpath, day);
        }

        public void SelectYear(By by,string yearStr , string RightClick)
        {/*
            by = takvim'de yıl yazan bölümün xpath'i
            yearStr = gitmek istediğim yıl
            RightClick = sağok path'i
             */
            string str;
            while (true)
            {
                str = FindElement(by).Text;
                if (str.Equals(yearStr))
                    break;
                ClickElement(By.XPath(RightClick));
            }
        }
        public void SelectMouth(By by, string mounthStr, string RightClick)
        {
            string str;

            while (true)
            {
                str = FindElement(by).Text;
                if (str.Equals(mounthStr))
                    break;
                ClickElement(By.XPath(RightClick));
                //Thread.Sleep(5);
            }
        }

        public void SelectDay(string links, string day)
        {
            result = driver.FindElements(By.XPath(links));
            
            foreach (var res in result)
            {
                if (res.Text.Equals(day)) // day = 10
                {
                    res.Click();
                    break;
                }
            }
        }

        public void SelectFlying()
        {
            

        }

       

        public void HighLightElement(By by)
        {
            scriptExecutor = (IJavaScriptExecutor)driver;
            scriptExecutor.ExecuteScript("arguments[0].setAttribute('style', 'background: yellow; border: 2px solid red;');", driver.FindElement(by));
            Thread.Sleep(TimeSpan.FromMilliseconds(50));
        }
    }
}

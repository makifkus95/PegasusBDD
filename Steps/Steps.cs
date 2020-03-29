using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PegasusBDD.Base;
using PegasusBDD.Util;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace PegasusBDD
{
    [Binding]
    public sealed class Steps
    {
        private readonly ScenarioContext context;
        public IWebDriver driver;
        BaseOperation baseOperation;
        public static int years;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        public static int Years { get => years; set => years = value; }

        public Steps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [BeforeScenario]
        public void StartScenario()
        {
            Logging.Logger();
            // Optionns oluşturuyoruz
            ChromeOptions options = new ChromeOptions();
            // Setleme işlemini gerçekleştiriyoruz
            options.AddArgument("start-maximized");
            options.AddArgument("disable-popup-blocking");
            options.AddArgument("disable-notifications");
            options.AddArgument("test-type");
            // Driver'a setliyoruz options'ları
            driver = new ChromeDriver(options);
            // Süreler
            //30sn sayfanın yüklenmesini bekler yoksa devam eder.
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            //dolaylı bekleme.1er 1er art ış yapar.
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            // Gidilen sayfa url'i
            driver.Navigate().GoToUrl("https://www.flypgs.com/");
            baseOperation = new BaseOperation(driver);
            //log.Info("Driver ayağa kalktı...");
        }

        [Given("'(.*)' objesine tıklanır..")]
        public void Click( string xpath)
        {
            //log.Info("tıklandı " + xpath);
            baseOperation.ClickElement(By.XPath(xpath));
        }

        [Given("'(.*)' objesine '(.*)' yazılır.")]
        public void Send(string xpath, string value)
        {
            baseOperation.SendKeys(By.ClassName(xpath), value);
        }

        [Given("'(.*)' seçimi '(.*)'")]
        public void CalenderSelect(string str,string calender)//Dönüş Bilet, 23.Kasım.2026
        {
            string[] arr = calender.Split(".");//23 Kasım 2026
            
            baseOperation.CalenderSelect(str,arr);
        }

        [Given("'(.*)' uçuş seçimi yapılır. '(.*)'")]
        public void SelectFlying(string select, string uçuş)
        {
            baseOperation.ClickElement(By.XPath(uçuş));
        }

        [Given("'(.*)' Ekonomik paket seçimi yapılır. '(.*)'")]
        public void PaketSelect(string str, string packed)
        {
            baseOperation.ClickElement(By.XPath(packed));
        }

        [Given("(.*) saniye bekle")]
        public void Wait(int time)
        {
            Thread.Sleep(TimeSpan.FromSeconds(time));
        }

        [AfterScenario]
        public void FinishScenario()
        {
            driver.Quit();
        }
       
    }
}

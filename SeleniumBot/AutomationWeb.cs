using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumBot
{

    public class AutomationWeb
    {
        public IWebDriver driver;

        public AutomationWeb()
        {
            driver = new ChromeDriver();
        }

        public string TesteWeb()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.FindElement(By.Name("q")).SendKeys("Hello World!");
            driver.FindElement(By.XPath("/html/body/div[2]/div[6]/form/div[1]/div/div[4]/center/input[1]")).Click();
            var text = driver.FindElement(By.XPath("//*[@id='rso']/div[2]/div[1]/div/div/div/div[2]/div[1]")).Text;

            return text;
        }
    }
}
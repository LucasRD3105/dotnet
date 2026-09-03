using EasyAutomationFramework;
using OpenQA.Selenium;
using System.Data;
using WebScraping.Model;

namespace WebScraping.Driver
{
    public class WebScraper : Web
    {
        public DataTable GetData(string link)
        {
            if (driver == null)
            {
                var browser = StartBrowser(TypeDriver.GoogleChorme);

                driver = browser.driver;
            }

            var items = new List<Item>();

            driver.Navigate().GoToUrl(link);

            Thread.Sleep(3000);

            var container = driver.FindElement(
                By.XPath("/html/body/div[2]/main/div[3]/div/div[2]/div[1]")
            );

            var elements = container.FindElements(
                By.ClassName("thumbnail")
            );

            foreach (var element in elements)
            {
                var item = new Item();

                item.Title = element.FindElement(By.ClassName("title")).GetAttribute("title") ?? string.Empty;
                item.Price = element.FindElement(By.ClassName("price")).Text;
                item.Description = element.FindElement(By.ClassName("description")).Text;

                items.Add(item);
            }

            return Base.ConvertTo(items);
        }
    }
}
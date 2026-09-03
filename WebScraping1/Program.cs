using EasyAutomationFramework;
using EasyAutomationFramework.Model;
using WebScraping.Driver;

var web = new WebScraper();
var computers = web.GetData("https://webscraper.io/test-sites/e-commerce/allinone/computers");
var laptops = web.GetData("https://webscraper.io/test-sites/e-commerce/allinone/computers/laptops");
var tablets = web.GetData("https://webscraper.io/test-sites/e-commerce/allinone/computers/tablets");

var paramss = new ParamsDataTable("Dados", @"C:\Users\Lucas Rocha Dantas\Documents\Lucas Rocha Dantas\Vida profissional\Atento\EstudosDotNet", new List<DataTables>()
{
    new DataTables("computers", computers),
    new DataTables("laptops", laptops),
    new DataTables("tablets", tablets),
});


Base.GenerateExcel(paramss);
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class Program
    {
       // IWebDriver driver = new ChromeDriver(@"C:\Users\User\Downloads\chromedriver_win32");

        static void Main(string[] args)
        {
            //IWebDriver driver = new ChromeDriver(@"C:\Users\User\Downloads\chromedriver_win32");
            //driver.Navigate().GoToUrl("http://www.google.com");
            //IWebElement element = driver.FindElement(By.Name("q"));
            //element.SendKeys("sdklsdlsk");
            //driver.Close();
        }
        [SetUp]
        public void Initializer()
        {
            PropertiesColection.driver = new ChromeDriver(@"C:\Users\User\Downloads\chromedriver_win32");
            //driver.Navigate().GoToUrl("http://www.google.com");
            PropertiesColection.driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("opend URL");
        }
        [Test]
        public void ExecuteTest()
        {
            // IWebElement element = driver.FindElement(By.Name("q"));
            // element.SendKeys("sdklsdlsk");
            //   Console.WriteLine("test runing");
            //Drop down
            SeleniumSetMethods.SelectDropDown( "TitleId", "Mr.", PropertyType.Id);

            //Title
            SeleniumSetMethods.EnterText("Initial","test",PropertyType.Name);

            //Resived text
            Console.WriteLine("resived text from title: "+SeleniumGetMethods.GetText("TitleId", PropertyType.Id));
            Console.WriteLine("resived text from initial: " + SeleniumGetMethods.GetText( "Initial", PropertyType.Name));

            //Click
            SeleniumSetMethods.Click("Save", PropertyType.Name);
        }
        [Test]
         public void NextTest()
        {
            Console.WriteLine("next test");

        }
        [TearDown]
        public void ClianUp()
        {
           // driver.Close();
            Console.WriteLine("close browser");
        }
    }
}

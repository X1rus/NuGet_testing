using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class SeleniumSetMethods
    {
        //Enter Text
        public static void EnterText(IWebElement element, string value)
        {
            element.SendKeys(value);
        }
        //Click operations

        public static void Click(IWebElement element)
        {
            element.Click();
        }

        //selecting drop down control
        public static void SelectDropDown(IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);

        }

    }
}

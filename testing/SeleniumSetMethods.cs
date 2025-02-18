﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
  public static  class SeleniumSetMethods
    {
        //Enter Text
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }
        //Click operations button, checkbox, option ect.

        public static void Clicks(this IWebElement element)
        {
            element.Click();
        }

        //selecting drop down control
        public static void SelectDropDown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);

        }

    }
}

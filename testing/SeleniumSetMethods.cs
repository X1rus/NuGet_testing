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
        public static void EnterText(string element, string value, PropertyType elementtype)
        {
            if (elementtype==PropertyType.Id)
                PropertiesColection.driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == PropertyType.Name)
                PropertiesColection.driver.FindElement(By.Name(element)).SendKeys(value);
        }
        //Click operations

        public static void Click(string element, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                PropertiesColection.driver.FindElement(By.Id(element)).Click();
            if (elementtype == PropertyType.Name)
                PropertiesColection.driver.FindElement(By.Name(element)).Click();

        }

        //selecting drop down control
        public static void SelectDropDown( string element, string value, PropertyType elementtype)
        {
          //  SelectElement selectElement = new SelectElement();
            if (elementtype == PropertyType.Id)
               new SelectElement(PropertiesColection.driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == PropertyType.Name)
                new SelectElement(PropertiesColection.driver.FindElement(By.Name(element))).SelectByText(value);

        }

    }
}

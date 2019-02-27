using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace testing
{
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }
    class PropertiesColection
    {
        //Auto implement properties
        public static IWebDriver driver { get; set; }
        enum PropertyType
        {
            Id,
            Name,
            LinkText,
            CssName,
            ClassName
        }
    }
}

﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class EAPageObject
    {
        public EAPageObject()
        {
            PageFactory.InitElements(PropertiesColection.driver,this);
        }


        [FindsBy(How =How.Id,Using = "TitleId")]
        public IWebElement ddlTitleId{ get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }

        public void FillUserForm(string initial, string middleName,string firstName)
        {

            txtInitial.EnterText(initial);
            //txtInitial.SendKeys(initial);
            txtFirstName.EnterText(firstName);
            txtMiddleName.EnterText(middleName);
            btnSave.Clicks();
        }
    }

}

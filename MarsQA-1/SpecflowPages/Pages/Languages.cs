using NUnit.Framework;
using OpenQA.Selenium;
using MarsQA_1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MarsQA_1.Pages

{
   public  class Languages
    {
        public  static void AddLanguges()
        { 
            //Click languges

            IWebElement createlanguges = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            createlanguges.Click();


            //Click AddNew Button
            IWebElement addnewbutton = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewbutton.Click();

            //Add languges
            IWebElement addlanguge = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addlanguge.SendKeys("English");

            //Add languge level
            IWebElement langugelevel = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            langugelevel.Click();

            IWebElement basicl = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]"));
            basicl.Click();

            //add and save languges
            IWebElement savelang = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            savelang.Click();
            Thread.Sleep(1000);

            // Check if record is present
            IWebElement actuallang = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
           Assert.That(actuallang.Text == "English", "actual languge and expected languge did not match");

        } }
    }


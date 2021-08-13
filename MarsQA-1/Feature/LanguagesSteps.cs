using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class LanguagesSteps
    {
        [Given(@"Seller has clicked on  languges tab")]
        public void GivenSellerHasClickedOnLangugesTab()
        {
            IWebElement createlanguges = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            createlanguges.Click();
        }

        [Given(@"Seller has clicked on Add New")]
        public void GivenSellerHasClickedOnAddNew()
        {
            IWebElement addnewbutton = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewbutton.Click();
        }

        [Given(@"Seller has added  name of the language")]
        public void GivenSellerHasAddedNameOfTheLanguage()
        {
            IWebElement addlanguge = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addlanguge.SendKeys("English");
        }

        [Given(@"Seller has chosen langugage level")]
        public void GivenSellerHasChosenLangugageLevel()
        {
            IWebElement langugelevel = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            langugelevel.Click();
            IWebElement basicl = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]"));
            basicl.Click();
        }

        
        [Given(@"Seller has clicked on Edit")]
        public void GivenSellerHasClickedOnEdit()
        {
            IWebElement editbtn = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
            editbtn.Click();
        }


        [Given(@"Seller has edit  name of the language or chosen language level")]
        public void GivenSellerHasEditNameOfTheLanguageOrChosenLanguageLevel()
        {
            IWebElement elanguage = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[1]/input"));
            elanguage.Clear();
            elanguage.SendKeys("Chinese");

        }

        [When(@"seller clicks on Add button")]
        public void WhenSellerClicksOnAddButton()
        {
            IWebElement savelang = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            savelang.Click();

        }

        [When(@"seller clicks on Update button")]
        public void WhenSellerClicksOnUpdateButton()
        {
            IWebElement updbtn = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
            updbtn.Click();

        }

        [When(@"seller clicks on Delete button")]
        public void WhenSellerClicksOnDeleteButton()
        {
            IWebElement deletebtn = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]"));
            deletebtn.Click();

        }

        [Then(@"Seller's languages must be saved and visible")]
        public void sellerlang()
        {
            Driver.driver.Navigate().Refresh();
            IWebElement actuallang = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            Assert.That(actuallang.Text == "English", "actual languge and expected languge did not match");
        }

        [Then(@"Seller can add only (.*) languages")]
        public void ThenSellerCanAddOnlyLanguages(int p0)
        {

            IWebElement addnewbutton = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewbutton.Click();


            IWebElement addlanguge = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addlanguge.SendKeys("Gujarati");


            IWebElement langugelevel = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            langugelevel.Click();

            IWebElement basicl = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]"));
            basicl.Click();


            IWebElement savelang = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            savelang.Click();
            Driver.driver.Navigate().Refresh();

            IWebElement addnewbuton = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewbuton.Click();


            IWebElement addlangug = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addlangug.SendKeys("Hindi");


            IWebElement langugeleve = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            langugeleve.Click();

            IWebElement basic = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]"));
            basic.Click();


            IWebElement savelan = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            savelan.Click();
            Driver.driver.Navigate().Refresh();

            IWebElement addnewbutto = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewbutto.Click();


            IWebElement addlangu = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addlangu.SendKeys("Panjabi");


            IWebElement langugele = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            langugele.Click();

            IWebElement basi = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]"));
            basi.Click();


            IWebElement savela = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            savela.Click();
            Driver.driver.Navigate().Refresh();
        }

        [Then(@"Seller's  Updated language must be saved and visible")]
        public void ThenSellerSUpdatedLanguageMustBeSavedAndVisible()
        {

            Driver.driver.Navigate().Refresh();
            IWebElement uptlang = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
            Assert.That(uptlang.Text == "Chinese", "actual languge and expected languge did not match");
        }



        [Then(@"Seller's languages must be Deleted")]
        public void ThenSellerSLanguagesMustBeDeleted()
        {
            IWebElement lang = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
            Assert.That(lang.Text != "English", "languge fail to delete");
        }
    }
}



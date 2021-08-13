using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class EducationSteps
    {
        [Given(@"Seller has clicked on  Education tab")]
        public void GivenSellerHasClickedOnEducationTab()
        {

            Driver.TurnOnWait();
            IWebElement edubtn = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            edubtn.Click();


        }

        [Given(@"Seller has clicked on Add New on Education")]
        public void GivenSellerHasClickedOnAddNewOnEducation()
        {
            Driver.TurnOnWait();
            IWebElement eduadd = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            eduadd.Click();

        }

        [Given(@"Seller has added  name of the Colledge")]
        public void GivenSellerHasAddedNameOfTheColledge()
        {
            Driver.TurnOnWait();
            IWebElement clgadd = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            clgadd.SendKeys("K.S");
        }

        [Given(@"Seller has selected country of colledge")]
        public void GivenSellerHasSelectedCountryOfColledge()
        {
            Driver.TurnOnWait();
            IWebElement clgcountry = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            clgcountry.Click();
            Driver.TurnOnWait();
            IWebElement countryname = Driver.driver.FindElement(By.XPath(" /html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[66]"));
            countryname.Click();

        }

        [Given(@"Seller has selected title")]
        public void GivenSellerHasSelectedTitle()
        {
            Driver.TurnOnWait();
            IWebElement degreetitle = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
            degreetitle.Click();
            Driver.TurnOnWait();
            IWebElement titlenm = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[6]"));
            titlenm.Click();

        }

        [Given(@"Seller has added degree")]
        public void GivenSellerHasAddedDegree()
        {
            Driver.TurnOnWait();
            IWebElement degreenm = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
            degreenm.SendKeys("bachler's in informtion technology");

        }

        [Given(@"Seller has selected year of graduation")]
        public void GivenSellerHasSelectedYearOfGraduation()
        {
            Driver.TurnOnWait();
            IWebElement yearofgradution = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            yearofgradution.Click();
            Driver.TurnOnWait();
            IWebElement year = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[3]"));
            year.Click();

        }

        [Given(@"Seller has clicked on Edit on Education")]
        public void GivenSellerHasClickedOnEditOnEducation()
        {

            IWebElement editedu = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i"));
            editedu.Click();
        }

        [Given(@"Seller has edit name of the Colledge")]
        public void GivenSellerHasEditNameOfTheColledge()
        {
            IWebElement eclg = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[1]/input"));
            eclg.Clear();
            eclg.SendKeys("B.K");
        }

        [Given(@"Seller has  edit country of colledge")]
        public void GivenSellerHasEditCountryOfColledge()
        {
            IWebElement ecountry = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[2]/select"));
            ecountry.Click();
            IWebElement ecountryn = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[2]/select/option[102]"));
            ecountryn.Click();

        }

        [Given(@"Seller has edit title")]
        public void GivenSellerHasEditTitle()
        {

            Driver.TurnOnWait();
            IWebElement edegreetitle = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[1]/select"));
            edegreetitle.Click();
            Driver.TurnOnWait();
            IWebElement etitlenm = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[1]/select/option[8]"));
            etitlenm.Click();
        }

        [Given(@"Seller has edit degree")]
        public void GivenSellerHasEditDegree()
        {
            Driver.TurnOnWait();
            IWebElement edegreenm = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[2]/input"));
            edegreenm.Clear();
            edegreenm.SendKeys("Master of Science"); ;
        }

        [Given(@"Seller has edit year of graduation")]
        public void GivenSellerHasEditYearOfGraduation()
        {
            Driver.TurnOnWait();
            IWebElement eyearofgradution = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[3]/select"));
            eyearofgradution.Click();
            Driver.TurnOnWait();
            IWebElement eyear = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[3]/select/option[4]"));
            eyear.Click();
        }

        [When(@"seller clicks on Add button on Education")]
        public void WhenSellerClicksOnAddButtonOnEducation()
        {
            Driver.TurnOnWait();
            IWebElement addedu = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            addedu.Click();


        }

        [When(@"seller clicks on update button on Education")]
        public void WhenSellerClicksOnUpdateButtonOnEducation()
        {
            IWebElement updbtn = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]"));
            updbtn.Click();

        }

        [When(@"seller clicks on delete button on Education")]
        public void WhenSellerClicksOnDeleteButtonOnEducation()
        {
            IWebElement deletebtn = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i"));
            deletebtn.Click();

        }

        [Then(@"Seller's  education must be saved and visible")]
        public void ThenSellerSEducationMustBeSavedAndVisible()
        {
            Driver.TurnOnWait();
            IWebElement actualedu = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
            Assert.That(actualedu.Text == "K.S", "actual colledge and expected colledge did not match");
        }

        [Then(@"Seller's  Updated education must be saved and visible")]
        public void ThenSellerSUpdatedEducationMustBeSavedAndVisible()
        {
            Driver.TurnOnWait();
            IWebElement updedu = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
            Assert.That(updedu.Text == "B.K", "actual colledge and expected colledge did not match");
        }


        [Then(@"Seller's  education must be deleted")]
        public void ThenSellerSEducationMustBeDeleted()
        {

            Driver.TurnOnWait();
            List<IWebElement> elementList = new List<IWebElement>();
            elementList.AddRange(Driver.driver.FindElements(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]")));
            Assert.That(elementList.Count > 0, "Test fail");

        }
        }
    }


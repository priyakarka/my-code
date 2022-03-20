﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using my_code.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace my_code.Pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            // Click on create new button 
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();

            // Select material from TypeCode dropdown
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();
           wait.WaitToBeClickable(driver, "XPath", "//*[@id='TypeCode_listbox']/li[1]");

            IWebElement materialOption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            materialOption.Click();

            // Identify the code textbox and input a code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("mycode");

            // Identify the description textbox and input a description 
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("mycode");

            // Identify the price textbox and input a price 

            IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceTag.Click();

            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("12");

            // Click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            wait.WaitToBeVisible(driver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 2);


            // Click on go to last page buttton
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(2000);


        }


        public string GetCode(IWebDriver driver)
        {
            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return actualCode.Text;
        }

        public string GetTypeCode(IWebDriver driver)
        {
            IWebElement actualTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            return actualTypeCode.Text;
        }

        public string GetDescription(IWebDriver driver)
        {
            IWebElement actualDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return actualDescription.Text;

        }

        public string GetPrice(IWebDriver driver)
        {
            IWebElement actualPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            return actualPrice.Text;
        }





        public void EditTM(IWebDriver driver, string description, string code,string price)
        {
            // Wait untill the entire TM page is displayed
            wait.WaitToBeVisible(driver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 2);

            // click on go to last page button 
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement findRecordCreated = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findRecordCreated.Text == "mycode")
            {
                // Click on edit button
                IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                editButton.Click();

            }

            else
            {
                Assert.Fail("Record to be edited hasn't been found. Record not edited");
            }

            // Edit code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.Clear();
            codeTextbox.SendKeys(code);


            // Edit description
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.Clear();
            descriptionTextbox.SendKeys(description);

            // Edit price
            IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));

            priceTag.Click();
            priceTextbox.Clear();
            priceTag.Click();
            priceTextbox.SendKeys(price);

            //   // Click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            wait.WaitToBeVisible(driver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 2);

            // Click on go to last page button
            IWebElement goToLastPageButton1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton1.Click();
            Thread.Sleep(1000);
                       

        }

        public string GetEditedDescription(IWebDriver driver)
        {
            IWebElement createdDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return createdDescription.Text;

        }

        public string GetEdtedCode(IWebDriver driver)
        {
            IWebElement createdCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return createdCode.Text;

        }

        public string GetEdtedPrice(IWebDriver driver)
        {
            IWebElement createdPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            return createdPrice.Text;
        }



        public void DeleteTM(IWebDriver driver)
        {

            // Wait until the entire TM page is displayed
            wait.WaitToBeVisible(driver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 2);

            // Click on go to last page button
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement findEditedRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findEditedRecord.Text == "Editedmycode")
            {
                // Click on delete button
                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
                deleteButton.Click();
                Thread.Sleep(1000);

                driver.SwitchTo().Alert().Accept();
            }
            else
            {
                Assert.Fail("Record to be deleted hasn't been found. Record not deleted");
            }

            // Assert that Time record has been deleted
            driver.Navigate().Refresh();
            Thread.Sleep(1000);

            IWebElement goToLastPageButton1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton1.Click();
            Thread.Sleep(1000);

            IWebElement editedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement editedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            // Assertion
            Assert.That(editedCode.Text != "Editedmy code", "Code record hasn't been deleted.");
            Assert.That(editedDescription.Text != "Editedmy code", "Description record hasn't been deleted.");
            Assert.That(editedPrice.Text != "$170.00", "Price record hasn't been deleted.");

        }
    }


}


using NUnit.Framework;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLoanTest
{
    class HomeLoanTest
    {
        IWebDriver driver;

        [SetUp]
                public void startBrowser()
        {
            driver = new ChromeDriver("C:\\devmtn\\testing-resources");
        }

        [Test]
                public void test()
        {
            driver.Url = "http://localhost:3000/";

            //Main Screen
            IWebElement button = driver.FindElement(By.CssSelector("button[name='nextButton']"));
            button.Click();

            //Page One
            IWebElement loantypesDropDownElement = driver.FindElement(By.CssSelector("select[id='loanTypes']"));
            SelectElement SelectALoanType = new SelectElement(loantypesDropDownElement);
            SelectALoanType.SelectByValue("Home Purchase");

            IWebElement propertyTypesDropDownElement = driver.FindElement(By.CssSelector("select[id='propertyTypes']"));
            SelectElement selectPropertyType = new SelectElement(propertyTypesDropDownElement);
            selectPropertyType.SelectByValue("Single Family Home");
            IWebElement buttonOne = driver.FindElement(By.CssSelector("button[name='nextButton']"));
            buttonOne.Click();

            //Page Two
            IWebElement cityField = driver.FindElement(By.CssSelector("input[name='city']"));
            cityField.SendKeys("San Fransisco, CA");
            IWebElement buttonTwo = driver.FindElement(By.CssSelector("button[name='nextButton']"));
            buttonTwo.Click();

            //Page Three
            IWebElement primaryHome = driver.FindElement(By.CssSelector("button[value='Primary Home']"));
            primaryHome.Click();

            //Page Four
            IWebElement yesButton = driver.FindElement(By.CssSelector("button[name='yesButton']"));
            yesButton.Click();

            //Page Five
            IWebElement noButton = driver.FindElement(By.CssSelector("button[name='noButton']"));
            noButton.Click();

            //Page Six
            IWebElement priceField = driver.FindElement(By.CssSelector("input[name='price']"));
            priceField.SendKeys("1000.00");
            IWebElement downField = driver.FindElement(By.CssSelector("input[name='down']"));
            downField.SendKeys("100.00");
            IWebElement buttonThree = driver.FindElement(By.CssSelector("button[name='nextButton']"));
            buttonThree.Click();

            //Page Seven
            IWebElement ExcellentButton = driver.FindElement(By.CssSelector("button[value='Excellent']"));
            ExcellentButton.Click();

            //Page Eight
            IWebElement BankruptcyButton = driver.FindElement(By.CssSelector("button[value='Has had bankruptcy']"));
            BankruptcyButton.Click();

            //Page Nine
            IWebElement addressOneField = driver.FindElement(By.CssSelector("input[id='addressOne']"));
            addressOneField.SendKeys("1 Main Street");
            IWebElement addressTwoField = driver.FindElement(By.CssSelector("input[id='addressTwo']"));
            IWebElement addressThreeField = driver.FindElement(By.CssSelector("input[id='addressThree']"));
            addressThreeField.SendKeys("San Fransisco, CA 94111");
            IWebElement buttonFour = driver.FindElement(By.CssSelector("button[name='nextButton']"));
            buttonFour.Click();

            //Page Ten
            IWebElement firstNameField = driver.FindElement(By.CssSelector("input[id='first']"));
            firstNameField.SendKeys("Wilson");
            IWebElement lastNameField = driver.FindElement(By.CssSelector("input[id='last']"));
            lastNameField.SendKeys("Wong");
            IWebElement emailField = driver.FindElement(By.CssSelector("input[id='email']"));
            emailField.SendKeys("williewonga@gmail.com");
            IWebElement buttonFive = driver.FindElement(By.CssSelector("button[name='nextButton']"));
            buttonFive.Click();

            //Summary Page
            IWebElement nameText = driver.FindElement(By.CssSelector("div[name ='nameLabel']"));
            Assert.IsTrue(nameText.Text.Contains("Wilson Wong"));
            IWebElement emailText = driver.FindElement(By.CssSelector("div[name ='emailLabel']"));
            Assert.IsTrue(emailText.Text.Contains("williewonga@gmail.com"));
            IWebElement loanTypeText = driver.FindElement(By.CssSelector("div[name ='loanTypeLabel']"));
            Assert.IsTrue(loanTypeText.Text.Contains("Home Purchase"));
            IWebElement cityText = driver.FindElement(By.CssSelector("div[name ='cityLabel']"));
            Assert.IsTrue(cityText.Text.Contains("San Fransisco, CA"));
            IWebElement propertyPurposeText = driver.FindElement(By.CssSelector("div[name ='propertyPurposeLabel']"));
            Assert.IsTrue(propertyPurposeText.Text.Contains("Primary Home"));
            IWebElement foundLabelText = driver.FindElement(By.CssSelector("div[name ='foundLabel']"));
            Assert.IsTrue(foundLabelText.Text.Contains("Yes"));
            IWebElement agentLabelText = driver.FindElement(By.CssSelector("div[name ='agentLabel']"));
            Assert.IsTrue(agentLabelText.Text.Contains("No"));
            IWebElement priceLabelText = driver.FindElement(By.CssSelector("div[name ='priceLabel']"));
            Assert.IsTrue(priceLabelText.Text.Contains("1000.00"));
            IWebElement downPaymentText = driver.FindElement(By.CssSelector("div[name ='downPaymentLabel']"));
            Assert.IsTrue(downPaymentText.Text.Contains("100.00"));
            IWebElement creditScoreText = driver.FindElement(By.CssSelector("div[name ='creditScoreLabel']"));
            Assert.IsTrue(creditScoreText.Text.Contains("Excellent"));
            //Assert.IsTrue(creditScoreText.Text.Contains("Has had bankruptcy"));
            IWebElement addressText = driver.FindElement(By.CssSelector("div[name ='addressLabel']"));
            Assert.IsTrue(addressText.Text.Contains("1 Main Street"));
            Assert.IsTrue(addressText.Text.Contains("San Fransisco, CA 94111"));
        }

        [TearDown]
                public void closeBrowser()
        {
            driver.Close();
        }
    }
}
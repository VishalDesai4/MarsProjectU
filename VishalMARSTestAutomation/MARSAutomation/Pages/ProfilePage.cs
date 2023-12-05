using MARSAutomation.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARSAutomation.Pages
{
    public class ProfilePage : CommonDriver
    {
        IWebDriver webDriver;
        private IWebElement addNewButton => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private IWebElement languageTextBox => webDriver.FindElement(By.Name("name"));
        private IWebElement langLevelDropdown => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
        private IWebElement langLevelBasic => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]"));
        private IWebElement langLevelConversational => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]"));
        private IWebElement langLevelFluent => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]"));
        private IWebElement langLevelBilingual => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[5]"));
        private IWebElement addButton => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
        private IWebElement languageTab => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
        private IWebElement skillTab => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
        private IWebElement cancelButton => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[2]"));
        private IWebElement editIcon => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
        private IWebElement updateTextBox => webDriver.FindElement(By.Name("name"));
        private IWebElement updateLevelDropdown => webDriver.FindElement(By.Name("level"));
        private IWebElement updateLevelBasic => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[2]"));
        private IWebElement updateLevelConversational => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[3]"));
        private IWebElement updateLevelFluent => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[4]"));
        private IWebElement updateLevelBilingual => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[5]"));
        private IWebElement updateButton => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));
        private IWebElement deleteIcon => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
        private IWebElement errorMessage => webDriver.FindElement(By.XPath("//*[@class='ns-box-inner']"));
        private IWebElement languageName => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
        private IWebElement languageLevel => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
        private IWebElement addNewSkillButton => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private IWebElement skillTextBox => webDriver.FindElement(By.Name("name"));
        private IWebElement skillLevelDropdown => webDriver.FindElement(By.Name("level"));
        private IWebElement skillLevelBeginner => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]"));
        private IWebElement skillLevelintermediate => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
        private IWebElement skillLevelExpert => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[4]"));
        private IWebElement addSkillButton => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));

        public ProfilePage(IWebDriver driver)
        {
            webDriver = driver;
        }
        public void ClickLanguagesTab()
        {         
            languageTab.Click();
        }
        public void ClickSkillTab()
        {       
            skillTab.Click();
        }
        public void GoToLanguageTab()
        {
            ClickLanguagesTab();
        }
        public void GoToSkillsTab()
        {
         ClickSkillTab();
        }      
        public void ClickAddNewButton()
        {
           addNewButton.Click();
        }
        public void AddLanguage(string language)
        {
            languageTextBox.SendKeys(language);
        }
        public void ClickLevelDropdown()
        { 
            langLevelDropdown.Click();
        }        
        public void AddLevelBasic()
        {
            langLevelBasic.Click();
        }
        public void AddLevelConversational()
        {
            langLevelConversational.Click();
        }
        public void AddLevelFluent()
        {
            langLevelFluent.Click();
        }
        public void AddLevelBilingual()
        {
            langLevelBilingual.Click();
        }
        public void ClickAddButton()
        {
            addButton.Click();
        }
        public void AddLanguage(IWebDriver driver, String language, String level)
        {            
            ClickAddNewButton();
            AddLanguage(language);
            ClickLevelDropdown();
            if (level == "Basic")
            {
                AddLevelBasic();
            }
            if (level == "Conversational")
            {
                AddLevelConversational();
            }
            if (level == "Fluent")
            {
                AddLevelFluent();
            }
            if (level == "Native/Bilingual")
            {
                AddLevelBilingual();
            }
            ClickAddButton();
            Thread.Sleep(1000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }      
        public void ClickCancelButton()
        {
            cancelButton.Click();
        }
        public void CancelAddLanguage(IWebDriver driver, String language, String level)
        {            
            this.ClickAddNewButton();
            this.AddLanguage(language);
            this.ClickLevelDropdown();
            if (level == "Basic")
            {
                this.AddLevelBasic();
            }
            if (level == "Conversational")
            {
                this.AddLevelConversational();
            }
            if (level == "Fluent")
            {
                this.AddLevelFluent();
            }
            if (level == "Native/Bilingual")
            {
                this.AddLevelBilingual();
            }
            this.ClickCancelButton();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(1000);
        }      
        public void ClickEditIcon()
        {
            editIcon.Click();
        }        
        public void AddNewLanguage(string language)
        {
            updateTextBox.Clear();
            updateTextBox.SendKeys(language);
        }
        public void ClickLanguageDropdown()
        {
            updateLevelDropdown.Click();
        }
        public void UpdateLevelBasic()
        {
            updateLevelBasic.Click();
        }
        public void UpdateLevelConversational()
        {
            updateLevelConversational.Click();
        }
        public void UpdateLevelFluent()
        {
          updateLevelFluent.Click();
        }
        public void UpdateLevelBilingual()
        {
            updateLevelBilingual.Click();
        }
        public void ClickEditButton()
        {
            updateButton.Click();
        }
        public void UpdateLanguage(IWebDriver driver, String language, String level)
        {            
            ClickEditIcon();
            AddNewLanguage(language);
            ClickLanguageDropdown();
            if (level == "Basic")
            {
               UpdateLevelBasic();
            }
            if (level == "Conversational")
            {
                this.UpdateLevelConversational();
            }
            if (level == "Fluent")
            {
               UpdateLevelFluent();
            }
            if (level == "Native/Bilingual")
            {
                UpdateLevelBilingual();
            }
            ClickEditButton();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(1000);
        }     
        public void DeleteLanguage(IWebDriver driver)
        {
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i", 5);
            deleteIcon.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Thread.Sleep(2000);
        }
        public string AlertMessage(IWebDriver driver)
          {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);           
            return errorMessage.Text;
          }       
        public string VerifyLanguage(IWebDriver driver)
        {           
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            return languageName.Text;
        }        
        public string VerifyLanguageLevel(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            return languageLevel.Text;
        }
        

        public void ClickAddNewSkill()
        {

            addNewSkillButton.Click();

        }


        public void EnterSkill(string skill)
        {
            skillTextBox.SendKeys(skill);

        }

        public void ClickSkillLevelDropdown()
        {

            skillLevelDropdown.Click();
        }


        public void AddLevelBeginner()
        {

           skillLevelBeginner.Click();


        }
        public void AddLevelIntermediate()
        {

            skillLevelintermediate.Click();


        }
        public void AddLevelExpert()
        {

            skillLevelExpert.Click();


        }
       
        public void ClickAddSkillButton()
        {

            addSkillButton.Click();

        }
        public void AddSkill(IWebDriver driver, String skill, String level)
        {


            ClickAddNewSkill();

            EnterSkill(skill);

            ClickSkillLevelDropdown();

            if (level == "Beginner")
            {

              AddLevelBeginner();
            }
            if (level == "Intermediate")
            {
               AddLevelIntermediate();
            }
            if (level == "Expert")
            {
               AddLevelExpert();
            }
           
            ClickAddSkillButton();

            Thread.Sleep(1000);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);


        }

        //Cancel Adding Skill

        private IWebElement cancelSkillButton => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[2]"));

        public void ClickCancelSkillButton()
        {

            cancelSkillButton.Click();

        }
        public void CancelAddSkill(IWebDriver driver,String skill, String level)
        {


            ClickAddNewSkill();

            EnterSkill(skill);

            ClickSkillLevelDropdown();

            if (level == "Beginner")
            {

                AddLevelBeginner();
            }
            if (level == "Intermediate")
            {
               AddLevelIntermediate();
            }
            if (level == "Expert")
            {
                AddLevelExpert();
            }

            ClickCancelSkillButton();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);


        }


        // Verification of Skill and Level

        private IWebElement skillNameVerify => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
        private IWebElement skillLevel => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));

        public string VerifySkill(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
          
            return skillNameVerify.Text;
        }
        public string VerifySkillLevel(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            return skillLevel.Text;
        }


        // Update Skill

        private IWebElement updateSkillIcon => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
        private IWebElement updateSkillTextBox => webDriver.FindElement(By.Name("name"));
        private IWebElement updateSkillLevelDropdown => webDriver.FindElement(By.Name("level"));
        private IWebElement updateSkillBeginner => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[2]"));
        private IWebElement updateSkillIntermediate => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[3]"));
        private IWebElement updateSkillExpert => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[4]"));
        private IWebElement updateSkillButton => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));
        public void ClickUpdateSkill()
        {

            updateSkillIcon.Click();

        }


        public void EnterNewSkill(string skill)
        {
          updateSkillTextBox.Clear();
          updateSkillTextBox.SendKeys(skill);

        }

        public void UpdateSkillLevelDropdown()
        {

            updateSkillLevelDropdown.Click();
        }


        public void UpdateLevelBeginner()
        {

            updateSkillBeginner.Click();


        }
        public void UpdateLevelIntermediate()
        {

            updateSkillIntermediate.Click();


        }
        public void UpdateLevelExpert()
        {

            updateSkillExpert.Click();


        }

        public void ClickUpdateSkillButton()
        {

            updateSkillButton.Click();

        }
        public void UpdateSkill(IWebDriver driver, String skill, String level)
        {


            ClickUpdateSkill();

            EnterNewSkill(skill);

            UpdateSkillLevelDropdown();

            if (level == "Beginner")
            {

                UpdateLevelBeginner();
            }
            if (level == "Intermediate")
            {
               UpdateLevelIntermediate();
            }
            if (level == "Expert")
            {
                UpdateLevelExpert();
            }

            ClickUpdateSkillButton();

            Thread.Sleep(1000);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);


        }

        //Delete Skill

        private IWebElement deleteSkillIcon => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));

        
        public void DeleteSkill(IWebDriver driver)
        {
            deleteSkillIcon.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(1000);
        }

        public void ResetLanguageTable(IWebDriver driver)
        {
            int rowCount = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr")).Count;

           
           
            if(rowCount > 0)
            {
                for (int i = 0; i < rowCount; i++)
                {
                    driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i")).Click();
                    Thread.Sleep(1000);
                }                                 
            }
            
           
        }

        public void ResetSkillTable(IWebDriver driver)
        {
            int rowCount = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr")).Count;

            

            if (rowCount > 0)
            {
                for (int i = 0; i < rowCount; i++)
                {
                    driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i")).Click();
                    Thread.Sleep(1000);                           
                }
            }

        }

    } 
}
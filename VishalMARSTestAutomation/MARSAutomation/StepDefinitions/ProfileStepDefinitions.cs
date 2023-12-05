using MARSAutomation.Pages;
using MARSAutomation.Utilities;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Reflection.Emit;

namespace MARSAutomation.StepDefinitions
{
    [Binding]


    public class ProfileStepDefinitions : CommonDriver
        
    {
        ProfilePage profilePageObj;
        LoginPage loginPageObj;
       

        [Given(@"I logged into the MARS Application successfully")]
        public void GivenILoggedIntoTheMARSApplicationSuccessfully()
        {
            loginPageObj = new LoginPage(driver);
            loginPageObj.LoginActions(driver, "desaivis@gmail.com", "Hiya12345@");
        }

        [Given(@"I navigate to Profile Page Languages tab")]
        public void GivenINavigateToProfilePageLanguagesTab()
        {
            profilePageObj = new ProfilePage(driver);
            profilePageObj.GoToLanguageTab();

        }

        [When(@"I Add a Language that already exists with a new level '([^']*)' '([^']*)' '([^']*)'")]
        public void WhenIAddALanguageThatAlreadyExistsWithANewLevel(string language, string levelOld, string levelNew)
        {
            profilePageObj.ResetLanguageTable(driver);
            profilePageObj.AddLanguage(driver,language, levelOld);
           profilePageObj.AddLanguage(driver,language, levelNew);
        }


        [When(@"I Add a new Language '([^']*)' '([^']*)'")]
        public void WhenIAddANewLanguage(string language, string level)
        {
            profilePageObj.ResetLanguageTable(driver);
            profilePageObj.AddLanguage(driver, language, level);
        }

        [Then(@"the language should be added Successfully '([^']*)' '([^']*)' '([^']*)'")]
        public void ThenTheLanguageShouldBeAddedSuccessfully(string language, string level, string message)
        {

            string langName = profilePageObj.VerifyLanguage(driver);
            string langLevel = profilePageObj.VerifyLanguageLevel(driver);
            string alertMessage = profilePageObj.AlertMessage(driver);
            Assert.That(langName == language, "Selected Language not added successfully");
            Assert.That(langLevel == level, "Selected Language level not added Successfully");
            Assert.That(alertMessage == message, "Selected Language not added Successfully");

        }
        [When(@"I Add a Language that already exists '([^']*)' '([^']*)'")]
        public void WhenIAddALanguageThatAlreadyExists(string language, string level)
        {
            profilePageObj.ResetLanguageTable(driver);
            profilePageObj.AddLanguage(driver,language, level);
            profilePageObj.AddLanguage(driver,language, level);
        }

        [Then(@"the user should not be added '([^']*)'")]
        public void ThenTheUserShouldNotBeAdded(string errorMessage)
        {
            string actualMessage = profilePageObj.AlertMessage(driver);
            Assert.That(actualMessage == errorMessage, "Duplicate data added Successfully");
        }

        [When(@"I Add a new Language with invalid input '([^']*)' '([^']*)'")]
        public void WhenIAddANewLanguageWithInvalidInput(string language, string level)
        {
           profilePageObj.ResetLanguageTable(driver);
           profilePageObj.AddLanguage(driver,language, level);
        }

        [Then(@"the user should see an error message '([^']*)'")]
        public void ThenTheUserShouldSeeAnErrorMessage(string expectedMessage)
        {

            string actualMessage = profilePageObj.AlertMessage(driver);            
            Assert.That(actualMessage == expectedMessage, "Invalid data added Successfully");
        }

        [Given(@"I Add a Language '([^']*)' '([^']*)'")]
        public void GivenIAddALanguage(string languageNew, string levelNew)
        {
            profilePageObj.ResetLanguageTable(driver);
           profilePageObj.AddLanguage(driver,languageNew, levelNew);
        }

        [When(@"I Update the Language '([^']*)' '([^']*)'")]
        public void WhenIUpdateTheLanguage(string language, string level)
        {            
            profilePageObj.UpdateLanguage(driver,language, level);
        }

        [Then(@"the language should be updated successfully '([^']*)' '([^']*)'")]
        public void ThenTheLanguageShouldBeUpdatedSuccessfully(string language, string level)
        {
            string langName = profilePageObj.VerifyLanguage(driver);
            string langLevel = profilePageObj.VerifyLanguageLevel(driver);
            Assert.That(langName == language, "Language not Updated Successfully");
            Assert.That(langLevel == level, "Language level not Updated Successfully");
        }

        [Given(@"I Add a new Language '([^']*)' '([^']*)'")]
        public void GivenIAddANewLanguage(string language, string level)
        {
            profilePageObj.ResetLanguageTable(driver);
           profilePageObj.AddLanguage(driver,language, level);
        }

        [When(@"I Delete the Language")]
        public void WhenIDeleteTheLanguage()
        {
            profilePageObj.DeleteLanguage(driver);
        }

        [Then(@"the language should be deleted successfully '([^']*)'")]
        public void ThenTheLanguageShouldBeDeletedSuccessfully(string popUpMessage)
        {
            string actualMessage = profilePageObj.AlertMessage(driver);
            Assert.That(actualMessage == popUpMessage, "Selected Language not Deleted");
        }

        [Given(@"I navigate to Profile Page Skills tab")]
        public void GivenINavigateToProfilePageSkillsTab()
        {
            profilePageObj = new ProfilePage(driver);
            profilePageObj.GoToSkillsTab();
        }

        [When(@"I Add a new Skill '([^']*)''([^']*)'")]
        public void WhenIAddANewSkill(string skill, string level)
        {
            profilePageObj.ResetSkillTable(driver);
            profilePageObj.AddSkill(driver, skill, level);
        }

        [Then(@"the Skill should be added successfully '([^']*)''([^']*)' '([^']*)'")]
        public void ThenTheSkillShouldBeAddedSuccessfully(string skill, string level, string message)
        {
            string skillName = profilePageObj.VerifySkill(driver);
            string skillLevel = profilePageObj.VerifySkillLevel(driver);
            string popUpMessage = profilePageObj.AlertMessage(driver);
            Assert.That(skillName == skill, "Skill not added successfully");
            Assert.That(skillLevel == level, "Skill level not added successfully");
            Assert.That(popUpMessage == message, "Skill not added successfully");
        }

        [When(@"I Add a Skill that already exists '([^']*)' '([^']*)'")]
        public void WhenIAddASkillThatAlreadyExists(string skill, string level)
        {
            profilePageObj.ResetSkillTable(driver);
            profilePageObj.AddSkill(driver,skill, level);
            profilePageObj.AddSkill(driver,skill, level);
        }

        [When(@"I Add a Skill that already exists with a new level '([^']*)' '([^']*)' '([^']*)'")]
        public void WhenIAddASkillThatAlreadyExistsWithANewLevel(string skill, string skillOld, string skillNew)
        {
            profilePageObj.ResetSkillTable(driver);
            profilePageObj.AddSkill(driver,skill, skillOld);
            profilePageObj.AddSkill(driver,skill, skillNew);
        }

        [Then(@"the Skill should not be added '([^']*)'")]
        public void ThenTheSkillShouldNotBeAdded(string expectedMessage)
        {
            string actualMessage = profilePageObj.AlertMessage(driver);           
            Assert.That(actualMessage == expectedMessage, "Duplicate data added");
        }

        [When(@"I Add a new Skill with invalid input '([^']*)' '([^']*)'")]
        public void WhenIAddANewSkillWithInvalidInput(string skill, string level)
        {
            profilePageObj.ResetSkillTable(driver);
            profilePageObj.AddSkill(driver,skill, level);
        }

        [Then(@"the user should see an error message to add Skill '([^']*)'")]
        public void ThenTheUserShouldSeeAnErrorMessageToAddSkill(string expectedMessage)
        {
            string actualMessage = profilePageObj.AlertMessage(driver);           
            Assert.That(actualMessage == expectedMessage, "Invalid data added");
        }

        [Given(@"I Add a Skill '([^']*)' '([^']*)'")]
        public void GivenIAddASkill(string skillNew, string levelNew)
        {
            profilePageObj.ResetSkillTable(driver);
            profilePageObj.AddSkill(driver,skillNew, levelNew);
        }

        [When(@"I Update the Skill '([^']*)' '([^']*)'")]
        public void WhenIUpdateTheSkill(string skill, string level)
        {
           profilePageObj.UpdateSkill(driver, skill, level);
        }

        [Then(@"the Skill should be updated successfully '([^']*)' '([^']*)'")]
        public void ThenTheSkillShouldBeUpdatedSuccessfully(string skill, string level)
        {
            string skillName = profilePageObj.VerifySkill(driver);
            string skillLevel = profilePageObj.VerifySkillLevel(driver);
            Assert.That(skillName == skill, "Skill not added successfully");
            Assert.That(skillLevel == level, "Skill level not added successfully");
        }

        [Given(@"I Add a new Skill '([^']*)' '([^']*)'")]
        public void GivenIAddANewSkill(string skill, string level)
        {
            profilePageObj.ResetSkillTable(driver);
            profilePageObj.AddSkill(driver,skill, level);
        }

        [When(@"I Delete the Skill")]
        public void WhenIDeleteTheSkill()
        {
            profilePageObj.DeleteSkill(driver);
        }

        [Then(@"the Skill should be deleted successfully '([^']*)'")]
        public void ThenTheSkillShouldBeDeletedSuccessfully(string popUpMessage)
        {
            string actualMessage = profilePageObj.AlertMessage(driver);
            Assert.That(actualMessage == popUpMessage, "Skill not Deleted");
        }

        [When(@"I Cancel Adding a language '([^']*)' '([^']*)'")]
        public void WhenICancelAddingALanguage(string language, string skill)
        {
            profilePageObj.ResetLanguageTable(driver);
            profilePageObj.CancelAddLanguage(driver,language, skill);
        }

        [Then(@"the Language should not be added '([^']*)' '([^']*)'")]
        public void ThenTheLanguageShouldNotBeAdded(string language, string level)
        {
            string langName = profilePageObj.VerifyLanguage(driver);
            Assert.That(langName != language, "Language Added");
        }

        [When(@"I Cancel Adding a Skill '([^']*)' '([^']*)'")]
        public void WhenICancelAddingASkill(string skill, string level)
        {
            profilePageObj.ResetSkillTable(driver);
            profilePageObj.CancelAddSkill(driver, skill, level);
        }

        [Then(@"the Skill should not be added '([^']*)' '([^']*)'")]
        public void ThenTheSkillShouldNotBeAdded(string skill, string level)
        {
            string skillName = profilePageObj.VerifySkill(driver);
            Assert.That(skillName != skill, "Skill Added");
        }


    }

}

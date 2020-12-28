using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace SpecFlow_Tests.Steps
{
    [Binding]
    public class TestingEpamWeb_SiteSteps : IDisposable
    {
        private IWebDriver chromeDriver;

        private string searchKeyword;
        public TestingEpamWeb_SiteSteps() => chromeDriver = new ChromeDriver();

        [Given(@"I opened Epam web-site")]
        public void GivenIOpenedEpamWeb_Site()
        {
            chromeDriver.Navigate().GoToUrl("https://www.epam-group.ru/");
            Assert.IsTrue(chromeDriver.Title.ToLower().Contains("epam"));
        }
        
        [Given(@"I click Language select button")]
        public void GivenIClickLanguageSelectButton()
        {
            chromeDriver.FindElement(By.XPath("//button[@class='hamburger-menu__button']")).Click();
            System.Threading.Thread.Sleep(2000);
            chromeDriver.FindElement(By.XPath("//div[@class='cookie-disclaimer__column']/button")).Click();
            chromeDriver.FindElement(By.XPath("//button[@class='mobile-location-selector__button']")).Click();
        }
        
        [Given(@"I am on the main page")]
        public void GivenIAmOnTheMainPage()
        {
            Assert.IsTrue(chromeDriver.Title.ToLower().Contains("epam"));
        }

        [Given(@"I select careers button in menu")]
        public void GivenISelectCareersButtonInMenu()
        {
            chromeDriver.Navigate().GoToUrl("https://careers.epam.ua/");
            Assert.IsTrue(chromeDriver.Url == "https://careers.epam.ua/");
        }

        [Given(@"I am on the page with the list of \.NET vacancies")]
        public void GivenIAmOnThePageWithTheListOf_NETVacancies()
        {
            chromeDriver.Navigate().GoToUrl("https://careers.epam.ua/vacancies/job-listings?query=.Net&country=Ukraine");
        }
        
        [Given(@"I scroll down the page")]
        public void GivenIScrollDownThePage()
        {
            ((IJavaScriptExecutor)chromeDriver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
            System.Threading.Thread.Sleep(2000);
        }
        
        [Given(@"I select office in Belarus")]
        public void GivenISelectOfficeInBelarus()
        {
            chromeDriver.FindElement(By.XPath("//div[@data-country='belarus']/button")).Click();
            System.Threading.Thread.Sleep(1000);
        }
        
        [Given(@"I see list of cities in Belarus with EPAM offices")]
        public void GivenISeeListOfCitiesInBelarusWithEPAMOffices()
        {
            ((IJavaScriptExecutor)chromeDriver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 50)");
            System.Threading.Thread.Sleep(1000);
        }
        
        [Given(@"I select Minsk city")]
        public void GivenISelectMinskCity()
        {
            
        }
        
        [Given(@"I scroll to the bottom")]
        public void GivenIScrollToTheBottom()
        {
            ((IJavaScriptExecutor)chromeDriver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            System.Threading.Thread.Sleep(2000);
            chromeDriver.FindElement(By.XPath("//div[@class='cookie-disclaimer__column']/button")).Click();
        }
        
        [Given(@"I click on the magnifier button")]
        public void GivenIClickOnTheMagnifierButton()
        {
            var searchButton = chromeDriver.FindElement(By.ClassName("header-search__button"));
            searchButton.Click();
        }
        
        [Given(@"Serch menu drops down")]
        public void GivenSerchMenuDropsDown()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//form[@class = 'header-search__field']")));

        }

        [Given(@"I type in ""(.*)"" in search field")]
        public void GivenITypeInInSearchField(string searchString)
        {
            this.searchKeyword = searchString.ToLower();
            chromeDriver.FindElement(By.XPath("//input[@id='new_form_search']")).SendKeys(searchKeyword);
        }
        
        [Given(@"I am on the contact page")]
        public void GivenIAmOnTheContactPage()
        {
            chromeDriver.Navigate().GoToUrl("https://www.epam-group.ru/contacts");
        }
        
        [Given(@"I am on the \.NET job offers page")]
        public void GivenIAmOnThe_NETJobOffersPage()
        {
            chromeDriver.Navigate().GoToUrl("https://careers.epam.ua/vacancies/job-listings?query=.Net&country=Ukraine");
        }
        
        [Given(@"by default all offers are sorted by relevance")]
        public void GivenByDefaultAllOffersAreSortedByRelevance()
        {
            System.Threading.Thread.Sleep(2000);
        }
        
        [Given(@"I want to order them by Date")]
        public void GivenIWantToOrderThemByDate()
        {
            chromeDriver.FindElement(By.XPath("//div[@class='cookie-disclaimer__column']/button")).Click();
        }
        
        [When(@"I select next region and language:")]
        public void WhenISelectNextRegionAndLanguage(Table table)
        {
            var wait = new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[@class='mobile-location-selector__link']")));

            chromeDriver.FindElements(By.XPath("//a[@class='mobile-location-selector__link']"))[7].Click();
        }
        
        [When(@"I click ""(.*)"" button")]
        public void WhenIClickButton(string po)
        {
            System.Threading.Thread.Sleep(3000);
            if (po.ToLower().Contains("contact"))
            {
                chromeDriver.FindElement(By.XPath("//div[@class='cookie-disclaimer__column']/button")).Click();
                System.Threading.Thread.Sleep(2000);
                chromeDriver.FindElement(By.XPath("//a[@href='#request']")).Click();
            }
            else
            {         
                chromeDriver.FindElements(By.XPath("//button[@class='header-search__submit']"))[0].Click();
            }
        }

        [When(@"I click on ""(.*)"" button")]
        public void WhenIClickOnButton( string str)
        {
            ((IJavaScriptExecutor)chromeDriver).ExecuteScript("window.scrollTo(0, 500)");
            System.Threading.Thread.Sleep(2000);
            chromeDriver.FindElements(By.XPath("//a[@class = 'search-result__item-apply']"))[0].Click();
        }

        [When(@"I enter ""(.*)"" in search field")]
        public void WhenIEnterInSearchField(string p0)
        {
            System.Threading.Thread.Sleep(1000);
            ((IJavaScriptExecutor)chromeDriver).ExecuteScript("window.scrollTo(0, 1000)");
            chromeDriver.FindElement(By.XPath("//a[@href='/vacancies/job-listings?query=.Net&country=Ukraine']")).Click();
        }

        [When(@"I click ""(.*)"" link")]
        public void WhenIClickLink(string p0)
        {
            chromeDriver.FindElements(By.XPath("//a[@class='locations-viewer__office-map']"))[5].Click();
        }
        
        [When(@"I click Instagram button")]
        public void WhenIClickInstagramButton()
        {
            System.Threading.Thread.Sleep(1000);
            chromeDriver.FindElements(By.XPath("//a[@class='footer__social-link']"))[3].Click();
        }
        
        [When(@"I hover my mouse on the ""(.*)"" text")]
        public void WhenIHoverMyMouseOnTheText(string p0)
        {
            var BeforeSort = chromeDriver.FindElements(By.XPath("//a[@class='search-result__item-apply']"))[0].GetAttribute("href");
            chromeDriver.FindElement(By.XPath("//label[@for='sort-time']")).Click();
            System.Threading.Thread.Sleep(2000);
            var AfterSort = chromeDriver.FindElements(By.XPath("//a[@class='search-result__item-apply']"))[0].GetAttribute("href");
            System.Threading.Thread.Sleep(2000);
            Assert.IsTrue(BeforeSort != AfterSort, "Something went wrong...");
        }
        
        [Then(@"I should be redirected to Ukrainian region English web-page")]
        public void ThenIShouldBeRedirectedToUkrainianRegionEnglishWeb_Page()
        {
            System.Threading.Thread.Sleep(2000);
            Assert.IsTrue(chromeDriver.Url.ToLower().Contains("ua"), "Something went wrong...");
        }
        
        [Then(@"I should see all job offers related to ""(.*)""")]
        public void ThenIShouldSeeAllJobOffersRelatedTo(string searchrequest)
        {
            System.Threading.Thread.Sleep(2000);
            Assert.IsTrue(chromeDriver.Url.ToLower().Contains(searchrequest.ToLower()), "Something went wrong...");
        }
        
        [Then(@"I should see the page with the job description, candidate'sa responsibilities,requirements,what company offers on the right and an application form on the left")]
        public void ThenIShouldSeeThePageWithTheJobDescriptionCandidateSaResponsibilitiesRequirementsWhatCompanyOffersOnTheRightAndAnApplicationFormOnTheLeft()
        {
            System.Threading.Thread.Sleep(2000);
            Assert.IsTrue(chromeDriver.Url.ToLower().Contains("job-detail"),"Something went wrong...");
        }
        
        [Then(@"My browser should open new tab with google maps")]
        public void ThenMyBrowserShouldOpenNewTabWithGoogleMaps()
        {
            System.Threading.Thread.Sleep(2000);
            List<String> tabs = new List<String>(chromeDriver.WindowHandles);
            Assert.IsTrue(tabs.Count > 1, "Something went wrong...");
        }
        
        [Then(@"mark the adress of office in Minsk")]
        public void ThenMarkTheAdressOfOfficeInMinsk()
        {
            List<String> tabs = new List<String>(chromeDriver.WindowHandles);
            Assert.IsTrue(tabs.Count > 1, "Something went wrong...");
        }
        
        [Then(@"Browser should redirect me to the EPAM Instagram web page in new tab")]
        public void ThenBrowserShouldRedirectMeToTheEPAMInstagramWebPageInNewTab()
        {
            List<String> tabs = new List<String>(chromeDriver.WindowHandles);
            Assert.IsTrue(tabs.Count > 1, "Something went wrong...");
        }
        
        [Then(@"I should see all results of search related to the ""(.*)""")]
        public void ThenIShouldSeeAllResultsOfSearchRelatedToThe(string searchrequest)
        {
            Assert.IsTrue(chromeDriver.Url.ToLower().Contains(searchrequest.ToLower()), "Something went wrong...");
        }
        
        [Then(@"browser should onload new page with a contact form")]
        public void ThenBrowserShouldOnloadNewPageWithAContactForm()
        {
            Assert.IsTrue(chromeDriver.Url.ToLower().Contains("#request"), "Something went wrong...");
        }
        
        [Then(@"cursore form should change into hand with pointing finger to show user that this text is clickable")]
        public void ThenCursoreFormShouldChangeIntoHandWithPointingFingerToShowUserThatThisTextIsClickable()
        {

            Assert.IsTrue(chromeDriver.Url.ToLower().Contains("sort=time"), "Something went wrong...");
        }
        
        public void Dispose()
        {
            if(chromeDriver != null)
            {
                chromeDriver.Dispose();
                chromeDriver = null;
            }
        }
    }
}

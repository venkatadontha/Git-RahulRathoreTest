using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Laxmi.TestAutomation.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using Laxmi.TestAutomation.AutomationTests.PageObjects;
using TestWebSiteTests.PageObjects;
using SpecFlow.Assist.Dynamic;
using TechTalk.SpecFlow.Assist;
using TestWebSiteTests.POCOs;

namespace TestWebSiteTests
{
    [Binding]
    public sealed class BookingStepDefinition : BaseTest
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly ScenarioContext context;

        public BookingStepDefinition(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }
      
        [Given(@"I am on the TestWebsite Homepage")]
        public void GivenIAmOnTheTestWebsiteHomepage()
        {
            HomePage homePage = new HomePage(Driver);
            if (!homePage.IsAt())
                NavigateBackToIndexPage();

            Assert.IsTrue(homePage.IsAt());
            context.Add("HomePage", homePage);
        }


        [When(@"I  choose one Item on the Grid of Items")]
        public void WhenIChooseOneItemOnTheGridOfItems()
        {
            HomePage homePage;
            if (!context.ContainsKey("HomePage"))
            {
                homePage = new HomePage(Driver);
            }
            else
            {
                homePage = context.Get<HomePage>("HomePage");
            }
            homePage.ChooseGridItem();
        }



        [When(@"I am on Items Details Page and click add to cart")]
        public void WhenIAmOnItemsDetailsPageAndClickAddToCart()
        {
            ItemDetailsPage itemDetailsPage;

            if (!context.ContainsKey("ItemDetailsPage"))
                itemDetailsPage = new ItemDetailsPage(Driver);
            else
                itemDetailsPage = context.Get<ItemDetailsPage>("ItemDetailsPage");

            itemDetailsPage.ClickOnAddToCart();
            itemDetailsPage.ClickOnProceedToCheckOut();
        }

        [When(@"I choose Item size of the following")]
        public void WhenIChooseItemSizeOfTheFollowing(Table table)
        {
            ItemDetailsPage itemDetailsPage = context.Get<ItemDetailsPage>("ItemDetailsPage");
            dynamic itemSize = table.CreateDynamicInstance();
            itemDetailsPage.SelectItemBySize(itemSize.ItemSize);
        }


        [When(@"I am on Items Details Page")]
        public void WhenIAmItemsDetailsPage()
        {
            ItemDetailsPage itemDetailsPage = new ItemDetailsPage(Driver);
            context.Add("ItemDetailsPage", itemDetailsPage);
            
        }

        [When(@"I select the same item with different color")]
        public void WhenISelectTheSameItemWithDifferentColor()
        {
            ItemDetailsPage itemDetailsPage = context.Get<ItemDetailsPage>("ItemDetailsPage");
            string colorBeforeSelection=itemDetailsPage.GetColorOfSelectedItem();
            itemDetailsPage.chooseAnotherItemColor();
            string colorAfterSelection = itemDetailsPage.GetColorOfSelectedItem();
            Assert.IsFalse(colorBeforeSelection == colorAfterSelection, "checking color of a new selected Item");

        }


        [Then(@"I should see Item is available in ""(.*)"" colors")]
        public void ThenIShouldSeeItemIsAvailableInColors(int p0)
        {
           ItemDetailsPage itemDetailsPage= context.Get<ItemDetailsPage>("ItemDetailsPage");
            Assert.IsTrue(itemDetailsPage.GetColorsCount() == p0,"checking colors availability count");
        }


        [When(@"I click on proceed to Next on Summary Details Page")]
        public void WhenIClickOnProceedToNextOnSummaryDetailsPage()
        {
            SummaryPage summaryPage = new SummaryPage(Driver);
            summaryPage.ProceedToCheckOut();

        }

        [When(@"I create an account by setting an email")]
        public void WhenICreateAnAccountBySettingAnEmail(Table table)
        {
            SignInPage signInPage = new SignInPage(Driver);
            //signInPage.SetEmailAndClickOnCreateAccount();
            dynamic email = table.CreateDynamicInstance();
            signInPage.SetEmailAndClickOnCreateAccount(email.Email, email.Suffix);

        }

        [When(@"I Fill PersonalDetails with the following")]
        public void WhenIFillPersonalDetailsWithTheFollowing(Table table)
        {
            Assert.IsTrue(table.Rows.Count > 0, "Table rows check");
            PersonalDetailsVO personalDetailsVO= table.CreateInstance<PersonalDetailsVO>();

            PersonDetailsPage personDetailsPage = new PersonDetailsPage(Driver);
            personDetailsPage.SetUpPersonalDetails(personalDetailsVO);

        }

        [When(@"I Fill PersonalDetails")]
        public void WhenIFillPersonalDetails()
        {
            PersonDetailsPage personDetailsPage = new PersonDetailsPage(Driver);
            personDetailsPage.SetUpPersonalDetails();
        }

        [When(@"I choose Address and proceed next")]
        public void WhenIChooseAddressAndProceedNext()
        {
            AddressPage addressPage = new AddressPage(Driver);
            addressPage.ProcessAddress();
        }

        [When(@"I process shipping")]
        public void WhenIProcessShipping()
        {
            ShippingPage shippingPage = new ShippingPage(Driver);
            shippingPage.ProcessShipping();
        }

        [When(@"I process the payment by wire")]
        public void WhenIProcessThePaymentByWire()
        {
            PaymentPage paymentPage = new PaymentPage(Driver);
            context.Add("AccountCreationMessage", paymentPage.PaymentByWire());
        }

        [Then(@"Verify that booking has completed successfully")]
        public void ThenVerifyThatBookingHasCompletedSuccessfully()
        {
            string accountCreationMessage = context.Get<string>("AccountCreationMessage");
            Assert.IsTrue("Your order on My Store is complete." == accountCreationMessage);
        }

        [Then(@"I Logout the application")]
        public void ThenILogoutTheApplication()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.SignOut();

        }

        [Then(@"User gets logged out\.")]
        public void ThenUserGetsLoggedOut()
        {
            Assert.IsTrue(new SignInPage(Driver).IsAt());
        }


    }
}

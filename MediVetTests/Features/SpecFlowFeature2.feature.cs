// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TestWebSiteTests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class VerifyBookingAnItemShoppingCartFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "SpecFlowFeature2.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Verify Booking an Item,ShoppingCart", "\tIn order to Book an item on the testwebsite\r\n\tAs a guest user\r\n\tI should be havi" +
                    "ng right navigations to purchase an item and finish the check out.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Verify Booking an Item,ShoppingCart")))
            {
                global::TestWebSiteTests.Features.VerifyBookingAnItemShoppingCartFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(_testContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Verify purchase an item via new account creation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Verify Booking an Item,ShoppingCart")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Smoke,@Regression")]
        public virtual void VerifyPurchaseAnItemViaNewAccountCreation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify purchase an item via new account creation", null, new string[] {
                        "Smoke,@Regression"});
#line 7
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 testRunner.Given("I am on the TestWebsite Homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When("I  choose one Item on the Grid of Items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.And("I am on Items Details Page and click add to cart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And("I click on proceed to Next on Summary Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Suffix"});
            table1.AddRow(new string[] {
                        "LaxmiSwamy",
                        "Auto"});
#line 12
 testRunner.And("I create an account by setting an email", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "LastName",
                        "Password",
                        "DOB",
                        "Company",
                        "Address1",
                        "Address2",
                        "City",
                        "State",
                        "PostCode",
                        "PhoneNumber",
                        "Alias"});
            table2.AddRow(new string[] {
                        "Laxmi",
                        "Swamy",
                        "LaxmiSwamy",
                        "1#01#1978",
                        "Laxmi",
                        "2 Tyberton Place",
                        "Address2",
                        "Reading",
                        "Alabama",
                        "12345",
                        "00447511207789",
                        "LaxmiSwamy"});
#line 15
 testRunner.And("I Fill PersonalDetails with the following", ((string)(null)), table2, "And ");
#line 18
 testRunner.And("I choose Address and proceed next", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.And("I process shipping", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.And("I process the payment by wire", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.Then("Verify that booking has completed successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
 testRunner.And("I Logout the application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.Then("User gets logged out.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void BookAnItemWithMultipleDatasetsViaNewAccountCreation(string firstName, string lastName, string password, string dOB, string company, string address1, string address2, string city, string state, string postCode, string phoneNumber, string alias, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Regression"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Book an Item with multiple Datasets via new account creation", null, @__tags);
#line 26
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 27
 testRunner.Given("I am on the TestWebsite Homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
 testRunner.When("I  choose one Item on the Grid of Items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.And("I am on Items Details Page and click add to cart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.And("I click on proceed to Next on Summary Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Suffix"});
            table3.AddRow(new string[] {
                        "DataDrivn",
                        "Auto"});
#line 31
 testRunner.And("I create an account by setting an email", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "LastName",
                        "Password",
                        "DOB",
                        "Company",
                        "Address1",
                        "Address2",
                        "City",
                        "State",
                        "PostCode",
                        "PhoneNumber",
                        "Alias"});
            table4.AddRow(new string[] {
                        string.Format("{0}", firstName),
                        string.Format("{0}", lastName),
                        string.Format("{0}", password),
                        string.Format("{0}", dOB),
                        string.Format("{0}", company),
                        string.Format("{0}", address1),
                        string.Format("{0}", address2),
                        string.Format("{0}", city),
                        string.Format("{0}", state),
                        string.Format("{0}", postCode),
                        string.Format("{0}", phoneNumber),
                        string.Format("{0}", alias)});
#line 34
 testRunner.And("I Fill PersonalDetails with the following", ((string)(null)), table4, "And ");
#line 37
 testRunner.And("I choose Address and proceed next", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And("I process shipping", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.And("I process the payment by wire", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.Then("Verify that booking has completed successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 41
 testRunner.And("I Logout the application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.Then("User gets logged out.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Book an Item with multiple Datasets via new account creation: Variant 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Verify Booking an Item,ShoppingCart")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Regression")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:FirstName", "Laxmi")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:LastName", "Swamy")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Password", "LaxmiSwamy")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DOB", "1#01#1978")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Company", "LaxmiC1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Address1", "1 Tyberton Place")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Address2", "Address21")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:City", "Reading")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:State", "Alabama")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PostCode", "12345")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PhoneNumber", "00447511207789")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Alias", "LaxmiSwamy1")]
        public virtual void BookAnItemWithMultipleDatasetsViaNewAccountCreation_Variant0()
        {
#line 26
this.BookAnItemWithMultipleDatasetsViaNewAccountCreation("Laxmi", "Swamy", "LaxmiSwamy", "1#01#1978", "LaxmiC1", "1 Tyberton Place", "Address21", "Reading", "Alabama", "12345", "00447511207789", "LaxmiSwamy1", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Book an Item with multiple Datasets via new account creation: Variant 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Verify Booking an Item,ShoppingCart")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Regression")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:FirstName", "Laxmi")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:LastName", "Masuram")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Password", "LaxmiSwamy")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DOB", "1#01#1978")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Company", "LaxmiC2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Address1", "2 Tyberton Place")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Address2", "Address22")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:City", "London")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:State", "Alabama")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PostCode", "12345")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PhoneNumber", "00441111111111")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Alias", "LaxmiSwamy2")]
        public virtual void BookAnItemWithMultipleDatasetsViaNewAccountCreation_Variant1()
        {
#line 26
this.BookAnItemWithMultipleDatasetsViaNewAccountCreation("Laxmi", "Masuram", "LaxmiSwamy", "1#01#1978", "LaxmiC2", "2 Tyberton Place", "Address22", "London", "Alabama", "12345", "00441111111111", "LaxmiSwamy2", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Book an Item with multiple Datasets via new account creation: Variant 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Verify Booking an Item,ShoppingCart")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Regression")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:FirstName", "Laxmi")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:LastName", "Narsimha")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Password", "LaxmiSwamy")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DOB", "1#01#1978")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Company", "LaxmiC3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Address1", "3 Tyberton Place")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Address2", "Address23")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:City", "BirmingHam")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:State", "Alabama")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PostCode", "12345")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PhoneNumber", "00441111111112")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Alias", "LaxmiSwamy3")]
        public virtual void BookAnItemWithMultipleDatasetsViaNewAccountCreation_Variant2()
        {
#line 26
this.BookAnItemWithMultipleDatasetsViaNewAccountCreation("Laxmi", "Narsimha", "LaxmiSwamy", "1#01#1978", "LaxmiC3", "3 Tyberton Place", "Address23", "BirmingHam", "Alabama", "12345", "00441111111112", "LaxmiSwamy3", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Book an Item with multiple Datasets via new account creation: Variant 3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Verify Booking an Item,ShoppingCart")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Regression")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:FirstName", "Narsimha")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:LastName", "Swamy")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Password", "LaxmiSwamy")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DOB", "1#01#1978")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Company", "LaxmiC4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Address1", "4 Tyberton Place")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Address2", "Address24")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:City", "Slough")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:State", "Alabama")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PostCode", "12345")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PhoneNumber", "00441111111114")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Alias", "LaxmiSwamy4")]
        public virtual void BookAnItemWithMultipleDatasetsViaNewAccountCreation_Variant3()
        {
#line 26
this.BookAnItemWithMultipleDatasetsViaNewAccountCreation("Narsimha", "Swamy", "LaxmiSwamy", "1#01#1978", "LaxmiC4", "4 Tyberton Place", "Address24", "Slough", "Alabama", "12345", "00441111111114", "LaxmiSwamy4", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Verify colors available on ItemDetails for FadedShortSleeve")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Verify Booking an Item,ShoppingCart")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Regression")]
        public virtual void VerifyColorsAvailableOnItemDetailsForFadedShortSleeve()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify colors available on ItemDetails for FadedShortSleeve", null, new string[] {
                        "Regression"});
#line 52
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 53
 testRunner.Given("I am on the TestWebsite Homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 54
 testRunner.When("I  choose one Item on the Grid of Items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
 testRunner.And("I am on Items Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
 testRunner.Then("I should see Item is available in \"2\" colors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Choose Different colors  on ItemDetails for FadedShortSleeve before you purchase")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Verify Booking an Item,ShoppingCart")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Regression")]
        public virtual void ChooseDifferentColorsOnItemDetailsForFadedShortSleeveBeforeYouPurchase()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Choose Different colors  on ItemDetails for FadedShortSleeve before you purchase", null, new string[] {
                        "Regression"});
#line 59
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 60
 testRunner.Given("I am on the TestWebsite Homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 61
 testRunner.When("I  choose one Item on the Grid of Items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 62
 testRunner.And("I am on Items Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
 testRunner.And("I select the same item with different color", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.When("I am on Items Details Page and click add to cart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 65
 testRunner.And("I click on proceed to Next on Summary Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Suffix"});
            table5.AddRow(new string[] {
                        "LaxmiSwamy",
                        "Auto"});
#line 66
 testRunner.And("I create an account by setting an email", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "LastName",
                        "Password",
                        "DOB",
                        "Company",
                        "Address1",
                        "Address2",
                        "City",
                        "State",
                        "PostCode",
                        "PhoneNumber",
                        "Alias"});
            table6.AddRow(new string[] {
                        "Laxmi",
                        "Swamy",
                        "LaxmiSwamy",
                        "1#01#1978",
                        "Laxmi",
                        "2 Tyberton Place",
                        "Address2",
                        "Reading",
                        "Alabama",
                        "12345",
                        "00447511207789",
                        "LaxmiSwamy"});
#line 69
 testRunner.And("I Fill PersonalDetails with the following", ((string)(null)), table6, "And ");
#line 72
 testRunner.And("I choose Address and proceed next", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.And("I process shipping", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
 testRunner.And("I process the payment by wire", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
 testRunner.Then("Verify that booking has completed successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 76
 testRunner.And("I Logout the application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
 testRunner.Then("User gets logged out.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Choose different Size of an Item before finish booking")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Verify Booking an Item,ShoppingCart")]
        public virtual void ChooseDifferentSizeOfAnItemBeforeFinishBooking()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Choose different Size of an Item before finish booking", null, ((string[])(null)));
#line 80
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 81
 testRunner.Given("I am on the TestWebsite Homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 82
 testRunner.When("I  choose one Item on the Grid of Items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 83
 testRunner.And("I am on Items Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemSize"});
            table7.AddRow(new string[] {
                        "S"});
#line 84
 testRunner.And("I choose Item size of the following", ((string)(null)), table7, "And ");
#line 87
 testRunner.When("I am on Items Details Page and click add to cart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 88
 testRunner.And("I click on proceed to Next on Summary Details Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Suffix"});
            table8.AddRow(new string[] {
                        "LaxmiSwamy",
                        "Auto"});
#line 89
 testRunner.And("I create an account by setting an email", ((string)(null)), table8, "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "LastName",
                        "Password",
                        "DOB",
                        "Company",
                        "Address1",
                        "Address2",
                        "City",
                        "State",
                        "PostCode",
                        "PhoneNumber",
                        "Alias"});
            table9.AddRow(new string[] {
                        "Laxmi",
                        "Swamy",
                        "LaxmiSwamy",
                        "1#01#1978",
                        "Laxmi",
                        "2 Tyberton Place",
                        "Address2",
                        "Reading",
                        "Alabama",
                        "12345",
                        "00447511207789",
                        "LaxmiSwamy"});
#line 92
 testRunner.And("I Fill PersonalDetails with the following", ((string)(null)), table9, "And ");
#line 95
 testRunner.And("I choose Address and proceed next", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
 testRunner.And("I process shipping", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
 testRunner.And("I process the payment by wire", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
 testRunner.Then("Verify that booking has completed successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 99
 testRunner.And("I Logout the application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
 testRunner.Then("User gets logged out.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

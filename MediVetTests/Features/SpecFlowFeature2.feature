Feature: Verify Booking an Item,ShoppingCart
	In order to Book an item on the testwebsite
	As a guest user
	I should be having right navigations to purchase an item and finish the check out.

@Smoke,@Regression
Scenario: Verify purchase an item via new account creation
	Given I am on the TestWebsite Homepage
	When I  choose one Item on the Grid of Items
	And I am on Items Details Page and click add to cart
	And I click on proceed to Next on Summary Details Page
	And I create an account by setting an email
	| Email      | Suffix |
	| LaxmiSwamy | Auto   |
	And I Fill PersonalDetails with the following
	| FirstName | LastName | Password   | DOB       | Company | Address1         | Address2 | City    | State   | PostCode | PhoneNumber    | Alias      |
	| Laxmi     | Swamy    | LaxmiSwamy | 1#01#1978 | Laxmi   | 2 Tyberton Place | Address2 | Reading | Alabama | 12345    | 00447511207789 | LaxmiSwamy |
	And I choose Address and proceed next
	And I process shipping
	And I process the payment by wire
	Then Verify that booking has completed successfully
	And I Logout the application
	Then User gets logged out.

@Regression
Scenario Outline: Book an Item with multiple Datasets via new account creation
	Given I am on the TestWebsite Homepage
	When I  choose one Item on the Grid of Items
	And I am on Items Details Page and click add to cart
	And I click on proceed to Next on Summary Details Page
	And I create an account by setting an email
	| Email      | Suffix |
	| DataDrivn | Auto   |
	And I Fill PersonalDetails with the following
	| FirstName | LastName | Password   | DOB       | Company | Address1         | Address2 | City    | State   | PostCode | PhoneNumber    | Alias      |
	| <FirstName> | <LastName >| <Password>   | <DOB>       | <Company> | <Address1>         | <Address2> | <City>    | <State>   | <PostCode> | <PhoneNumber>    | <Alias>      |
	And I choose Address and proceed next
	And I process shipping
	And I process the payment by wire
	Then Verify that booking has completed successfully
	And I Logout the application
	Then User gets logged out.

Examples: 
	| FirstName | LastName | Password   | DOB       | Company | Address1         | Address2  | City       | State   | PostCode | PhoneNumber    | Alias      |
	| Laxmi     | Swamy    | LaxmiSwamy | 1#01#1978 | LaxmiC1 | 1 Tyberton Place | Address21 | Reading    | Alabama | 12345    | 00447511207789 | LaxmiSwamy1 |
	| Laxmi     | Masuram  | LaxmiSwamy | 1#01#1978 | LaxmiC2 | 2 Tyberton Place | Address22 | London     | Alabama | 12345    | 00441111111111 | LaxmiSwamy2 |
	| Laxmi     | Narsimha | LaxmiSwamy | 1#01#1978 | LaxmiC3 | 3 Tyberton Place | Address23 | BirmingHam | Alabama | 12345    | 00441111111112 | LaxmiSwamy3 |
	| Narsimha  | Swamy    | LaxmiSwamy | 1#01#1978 | LaxmiC4 | 4 Tyberton Place | Address24 | Slough     | Alabama | 12345    | 00441111111114 | LaxmiSwamy4 |

@Regression
Scenario: Verify colors available on ItemDetails for FadedShortSleeve
	Given I am on the TestWebsite Homepage
	When I  choose one Item on the Grid of Items
	And I am on Items Details Page
	Then I should see Item is available in "2" colors

@Regression
Scenario: Choose Different colors  on ItemDetails for FadedShortSleeve before you purchase
	Given I am on the TestWebsite Homepage
	When I  choose one Item on the Grid of Items
	And I am on Items Details Page
	And I select the same item with different color
	When I am on Items Details Page and click add to cart
	And I click on proceed to Next on Summary Details Page
	And I create an account by setting an email
	| Email      | Suffix |
	| LaxmiSwamy | Auto   |
	And I Fill PersonalDetails with the following
	| FirstName | LastName | Password   | DOB       | Company | Address1         | Address2 | City    | State   | PostCode | PhoneNumber    | Alias      |
	| Laxmi     | Swamy    | LaxmiSwamy | 1#01#1978 | Laxmi   | 2 Tyberton Place | Address2 | Reading | Alabama | 12345    | 00447511207789 | LaxmiSwamy |
	And I choose Address and proceed next
	And I process shipping
	And I process the payment by wire
	Then Verify that booking has completed successfully
	And I Logout the application
	Then User gets logged out.

	
Scenario: Choose different Size of an Item before finish booking
	Given I am on the TestWebsite Homepage
	When I  choose one Item on the Grid of Items
	And I am on Items Details Page
	And I choose Item size of the following
	| ItemSize |
	| S        |
	When I am on Items Details Page and click add to cart
	And I click on proceed to Next on Summary Details Page
	And I create an account by setting an email
	| Email      | Suffix |
	| LaxmiSwamy | Auto   |
	And I Fill PersonalDetails with the following
	| FirstName | LastName | Password   | DOB       | Company | Address1         | Address2 | City    | State   | PostCode | PhoneNumber    | Alias      |
	| Laxmi     | Swamy    | LaxmiSwamy | 1#01#1978 | Laxmi   | 2 Tyberton Place | Address2 | Reading | Alabama | 12345    | 00447511207789 | LaxmiSwamy |
	And I choose Address and proceed next
	And I process shipping
	And I process the payment by wire
	Then Verify that booking has completed successfully
	And I Logout the application
	Then User gets logged out.
What is covered?

Technology stack: csharp, BDD Gherkin, Specflow

tests/scenarios:

1.scenrio given happy path 
2.Color of the Item changing on ItemDetails page before purchase
3.Choosing AnySize for an item before purchase
4.count the colors available for an Item
we can add many more scenarios, Booking , shopping carts, price calculation , content check headers , footers etc.. But just stopping here by assuming tests are  to show my ability to write script 

Features:

Framework with POM is in place
reportinng is in place
Data Driver test is in place
BDD tests with specflow is in place


Technical improvements
1. DOB is not parsed, can do it later as it has got spaces, nothing to worry in creation
2. Used Thread.sleep in some places to force the script not to fail
	Dynamic waits can be used WaitUntil or loading of element based on other attributes , will add utility later. wait until is used once in the script and this has to be repeated to avoid static waits
3.Item Details page -update can be taken care by single update through a specflow table -quantity, color,size. 
4. all pages are not implemented isAt() .. 2 pages are done as a sample to show.
5. 


what Technical aspects covered?
OOps, specflow features,Gherkin Syntaxes
Inheritance
override methods
Context Injection
specflow Table data parsing assist dynamic 
Used valueobjects to bind the data and passover
Hooks
Reporting
Make use of nuget package
MSbuild Code generation ,version conflicts with specflow errors



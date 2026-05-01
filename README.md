# Playwright_BDDSpecFlow
-------------------------
This is sample HRM UI automation framework. This framework is based on C#, SpecFlow, Playwright, and various other modern concepts. This project supports parallel execution, cross-browser testing, and functional testing. The framework is designed to automate testing for web applications and provides a robust structure for managing tests efficiently.
Created with lessons learned from a large number of development projects to provide all commonly required components and concepts.

Concepts Included
-----------------
• Cucumber structure (SpecFlow):- better test management 

• Parallel test runs :- Playwright runs the test parallelly itself. 

• Cross Browser tests:- Tests can run on multiple browsers (e.g., Chrome, Firefox, Edge) using Playwright.

• Execution Mode :- User can decide to run the test on Headed or Headless Mode.

• Page Object pattern :- Improves test maintainability and readability by separating page-specific logic from test steps.

• Video Recording :- Capture Video of each test execution for evidence purpose. 

Tools
------
•	SpecFlow: For BDD and managing feature files.

•	Playwright: For browser automation and cross-browser testing.

•	.NET 8: The framework is built on the latest .NET platform for modern development practices.

Usage
-------
1.	Clone the Project:	Clone the repository into your IDE.
   
2.	Restore Dependencies:Restore NuGet packages by running:  dotnet restore
   
3.	Run Tests: dotnet test
   
Note: I have cofigure 2 Jenkins Job locally to run the Test scripts

Reporting
----------
Yet to done.

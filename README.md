# BusCompany Price Calculator Specs

This project focuses on behavior-driven testing of a bus ticket price calculator.  
The production class `PriceCalculator.cs` was provided by the teacher, while I implemented the specification and test automation around it through:

- `PriceCalculator.feature`
- `PriceCalculatorStepDefinitions.cs`

The calculator determines bus prices based on travel distance and distance-based fees. It also rejects invalid negative distances.

## What I worked on

My contribution in this project was to describe and automate the expected behavior of the price calculator using BDD.

I created:

- a **Gherkin feature file** that describes the expected system behavior in readable scenarios
- **step definitions in C#** that connect the Gherkin steps to executable automated tests
- scenarios for both **valid inputs** and **invalid input handling**

## Topics covered

This project covers several important software testing concepts:

- **Behavior-Driven Development (BDD)**  
  The system behavior is described from the outside using readable scenarios.

- **Gherkin syntax**  
  The scenarios are written using `Feature`, `Scenario`, `Scenario Outline`, `Given`, `When`, and `Then`.

- **Reqnroll**  
  Reqnroll is the .NET tool used to execute the Gherkin scenarios.

- **Cucumber-style testing**  
  The project follows the Cucumber/BDD style of writing executable specifications. In .NET, this is implemented with Reqnroll.

- **Data-driven testing**  
  The `Scenario Outline` with an `Examples` table is used to test multiple valid distances and expected prices using the same scenario structure.

- **Exception and validation testing**  
  The project verifies that negative distances are rejected correctly.



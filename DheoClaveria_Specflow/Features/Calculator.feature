Feature: Calculator
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

    @mytag
    Scenario: Add two numbers
        Given the first number is 50
        And the second number is 70
        And I enter the following number:
          | number | digits |
          | one    | 1      |
          | two    | 2      |
          | three  | 3      |
        When the two numbers are added
        Then the result should be 120
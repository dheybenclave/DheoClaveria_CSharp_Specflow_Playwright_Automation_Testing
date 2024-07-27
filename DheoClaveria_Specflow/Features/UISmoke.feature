Feature: UISmoke Testing for Users

    @UISmoke @testing1
    Scenario Outline: Validate and Verify the user details
        Given I enter user details <FirstName> <LastName> <Email> <Phone> 
        Given I navigate to application
        And Login in the Application as Customer
        Examples:
          | FirstName   | LastName | Email                  | Phone     |
          | Dheo        | Claveria | dheybenclave@gmail.com | 123123132 |
          | Shara Mariz | Natalio  | testing@gmail.com      | 987654321 |
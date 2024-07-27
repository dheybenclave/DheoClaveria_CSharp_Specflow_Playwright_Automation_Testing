using System.Net.Mail;
using AutoFixture;
using DheoClaveria_Specflow.Utils;
using NUnit.Framework.Internal;

namespace DheoClaveria_Specflow;

[Binding]
public class UserCredentialsSteps
{
    [Given(@"I enter user details (.*) (.*) (.*) (.*)")]
    public void enterUserCredentails(String fName, String lName, String email, int phone)
    {
        Console.WriteLine($"User Details passed by Scenario Outline Examples {fName} {lName} {email} {phone} ");

        var randUserDetails = new Fixture().Create<UserDetails>(); //create randomUserDetails
        List<UserDetails> userDetails = new List<UserDetails>()
        {
            new UserDetails(fName, lName, email, phone),
            new UserDetails(randUserDetails.FirstName, randUserDetails.LastName, randUserDetails.Email + "@gmail.com", randUserDetails.Phone),
    
        };
        var filteredResultsTwo = userDetails.Where(employee => employee.FirstName == "Dheo");

        foreach (var userDetail in userDetails)
        {
            Console.WriteLine($"User Details - " +
                              $"Full Name : {userDetail.FirstName} {userDetail.LastName} | \n" +
                              $"Email : {userDetail.Email} | \n" +
                              $"Phone : {userDetail.Phone} | \n");
        }
    }
}
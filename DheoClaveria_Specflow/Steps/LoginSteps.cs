using DheoClaveria_Specflow.Drivers;
using DheoClaveria_Specflow.Pages.Login;

namespace DheoClaveria_Specflow.Steps;

[Binding]
public sealed class LoginSteps
{
    private readonly Driver _driver;
    private readonly LoginPage _loginPage;
    private string _userName, _password = null!;

    public LoginSteps(Driver driver)
    {
        _driver = driver;
        _loginPage = new LoginPage(_driver.Page);
    }

    [Given(@"I navigate to application")]
    public async Task GivenINavigateToApplication()
    {
        await _driver.Page.GotoAsync("https://accounts.amaysim.com.au/identity/login");
    }
    
    [Given(@"Login in the Application as (.*)")]
    public async Task LoginUser(String user)
    {
        switch (user.ToLower())
        {
            case "customer":
                _userName = "0466 134 574";
                _password = "AWqasde321";
                break;
            default:
                _userName = null;
                _password = null;
                break;
        }
       await Login(_userName, _password);
        
    }

    private async Task Login(string userName, string password)
    {
        await _loginPage._txtUserName.FillAsync(userName);
        await _loginPage._txtPassword.FillAsync(password);
        await _loginPage._btnLogin.ClickAsync();
    }

}
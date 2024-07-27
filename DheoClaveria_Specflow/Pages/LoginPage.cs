using DheoClaveria_Specflow.Pages.common;
using Microsoft.Playwright;

namespace DheoClaveria_Specflow.Pages.Login;

public class LoginPage : CommonPage
{
    private readonly IPage _page;
    public LoginPage(IPage page) => _page = page;
    public ILocator _txtUserName => _page.Locator("xpath='//input[@id='username']");
    public ILocator _txtPassword => _page.Locator("xpath='//input[@id='password']");
    public ILocator _btnLogin => _page.Locator("xpath=//button[text()='Login' and @data-disable-with='logging in']");
}
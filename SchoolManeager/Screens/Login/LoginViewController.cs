using SchoolManeager.Base;
using SchoolManeager.DataBase;
using SchoolManeager.Screens;

namespace SchoolManeager.Screens;

public class LoginViewController : BaseController
{
    public LoginState CheckLogin(string email, string password)
    {
        Users  users = new Users();
        var user = users.GetUser(email , password);
        if (user is not null)
        {
            return new LoginState(user);
        }else
        {
            return new LoginState("Email or Password is incorrect.");
        }
    }
}
using System;
using System.Net.Mail;
using SchoolManeager.Base;
using SchoolManeager.DataBase;
using SchoolManeager.Screens.Home;
using SchoolManeager.Utiltis.Validation;

namespace SchoolManeager.Screens;

public class LoginScreen : BaseScreen<LoginViewController> , ITopBar
{
    private string email;
    public override void InitUi(LoginViewController controller)
    {
        if (email == null)
        {
            try
            {
                email = GetInput("Enter your email address:");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Enter your email address:");
            }
        }
        else
        {
            Console.WriteLine("Enter your email address");
            Console.WriteLine(email);
        }
        var emailValid = new EmailValidation(email);
        var result1 = emailValid.IsValid();
        if (result1.value != null)
        {
            Console.WriteLine(result1.value);
            Console.ReadKey();
            email = null;
            RenderUI();
            return;
        }
        
        var password = GetInput("Enter your password:");
        
        var passwordValidationValid = new PasswordValidation(password);
        
        var result = passwordValidationValid.IsValid();
        if (result.value != null)
        {
            Console.WriteLine(result.value);
            Console.ReadKey();
            RenderUI();
            return;
        }

        var check = controller.CheckLogin(email, password);

        if (check.dto is not null)
        {
            var screen = new HomeScreen(check.dto);
            screen.Show(isRplace: true);
        }
        else
        {
            Console.WriteLine(check.Message);
            email = null;
            Console.ReadKey();
            RenderUI();
            return;
        }
        //Todo
    }
    public string GetTitleTopBar()
    {
        return "Login";
    }
}
using SchoolManeager.Base;

namespace SchoolManeager.Screens;

public class WellcomeScreen : BaseScreen<LoginViewController>
{
    public override void InitUi(LoginViewController controller)
    {
        Console.WriteLine("Welcome to School Maneager");
        Thread.Sleep(3000);
        Console.Clear();
        Console.WriteLine("Cheking Version 1.1.0");
        Thread.Sleep(4000);
        Console.Clear();

        GetOpeator();
        
        var input = Console.ReadLine();
        switch (input)
        {
            case "0" :
                break;
            case "1" : 
                Console.Clear();
                LoginScreen login = new LoginScreen();
                login.Show(isRplace: true);
                break;
        }
    }

    protected override void GetOpeator()
    {
        Console.WriteLine("0-exit");
        Console.WriteLine("1-LoginScreen");
    }
}
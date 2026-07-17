using SchoolManeager.Base;
using SchoolManeager.DataBase;

namespace SchoolManeager.Screens.Home;

public class HomeScreen : BaseScreen<HomeController>,ITopBar
{
    public HomeScreen(UserDto userDto)
    {
        controller.dto = userDto;
    }

    public override void InitUi(HomeController controller)
    {
        Console.WriteLine($"Welcome {controller.dto.FullName}");
    }

    public string GetTitleTopBar()
    {
        return "Home";
    }
}
using SchoolManeager.DataBase;

namespace SchoolManeager.Screens;

public class LoginState
{
    public string Message;

    public UserDto dto;

    public LoginState(string message)
    {
        Message = message;
    }

    public LoginState(UserDto dto)
    {
        this.dto = dto;
    }
}
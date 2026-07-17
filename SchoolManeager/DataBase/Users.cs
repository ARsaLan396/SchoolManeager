using System.Data.Common;

namespace SchoolManeager.DataBase;

public class Users
{
    private List<UserEntity> _users = new List<UserEntity>()
    {
        new UserEntity(1,"ghasem Baghery","asq1@123.com","asq1"),
        new UserEntity(2,"Zahra babie","asq12@123.com","asq12"),
        new UserEntity(3,"Mohammad Joshaghani","asq123@123.com","asq13"),
    };
    
    public UserDto? GetUser(string email , string password)
    {
        var entity = _users.FirstOrDefault(x => x.Email == email && x.Password == password);
        if (entity is not null)
        {
            return MapToUserDto(entity);
        }else
        {
            return null;
        }
    }
    UserDto MapToUserDto(UserEntity userEntity)
    {
        return new UserDto()
        {
            Id = userEntity.Id,
            Email = userEntity.Email,
            FullName = userEntity.FullName,
        };
    }
}
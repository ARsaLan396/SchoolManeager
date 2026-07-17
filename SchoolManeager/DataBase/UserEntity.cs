namespace SchoolManeager.DataBase;

public class UserEntity
{
    public UserEntity(int id, string fullName, string email, string password)
    {
        Id = id;
        FullName = fullName;
        Email = email;
        Password = password;
    }

    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}
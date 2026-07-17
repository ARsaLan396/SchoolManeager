namespace SchoolManeager.Utiltis.Validation;

public class PasswordValidation
{
    private string _password;

    public PasswordValidation(string password)
    {
        _password = password;
    }

    public PasswordValidationStaste IsValid()
    {
        if (_password.Length < 3)
        {
            return PasswordValidationStaste.Short;
        }
        
        if (!_password.Any(c => IsLetear(c)))
        {
            return PasswordValidationStaste.NoLeter;
        }

        if (!_password.Any(c => IsDigit(c)))
        {
            return PasswordValidationStaste.NoDigit;
        }

        return PasswordValidationStaste.ok;
    }

    private bool IsLetear(char c)
    {
        return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
    }

    private bool IsDigit(char c)
    {
        return (c >= '0' && c <= '9');
    }
}
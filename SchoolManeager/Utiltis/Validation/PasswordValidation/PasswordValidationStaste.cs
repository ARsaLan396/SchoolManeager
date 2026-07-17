namespace SchoolManeager.Utiltis.Validation;

public class PasswordValidationStaste
{
    public string value;

    private PasswordValidationStaste(string value)
    {
        this.value = value;
    }

    public static PasswordValidationStaste Short
    {
        get
        {
            return new PasswordValidationStaste("Password Is Shorter Than");
        }
    }
    
    public static PasswordValidationStaste NoLeter
    {
        get
        {
            return new PasswordValidationStaste("Password Must Be Leter");
        }
    }
    
    public static PasswordValidationStaste NoDigit
    {
        get
        {
            return new PasswordValidationStaste("Password Must Be Digit");
        }
    }
    
    public static PasswordValidationStaste ok
    {
        get
        {
            return new PasswordValidationStaste(null);
        }
    }
}
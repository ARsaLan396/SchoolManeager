namespace SchoolManeager.Utiltis.Validation;

public class EmailValidationState
{
    public string value;

    private EmailValidationState(string value)
    {
        this.value = value;
    }

    public static EmailValidationState Format
    {
        get
        {
            return new EmailValidationState("Please enter a valid email address.");
        }
    }
    
    public static EmailValidationState Emty
    {
        get
        {
            return new EmailValidationState("Please enter a Email address.");
        }
    }
    public static EmailValidationState Ok
    {
        get
        {
            return new EmailValidationState(null);
        }
    }
}
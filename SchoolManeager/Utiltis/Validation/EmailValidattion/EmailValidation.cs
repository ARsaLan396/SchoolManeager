using System.Net.Mail;

namespace SchoolManeager.Utiltis.Validation;

public class EmailValidation
{
    private string _email;

    public EmailValidation(string email)
    {
        _email = email;
    }

    public EmailValidationState IsValid ()
    {
        try
        {
            MailAddress mailAddress = new MailAddress(_email);
            return EmailValidationState.Ok;
        }
        catch (FormatException)
        {
            return EmailValidationState.Format;
        }
        catch (ArgumentException)
        {
            return EmailValidationState.Emty;
        }
    }
}
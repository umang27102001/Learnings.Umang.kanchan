using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace SOLID.Question
{
    /* QUESTION
     * Are we breaking SRP in LoginInterface class ?
     * Answer We are breaking SRP in LoginInterface class as we have given responsibilities like 
     * ValidateEmail and SendWelcomeEmail to the LoginInterface class which is not expected to be the 
     * behivor of this class so it breaks SRP.
     * The solution to this is given in SSol.cs file.
     */

    public class Customer
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class LoginInterface
    {
        private readonly SmtpClient smtpClient;
        public void Register(string email, string password)
        {
            if (!ValidateEmail(email))
            {
                throw new ValidationException("Please enter a valid email address");
            }

            var x = new Customer() { Email = email, Password = password };
            SendWelcomeEmail(new MailMessage("testsite@test.com", email) { Subject = "Thank you for creating an account" });
        }
        public virtual bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
        public void SendWelcomeEmail(MailMessage message)
        {
            smtpClient.Send(message);
        }
    }
}

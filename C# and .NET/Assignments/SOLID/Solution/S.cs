using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Solution
{
    /*Ans: We can solve the problem by separating the responsibilities EmailValidator and 
     * SendWelcomeEmail in separate classes.*/
    public class Customer
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class LoginInterface
    {
        public SendWelcome _SendWelcome;
        public EmailValidator _EmailValidator;
        public LoginInterface(SendWelcome sendWelcome, EmailValidator emailValidator)
        {
            _SendWelcome = sendWelcome;
            _EmailValidator = emailValidator;
        }
        public void Register(string email, string password)
        {
            if (!_EmailValidator.IsValid(email))
            {
                throw new ValidationException("Please enter a valid email address");
            }

            var x = new Customer() { Email = email, Password = password };
            _SendWelcome.SendWelcomeEmail(new MailMessage("testsite@test.com", email) { Subject = "Thank you for creating an account" });
        }
    }
    public class EmailValidator
    {
        public bool IsValid(string email)
        {
            return email.Contains("@");
        }
    }
    public class SendWelcome
    {
        private readonly SmtpClient smtpClient;
        public void SendWelcomeEmail(MailMessage message)
        {
            smtpClient.Send(message);
        }

    }
}

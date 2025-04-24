using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace D1Task01
{
    public interface IEmailValidator
    {
        bool ValidateEmail(string email);
    }
    public interface IEmailSender
    {
        void sendEmail(MailMessage message);
    }

    public class EmailValidator : IEmailValidator
    {
        public bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
    }

    //public interface IRegister
    //{
    //    void Register(string email, string password);
    //}
    public class EmailSender : IEmailSender
    {
        SmtpClient _smtpClient;
        public EmailSender(SmtpClient smtpClient)
        {
            _smtpClient = smtpClient;
        }
        public void sendEmail(MailMessage message)
        {
            _smtpClient.Send(message);
        }
    }

    //public class Register : IRegister
    //{
    //    public void Register(string email, string password)
    //    {
    //    }
    //}

    public class User
    {
        public string Email { get; }
        public string Password { get; }
        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
    public class UserService
    {
        private readonly IEmailValidator _emailValidator;
        private readonly IEmailSender _emailSender;
        public UserService(IEmailValidator emailValidator, IEmailSender emailSender)
        {
            _emailValidator = emailValidator;
            _emailSender = emailSender;
        }

        public void Register(string email, string password)
        {
            if (!_emailValidator.ValidateEmail(email))
                throw new ValidationException("Email is not an email");

            var user = new User(email, password);
            var message = new MailMessage("ahmed@gmail.com", email)
                { Subject = "Hello foo" };
            _emailSender.sendEmail(message);

        }
    }
}

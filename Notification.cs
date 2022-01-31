using System;

namespace DependencyInversion
{
    public class Notification
    {
        private Email _email;
        private Sms _sms;

        public Notification()
        {
            _email = new Email();
            _sms = new Sms();
        }

        public void SendNotification()
        {
            _email.SendEmail();
            _sms.SendSms();
        }
    }
    
    public class Email
    {
        public string ToAddress { get; set; }
        public string FromAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public void SendEmail()
        {
            //Send the email
        }
    }

    public class Sms
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }

        public void SendSms()
        {
            //Send the SMS
        }
    }
}
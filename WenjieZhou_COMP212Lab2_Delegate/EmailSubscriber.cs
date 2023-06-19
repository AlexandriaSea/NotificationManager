using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WenjieZhou_COMP212Lab2_Delegate
{
    public class EmailSubscriber
    {
        public string Email { get; set; }

        // Static list for storing email subscribers
        public static List<EmailSubscriber> emailSubscribers = new List<EmailSubscriber>();

        public EmailSubscriber(string email)
        {
            Email = email;
        }

        public void SubscribeViaEmail()
        {
            NotificationForm.messageDel += SendEmail;
        }

        public void UnsubscribeViaEmail()
        {
            NotificationForm.messageDel -= SendEmail;
        }

        public string SendEmail(string message)
        {
            return "Sent " + message + " to " + Email;
        }
    }
}

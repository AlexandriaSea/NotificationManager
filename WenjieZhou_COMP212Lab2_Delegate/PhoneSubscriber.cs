using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WenjieZhou_COMP212Lab2_Delegate
{
    public class PhoneSubscriber
    {
        public string Phone { get; set; }

        // Static list for storing phone subscribers
        public static List<PhoneSubscriber> phoneSubscribers = new List<PhoneSubscriber>();

        public PhoneSubscriber(string phone)
        {
            Phone = phone;
        }

        public void SubscribeViaPhone()
        {
            NotificationForm.messageDel += SendPhone;
        }

        public void UnsubscribeViaPhone()
        {
            NotificationForm.messageDel -= SendPhone;
        }

        public string SendPhone(string message)
        {
            return "Sent " + message + " to " + Phone;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WenjieZhou_COMP212Lab2_Delegate
{
    public partial class SubscriptionForm : Form
    {
        public SubscriptionForm()
        {
            InitializeComponent();
        }

        public event EventHandler buttonClicked;

        private void buttonSubscribe_Click(object sender, EventArgs e)
        {
            // Set phone input format and capture textbox strings
            string phoneFormat = @"^\d{3}-\d{3}-\d{4}$";
            string email = textBoxEmail.Text.Trim();
            string phone = textBoxSMS.Text.Trim();

            // Check if checkbox is selected
            if (checkBoxEmail.Checked)
            {
                if (!email.Contains("@"))
                {
                    labelEmail.ForeColor = Color.Red;
                    labelEmail.Text = "Invalid email address";
                }
                else
                {
                    // Search for email subscriber with same email address in the list
                    EmailSubscriber findSubscriber = EmailSubscriber.emailSubscribers.FirstOrDefault(s => s.Email == email);

                    if (findSubscriber == null)
                    {
                        // If null, create the subscriber object, add into the list, and subscribe delegate
                        EmailSubscriber subscriber = new EmailSubscriber(email);
                        EmailSubscriber.emailSubscribers.Add(subscriber);
                        subscriber.SubscribeViaEmail();
                        labelEmail.Text = "";
                    }
                    else
                    {
                        labelEmail.ForeColor = Color.Red;
                        labelEmail.Text = "Email already exists";
                    }
                }
            }

            // Check if checkbox is selected
            if (checkBoxSMS.Checked)
            {
                if (!Regex.IsMatch(phone, phoneFormat))
                {
                    labelSMS.ForeColor = Color.Red;
                    labelSMS.Text = "Invalid phone number";
                }
                else
                {
                    // Search for phone subscriber with same phone number in the list
                    PhoneSubscriber findSubscriber = PhoneSubscriber.phoneSubscribers.FirstOrDefault(s => s.Phone == phone);

                    if(findSubscriber == null)
                    {
                        // If null, create the subscriber object, add into the list, and subscribe delegate
                        PhoneSubscriber subscriber = new PhoneSubscriber(phone);
                        PhoneSubscriber.phoneSubscribers.Add(subscriber);
                        subscriber.SubscribeViaPhone();
                        labelSMS.Text = "";
                    }
                    else
                    {
                        labelSMS.ForeColor = Color.Red;
                        labelSMS.Text = "Phone already exists";
                    }
                }
            }

            // Invoke EventHandler
            buttonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void buttonUnsubscribe_Click(object sender, EventArgs e)
        {
            // Set phone input format and capture textbox strings
            string phoneFormat = @"^\d{3}-\d{3}-\d{4}$";
            string email = textBoxEmail.Text.Trim();
            string phone = textBoxSMS.Text.Trim();

            // Check if checkbox is selected
            if (checkBoxEmail.Checked)
            {
                if (!email.Contains("@"))
                {
                    labelEmail.ForeColor = Color.Red;
                    labelEmail.Text = "Invalid email address";
                }
                else
                {
                    // Search for email subscriber with same email address in the list
                    EmailSubscriber findSubscriber = EmailSubscriber.emailSubscribers.FirstOrDefault(s => s.Email == email);

                    if (findSubscriber != null)
                    {
                        // If not null, remove the subscriber object from the list, and unsubscribe delegate
                        EmailSubscriber.emailSubscribers.Remove(findSubscriber);
                        findSubscriber.UnsubscribeViaEmail();
                        labelEmail.Text = "";
                    }
                    else
                    {
                        labelEmail.ForeColor = Color.Red;
                        labelEmail.Text = "Email does not exists";
                    }
                }
            }

            // Check if checkbox is selected
            if (checkBoxSMS.Checked)
            {
                if (!Regex.IsMatch(phone, phoneFormat))
                {
                    labelSMS.ForeColor = Color.Red;
                    labelSMS.Text = "Invalid phone number";
                }
                else
                {
                    // Search for phone subscriber with same phone number in the list
                    PhoneSubscriber findSubscriber = PhoneSubscriber.phoneSubscribers.FirstOrDefault(s => s.Phone == phone);

                    if (findSubscriber != null)
                    {
                        // If not null, remove the subscriber object from the list, and unsubscribe delegate
                        PhoneSubscriber.phoneSubscribers.Remove(findSubscriber);
                        findSubscriber.UnsubscribeViaPhone();
                        labelSMS.Text = "";
                    }
                    else
                    {
                        labelSMS.ForeColor = Color.Red;
                        labelSMS.Text = "Phone does not exists";
                    }
                }
            }

            // Invoke EventHandler
            buttonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

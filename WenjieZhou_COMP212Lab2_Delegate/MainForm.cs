using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WenjieZhou_COMP212Lab2_Delegate
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // Set the default button status of the static publish button to disabled at launch
            buttonPublish.Enabled = false;
        }

        private void buttonManage_Click(object sender, EventArgs e)
        {
            SubscriptionForm subscriptionForm = new SubscriptionForm();
            // Subscribe the method to EventHandler
            subscriptionForm.buttonClicked += this.handleButtonClicked;
            subscriptionForm.Show();
        }

        private void buttonPublish_Click(object sender, EventArgs e)
        {
            NotificationForm notificationForm = new NotificationForm();
            notificationForm.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void handleButtonClicked(object sender, EventArgs e)
        {
            buttonPublish.Enabled = (EmailSubscriber.emailSubscribers.Count > 0 || PhoneSubscriber.phoneSubscribers.Count > 0) ? true : false; 
        }
    }
}

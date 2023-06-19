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
        // Initialize the other two forms
        SubscriptionForm subscriptionForm = new SubscriptionForm();
        NotificationForm notificationForm = new NotificationForm();

        public MainForm()
        {
            InitializeComponent();

            // Set the default button status of the static publish button to disabled at launch
            buttonPublish.Enabled = false;
        }

        private void buttonManage_Click(object sender, EventArgs e)
        {
            subscriptionForm.Show();
        }

        private void buttonPublish_Click(object sender, EventArgs e)
        {
            notificationForm.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

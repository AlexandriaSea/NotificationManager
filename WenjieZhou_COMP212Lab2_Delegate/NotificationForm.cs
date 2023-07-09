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
    public partial class NotificationForm : Form
    {
        // Set up delegate and create a static delegate
        public delegate string MessageDel(string message);
        public static MessageDel messageDel = null;

        public NotificationForm()
        {
            InitializeComponent();
        }

        private void buttonPublish_Click(object sender, EventArgs e)
        {
            // Capture textbox string
            string content = textBoxNotification.Text;

            // create a list for storing strings from delegate methods
            List<string> list = new List<string>();

            // Invoke each method in the delegate using foreach loop and store those strings into the list
            foreach(MessageDel method in messageDel.GetInvocationList())
            {
                list.Add(method.Invoke(content));
            }

            // Initialuze a output form
            OutputForm outputForm = new OutputForm();

            // Set multiline textbox with text from the list
            outputForm.textBoxOutput.Text = string.Join(Environment.NewLine, list);

            outputForm.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

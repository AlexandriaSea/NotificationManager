namespace WenjieZhou_COMP212Lab2_Delegate
{
    partial class SubscriptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkBoxEmail = new CheckBox();
            checkBoxSMS = new CheckBox();
            textBoxEmail = new TextBox();
            textBoxSMS = new TextBox();
            labelEmail = new Label();
            labelSMS = new Label();
            buttonSubscribe = new Button();
            buttonUnsubscribe = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // checkBoxEmail
            // 
            checkBoxEmail.AutoSize = true;
            checkBoxEmail.Location = new Point(34, 59);
            checkBoxEmail.Name = "checkBoxEmail";
            checkBoxEmail.Size = new Size(163, 19);
            checkBoxEmail.TabIndex = 0;
            checkBoxEmail.Text = "Notification Sent by Email";
            checkBoxEmail.UseVisualStyleBackColor = true;
            // 
            // checkBoxSMS
            // 
            checkBoxSMS.AutoSize = true;
            checkBoxSMS.Location = new Point(34, 126);
            checkBoxSMS.Name = "checkBoxSMS";
            checkBoxSMS.Size = new Size(157, 19);
            checkBoxSMS.TabIndex = 1;
            checkBoxSMS.Text = "Notification Sent by SMS";
            checkBoxSMS.UseVisualStyleBackColor = true;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(252, 57);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "aaa@aaa.com";
            textBoxEmail.Size = new Size(240, 23);
            textBoxEmail.TabIndex = 2;
            // 
            // textBoxSMS
            // 
            textBoxSMS.Location = new Point(252, 124);
            textBoxSMS.Name = "textBoxSMS";
            textBoxSMS.PlaceholderText = "xxx-xxx-xxxx";
            textBoxSMS.Size = new Size(240, 23);
            textBoxSMS.TabIndex = 3;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(252, 95);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(0, 15);
            labelEmail.TabIndex = 4;
            // 
            // labelSMS
            // 
            labelSMS.AutoSize = true;
            labelSMS.Location = new Point(252, 163);
            labelSMS.Name = "labelSMS";
            labelSMS.Size = new Size(0, 15);
            labelSMS.TabIndex = 5;
            // 
            // buttonSubscribe
            // 
            buttonSubscribe.Location = new Point(52, 212);
            buttonSubscribe.Name = "buttonSubscribe";
            buttonSubscribe.Size = new Size(112, 41);
            buttonSubscribe.TabIndex = 6;
            buttonSubscribe.Text = "Subscribe";
            buttonSubscribe.UseVisualStyleBackColor = true;
            buttonSubscribe.Click += buttonSubscribe_Click;
            // 
            // buttonUnsubscribe
            // 
            buttonUnsubscribe.Location = new Point(220, 212);
            buttonUnsubscribe.Name = "buttonUnsubscribe";
            buttonUnsubscribe.Size = new Size(112, 41);
            buttonUnsubscribe.TabIndex = 7;
            buttonUnsubscribe.Text = "Unsubscribe";
            buttonUnsubscribe.UseVisualStyleBackColor = true;
            buttonUnsubscribe.Click += buttonUnsubscribe_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(380, 212);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 41);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // SubscriptionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 300);
            Controls.Add(buttonCancel);
            Controls.Add(buttonUnsubscribe);
            Controls.Add(buttonSubscribe);
            Controls.Add(labelSMS);
            Controls.Add(labelEmail);
            Controls.Add(textBoxSMS);
            Controls.Add(textBoxEmail);
            Controls.Add(checkBoxSMS);
            Controls.Add(checkBoxEmail);
            Name = "SubscriptionForm";
            Text = "Manage Subscription";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxEmail;
        private CheckBox checkBoxSMS;
        private TextBox textBoxEmail;
        private TextBox textBoxSMS;
        private Label labelEmail;
        private Label labelSMS;
        private Button buttonSubscribe;
        private Button buttonUnsubscribe;
        private Button buttonCancel;
    }
}
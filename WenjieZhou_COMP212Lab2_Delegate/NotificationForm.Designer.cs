namespace WenjieZhou_COMP212Lab2_Delegate
{
    partial class NotificationForm
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
            labelNotification = new Label();
            textBoxNotification = new TextBox();
            buttonPublish = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // labelNotification
            // 
            labelNotification.AutoSize = true;
            labelNotification.Location = new Point(35, 60);
            labelNotification.Name = "labelNotification";
            labelNotification.Size = new Size(116, 15);
            labelNotification.TabIndex = 0;
            labelNotification.Text = "Notification Content";
            // 
            // textBoxNotification
            // 
            textBoxNotification.Location = new Point(176, 57);
            textBoxNotification.Name = "textBoxNotification";
            textBoxNotification.Size = new Size(287, 23);
            textBoxNotification.TabIndex = 1;
            // 
            // buttonPublish
            // 
            buttonPublish.Location = new Point(84, 129);
            buttonPublish.Name = "buttonPublish";
            buttonPublish.Size = new Size(110, 35);
            buttonPublish.TabIndex = 2;
            buttonPublish.Text = "Publish";
            buttonPublish.UseVisualStyleBackColor = true;
            buttonPublish.Click += buttonPublish_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(273, 131);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(100, 33);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // NotificationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 200);
            Controls.Add(buttonExit);
            Controls.Add(buttonPublish);
            Controls.Add(textBoxNotification);
            Controls.Add(labelNotification);
            Name = "NotificationForm";
            Text = "Publish Notification";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNotification;
        private TextBox textBoxNotification;
        private Button buttonPublish;
        private Button buttonExit;
    }
}
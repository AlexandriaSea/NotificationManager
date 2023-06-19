namespace WenjieZhou_COMP212Lab2_Delegate
{
    partial class MainForm
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
            buttonManage = new Button();
            buttonPublish = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // buttonManage
            // 
            buttonManage.Location = new Point(23, 70);
            buttonManage.Name = "buttonManage";
            buttonManage.Size = new Size(139, 49);
            buttonManage.TabIndex = 0;
            buttonManage.Text = "Manage Subscription";
            buttonManage.UseVisualStyleBackColor = true;
            buttonManage.Click += buttonManage_Click;
            // 
            // buttonPublish
            // 
            buttonPublish.Location = new Point(182, 70);
            buttonPublish.Name = "buttonPublish";
            buttonPublish.Size = new Size(139, 49);
            buttonPublish.TabIndex = 1;
            buttonPublish.Text = "Publish Notification";
            buttonPublish.UseVisualStyleBackColor = true;
            buttonPublish.Click += buttonPublish_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(340, 70);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(139, 49);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 200);
            Controls.Add(buttonExit);
            Controls.Add(buttonPublish);
            Controls.Add(buttonManage);
            Name = "MainForm";
            Text = "Notification Manager";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonManage;
        public static Button buttonPublish;
        private Button buttonExit;
    }
}
namespace WenjieZhou_COMP212Lab2_Delegate
{
    partial class OutputForm
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
            textBoxOutput = new TextBox();
            SuspendLayout();
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(12, 12);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.Size = new Size(576, 576);
            textBoxOutput.TabIndex = 0;
            // 
            // OutputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 600);
            Controls.Add(textBoxOutput);
            Name = "OutputForm";
            Text = "Delegate Output";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox textBoxOutput;
    }
}
namespace Expense_Tracker_Desktop
{
    partial class ErrWin
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
            components = new System.ComponentModel.Container();
            lblErrorMsg = new Label();
            fadeTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.Anchor = AnchorStyles.None;
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblErrorMsg.ImageAlign = ContentAlignment.MiddleLeft;
            lblErrorMsg.Location = new Point(15, 9);
            lblErrorMsg.Margin = new Padding(6, 0, 3, 0);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(90, 18);
            lblErrorMsg.TabIndex = 0;
            lblErrorMsg.Text = "ErrorMessage";
            lblErrorMsg.TextAlign = ContentAlignment.TopCenter;
            lblErrorMsg.Click += lblErrorMsg_Click;
            // 
            // ErrWin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(432, 38);
            Controls.Add(lblErrorMsg);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ErrWin";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "ToastForm";
            Load += ToastForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblErrorMsg;
        private System.Windows.Forms.Timer fadeTimer;
    }
}
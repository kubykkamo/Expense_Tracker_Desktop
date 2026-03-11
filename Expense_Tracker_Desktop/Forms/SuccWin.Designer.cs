namespace Expense_Tracker_Desktop
{
    partial class SuccWin
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
            lblSuccessMsg = new Label();
            fadeTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblSuccessMsg
            // 
            lblSuccessMsg.Dock = DockStyle.Fill;
            lblSuccessMsg.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblSuccessMsg.Location = new Point(0, 0);
            lblSuccessMsg.Margin = new Padding(6, 0, 3, 0);
            lblSuccessMsg.Name = "lblSuccessMsg";
            lblSuccessMsg.Size = new Size(250, 50);
            lblSuccessMsg.TabIndex = 0;
            lblSuccessMsg.Text = "SuccessMessage";
            lblSuccessMsg.TextAlign = ContentAlignment.MiddleCenter;
            lblSuccessMsg.Click += lblSuccessMsg_Click;
            // 
            // SuccWin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(250, 50);
            Controls.Add(lblSuccessMsg);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SuccWin";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "ToastForm";
            Load += ToastForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblSuccessMsg;
        private System.Windows.Forms.Timer fadeTimer;
    }
}
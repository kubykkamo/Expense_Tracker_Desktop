namespace Expense_Tracker_Desktop
{
    partial class AddCategoryForm
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
            panelNewCat = new Panel();
            button11 = new Button();
            txtNewCat = new TextBox();
            button9 = new Button();
            label5 = new Label();
            panelNewCat.SuspendLayout();
            SuspendLayout();
            // 
            // panelNewCat
            // 
            panelNewCat.Controls.Add(button11);
            panelNewCat.Controls.Add(txtNewCat);
            panelNewCat.Controls.Add(button9);
            panelNewCat.Controls.Add(label5);
            panelNewCat.Location = new Point(-3, -4);
            panelNewCat.Margin = new Padding(3, 2, 3, 2);
            panelNewCat.Name = "panelNewCat";
            panelNewCat.Size = new Size(388, 157);
            panelNewCat.TabIndex = 25;
            // 
            // button11
            // 
            button11.BackColor = SystemColors.ActiveBorder;
            button11.Location = new Point(32, 108);
            button11.Name = "button11";
            button11.Size = new Size(108, 36);
            button11.TabIndex = 23;
            button11.Text = "Zpět";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // txtNewCat
            // 
            txtNewCat.Location = new Point(32, 55);
            txtNewCat.Name = "txtNewCat";
            txtNewCat.Size = new Size(181, 23);
            txtNewCat.TabIndex = 22;
            // 
            // button9
            // 
            button9.Location = new Point(247, 108);
            button9.Name = "button9";
            button9.Size = new Size(108, 36);
            button9.TabIndex = 21;
            button9.Text = "Přidat";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.Location = new Point(32, 30);
            label5.Name = "label5";
            label5.Size = new Size(138, 23);
            label5.TabIndex = 21;
            label5.Text = "Název kategorie";
            // 
            // AddCategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 152);
            Controls.Add(panelNewCat);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddCategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Přidat kategorii";
            Load += AddCategoryForm_Load;
            panelNewCat.ResumeLayout(false);
            panelNewCat.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNewCat;
        private Button button11;
        private TextBox txtNewCat;
        private Button button9;
        private Label label5;
    }
}
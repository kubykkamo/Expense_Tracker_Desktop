namespace Expense_Tracker_Desktop
{
    partial class App
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvTransactions = new DataGridView();
            lblBalance = new Label();
            button1 = new Button();
            panelOverview = new Panel();
            button4 = new Button();
            label5 = new Label();
            cmbCategoryFilter = new ComboBox();
            filtrovatPodleKategorie = new Label();
            panelAddTransaction = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            cmbCategory = new ComboBox();
            chckIsIncome = new CheckBox();
            txtAmount = new TextBox();
            txtDescription = new TextBox();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            panelOverview.SuspendLayout();
            panelAddTransaction.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTransactions
            // 
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(39, 78);
            dgvTransactions.MultiSelect = false;
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.Size = new Size(622, 556);
            dgvTransactions.TabIndex = 0;
            dgvTransactions.CellContentClick += dataGridView1_CellContentClick;
            dgvTransactions.KeyDown += dgvTransactions_KeyDown_1;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Sitka Display", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblBalance.Location = new Point(97, 23);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(74, 28);
            lblBalance.TabIndex = 1;
            lblBalance.Text = "Balance";
            lblBalance.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(519, 17);
            button1.Name = "button1";
            button1.Size = new Size(142, 46);
            button1.TabIndex = 2;
            button1.Text = "Nová platba";
            button1.UseVisualStyleBackColor = true;
            button1.Click += NewTransaction_Click;
            // 
            // panelOverview
            // 
            panelOverview.Controls.Add(button5);
            panelOverview.Controls.Add(button4);
            panelOverview.Controls.Add(label5);
            panelOverview.Controls.Add(cmbCategoryFilter);
            panelOverview.Controls.Add(filtrovatPodleKategorie);
            panelOverview.Controls.Add(dgvTransactions);
            panelOverview.Controls.Add(button1);
            panelOverview.Controls.Add(lblBalance);
            panelOverview.Location = new Point(22, 12);
            panelOverview.Name = "panelOverview";
            panelOverview.Size = new Size(1195, 665);
            panelOverview.TabIndex = 3;
            // 
            // button4
            // 
            button4.Location = new Point(680, 328);
            button4.Name = "button4";
            button4.Size = new Size(108, 25);
            button4.TabIndex = 14;
            button4.Text = "Filtrovat";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.Location = new Point(680, 257);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 13;
            label5.Text = "Kategorie";
            // 
            // cmbCategoryFilter
            // 
            cmbCategoryFilter.FormattingEnabled = true;
            cmbCategoryFilter.Location = new Point(680, 283);
            cmbCategoryFilter.Name = "cmbCategoryFilter";
            cmbCategoryFilter.Size = new Size(121, 23);
            cmbCategoryFilter.TabIndex = 12;
            cmbCategoryFilter.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // filtrovatPodleKategorie
            // 
            filtrovatPodleKategorie.AutoSize = true;
            filtrovatPodleKategorie.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            filtrovatPodleKategorie.Location = new Point(680, 215);
            filtrovatPodleKategorie.Name = "filtrovatPodleKategorie";
            filtrovatPodleKategorie.Size = new Size(203, 23);
            filtrovatPodleKategorie.TabIndex = 10;
            filtrovatPodleKategorie.Text = "Filtrovat podle kategorie";
            filtrovatPodleKategorie.Click += label4_Click;
            // 
            // panelAddTransaction
            // 
            panelAddTransaction.Controls.Add(label3);
            panelAddTransaction.Controls.Add(label2);
            panelAddTransaction.Controls.Add(label1);
            panelAddTransaction.Controls.Add(button3);
            panelAddTransaction.Controls.Add(button2);
            panelAddTransaction.Controls.Add(cmbCategory);
            panelAddTransaction.Controls.Add(chckIsIncome);
            panelAddTransaction.Controls.Add(txtAmount);
            panelAddTransaction.Controls.Add(txtDescription);
            panelAddTransaction.Location = new Point(22, 12);
            panelAddTransaction.Name = "panelAddTransaction";
            panelAddTransaction.Size = new Size(954, 505);
            panelAddTransaction.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(165, 237);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 11;
            label3.Text = "Kategorie";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(165, 164);
            label2.Name = "label2";
            label2.Size = new Size(63, 23);
            label2.TabIndex = 10;
            label2.Text = "Částka";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(165, 78);
            label1.Name = "label1";
            label1.Size = new Size(48, 23);
            label1.TabIndex = 9;
            label1.Text = "Popis";
            label1.Click += label1_Click_1;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.Location = new Point(165, 324);
            button3.Name = "button3";
            button3.Size = new Size(138, 33);
            button3.TabIndex = 8;
            button3.Text = "Uložit platbu";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Location = new Point(550, 333);
            button2.Name = "button2";
            button2.Size = new Size(111, 52);
            button2.TabIndex = 7;
            button2.Text = "Zpět";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Overview_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(165, 263);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(121, 23);
            cmbCategory.TabIndex = 6;
            cmbCategory.SelectedIndexChanged += txtCategory_SelectedIndexChanged;
            // 
            // chckIsIncome
            // 
            chckIsIncome.AutoSize = true;
            chckIsIncome.Location = new Point(302, 194);
            chckIsIncome.Name = "chckIsIncome";
            chckIsIncome.Size = new Size(65, 19);
            chckIsIncome.TabIndex = 5;
            chckIsIncome.Text = "Příjem?";
            chckIsIncome.UseVisualStyleBackColor = true;
            chckIsIncome.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(165, 190);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(100, 23);
            txtAmount.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(165, 108);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(334, 23);
            txtDescription.TabIndex = 1;
            txtDescription.TextChanged += textBox1_TextChanged;
            // 
            // button5
            // 
            button5.Location = new Point(874, 415);
            button5.Name = "button5";
            button5.Size = new Size(108, 25);
            button5.TabIndex = 15;
            button5.Text = "Reset";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 749);
            Controls.Add(panelOverview);
            Controls.Add(panelAddTransaction);
            Name = "App";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            panelOverview.ResumeLayout(false);
            panelOverview.PerformLayout();
            panelAddTransaction.ResumeLayout(false);
            panelAddTransaction.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTransactions;
        private Label lblBalance;
        private Button button1;
        private Panel panelOverview;
        private Panel panelAddTransaction;
        private TextBox txtDescription;
        private ComboBox cmbCategory;
        private CheckBox chckIsIncome;
        private TextBox txtAmount;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label filtrovatPodleKategorie;
        private Label label5;
        private ComboBox cmbCategoryFilter;
        private Button button4;
        private Button button5;
    }
}

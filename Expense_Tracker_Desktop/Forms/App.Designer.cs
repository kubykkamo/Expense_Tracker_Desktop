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
            button12 = new Button();
            lblTotalOutcome = new Label();
            button10 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            label4 = new Label();
            cmbSort = new ComboBox();
            button5 = new Button();
            button4 = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            panelOverview.SuspendLayout();
            panelAddTransaction.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTransactions
            // 
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(39, 78);
            dgvTransactions.MultiSelect = false;
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.RowHeadersWidth = 51;
            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.Size = new Size(622, 556);
            dgvTransactions.TabIndex = 0;
            dgvTransactions.CellBeginEdit += dgvTransactions_CellBeginEdit;
            dgvTransactions.CellContentClick += dataGridView1_CellContentClick;
            dgvTransactions.CellEndEdit += dgvTransactions_CellEndEdit;
            dgvTransactions.KeyDown += dgvTransactions_KeyDown_1;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Sitka Display", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblBalance.Location = new Point(39, 23);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(74, 28);
            lblBalance.TabIndex = 1;
            lblBalance.Text = "Balance";
            // 
            // button1
            // 
            button1.Location = new Point(680, 78);
            button1.Name = "button1";
            button1.Size = new Size(142, 46);
            button1.TabIndex = 2;
            button1.Text = "Přidat platbu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += NewTransaction_Click;
            // 
            // panelOverview
            // 
            panelOverview.Controls.Add(button12);
            panelOverview.Controls.Add(lblTotalOutcome);
            panelOverview.Controls.Add(button10);
            panelOverview.Controls.Add(button8);
            panelOverview.Controls.Add(button7);
            panelOverview.Controls.Add(button6);
            panelOverview.Controls.Add(label4);
            panelOverview.Controls.Add(cmbSort);
            panelOverview.Controls.Add(button5);
            panelOverview.Controls.Add(button4);
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
            // button12
            // 
            button12.Location = new Point(680, 594);
            button12.Name = "button12";
            button12.Size = new Size(142, 40);
            button12.TabIndex = 25;
            button12.Text = "Uložit";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // lblTotalOutcome
            // 
            lblTotalOutcome.AutoSize = true;
            lblTotalOutcome.Font = new Font("Sitka Display", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblTotalOutcome.Location = new Point(453, 23);
            lblTotalOutcome.Name = "lblTotalOutcome";
            lblTotalOutcome.Size = new Size(74, 28);
            lblTotalOutcome.TabIndex = 23;
            lblTotalOutcome.Text = "Balance";
            // 
            // button10
            // 
            button10.Location = new Point(680, 130);
            button10.Name = "button10";
            button10.Size = new Size(142, 46);
            button10.TabIndex = 21;
            button10.Text = "Přidat kategorii";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button8
            // 
            button8.Location = new Point(850, 356);
            button8.Name = "button8";
            button8.Size = new Size(123, 29);
            button8.TabIndex = 20;
            button8.Text = "Filtrovat a seřadit";
            button8.UseVisualStyleBackColor = true;
            button8.Click += TwoFilters_Click;
            // 
            // button7
            // 
            button7.Location = new Point(1111, 643);
            button7.Name = "button7";
            button7.Size = new Size(84, 22);
            button7.TabIndex = 19;
            button7.Text = "Test";
            button7.UseVisualStyleBackColor = true;
            button7.Click += TestData_Click;
            // 
            // button6
            // 
            button6.Location = new Point(1039, 324);
            button6.Name = "button6";
            button6.Size = new Size(108, 25);
            button6.TabIndex = 18;
            button6.Text = "Seřadit";
            button6.UseVisualStyleBackColor = true;
            button6.Click += SortTransactions_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.Location = new Point(1026, 257);
            label4.Name = "label4";
            label4.Size = new Size(114, 23);
            label4.TabIndex = 17;
            label4.Text = "Seřadit podle";
            label4.Click += label4_Click_1;
            // 
            // cmbSort
            // 
            cmbSort.FormattingEnabled = true;
            cmbSort.Location = new Point(1026, 282);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(121, 23);
            cmbSort.TabIndex = 16;
            // 
            // button5
            // 
            button5.Location = new Point(680, 403);
            button5.Name = "button5";
            button5.Size = new Size(108, 25);
            button5.TabIndex = 15;
            button5.Text = "Resetovat filtry";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(680, 324);
            button4.Name = "button4";
            button4.Size = new Size(108, 25);
            button4.TabIndex = 14;
            button4.Text = "Filtrovat";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // cmbCategoryFilter
            // 
            cmbCategoryFilter.FormattingEnabled = true;
            cmbCategoryFilter.Location = new Point(680, 283);
            cmbCategoryFilter.Name = "cmbCategoryFilter";
            cmbCategoryFilter.Size = new Size(121, 23);
            cmbCategoryFilter.TabIndex = 12;
            // 
            // filtrovatPodleKategorie
            // 
            filtrovatPodleKategorie.AutoSize = true;
            filtrovatPodleKategorie.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            filtrovatPodleKategorie.Location = new Point(680, 257);
            filtrovatPodleKategorie.Name = "filtrovatPodleKategorie";
            filtrovatPodleKategorie.Size = new Size(203, 23);
            filtrovatPodleKategorie.TabIndex = 10;
            filtrovatPodleKategorie.Text = "Filtrovat podle kategorie";
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
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Location = new Point(465, 320);
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
            button2.Location = new Point(165, 322);
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
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
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
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 749);
            Controls.Add(panelAddTransaction);
            Controls.Add(panelOverview);
            Name = "App";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Expense Tracker";
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
        private ComboBox cmbCategoryFilter;
        private Button button4;
        private Button button5;
        private ComboBox cmbSort;
        private Label label4;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button10;
        private Label lblTotalOutcome;
        private Button button12;
    }
}

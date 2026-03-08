namespace Expense_Tracker_Desktop
{
    public partial class App : Form
    {
        private Account _account;
        private FileStorageService _storage = new FileStorageService();
        public App()
        {
            InitializeComponent();
            var loadedTransactions = _storage.LoadTransactions()
                .OrderByDescending(x => x.Date)
                .ToList();
            var loadedCategories = _storage.LoadCategories();

            _account = new Account(loadedTransactions, loadedCategories);

            cmbSort.Items.Add(new SortOption { DisplayName = "Od nejdražší", Type = SortType.ByAmountDesc });
            cmbSort.Items.Add(new SortOption { DisplayName = "Od nejlevnější", Type = SortType.ByAmountAsc });
            cmbSort.Items.Add(new SortOption { DisplayName = "Podle abecedy A-Z", Type = SortType.ByNameAsc });
            cmbSort.Items.Add(new SortOption { DisplayName = "Podle abecedy Z-A", Type = SortType.ByNameDesc });
            cmbSort.Items.Add(new SortOption { DisplayName = "Od nejnvoější", Type = SortType.ByDateDesc });
            cmbSort.Items.Add(new SortOption { DisplayName = "Od nejstarší", Type = SortType.ByDateAsc });

            cmbSort.DisplayMember = "DisplayName";

            cmbCategory.DataSource = _account.Categories;
            cmbCategory.DisplayMember = "Name";
            cmbCategoryFilter.DataSource = _account.Categories;
            cmbCategoryFilter.DisplayMember = "Name";
            UpdateData();
            FormatTable();

            dgvTransactions.DataBindingComplete += DgvTransactions_DataBindingComplete;
        }

        private void DgvTransactions_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            FormatTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void UpdateData()
        {
            lblBalance.Text = $"Celkový zůstatek: {_account.Balance} Kč.";
            dgvTransactions.DataSource = null;
            dgvTransactions.DataSource = _account.DateOrderedTransactions();
        }

        private void FormatTable()
        {

            dgvTransactions.Columns["Category"].Visible = false;
            dgvTransactions.Columns["Description"].HeaderText = "Popis";
            dgvTransactions.Columns["Amount"].HeaderText = "Částka";
            dgvTransactions.Columns["Date"].HeaderText = "Datum";
            dgvTransactions.Columns["IsIncome"].HeaderText = "Příjem?";
            dgvTransactions.Columns["CategoryName"].HeaderText = "Kategorie";

            if (dgvTransactions.Columns["Amount"] != null)
            {

                dgvTransactions.Columns["Amount"].DefaultCellStyle.Format = "C0";
            }


            foreach (DataGridViewRow radek in dgvTransactions.Rows)
            {
                if (radek.IsNewRow) continue;


                bool jePrijem = (bool)radek.Cells["IsIncome"].Value;

                if (jePrijem)
                {

                    radek.DefaultCellStyle.BackColor = Color.AliceBlue;
                }
                else
                {
                    radek.DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
        }

        private void NewTransaction_Click(object sender, EventArgs e)
        {

            panelOverview.Visible = false;
            panelAddTransaction.Visible = true;
        }

        private void Overview_Click(object sender, EventArgs e)
        {
            panelAddTransaction.Visible = false;
            panelOverview.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void VerifyTransaction(string desc, string amountText, bool isIncome, Category cat)

        {
            if (string.IsNullOrEmpty(desc))
            {
                throw new ArgumentException("Popis nesmí být prázdný.");
            }
            if (!decimal.TryParse(amountText, out decimal amount))
            {
                throw new ArgumentException("Částka musí být platné číslo!");
            }

            _account.AddTransaction(desc, amount, isIncome, cat);
            _storage.SaveTransactions(_account.Transactions);





        }

        private void dgvTransactions_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dgvTransactions.SelectedRows.Count > 0)
                {
                    var deletedTransaction = (Transaction)dgvTransactions.SelectedRows[0].DataBoundItem;

                    _account.Transactions.Remove(deletedTransaction);
                    _storage.SaveTransactions(_account.Transactions);



                    UpdateData();
                    FormatTable();
                    SuccWin.Show("Platba byla smazána", this);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                VerifyTransaction(txtDescription.Text, txtAmount.Text, chckIsIncome.Checked, (Category)cmbCategory.SelectedItem);
                SuccWin.Show("Platba byla úspěšně přidána!", this);


                txtDescription.Clear();
                txtAmount.Clear();
                chckIsIncome.Checked = false;

                UpdateData();
                FormatTable();

            }
            catch (Exception ex)
            {

                ErrWin.Show(ex.Message, this);

            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            var transactions = _account.GetFilteredTransactions((Category)cmbCategoryFilter.SelectedItem);

            dgvTransactions.DataSource = transactions;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateData();
            FormatTable();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var selectedOption = (SortOption)cmbSort.SelectedItem;
            var transactions = _account.GetSortedTransactions(selectedOption.Type);

            dgvTransactions.DataSource = transactions;
        }
    }
}

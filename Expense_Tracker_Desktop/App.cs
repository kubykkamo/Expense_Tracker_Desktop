namespace Expense_Tracker_Desktop
{
    public partial class App : Form
    {
        private Account _account;
        private FileStorageService _storage = new FileStorageService();
        public App()
        {
            InitializeComponent();
            var loadedTransactions = _storage.LoadTransactions();
            var loadedCategories = _storage.LoadCategories();
            _account = new Account(loadedTransactions, loadedCategories);
            

            cmbCategory.DataSource = _account.Categories;
            cmbCategory.DisplayMember = "Name";
            UpdateBalance();
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

        private void UpdateBalance()
        {
            lblBalance.Text = $"Celkový zůstatek: {_account.Balance} Kč.";
        }

        private void FormatTable()
        {
            dgvTransactions.DataSource = _account.Transactions;
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

                    radek.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else
                {
                    radek.DefaultCellStyle.BackColor = Color.LightSalmon;
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



        private void button3_Click(object sender, EventArgs e)
        {
            string description = txtDescription.Text;
            if(!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("Do pole pro částku musíš zadat platné číslo.", 
                    "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Category category = (Category)cmbCategory.SelectedItem;
            bool isIncome = chckIsIncome.Checked;
            try
            {
                var transaction = new Transaction(description, amount, isIncome, category);
                _account.Transactions.Add(transaction);

                dgvTransactions.DataSource = null;
                dgvTransactions.DataSource = _account.Transactions;

                UpdateBalance();
                FormatTable();
                _storage.SaveTransactions(_account.Transactions);
                ToastForm.Show("Platba byla úspěšně přidána!", this);
                txtDescription.Clear();
                txtAmount.Clear();
                chckIsIncome.Checked = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Chyba při vytváření platby", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}

using System.Diagnostics.PerformanceData;

namespace Expense_Tracker_Desktop
{
    public partial class App : Form
    {
        private Account _account;
        private List<Transaction> loadedTransactions;
        private List<Category> loadedCategories;
        private FileStorageService _storage = new FileStorageService();
        public App()
        {
            InitializeComponent();

            loadedTransactions = _storage.LoadTransactions()
                .OrderByDescending(x => x.Date)
                .ToList();
            loadedCategories = _storage.LoadCategories();

            _account = new Account(loadedTransactions, loadedCategories);

            cmbSort.Items.Add(new SortOption { DisplayName = "Od nejdražší", Type = SortType.ByAmountDesc });
            cmbSort.Items.Add(new SortOption { DisplayName = "Od nejlevnější", Type = SortType.ByAmountAsc });
            cmbSort.Items.Add(new SortOption { DisplayName = "Podle abecedy A-Z", Type = SortType.ByNameAsc });
            cmbSort.Items.Add(new SortOption { DisplayName = "Podle abecedy Z-A", Type = SortType.ByNameDesc });
            cmbSort.Items.Add(new SortOption { DisplayName = "Od nejnovější", Type = SortType.ByDateDesc });
            cmbSort.Items.Add(new SortOption { DisplayName = "Od nejstarší", Type = SortType.ByDateAsc });

            cmbSort.DisplayMember = "DisplayName";


            cmbCategoryFilter.DataSource = _account.Categories;
            cmbCategoryFilter.DisplayMember = "Name";
            cmbCategoryFilter.SelectedIndex = -1;
            cmbSort.SelectedIndex = -1;

            UpdateData();
            FormatTable();
            ShowPanel(panelOverview);

            dgvTransactions.DataBindingComplete += DgvTransactions_DataBindingComplete;
        }

        private void DgvTransactions_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            FormatTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowPanel(Panel panelToShow)
        {
            Panel[] allPanels = { panelOverview, panelNewCat, panelAddTransaction };

            foreach (var p in allPanels)
            {
                p.Visible = false;
            }

            panelToShow.Visible = true;
            panelToShow.BringToFront();
        }

        private void UpdateData()
        {
            lblBalance.Text = $"Celkový zůstatek: {_account.Balance} Kč.";
            dgvTransactions.DataSource = null;
            dgvTransactions.DataSource = _account.DateOrderedTransactions();
            cmbCategoryFilter.DataSource = null;
            cmbCategoryFilter.DataSource = loadedCategories;
           
            
        }

        private void FormatTable()
        {

            dgvTransactions.Columns["Category"].Visible = false;
            dgvTransactions.Columns["Description"].HeaderText = "Popis";
            dgvTransactions.Columns["Amount"].HeaderText = "Částka";
            dgvTransactions.Columns["Date"].HeaderText = "Datum";
            dgvTransactions.Columns["IsIncome"].HeaderText = "Příjem?";
            dgvTransactions.Columns["CategoryName"].HeaderText = "Kategorie";


            DateTime? lastDate = null;
            bool useAlternateColor = false;

            Color dayColorA = Color.White;
            Color dayColorB = Color.FromArgb(255, 223, 211);

            foreach (DataGridViewRow row in dgvTransactions.Rows)
            {
                if (row.IsNewRow) continue;

                DateTime currentDate = Convert.ToDateTime(row.Cells["Date"].Value);
                bool isIncome = (bool)row.Cells["IsIncome"].Value;

                // Střídání barev podle dnů
                if (lastDate.HasValue && currentDate.Date != lastDate.Value.Date)
                {
                    useAlternateColor = !useAlternateColor;
                }

                row.DefaultCellStyle.BackColor = useAlternateColor ? dayColorB : dayColorA;
                row.DefaultCellStyle.ForeColor = Color.Black; // Všechno písmo čistě černé

                // Znaménka pro částku (nastaví se formát jen pro konkrétní buňku)
                if (isIncome)
                {
                    row.Cells["Amount"].Style.Format = "+ #,##0 Kč";
                }
                else
                {
                    row.Cells["Amount"].Style.Format = "- #,##0 Kč";
                }

                lastDate = currentDate.Date;
            }
        }

        private void NewTransaction_Click(object sender, EventArgs e)
        {

            ShowPanel(panelAddTransaction);
        }

        private void Overview_Click(object sender, EventArgs e)
        {
            ShowPanel(panelOverview);
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

        private void VerifyCategory(string desc)
        {
            if (string.IsNullOrEmpty(desc))
            {
                throw new ArgumentException("Zadej název kategorie!");
            }

            _account.AddCategory(desc);
            _storage.SaveCategories(_account.Categories);
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


        private void button4_Click(object sender, EventArgs e)
        {

            var transactions = _account.GetFilteredTransactions((Category)cmbCategoryFilter.SelectedItem);

            dgvTransactions.DataSource = transactions;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateData();
            FormatTable();
            cmbCategoryFilter.SelectedIndex = -1;
            cmbSort.SelectedIndex = -1;

        }
        public void GenerateTestData()
        {
            int count = 500;
            var random = new Random();

            var transactions = _account.Transactions;

            // Vezmeme kategorie, které už v aplikaci máš
            var categories = _account.Categories;

            for (int i = 0; i < count; i++)
            {
                var cat = categories[random.Next(categories.Count)];
                bool isIncome = random.Next(0, 2) == 0;
                decimal amount = random.Next(10, 5000);
                string desc = $"Testovací platba č. {i + 1}";

                // Vytvoříme transakci (využijeme tvůj konstruktor, co hlídá chyby)
                var t = new Transaction(desc, amount, isIncome, cat);

                // Náhodné datum v rozmezí posledních 30 dnů
                t.Date = DateTime.Now.AddDays(-random.Next(0, 30));

                transactions.Add(t);
            }

            _storage.SaveTransactions(transactions);
            MessageBox.Show($"{count} testovacích transakcí vygenerováno!");
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void SortTransactions_Click(object sender, EventArgs e)
        {
            var selectedOption = (SortOption)cmbSort.SelectedItem;
            var transactions = _account.GetSortedTransactions(selectedOption.Type, _account.Transactions);

            dgvTransactions.DataSource = transactions;
        }

        private void TestData_Click(object sender, EventArgs e)
        {
            GenerateTestData();
        }

        private void TwoFilters_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedCategory = cmbCategoryFilter.SelectedItem as Category;
                var selectedOption = cmbSort.SelectedItem as SortOption;
                SortType type = SortType.ByDateDesc;
                if (selectedOption != null)
                {
                    type = selectedOption.Type;
                }
                else
                {
                    ErrWin.Show("Nevybral/a jsi druhý filtr!", this);
                }

                var transactions = _account.GetFilteredSortedTransactions(selectedCategory, type);
                dgvTransactions.DataSource = transactions;
            }

            catch (Exception ex)
            {
                ErrWin.Show(ex.Message, this);
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string desc = txtNewCat.Text;

            try
            {
                VerifyCategory(desc);
                SuccWin.Show("Kategorie byla přidána!", this);
                UpdateData();
                ShowPanel(panelOverview);
            }

            catch (Exception ex)
            {
                ErrWin.Show(ex.Message, this);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ShowPanel(panelNewCat);

        }

        
    }
}

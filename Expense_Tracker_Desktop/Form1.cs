namespace Expense_Tracker_Desktop
{
    public partial class Form1 : Form
    {
        private Account _account;
        private FileStorageService _storage = new FileStorageService();
        public Form1()
        {
            InitializeComponent();
            var loadedTransactions = _storage.LoadTransactions();
            var loadedCategories = _storage.LoadCategories();
            _account = new Account(loadedTransactions, loadedCategories);
            dgvTransactions.DataSource = _account.Transactions;
            dgvTransactions.Columns["Category"].Visible = false;
            dgvTransactions.Columns["Description"].HeaderText = "Popis";
            dgvTransactions.Columns["Amount"].HeaderText = "Částka";
            dgvTransactions.Columns["Date"].HeaderText = "Datum";
            dgvTransactions.Columns["IsIncome"].HeaderText = "Příjem?";
            dgvTransactions.Columns["CategoryName"].HeaderText = "Kategorie";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

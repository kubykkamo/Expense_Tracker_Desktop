using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Expense_Tracker_Desktop
{
    public partial class AddCategoryForm : Form
    {
        // Veřejná vlastnost, kterou si pak přečteme v hlavním okně
        public string CategoryName { get; private set; }

        public AddCategoryForm()
        {
            this.Text = string.Empty;
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e) // To je tvoje tlačítko "Přidat"
        {
            CategoryName = txtNewCat.Text;
           
                this.DialogResult = DialogResult.OK; // Tímto okno zavřeš a oznámíš úspěch
                this.Close();
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCategoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}

using Assignment5_comp123.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5_comp123.Views
{
    public partial class SelectForm : Form
    {
        private int rowIndex;

        public SelectForm()
        {
            InitializeComponent();
        }

        public bool HasLoadedDataSource()
        {
            using (var db = new ProductModel())
            {
                db.products.Load();
                productsBindingSource.DataSource = db.products.Local.ToBindingList();
                if(productsBindingSource.DataSource!=null)
                {
                    return true;
                }
            }
            return false;
        }
        private string ProductdataGridViewSelectItem()
        {
            var rouIndex = ProductdataGridView.CurrentCell.RowIndex;
            var currentrow = ProductdataGridView.Rows[rowIndex];
            var cost = currentrow.Cells[1].Value.ToString();
            var manufacturer = currentrow.Cells[2].Value.ToString();
            var model = currentrow.Cells[3].Value.ToString();

            string outputstring = manufacturer + " " + model + " " + cost;
            return outputstring;
        }
        private void SelectForm_Load(object sender, EventArgs e)
        {
            if(!HasLoadedDataSource())
            {
                MessageBox.Show("DateSource Not Loaded", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductdataGridView_SelectionChanged(object sender, EventArgs e)
        {
            SelectLabel.Text = ProductdataGridViewSelectItem();
        }

       
    }
}

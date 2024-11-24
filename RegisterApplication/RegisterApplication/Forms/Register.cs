using RegisterApplication.DAO;
using RegisterApplication.objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RegisterApplication
{
    public partial class Register : Form
    {
        double totalAmount = 0;

        public void AddProductToList(string idOfItem)
        {
            ProductsDAO productsDAO = new ProductsDAO();
            Product product = productsDAO.getProductFromBarcode(idOfItem);

            if (product == null || string.IsNullOrEmpty(product.Name))
            {
                MessageBox.Show("Product not found.");
                return;
            }

            bool productExists = false;

            foreach (DataGridViewRow row in currentOrder.Rows)
            {
                if (row.Cells["Barcode"].Value?.ToString() == product.Barcode)
                {
                    int currentQuantity = row.Cells["Quantity"].Value == null ? 0 : Convert.ToInt32(row.Cells["Quantity"].Value);
                    row.Cells["Quantity"].Value = currentQuantity + 1;
                    row.Cells["Price"].Value = (currentQuantity + 1) * product.Price;

                    productExists = true;
                    break;
                }
            }

            if (!productExists)
            {
                int rowIndex = currentOrder.Rows.Add();
                currentOrder.Rows[rowIndex].Cells["ProductName"].Value = product.Name;
                currentOrder.Rows[rowIndex].Cells["Price"].Value = product.Price;
                currentOrder.Rows[rowIndex].Cells["Barcode"].Value = product.Barcode;
                currentOrder.Rows[rowIndex].Cells["Notes"].Value = product.Notes;
                currentOrder.Rows[rowIndex].Cells["Quantity"].Value = 1;
            }

            totalAmount += product.Price;
            label2.Text = "Total: $" + totalAmount.ToString("F2");
            CurrentPriceLabel.Text = "Price: $" + product.Price.ToString("F2");
            ProductNameLabel.Text = "Product Name: " + product.Name;
        }

        public void EnterFullScreenMode(Form targetForm)
        {
            targetForm.WindowState = FormWindowState.Normal;
            targetForm.FormBorderStyle = FormBorderStyle.None;
            targetForm.WindowState = FormWindowState.Maximized;
        }

        public void LeaveFullScreenMode(Form targetForm)
        {
            targetForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            targetForm.WindowState = FormWindowState.Normal;
        }

        bool isUserManager = false;
        public Register(bool isManager, string nameOfStaff)
        {
            InitializeComponent();
            isUserManager = isManager;
            EnterFullScreenMode(this);
            this.ActiveControl = inputIDBox;
            nameTextLabel.Text = "Hello, " + nameOfStaff;

            currentOrder.Columns.Add("ProductName", "Product Name");
            currentOrder.Columns.Add("Price", "Price");
            currentOrder.Columns.Add("Barcode", "Barcode");
            currentOrder.Columns.Add("Notes", "Notes");

            currentOrder.Columns.Add("Quantity", "Quantity");

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nameTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            inputIDBox.Text += "1";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            inputIDBox.Text += "2";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            inputIDBox.Text += "3";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            inputIDBox.Text += "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            inputIDBox.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            inputIDBox.Text += "6";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            inputIDBox.Text += "7";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            inputIDBox.Text += "8";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            inputIDBox.Text += "9";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            inputIDBox.Text += "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            inputIDBox.Text = "";
            this.ActiveControl = inputIDBox;
        }

        private void inputIDBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddProductToList(inputIDBox.Text);
                inputIDBox.Text = "";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AddProductToList(inputIDBox.Text);
            this.ActiveControl = inputIDBox;
            inputIDBox.Text = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;


namespace TechVault.Inventory
{
    public partial class Form1 : Form
    {
        int selectedItemId = 0;
        List<Item> allItems = new List<Item>();
        HttpClient client = new HttpClient();

        string apiUrl = "https://localhost:7270/api/items";

        public Form1()
        {
            InitializeComponent();

            dgvItems.EnableHeadersVisualStyles = false;

            dgvItems.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(126, 87, 194);

            dgvItems.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvItems.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);


            dgvItems.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 240, 255);

            cmbCategory.Items.Add("Laptop");
            cmbCategory.Items.Add("Accessories");
            cmbCategory.Items.Add("Monitor");
            cmbCategory.Items.Add("Keyboard");
            cmbCategory.Items.Add("Mouse");
            cmbCategory.Items.Add("Other");

            this.Load += async (s, e) =>
{
    await LoadItems();
};

            dgvItems.ClearSelection();
            selectedItemId = 0;

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

        }

        private async Task LoadItems()
        {
            try
            {
                var items = await client.GetFromJsonAsync<List<Item>>(apiUrl);
                allItems = items;

                dgvItems.DataSource = items;

                // DataGridView Formatting
                dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvItems.MultiSelect = false;
                dgvItems.ReadOnly = true;
                dgvItems.AllowUserToAddRows = false;

                ApplyLowStockWarning();

                // Header style
                dgvItems.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                dgvItems.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // Cell alignment
                dgvItems.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvItems.Columns["StockQuantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvItems.Columns["UnitPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                // Row height
                dgvItems.RowTemplate.Height = 30;

                // Column Width
                SetDataGridColumnWidth();

                // Price format
                dgvItems.Columns["UnitPrice"].DefaultCellStyle.Format = "N2";
                dgvItems.Columns["UnitPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                // Low Stock Warning
                foreach (DataGridViewRow row in dgvItems.Rows)
                {
                    if (row.Cells["StockQuantity"].Value != null)
                    {
                        int stock = Convert.ToInt32(row.Cells["StockQuantity"].Value);

                        if (stock <= 5)
                        {
                            row.DefaultCellStyle.BackColor = Color.FromArgb(239, 154, 154);
                            row.DefaultCellStyle.ForeColor = Color.White;
                        }
                        else if (stock <= 10)
                        {
                            row.DefaultCellStyle.BackColor = Color.FromArgb(255, 224, 178);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetDataGridColumnWidth()
        {
            dgvItems.Columns["Id"].Width = 50;
            dgvItems.Columns["Name"].Width = 180;
            dgvItems.Columns["Code"].Width = 120;
            dgvItems.Columns["Brand"].Width = 100;
            dgvItems.Columns["Category"].Width = 100;
            dgvItems.Columns["StockQuantity"].Width = 120;
            dgvItems.Columns["UnitPrice"].Width = 150;
        }

        private void ApplyLowStockWarning()
        {
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.ForeColor = Color.Black;

                if (row.Cells["StockQuantity"].Value != null)
                {
                    int stock = Convert.ToInt32(row.Cells["StockQuantity"].Value);

                    if (stock <= 5)
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(239, 154, 154);
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                    else if (stock <= 10)
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 224, 178);
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // validation
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtCode.Text) ||
                string.IsNullOrWhiteSpace(txtBrand.Text) ||
                string.IsNullOrWhiteSpace(txtStockQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtUnitPrice.Text) ||
                cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please complete all fields.");
                return;
            }

            // check price
            if (!decimal.TryParse(txtUnitPrice.Text, out decimal price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            // check stock
            if (!int.TryParse(txtStockQuantity.Text, out int stock))
            {
                MessageBox.Show("Please enter a valid stock quantity.");
                return;
            }

            // create item
            var item = new Item
            {
                Name = txtName.Text,
                Code = txtCode.Text,
                Brand = txtBrand.Text,
                Category = cmbCategory.Text,
                StockQuantity = int.Parse(txtStockQuantity.Text),
                UnitPrice = price
            };

            // send to API
            await client.PostAsJsonAsync(apiUrl, item);

            MessageBox.Show("Item added successfully!");

            // refresh DataGrid
            await LoadItems();

            // clear textbox
            txtName.Clear();
            txtCode.Clear();
            txtBrand.Clear();
            txtUnitPrice.Clear();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (selectedItemId == 0)
            {
                MessageBox.Show("Please select an item first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this item?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                await client.DeleteAsync($"{apiUrl}/{selectedItemId}");

                MessageBox.Show("Item deleted successfully!");

                await LoadItems();

                dgvItems.ClearSelection();
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                selectedItemId = 0;

                // clear fields after delete
                txtName.Clear();
                txtCode.Clear();
                txtBrand.Clear();
                txtUnitPrice.Clear();
                txtStockQuantity.Clear();
                cmbCategory.SelectedIndex = -1;

                selectedItemId = 0;
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            await LoadItems();

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            selectedItemId = 0;
            dgvItems.ClearSelection();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;

                DataGridViewRow row = dgvItems.Rows[e.RowIndex];

                selectedItemId = Convert.ToInt32(row.Cells["Id"].Value);

                txtName.Text = row.Cells["Name"].Value.ToString();
                txtCode.Text = row.Cells["Code"].Value.ToString();
                txtBrand.Text = row.Cells["Brand"].Value.ToString();
                cmbCategory.Text = row.Cells["Category"].Value.ToString();
                txtStockQuantity.Text = row.Cells["StockQuantity"].Value.ToString();
                txtUnitPrice.Text = row.Cells["UnitPrice"].Value.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtName.Clear();
            txtCode.Clear();
            txtBrand.Clear();
            txtUnitPrice.Clear();
            txtStockQuantity.Clear();
            txtSearch.Clear();

            cmbCategory.SelectedIndex = -1;

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            selectedItemId = 0;

            dgvItems.ClearSelection();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (selectedItemId == 0)
            {
                MessageBox.Show("Please select an item first.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtCode.Text) ||
                string.IsNullOrWhiteSpace(txtBrand.Text) ||
                string.IsNullOrWhiteSpace(txtUnitPrice.Text))
            {
                MessageBox.Show("Please complete all fields.");
                return;
            }

            var item = new Item
            {
                Id = selectedItemId,
                Name = txtName.Text,
                Code = txtCode.Text,
                Brand = txtBrand.Text,
                Category = cmbCategory.Text,
                StockQuantity = int.Parse(txtStockQuantity.Text),
                UnitPrice = decimal.Parse(txtUnitPrice.Text)
            };

            await client.PutAsJsonAsync($"{apiUrl}/{selectedItemId}", item);


            MessageBox.Show("Item updated successfully!");


            // refresh datagrid
            await LoadItems();

            // clear fields
            txtName.Clear();
            txtCode.Clear();
            txtBrand.Clear();
            txtUnitPrice.Clear();
            txtStockQuantity.Clear();

            cmbCategory.SelectedIndex = -1;

            selectedItemId = 0;

            dgvItems.ClearSelection();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.ToLower();

            var filteredItems = allItems.Where(x =>
                x.Name.ToLower().Contains(search) ||
                x.Code.ToLower().Contains(search) ||
                x.Brand.ToLower().Contains(search) ||
                x.Category.ToLower().Contains(search)
            ).ToList();

            dgvItems.DataSource = null;
            dgvItems.DataSource = filteredItems;

            SetDataGridColumnWidth();

            ApplyLowStockWarning();

            if (string.IsNullOrWhiteSpace(search))
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                selectedItemId = 0;
                dgvItems.ClearSelection();
            }
        }
    }
}

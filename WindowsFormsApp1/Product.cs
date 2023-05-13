using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Product : Form
    {
        product_DAL prd_obj = new product_DAL();
        public Product()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource =  prd_obj.disp();
        }


        private void Insert_Click(object sender, EventArgs e)
        {
            product_info prod_infObj = new product_info();
            bool isNumeric_prID = int.TryParse(productId_input_textBox.Text, out _);
            bool isNumeric_pcID = int.TryParse(price_input_textBox.Text, out _);
            bool isNumeric_stock = int.TryParse(stock_input_textBox.Text, out _);
            if (string.IsNullOrEmpty(productId_input_textBox.Text) ||
                string.IsNullOrEmpty(price_input_textBox.Text) ||
                string.IsNullOrEmpty(stock_input_textBox.Text) ||
                category_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Please enter all information completely!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (isNumeric_prID && isNumeric_pcID && isNumeric_stock)
            {
                prod_infObj.pr_id = Convert.ToInt32(productId_input_textBox.Text);
                prod_infObj.price = Convert.ToInt64(price_input_textBox.Text);
                prod_infObj.stock = Convert.ToInt32(stock_input_textBox.Text);
                prod_infObj.pc_id = Convert.ToInt32(category_comboBox.SelectedItem.ToString());
            } else {
                MessageBox.Show("Please enter the pr_ID, pc_ID and St as a number!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            prod_infObj.name = name_input_textBox.Text;
            prod_infObj.date = date_input_dateTimePicker.Value;
            prod_infObj.comment = comment_textBox.Text;
            product_DAL prod_dalObj = new product_DAL();

            bool customerIsValid =
                prod_infObj.name != string.Empty &&
                prod_infObj.price.ToString() != string.Empty &&
                prod_infObj.stock.ToString() != string.Empty &&
                prod_infObj.pr_id.ToString() != string.Empty &&
                prod_infObj.comment != string.Empty;
            if (customerIsValid)
            {
                prod_dalObj.insert(prod_infObj);  // calling a method from backend and paasing the information of new customer into a single object (packet)
                if (dataGridView1.RowCount != 0)
                    dataGridView1.DataSource = prod_dalObj.disp();
            }
            else
                MessageBox.Show("Please enter all information completely!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Update_Click(object sender, EventArgs e)
        {
            product_info prod_infObj = new product_info();
            product_DAL prod_dalObj = new product_DAL();

            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

                prod_infObj.pr_id = (int)dataGridView1.Rows[selectedRowIndex].Cells[0].Value;
                prod_infObj.name = (string)dataGridView1.Rows[selectedRowIndex].Cells[1].Value;
                prod_infObj.date = (DateTime)dataGridView1.Rows[selectedRowIndex].Cells[2].Value;
                prod_infObj.price = (long)dataGridView1.Rows[selectedRowIndex].Cells[3].Value;
                prod_infObj.stock = (int)dataGridView1.Rows[selectedRowIndex].Cells[4].Value;
                prod_infObj.comment = (string)dataGridView1.Rows[selectedRowIndex].Cells[5].Value;
                prod_infObj.pc_id = (int)dataGridView1.Rows[selectedRowIndex].Cells[6].Value;

                UpdateProduct updateObj = new UpdateProduct(prod_infObj, prod_dalObj, dataGridView1);
                updateObj.ShowDialog();

            }
            else
            {
                MessageBox.Show("Please select one product of the Prudoct's list!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void List_Click(object sender, EventArgs e)
        {
            product_DAL cus_obj = new product_DAL();
            dataGridView1.DataSource = cus_obj.disp();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            product_info prod_infObj = new product_info();
            product_DAL prod_dalObj = new product_DAL();

            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

                prod_infObj.pr_id = (int)dataGridView1.Rows[selectedRowIndex].Cells[0].Value;
                prod_infObj.pc_id = (int)dataGridView1.Rows[selectedRowIndex].Cells[6].Value;
                prod_dalObj.delete(prod_infObj);
                dataGridView1.DataSource = prod_dalObj.disp();
            }
            else
            {
                MessageBox.Show("Please select the product you want to delete from the Product's list!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(search_textBox.Text))
            {
                MessageBox.Show("Please enter a search text as a 'Product Name'", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                string name = search_textBox.Text;
                dataGridView1.DataSource = prd_obj.search_by_name(name);
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

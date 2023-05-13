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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customer_DAL cus_obj = new Customer_DAL();
            dataGridView1.DataSource = cus_obj.disp();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Customer_DAL cust_obj = new Customer_DAL();
            dataGridView1.DataSource = cust_obj.disp_tell();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            customer_info cust_infObj = new customer_info();
            bool isNumeric = int.TryParse(customerId_input_textBox2.Text, out _);
            if (customerId_input_textBox2.Text == string.Empty)
            {
                MessageBox.Show("Please enter all information completely!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (isNumeric)
                cust_infObj.cu_id = Convert.ToInt32(customerId_input_textBox2.Text);
            else
            {
                MessageBox.Show("Please enter the ID as a number!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cust_infObj.name = name_inout_textBox1.Text;
            cust_infObj.family = family_input_textBox1.Text;
            cust_infObj.tell = Tell_input_textBox1.Text;
            cust_infObj.iban = ibanin_textBox1.Text;
            Customer_DAL cust_dalObj = new Customer_DAL();
            
            bool customerIsValid = cust_infObj.name != string.Empty && cust_infObj.family != string.Empty && cust_infObj.tell != string.Empty && cust_infObj.iban != string.Empty;
            if (customerIsValid)
            {
                cust_dalObj.insert(cust_infObj);  // calling a method from backend and paasing the information of new customer into a single object (packet)
                if (dataGridView1.RowCount != 0)
                    dataGridView1.DataSource = cust_dalObj.disp();
            }
            else
                MessageBox.Show("Please enter all information completely!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void button5_Click(object sender, EventArgs e)
        {

            Customer_DAL cust_obj = new Customer_DAL();
            int selectedIdx = comboBox2.SelectedIndex;
            Console.WriteLine(selectedIdx.ToString());
            switch(selectedIdx)
            {
                case 0:
                    int searchID = int.TryParse(customerId_input_textBox2.Text, out _) == true ? Convert.ToInt32(customerId_input_textBox2.Text) : -999;
                    dataGridView1.DataSource = cust_obj.search_by_id(searchID);
                    break;

                case 1:
                    dataGridView1.DataSource = cust_obj.search_by_name(name_inout_textBox1.Text);
                    break;

                case 2:
                    dataGridView1.DataSource = cust_obj.search_by_familly(family_input_textBox1.Text);
                    break;

                case 3:
                    dataGridView1.DataSource = cust_obj.search_by_iban(ibanin_textBox1.Text);
                    break;

                default:
                    MessageBox.Show("Herhangi bir arama secenegi secmediniz!!");
                    break;
            }

            return;
        }

        //delete
        private void button1_Click(object sender, EventArgs e)
        {
            customer_info cust_infObj = new customer_info();
            Customer_DAL cust_dalObj = new Customer_DAL();

            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

                cust_infObj.cu_id = (int)dataGridView1.Rows[selectedRowIndex].Cells[0].Value;
                cust_dalObj.delete(cust_infObj);
                dataGridView1.DataSource = cust_dalObj.disp();
            }
            else
            {
                MessageBox.Show("Please select the customer you want to delete from the Customer's list!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return;
        }

        //update
        private void button2_Click(object sender, EventArgs e)
        {
            customer_info cust_infObj = new customer_info();
            Customer_DAL cust_dalObj = new Customer_DAL();

            if(dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

                cust_infObj.cu_id = (int)dataGridView1.Rows[selectedRowIndex].Cells[0].Value;
                cust_infObj.name = (string)dataGridView1.Rows[selectedRowIndex].Cells[1].Value;
                cust_infObj.family = (string)dataGridView1.Rows[selectedRowIndex].Cells[2].Value;
                cust_infObj.tell = (string)dataGridView1.Rows[selectedRowIndex].Cells[3].Value;
                cust_infObj.iban = (string)dataGridView1.Rows[selectedRowIndex].Cells[4].Value;
                
                UpdateCustomer updateObj = new UpdateCustomer(cust_infObj, cust_dalObj, dataGridView1);
                updateObj.ShowDialog();

            } else {
                MessageBox.Show("Please select one of the Customer's list!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

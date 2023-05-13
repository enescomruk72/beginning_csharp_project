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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customer_DAL cust_DAL_obj = new Customer_DAL();
            dataGridView2.DataSource = cust_DAL_obj.disp();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Payment_DAL pay_DAL_obj = new Payment_DAL();
            dataGridView2.DataSource = pay_DAL_obj.disp();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customer_info cust_inf_obj = new customer_info();
            cust_inf_obj.cu_id = Convert.ToInt32(id_text_in.Text);
            cust_inf_obj.name = Name_text_in.Text;
            cust_inf_obj.family = Family_text_in.Text;
            cust_inf_obj.tell = Tell_text_in.Text;
            cust_inf_obj.iban = iban_text_in.Text;

            Customer_DAL cust_obj = new Customer_DAL();
            cust_obj.insert(cust_inf_obj);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Customer_DAL cust_obj = new Customer_DAL();
            if(Name_text_in.Text!="")
                dataGridView2.DataSource= cust_obj.search_by_name(Name_text_in.Text);
            else if (id_text_in.Text!="")
                dataGridView2.DataSource = cust_obj.search_by_id(Convert.ToInt16(id_text_in. Text));

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}

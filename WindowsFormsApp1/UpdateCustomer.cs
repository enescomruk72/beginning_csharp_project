using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;


namespace WindowsFormsApp1
{
    public partial class UpdateCustomer : Form
    {
        customer_info cInfo_obj;
        Customer_DAL cDal_obj;
        DataGridView cDtView;
        public UpdateCustomer(customer_info obj=null, Customer_DAL Dal_obj=null, DataGridView dtView=null)
        {
            InitializeComponent();
          
            cInfo_obj = obj;
            cDal_obj = Dal_obj;
            cDtView = dtView;


            textBox1.Text = obj.cu_id.ToString(); textBox1.ReadOnly = true;
            textBox2.Text = obj.name; textBox2.ReadOnly = true;
            textBox3.Text = obj.family; textBox3.ReadOnly = true;
            textBox4.Text = obj.tell; textBox4.ReadOnly = true;
            textBox5.Text = obj.iban; textBox5.ReadOnly = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            cInfo_obj.name = string.IsNullOrEmpty(textBox7.Text) ? cInfo_obj.name : textBox7.Text;
            cInfo_obj.family = string.IsNullOrEmpty(textBox8.Text) ? cInfo_obj.family : textBox8.Text;
            cInfo_obj.tell = string.IsNullOrEmpty(textBox9.Text) ? cInfo_obj.tell : textBox9.Text;
            cInfo_obj.iban = string.IsNullOrEmpty(textBox10.Text) ? cInfo_obj.iban : textBox10.Text;

            cDal_obj.update(cInfo_obj);
            cDtView.DataSource = cDal_obj.disp();

            this.Dispose();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

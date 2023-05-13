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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer cust_obj = new Customer();
            cust_obj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Product prd_obj = new Product();
            prd_obj.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Payment pay_obj = new Payment();
            pay_obj.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sale sale_obj = new sale();
            sale_obj.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
            return;
        }
    }
}

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
    public partial class Payment : Form
    {
        Payment_DAL pay_obj = new Payment_DAL();
        public Payment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pay_obj.disp();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
               dataGridView1.DataSource= pay_obj.search_by_amount(Convert.ToInt32(textBox1_search.Text));
            if (comboBox1.SelectedIndex == 2)
                dataGridView1.DataSource = pay_obj.search_by_date(dateTimePicker1.Value);
        }
    }
}

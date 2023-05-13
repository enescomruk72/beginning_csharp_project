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
    public partial class UpdateProduct : Form
    {
        product_info c_Info_obj;
        product_DAL c_Dal_obj;
        DataGridView c_data_grid_view;
        public UpdateProduct(product_info prod_inf_obj=null, product_DAL prod_dal_obj=null, DataGridView dtView=null)
        {
            InitializeComponent();

            c_Info_obj = prod_inf_obj;
            c_Dal_obj = prod_dal_obj;
            c_data_grid_view = dtView;

            textBox1.Text = c_Info_obj.pr_id.ToString();
            textBox2.Text = c_Info_obj.name;
            textBox3.Text = c_Info_obj.date.ToString();
            textBox4.Text = c_Info_obj.price.ToString();
            textBox5.Text = c_Info_obj.stock.ToString();
            textBox6.Text = c_Info_obj.comment;
            textBox7.Text = c_Info_obj.pc_id.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            c_Info_obj.name = string.IsNullOrEmpty(update_name_textBox.Text) ? c_Info_obj.name : update_name_textBox.Text;
            c_Info_obj.date = update_product_dateTimePicker.Value;
            c_Info_obj.price = string.IsNullOrEmpty(update_price_textBox.Text) ? c_Info_obj.price: Convert.ToInt64(update_price_textBox.Text);
            c_Info_obj.stock = string.IsNullOrEmpty(update_stock_textBox.Text) ? c_Info_obj.stock : Convert.ToInt32(update_stock_textBox.Text);
            c_Info_obj.comment = string.IsNullOrEmpty(update_comment_textBox.Text) ? c_Info_obj.comment : update_comment_textBox.Text;
            c_Info_obj.pc_id = string.IsNullOrEmpty(update_category_comboBox.SelectedIndex.ToString()) ? c_Info_obj.pc_id: Convert.ToInt16( update_category_comboBox.SelectedItem);

            c_Dal_obj.update(c_Info_obj);
            c_data_grid_view.DataSource = c_Dal_obj.disp();

            this.Dispose();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

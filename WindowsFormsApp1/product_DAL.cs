using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;// its required for ADO 
using System.Data.SqlClient;
using System.Windows.Forms;


public class product_DAL
{
    SqlConnection cn;
    SqlCommand cm;
    SqlDataAdapter da;
    DataTable dt;
   
    public product_DAL()
    {
        cn = connection.cn;
    }
    public DataTable disp()
    {
        cn.Open();

        cm = new SqlCommand("[dbo].[get_all_product]", cn);  // define a command
        cm.CommandType = CommandType.StoredProcedure;
        cm.CommandText = "get_all_product";
        dt = new DataTable();// define a data table for storing the results of command
        da = new SqlDataAdapter(cm);  //adaptor is defined for executiong the defined command
        da.Fill(dt);   //executes the command and stores the results in a data table
        
        
        cn.Close();  // closing the connection
        return (dt);    // returning the data table

    }


    // inserting the product info
    public void insert(product_info obj1)
    {
        cn.Open();
        cm = new SqlCommand("SELECT dbo.product_stock_check(@pr_id) as productID", cn);
        cm.Parameters.AddWithValue("@pr_id", obj1.pr_id);

        connection.set_connection();
        da = new SqlDataAdapter(cm);
        dt = new DataTable();
        da.Fill(dt);

        int unique = -1;
        foreach (DataRow row in dt.Rows)
        {
            foreach (DataColumn column in dt.Columns)
            {
                unique = (int)row[column];
            }
        }

        if (unique == 1)
        {
            MessageBox.Show("There is already a product with this id!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cn.Close();
            return;
        }
        else
        {
            try
            {
                //insert to customer table
                string query = "insert into product(pr_id, name, date1, price, stock, comment, pc_id) values(@pr_id, @name, @date1, @price, @stock, @comment, @pc_id);";
                cm = new SqlCommand(query, cn);

                cm.Parameters.AddWithValue("@pr_id", obj1.pr_id);
                cm.Parameters.AddWithValue("@name", obj1.name);
                cm.Parameters.AddWithValue("@date1", obj1.date);
                cm.Parameters.AddWithValue("@price", obj1.price);
                cm.Parameters.AddWithValue("@stock", obj1.stock);
                cm.Parameters.AddWithValue("@comment", obj1.comment);
                cm.Parameters.AddWithValue("@pc_id", obj1.pr_id);
                connection.set_connection();
                cm.ExecuteNonQuery();
                MessageBox.Show("! The Check Record was inserted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: ", e);
                throw e;
            }
            finally
            {
                if (cn != null)
                    cn.Close();
            }
        }


    }
    public DataTable search_by_name(string name)
    {
        cn.Open();
        //search customer
        cm = new SqlCommand("select * from product where name=@name", cn);
        cm.Parameters.AddWithValue("@name", name);

        connection.set_connection();
        da = new SqlDataAdapter(cm);
        dt = new DataTable();
        da.Fill(dt);

        cn.Close();
        return (dt);
    }
    public void update(product_info obj)
    {
        cn.Open();

        string updateString = "UPDATE product SET name=@name, date1=@date1, price=@price, stock=@stock, comment=@comment, pc_id=@pc_id WHERE pr_id=@pr_id";
        SqlCommand updateCustomer = new SqlCommand(updateString, cn);
        updateCustomer.Parameters.AddWithValue("@pr_id", obj.pr_id);
        updateCustomer.Parameters.AddWithValue("@name", obj.name);
        updateCustomer.Parameters.AddWithValue("@date1", obj.date);
        updateCustomer.Parameters.AddWithValue("@price", obj.price);
        updateCustomer.Parameters.AddWithValue("@stock", obj.stock);
        updateCustomer.Parameters.AddWithValue("@comment", obj.comment);
        updateCustomer.Parameters.AddWithValue("@pc_id", obj.pc_id);
        updateCustomer.ExecuteNonQuery();
        connection.set_connection();


        MessageBox.Show("! The Check Record was updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        cn.Close();
        return;
    }
    public void delete(product_info obj)
    {
        cn.Open();

        DialogResult result = MessageBox.Show("Are you sure you want to DELETE product?", "Warning!", MessageBoxButtons.YesNo);

        if (result == System.Windows.Forms.DialogResult.Yes)
        {
            string deleteString = "DELETE FROM product WHERE pr_id=@pr_id;";
            SqlCommand deleteCustomer = new SqlCommand(deleteString, cn);
            deleteCustomer.Parameters.AddWithValue("@pr_id", obj.pr_id);
            deleteCustomer.Parameters.AddWithValue("@pc_id", obj.pc_id);
            deleteCustomer.ExecuteNonQuery();
            connection.set_connection();
            MessageBox.Show("! The Check Record was updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            deleteCustomer.Connection.Close();
        }
        cn.Close();
        return;
    }
    
}


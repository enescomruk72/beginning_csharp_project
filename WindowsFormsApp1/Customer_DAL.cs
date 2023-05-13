using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;// its required for ADO 
using System.Data.SqlClient;
using System.Windows.Forms;



public class Customer_DAL
{
    SqlConnection cn;  //to connect to  a database
    SqlCommand cm;
    SqlDataAdapter da;
    DataTable dt;
    public Customer_DAL()
    {
        cn=connection.cn;
    }
    
    //=====================================
    //display the list of customers
    public DataTable disp()
    {
        cn.Open();

        cm = new SqlCommand("[dbo].[get_all_customer]", cn);  // define a command
        cm.CommandType = CommandType.StoredProcedure;
        cm.CommandText = "get_all_customer";
        dt = new DataTable();// define a data table for storing the results of command
        da = new SqlDataAdapter(cm);  //adaptor is defined for executiong the defined command
        da.Fill(dt);   //executes the command and stores the results in a data table


        cn.Close();  // closing the connection
        return (dt);    // returning the data table
    }

    public DataTable disp_tell()
    {
        cn.Open();  // for opening data base
        cm = new SqlCommand("get_all_cutometNameTell", cn);
        cm.CommandType = CommandType.StoredProcedure;
        dt = new DataTable();
        da = new SqlDataAdapter(cm);
        da.Fill(dt);
        cn.Close();
        return (dt);
    }
    public void insert(customer_info obj1)
    {
        cn.Open();
        cm = new SqlCommand("SELECT dbo.customer_existence_check(@cu_id) as customerID", cn);
        cm.Parameters.AddWithValue("@cu_id", obj1.cu_id);

        connection.set_connection();
        da = new SqlDataAdapter(cm);
        dt = new DataTable();
        da.Fill(dt);

        int unique= -1;
        foreach (DataRow row in dt.Rows)
        {
            foreach (DataColumn column in dt.Columns)
            {
                unique = (int)row[column];
            }
        }

        if(unique == 1)
        {
            MessageBox.Show("There is already a customer with this id!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cn.Close();
            return;
        }
        else {
            try
            {
                //insert to customer table
                cm = new SqlCommand("[dbo].[Customer_insert]", cn);
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "Customer_insert";


                cm.Parameters.AddWithValue("@cu_id", obj1.cu_id);
                cm.Parameters.AddWithValue("@name", obj1.name);

                cm.Parameters.AddWithValue("@family", obj1.family);
                cm.Parameters.AddWithValue("@tell", obj1.tell);
                cm.Parameters.AddWithValue("@iban", obj1.iban);
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
        cm = new SqlCommand("search_customer_by_name", cn);
        cm.CommandType = CommandType.StoredProcedure;
        cm.Parameters.AddWithValue("@name", name);
        
        connection.set_connection();
        da = new SqlDataAdapter(cm);
        dt = new DataTable();
        da.Fill(dt);

        cn.Close();
        return (dt);
       
     
    }
    public DataTable search_by_id(int id)
    {

        cn.Open();
        //search customer
        cm = new SqlCommand("search_customer_id", cn);
        cm.CommandType = CommandType.StoredProcedure;
        cm.Parameters.AddWithValue("@cu_id", id);

        connection.set_connection();
        da = new SqlDataAdapter(cm);
        dt = new DataTable();
        da.Fill(dt);

        cn.Close();
        return (dt);


    }
    public DataTable search_by_familly(string family)
    {
        cn.Open();
        //search customer
        cm = new SqlCommand("search_customer_by_family", cn);
        cm.CommandType = CommandType.StoredProcedure;
        cm.Parameters.AddWithValue("@family", family);

        connection.set_connection();
        da = new SqlDataAdapter(cm);
        dt = new DataTable();
        da.Fill(dt);

        cn.Close();
        return (dt);
    }
    public DataTable search_by_iban(string iban)
    {
        cn.Open();
        //search customer
        cm = new SqlCommand("customerSearchIban", cn);
        cm.CommandType = CommandType.StoredProcedure;
        cm.Parameters.AddWithValue("@iban", iban);

        connection.set_connection();
        da = new SqlDataAdapter(cm);
        dt = new DataTable();
        da.Fill(dt);

        cn.Close();
        return (dt);
    }

    public void update(customer_info obj)
    {
        cn.Open();

        string updateString = "UPDATE customer SET name=@newName, family=@newFamily, tell=@newTell, iban=@newIban WHERE cu_id=@urun_id";
        SqlCommand updateCustomer = new SqlCommand(updateString, cn);
        updateCustomer.Parameters.AddWithValue("@urun_id", obj.cu_id);
        updateCustomer.Parameters.AddWithValue("@newName", obj.name);
        updateCustomer.Parameters.AddWithValue("@newFamily", obj.family);
        updateCustomer.Parameters.AddWithValue("@newTell", obj.tell);
        updateCustomer.Parameters.AddWithValue("@newIban", obj.iban);
        updateCustomer.ExecuteNonQuery();
        connection.set_connection();


        MessageBox.Show("! The Check Record was updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        cn.Close();
        return;
    }

    public void delete(customer_info obj)
    {
        cn.Open();

        DialogResult result = MessageBox.Show("Are you sure you want to DELETE customer?", "Warning!", MessageBoxButtons.YesNo);

        if (result == System.Windows.Forms.DialogResult.Yes)
        {
            string updateString = "DELETE FROM customer WHERE cu_id=@cu_id; DELETE FROM factor WHERE cu_id=@cu_id";
            SqlCommand deleteCustomer = new SqlCommand(updateString, cn);
            deleteCustomer.Parameters.AddWithValue("@cu_id", obj.cu_id);
            deleteCustomer.ExecuteNonQuery();
            connection.set_connection();
            MessageBox.Show("! The Check Record was updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            deleteCustomer.Connection.Close();
        }
        cn.Close();
        return;
    }

}


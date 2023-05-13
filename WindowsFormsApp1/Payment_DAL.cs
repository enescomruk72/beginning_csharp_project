using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


public class Payment_DAL
{
    SqlConnection cn;
    SqlCommand cm;
    SqlDataAdapter da;
    DataTable dt;

    public Payment_DAL()
    {
        cn = connection.cn;
    }
    public DataTable disp()
    {

        cm = new SqlCommand("get_all_payments", cn);
        dt = new DataTable();
        da = new SqlDataAdapter(cm);
        da.Fill(dt);
        return (dt);

    }
  /*  public DataTable search_by_cust_id(int cust_id)
    {
        
  
    }  */
    public DataTable search_by_amount(int amount)
    {

        //search PAYMENT
        cm = new SqlCommand("search_payment_by_amount", cn);
        cm.CommandType = CommandType.StoredProcedure;
        cm.Parameters.AddWithValue("@amount", amount);

        connection.set_connection();
        da = new SqlDataAdapter(cm);
        dt = new DataTable();
        da.Fill(dt);
        return (dt);
    }
    public DataTable search_by_date(DateTime dt1)
    {
        
        //search PAYMENT
        cm = new SqlCommand("search_payment_by_date", cn);
        cm.CommandType = CommandType.StoredProcedure;
        cm.Parameters.AddWithValue("@date11", dt1);

        connection.set_connection();
        da = new SqlDataAdapter(cm);
        dt = new DataTable();
        da.Fill(dt);
        return (dt);
    }
}


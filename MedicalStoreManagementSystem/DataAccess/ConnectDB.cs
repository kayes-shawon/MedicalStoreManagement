using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace MedicalStoreManagementSystem.DataAccess
{
    class ConnectDB
    {
        SqlConnection con = new SqlConnection("Server=KAYES-PC\\SQLEXPRESS;Initial Catalog=medicalstoremanagement;Integrated Security=True;");
         
        public void LoadDl(DataGridView _dtv)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string strQuery = "showalldl";
                SqlCommand cmd = new SqlCommand(strQuery, con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                _dtv.DataSource = dt;

            }
            catch (Exception e)
            {

                MessageBox.Show("Error : " + e.Message);
            }
            finally
            {
                con.Close();
            }
            
        }

        public void InsertDl(int id,string name,string address,string number,string medicine)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string strQuery = "Insertdl";
                SqlCommand cmd = new SqlCommand(strQuery, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("id", SqlDbType.Int)).Value = id;
                cmd.Parameters.Add(new SqlParameter("name", SqlDbType.VarChar)).Value = name;
                cmd.Parameters.Add(new SqlParameter("address", SqlDbType.VarChar)).Value = address;
                cmd.Parameters.Add(new SqlParameter("number", SqlDbType.VarChar)).Value = number;
                cmd.Parameters.Add(new SqlParameter("medicine", SqlDbType.VarChar)).Value = medicine;

                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                MessageBox.Show("Error : " + e.Message);
            }
            finally
            {
                con.Close();
            }

        }
        public void UpdateDl(int id, string name, string address, string number, string medicine)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string strQuery = "Updatedl";
                SqlCommand cmd = new SqlCommand(strQuery, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("id", SqlDbType.Int)).Value = id;
                cmd.Parameters.Add(new SqlParameter("name", SqlDbType.VarChar)).Value = name;
                cmd.Parameters.Add(new SqlParameter("address", SqlDbType.VarChar)).Value = address;
                cmd.Parameters.Add(new SqlParameter("number", SqlDbType.VarChar)).Value = number;
                cmd.Parameters.Add(new SqlParameter("medicine", SqlDbType.VarChar)).Value = medicine;

                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                MessageBox.Show("Error : " + e.Message);
            }
            finally
            {
                con.Close();
            }

        }
        public void DeleteDl(int id)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string strQuery = "Deletedl";
                SqlCommand cmd = new SqlCommand(strQuery, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("id", SqlDbType.Int)).Value = id;
                

                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {

                MessageBox.Show("Error : " + e.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }

}

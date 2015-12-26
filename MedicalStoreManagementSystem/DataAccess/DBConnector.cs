using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalStoreManagementSystem.DataAccess
{
    class DBConnector
    {
        SqlConnection con = new SqlConnection("Server=KAYES-PC\\SQLEXPRESS;Initial Catalog=medicalstoremanagement;Integrated Security=True;");

        public void LoadMc(DataGridView _dtm)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string strQuery = "ShowallMc";
                SqlCommand cmd = new SqlCommand(strQuery, con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                _dtm.DataSource = dt;

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

        public void InsertMc(int id, string name, string price, string description)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string strQuery = "InsertMc";
                SqlCommand cmd = new SqlCommand(strQuery, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("id", SqlDbType.Int)).Value = id;
                cmd.Parameters.Add(new SqlParameter("name", SqlDbType.VarChar)).Value = name;
                cmd.Parameters.Add(new SqlParameter("price", SqlDbType.VarChar)).Value = price;
                cmd.Parameters.Add(new SqlParameter("description", SqlDbType.VarChar)).Value = description;
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
        public void UpdateMc(int id, string name, string price, string description)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string strQuery = "UpdateMc";
                SqlCommand cmd = new SqlCommand(strQuery, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("id", SqlDbType.Int)).Value = id;
                cmd.Parameters.Add(new SqlParameter("name", SqlDbType.VarChar)).Value = name;
                cmd.Parameters.Add(new SqlParameter("price", SqlDbType.VarChar)).Value = price;
                cmd.Parameters.Add(new SqlParameter("description", SqlDbType.VarChar)).Value = description;
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
        public void DeleteMc(int id)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string strQuery = "DeleteMc";
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

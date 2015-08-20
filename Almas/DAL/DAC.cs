using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Almas.DAL
{
    // try to make a file for save database log
    class DAC
    {
        SqlConnection conn = new SqlConnection("Server=localhost;Integrated Security=True;Database=almas");

        public void connect()
        {
            conn.Open();
        }

        public void disconnect()
        {
            conn.Close();
        }

        public string Do_Command_Execute_None(string sql,bool ShowMessageBox)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            string res = comm.ExecuteNonQuery().ToString();
            conn.Close();
            if (ShowMessageBox)
            {
                if (res == "1")
                {
                    extramessage_frm.Show("عملیات ثبت اطلاعات با موفقیت انجام شد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    extramessage_frm.Show("عملیات ثبت اطلاعات با مشکل روبه رو شد ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return res;
        }

        public string Do_Command_Execute_Scaler(string sql)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            string res = comm.ExecuteScalar().ToString();
            conn.Close();
            return res;
        }

        public DataTable Do_Table(SqlDataAdapter sda)
        {
            conn.Open();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            return dt;
        }

        public SqlDataAdapter Do_Sql_Adapter(string sql)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sql,conn);
            return sda;
        }

        public bool insert_picture_2DB(string code,byte[] image_byte)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand("insert into image (code,image)values(@code,@img)", conn);
            comm.Parameters.Add("@code", SqlDbType.BigInt).Value = code;
            comm.Parameters.Add("@img", SqlDbType.VarBinary).Value = image_byte;
            string res = comm.ExecuteNonQuery().ToString();
            conn.Close();
             return (res == "1") ? true : false;       
        }
    }
}

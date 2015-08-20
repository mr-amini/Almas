using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using Klik.Windows.Forms.v1.EntryLib;
using System.Data;


namespace Almas.BLL
{
    class cleark
    {
        DAL.DAC _DA = new DAL.DAC();
        public bool Exist(string code)
        {
            int count = int.Parse(_DA.Do_Command_Execute_Scaler("select COUNT(n_code) from clerk where n_code='" + code + "'").ToString());

            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Insert(string code, string name, string family, string f_name, string n_code, string sh_num, byte sex, string bith_date, string relation, string military, string education, string religion_pri, string religion_sec, string united, string city, string address, string tell,  string mobile ,string salary , string pay_time, string overtime,byte insurance, string start_work, string end_work, string disease)
        {
            string res = _DA.Do_Command_Execute_None("insert into clerk values('" + code.Trim() + "','" + name.Trim() + "','" + family.Trim() + "','" + f_name.Trim() +
                         "','" + n_code +  "','" + sh_num + "','" + sex + "','" + bith_date + "','" + relation + "','" + military +
                         "','" + education + "','" + religion_pri + "','" + religion_sec + "','" + united + "','" + city +
                         "','" + address.Trim() + "','" + tell.Trim() + "','" + mobile + "','" + salary + "','" + pay_time + "','" + overtime + 
                         "','" + insurance + "','" + start_work + "','" + end_work + "','" + disease + "')",true);
            return res == "1" ? true : false;
        }

        public DataTable ShowDataGridView()
        {
            DataTable Dt_Source = new DataTable();
            Dt_Source = _DA.Do_Table(_DA.Do_Sql_Adapter("select * from clerk"));
            DataTable Dt_Final = Dt_Source.Clone();
            DataRow DT_Row;

            Dt_Final.Columns[6].DataType = typeof(string);
            foreach (DataRow item in Dt_Source.Rows)
            {
                DT_Row = item;
                DT_Row[6] = item[6].ToString() == "True" ? "Man" : "Women";
            }
            return Dt_Final;
        }
    }
}

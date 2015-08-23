using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Klik.Windows.Forms.v1.EntryLib;

namespace Almas.BLL
{
    class public_class
    {
        DAL.DAC DA = new DAL.DAC();
        
        public DataTable EducationCombobox()
        {
            return  DA.Do_Table(DA.Do_Sql_Adapter("select ID,name from education"));
        }

        public DataTable Religion_pri()
        {
            return DA.Do_Table(DA.Do_Sql_Adapter("select ID,name from religion_pri"));
        }

        public DataTable Religion_sec(int Religion_pri_code)
        {
            return DA.Do_Table(DA.Do_Sql_Adapter("select ID,name from religion_sec where religion_pri_code ="+ Religion_pri_code +""));
        }

        public DataTable United()
        {
            return DA.Do_Table(DA.Do_Sql_Adapter("select ID,name from united "));
        }

        public DataTable City(int United_code)
        {
            return DA.Do_Table(DA.Do_Sql_Adapter("select ID,name from city where united_code =" + United_code + ""));
        }

        public DataTable Illness()
        {
            return DA.Do_Table(DA.Do_Sql_Adapter("select ID,name from illness"));
        }

        public string Create_Personal_Code()
        {
            string clerk_code = DA.Do_Command_Execute_Scaler("select MAX(code) from clerk").ToString();
            string worker_code = DA.Do_Command_Execute_Scaler("select MAX(code) from worker").ToString();

            clerk_code = clerk_code == "" ? "0" : clerk_code;
            worker_code = worker_code == "" ? "0" : worker_code;

            if (int.Parse(worker_code) == 0 && int.Parse(clerk_code) == 0)
            {
                return (100001).ToString();
            }
            else if (int.Parse(worker_code) > int.Parse(clerk_code))
            {
                return (int.Parse(worker_code) + 1).ToString();
            }
            else
            {
                return (int.Parse(clerk_code) + 1).ToString();
            }
        }

        public ValidationStyle Mask_Format_Style(string mask)
        {
            ValidationStyle vs = new ValidationStyle();
            MaskValidationStyle msk = new MaskValidationStyle();
            msk.Mask = mask;
            vs.ValidationType = ValidationTypes.Mask;
            vs.MaskValidationStyle = msk;
            return vs;
        }

        public ValidationStyle Mask_Format_ReadOnly()
        {
            ValidationStyle vs = new ValidationStyle();
            vs.ReadOnly = true;
            return vs;
        }

        public ValidationStyle Mask_Format_String()
        {
            ValidationStyle vs = new ValidationStyle();
            StringValidationStyle svs = new StringValidationStyle();
            svs.InvalidCharacters = "1,2,3,4,5,6,7,8,9,0,\\,/,?,.,!,@,#,$,%,^,&,*,(,),-,_,=,+,',;,:,`,~";
            vs.StringValidationStyle = svs;
            return vs;
        }

        public ValidationStyle Mask_Format_String_Address()
        {
            ValidationStyle vs = new ValidationStyle();
            vs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            vs.MaxLength = 300;
            vs.Multiline = true;
            return vs;
        }

        public string Fetch_Checked_Item(ELListBoxItemCollection obj)
        {
            string disease = ",";
            foreach (ELListBoxItem item in obj)
            {
                disease += item.Key + ",,";
            }
            return disease;
        }

    }
}

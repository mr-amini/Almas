using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Klik.Windows.Forms.v1.EntryLib;

namespace Almas
{
    public partial class Clerk_Show : Form
    {

        BLL.public_class _PublicClass = new BLL.public_class();
        DAL.DAC _DA = new DAL.DAC();
        //use modalbox for show richepanel
        ELModalBox Modal1 = new ELModalBox();
        ELModalBox Modal2 = new ELModalBox();

        public Clerk_Show()
        {
            InitializeComponent();
            // this wrote for time_picker_ Click event
            time_picker1.TimePickerClicked += OnButtonsClicked;
            //fill DataGridView and write Qty of row 
            DataGridView1.AutoGenerateColumns = false;
            DataGridView1.DataSource = _DA.Do_Table(_DA.Do_Sql_Adapter("SELECT * FROM clerk"));
            elLabel1.Text = "تعداد سطرها :" + "     " + DataGridView1.Rows.Count.ToString();
            //---------

            //set read only for enterybox in richpanel4 // for date value 
            foreach (Control item in elRichPanel4.Controls)
            {
                if (item is ELEntryBox)
                {
                    (item as ELEntryBox).ValidationStyle = _PublicClass.Mask_Format_ReadOnly();
                }
            }
            //set read only for enterybox in richpanel5 // for date value 
            foreach (Control item in elRichPanel5.Controls)
            {
                if (item is ELEntryBox)
                {
                    (item as ELEntryBox).ValidationStyle = _PublicClass.Mask_Format_ReadOnly();
                }
            }


            // add information of education on combobox 
            foreach (DataRow item in _PublicClass.EducationCombobox().Rows)
            {
                ELListBoxItem ExItem = new ELListBoxItem();
                ExItem.Key = item[0];
                ExItem.Value = item[1];
                education_combo.Items.Add(ExItem);
            }
            // add information of religion on combobox 
            foreach (DataRow item in _PublicClass.Religion_pri().Rows)
            {
                ELListBoxItem ExItem = new ELListBoxItem();
                ExItem.Key = item[0];
                ExItem.Value = item[1];
                religion_pri_combo.Items.Add(ExItem);
            }
            // add information of uniteds on combobox 
            foreach (DataRow item in _PublicClass.United().Rows)
            {
                ELListBoxItem ExItem = new ELListBoxItem();
                ExItem.Key = item[0];
                ExItem.Value = item[1];
                united_combo.Items.Add(ExItem);
            }
            // add information of illness on combobox 
            foreach (DataRow item in _PublicClass.Illness().Rows)
            {
                ELListBoxItem ExItem = new ELListBoxItem();
                ExItem.Key = item[0];
                ExItem.Value = item[1];
                illness_combo.Items.Add(ExItem);
            }

            //set mask to special entrybox
            //personalization code
            personal_code_txt.ValidationStyle = _PublicClass.Mask_Format_Style("000000");
            //nation code
            nCode_txt.ValidationStyle = _PublicClass.Mask_Format_Style("0000000000");
            //shenasname code
            sh_sh_txt.ValidationStyle = _PublicClass.Mask_Format_Style("0000000000");
            //bithday date
            birth_txt.ValidationStyle = _PublicClass.Mask_Format_ReadOnly();
            //address 
            address_txt.ValidationStyle = _PublicClass.Mask_Format_String_Address();
            //mobile number
            mobile_txt.ValidationStyle = _PublicClass.Mask_Format_Style("\\0\\9000000000");
            //data of pay salary
            pay_time_txt.ValidationStyle = _PublicClass.Mask_Format_ReadOnly();
            //start job
            start_work_txt.ValidationStyle = _PublicClass.Mask_Format_ReadOnly();
            //end job
            end_work_txt.ValidationStyle = _PublicClass.Mask_Format_ReadOnly();

            //set string mask for all of string entrybox
            name_txt.ValidationStyle = _PublicClass.Mask_Format_String();
            family_txt.ValidationStyle = _PublicClass.Mask_Format_String();
            father_txt.ValidationStyle = _PublicClass.Mask_Format_String();
        }

        private void OnButtonsClicked(object sender, EventArgs e)
        {
            (which_Button as ELEntryBox).Value = time_picker1.GetTime();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //when user click on first column then show all of clerk information
            if (e.ColumnIndex == 0)
            {
                MessageBox.Show("");
            }
        }

        private void elButton3_Click(object sender, EventArgs e)
        {
            // show richpanel2  with modalbox
            Modal1.Show(this, elRichPanel2);
        }

        private void elButton1_Click(object sender, EventArgs e)
        {
            
            Modal2.Show(elRichPanel2, elRichPanel3);
        }

        private void elButton2_Click(object sender, EventArgs e)
        {
            Modal2.Show(elRichPanel2, elRichPanel4);
        }

        private void elButton4_Click(object sender, EventArgs e)
        {
            Modal2.Show(elRichPanel2, elRichPanel5);
        }

        private void elButton5_Click(object sender, EventArgs e)
        {
            Modal2.Show(elRichPanel2, elRichPanel6);
        }


        /// when user enter value and press 'emaal taghyirat' on small Richpanel this function run and check value and send to main Richpanel
        public void Small_RichPanel_Send_Data(object radio_1, object radio_2, object radio_3, object radio_4, object txt_1, object txt_2, object txt_3, object txt_4, object txt_5, object txt)
        {
            bool check_right_value = false;
            if ((radio_1 as ELRadioButton).Checked == true && (txt_1 as ELEntryBox).Value.ToString().Trim() != "")
            {
                (txt as ELEntryBox).Value = (txt_1 as ELEntryBox).Value; check_right_value = true;
            }
            else if ((radio_2 as ELRadioButton).Checked == true && (txt_2 as ELEntryBox).Value.ToString().Trim() != "")
            {
                (txt as ELEntryBox).Value = (txt_2 as ELEntryBox).Value; check_right_value = true;
            }
            else if ((radio_3 as ELRadioButton).Checked == true && (txt_3 as ELEntryBox).Value.ToString().Trim() != "")
            {
                (txt as ELEntryBox).Value = (txt_3 as ELEntryBox).Value; check_right_value = true;
            }
            else if ((radio_4 as ELRadioButton).Checked == true && (txt_4 as ELEntryBox).Value.ToString().Trim() != "" && (txt_5 as ELEntryBox).Value.ToString().Trim() != "" )
            {
                if ((txt_4 as ELEntryBox).Tag == null)
                {
                    if(int.Parse((txt_4 as ELEntryBox).Value.ToString()) < int.Parse((txt_5 as ELEntryBox).Value.ToString()))
                    {
                        (txt as ELEntryBox).Value = (txt_4 as ELEntryBox).Value + " تا " + (txt_5 as ELEntryBox).Value; check_right_value = true;
                    }
                }
                else
                {
                    if (DateTime.Parse((txt_4 as ELEntryBox).Value.ToString()) < DateTime.Parse((txt_5 as ELEntryBox).Value.ToString()))
                    {
                        (txt as ELEntryBox).Value = (txt_4 as ELEntryBox).Value + " تا " + (txt_5 as ELEntryBox).Value; check_right_value = true;
                    }
                }

            }
            if (!check_right_value)
            {
                (txt as ELEntryBox).Value = "";
                extramessage_frm.Show("مقادیر وارد شده درست نمی باشد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Modal2.Close();
            }
        }

        //====================================================================================================
        //                   ***       Start ++ All OF Code About Salary         ***
        //====================================================================================================

        public void Salary_Enable_Txt(object sender_1, object sender_2)
        {
            foreach (Control item in elRichPanel3.Controls)
            {
                if (item is ELEntryBox)
                {
                    item.Enabled = false; (item as ELEntryBox).Value = "";
                }
            }
            (sender_1 as ELEntryBox).Enabled = true;
            (sender_2 as ELEntryBox).Enabled = true;
        }

        private void salary_radio_1_CheckedChanged(object sender, EventArgs e)
        {
            if (salary_radio_1.Checked == true)
                Salary_Enable_Txt(salary_txt_1, salary_txt_1);
        }

        private void salary_radio_2_CheckedChanged(object sender, EventArgs e)
        {
            if (salary_radio_2.Checked == true)
                Salary_Enable_Txt(salary_txt_2, salary_txt_2);
        }

        private void salary_radio_3_CheckedChanged(object sender, EventArgs e)
        {
            if (salary_radio_3.Checked == true)
                Salary_Enable_Txt(salary_txt_3, salary_txt_3);
        }

        private void salary_radio_4_CheckedChanged(object sender, EventArgs e)
        {
            if (salary_radio_4.Checked == true)
                Salary_Enable_Txt(salary_txt_4, salary_txt_5);
        }

        private void elRichPanel3_FooterButtonClick(object sender, Klik.Windows.Forms.v1.Common.HeaderButtonClickEventArgs e)
        {
            Small_RichPanel_Send_Data(salary_radio_1, salary_radio_2, salary_radio_3, salary_radio_4, salary_txt_1, salary_txt_2, salary_txt_3, salary_txt_4, salary_txt_5, salary_txt);
        }

        //===================================================================================================
        //                    ***    End ++ All Of Code About Salary     ***
        //===================================================================================================


        //====================================================================================================
        //                   ***       Start ++ All OF Code About Overtime         ***
        //====================================================================================================
        //--- when user click on radio button some entry box disable and enable
        public void OverTime_Enable_Txt(object sender_1,object sender_2)
        {
            foreach (Control item in elRichPanel6.Controls)
            {
                if (item is ELEntryBox)
                {
                    item.Enabled = false; (item as ELEntryBox).Value = "";
                }
            }
            (sender_1 as ELEntryBox).Enabled = true;
            (sender_2 as ELEntryBox).Enabled = true;
        }

        private void overtime_radio_1_CheckedChanged(object sender, EventArgs e)
        {
            if (overtime_radio_1.Checked == true)
                OverTime_Enable_Txt(overtime_txt_1, overtime_txt_1);
        }

        private void overtime_radio_2_CheckedChanged(object sender, EventArgs e)
        {
            if (overtime_radio_2.Checked == true)
                OverTime_Enable_Txt(overtime_txt_2, overtime_txt_2);
        }

        private void overtime_radio_3_CheckedChanged(object sender, EventArgs e)
        {
            if (overtime_radio_3.Checked == true)
                OverTime_Enable_Txt(overtime_txt_3, overtime_txt_3);
        }

        private void overtime_radio_4_CheckedChanged(object sender, EventArgs e)
        {
            if (overtime_radio_4.Checked == true)
                OverTime_Enable_Txt(overtime_txt_4, overtime_txt_5);
        }

        private void elRichPanel6_FooterButtonClick(object sender, Klik.Windows.Forms.v1.Common.HeaderButtonClickEventArgs e)
        {
            Small_RichPanel_Send_Data(overtime_radio_1, overtime_radio_2, overtime_radio_3, overtime_radio_4, overtime_txt_1, overtime_txt_2, overtime_txt_3, overtime_txt_4, overtime_txt_5, overtime_txt);
        }

        //===================================================================================================
        //                    ***    End ++ All Of Code About Overtime     ***
        //===================================================================================================

        object which_Button;
        //====================================================================================================
        //                   ***       Start ++ All OF Code About Pay Time         ***
        //====================================================================================================

        public void Pay_Time_Enable_Txt(object sender_1, object sender_2)
        {
            foreach (Control item in elRichPanel5.Controls)
            {
                if (item is ELEntryBox)
                {
                    item.Enabled = false; (item as ELEntryBox).Value = "";
                }
            }
            (sender_1 as ELEntryBox).Enabled = true;
            (sender_2 as ELEntryBox).Enabled = true;
        }

        private void elEntryBox35_ButtonClick(object sender, ELEntryBoxButtonClickEventArgs e)
        {
            which_Button = sender;
        }

        private void payTime_radio_1_CheckedChanged(object sender, EventArgs e)
        {
            if (payTime_radio_1.Checked == true)
                Pay_Time_Enable_Txt(payTime_txt_1, payTime_txt_1);
        }

        private void payTime_radio_2_CheckedChanged(object sender, EventArgs e)
        {
            if (payTime_radio_2.Checked == true)
                Pay_Time_Enable_Txt(payTime_txt_2, payTime_txt_2);
        }

        private void payTime_radio_3_CheckedChanged(object sender, EventArgs e)
        {
            if (payTime_radio_3.Checked == true)
                Pay_Time_Enable_Txt(payTime_txt_3, payTime_txt_3);
        }

        private void payTime_radio_4_CheckedChanged(object sender, EventArgs e)
        {
            if (payTime_radio_4.Checked == true)
                Pay_Time_Enable_Txt(payTime_txt_4, payTime_txt_5);
        }

        private void elRichPanel5_FooterButtonClick(object sender, Klik.Windows.Forms.v1.Common.HeaderButtonClickEventArgs e)
        {
            Small_RichPanel_Send_Data(payTime_radio_1, payTime_radio_2, payTime_radio_3, payTime_radio_4, payTime_txt_1, payTime_txt_2, payTime_txt_3, payTime_txt_4, payTime_txt_5, pay_time_txt);
        }

        //===================================================================================================
        //                    ***    End ++ All Of Code About Pay Time     ***
        //===================================================================================================


        //====================================================================================================
        //                   ***       Start ++ All OF Code About Pay Time         ***
        //====================================================================================================


        public void Birth_Enable_Txt(object sender_1, object sender_2)
        {
            foreach (Control item in elRichPanel4.Controls)
            {
                if (item is ELEntryBox)
                {
                    item.Enabled = false; (item as ELEntryBox).Value = "";
                }
            }
            (sender_1 as ELEntryBox).Enabled = true;
            (sender_2 as ELEntryBox).Enabled = true;
        }

        private void elEntryBox33_ButtonClick(object sender, ELEntryBoxButtonClickEventArgs e)
        {
            which_Button = sender;
        }

        private void elRichPanel4_FooterButtonClick(object sender, Klik.Windows.Forms.v1.Common.HeaderButtonClickEventArgs e)
        {
            Small_RichPanel_Send_Data(birth_radio_1, birth_radio_2, birth_radio_3, birth_radio_4, birth_txt_1, birth_txt_2, birth_txt_3, birth_txt_4, birth_txt_5, birth_txt);
        }

        private void birth_radio_1_CheckedChanged(object sender, EventArgs e)
        {
            if (birth_radio_1.Checked == true)
                Birth_Enable_Txt(birth_txt_1, birth_txt_1);
        }

        private void birth_radio_2_CheckedChanged(object sender, EventArgs e)
        {
            if (birth_radio_2.Checked == true)
                Birth_Enable_Txt(birth_txt_2, birth_txt_2);
        }

        private void birth_radio_3_CheckedChanged(object sender, EventArgs e)
        {
            if (birth_radio_3.Checked == true)
                Birth_Enable_Txt(birth_txt_3, birth_txt_3);
        }

        private void birth_radio_4_CheckedChanged(object sender, EventArgs e)
        {
            if (birth_radio_4.Checked == true)
                Birth_Enable_Txt(birth_txt_4, birth_txt_5);
        }


        //===================================================================================================
        //                    ***    End ++ All Of Code About Overtime     ***
        //===================================================================================================

        //--------------- < Set numeric style to some entrybox > ---------------
        
        private void overtime_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.KeyChar = (char)Keys.None;
            }
        }


        private void salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.KeyChar = (char)Keys.None;
            }
        }

        private void tell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.KeyChar = (char)Keys.None;
            }
        }

        private void sh_sh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.KeyChar = (char)Keys.None;
            }
        }

        private void overtime_txt_4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.KeyChar = (char)Keys.None;
            }
        }

        private void salary_txt_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.KeyChar = (char)Keys.None;
            }
        }

        //-----------------------------------<>--------------------------------------

        // this function choose right date for any entrybox e.x ===> pay time or birth day
        private void monthCalendarX1_SelectedDateChanged(DateTime selectedDateTime, BehComponents.PersianDateTime selectedPersianDateTime)
        {
            if ((which_Button as ELEntryBox).Tag != null)
            {
                (which_Button as ELEntryBox).Value = monthCalendarX1.GetSelectedDateInPersianDateTime().ToShortDateString().ToString();
            }
            else
            {
                (which_Button as ELEntryBox).Value = monthCalendarX1.GetSelectedDateInPersianDateTime().Day.ToString();
            }
        }

        // enter sub religion to combobox
        private void religion_pri_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            religion_sec_combo.Items.Clear();
            foreach (DataRow item in _PublicClass.Religion_sec(((int)religion_pri_combo.SelectedKey)).Rows)
            {
                ELListBoxItem NewItem = new ELListBoxItem();
                NewItem.Key = item[0];
                NewItem.Value = item[1];
                religion_sec_combo.Items.Add(NewItem);
            }
        }

        // enter sub city to combobox
        private void united_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            city_combo.Items.Clear();
            foreach (DataRow item in _PublicClass.City(((int)united_combo.SelectedKey)).Rows)
            {
                ELListBoxItem NewItem = new ELListBoxItem();
                NewItem.Key = item[0];
                NewItem.Value = item[1];
                city_combo.Items.Add(NewItem);
            }
        }

        //related to time picker and add time to start work or end work
        private void start_work_txt_ButtonClick(object sender, ELEntryBoxButtonClickEventArgs e)
        {
            which_Button = sender;
            if ((string)(which_Button as ELEntryBox).Value != "")
            {
                time_picker1.SetTime((which_Button as ELEntryBox).Value.ToString());
            }
        }

        private object Find_Like_Checkbox(string entry_tag)
        {
            object res = null;
            switch (entry_tag)
            {
                case "name":
                    res = name_LIKE;
                    break;
                case "family":
                    res = family_LIKE;
                    break;
                case "f_name":
                    res = father_LIKE;
                    break;
                case "n_code":
                    res = nCode_LIKE;
                    break;
                case "sh_num":
                    res = sh_sh_LIKE;
                    break;
                case "tell":
                    res = tell_LIKE;
                    break;
                case "address":
                    res = address_LIKE;
                    break;
            }
            return res;
        }

        //======================================================
        //        START ===>      Main Search
        //------------------------------------------------------
        private void elButton6_Click(object sender, EventArgs e) //main function
        {
            string SearchString = "";

            foreach (Control item in elRichPanel2.Controls)
            {
                string value;
                string tag;
                
                if (item is ELEntryBox)
                {
                    tag = (item as ELEntryBox).Tag.ToString();
                    value = (item as ELEntryBox).Value.ToString().Trim();
                    if ((tag == "salary" && value != "") || (tag == "birth" && value != "") || (tag == "pay_time" && value != "") || (tag == "overtime" && value != ""))
                    {
                        SearchString += Check_EntryBox_In_RichPanel(tag);
                    }
                    else
                    {
                        SearchString += Check_EntryBox_Out_RichPanel(item);
                    }
                }
                else if (item is ELComboBox)
                {
                    if ((item as ELComboBox).SelectedIndex != -1 && (item as ELComboBox).Tag.ToString() != "illness")
                    {
                        tag = (item as ELComboBox).Tag.ToString();
                        value = (item as ELComboBox).SelectedKey.ToString().Trim();
                        SearchString += tag + " = '" + value + "' AND ";
                    }
                    else if ((item as ELComboBox).SelectedIndex != -1 && (item as ELComboBox).Tag.ToString() == "illness")
                    {
                        string Query = "";
                        Query = _PublicClass.Fetch_Checked_Item(illness_combo.CheckedItems);
                        Query = Query.Replace(",,", ",%");
                        SearchString += "illness LIKE '%" + Query + "' AND ";
                    }
                    
                }
                else if (item is ELRadioButton)
                {
                    if (man_radio.Checked == true)
                    {
                        SearchString += "sex ='True' AND ";
                    }
                    else if(woman_radio.Checked == true)
                    {
                        SearchString += "sex ='False' AND ";
                    }
                }
                else if (item is ELCheckBox)
                {
                    if (insurance_checkbox.Checked == true)
                        SearchString += "insurance ='True' AND ";
                }
            }

            if (SearchString == "")
            {
                SearchString = "SELECT * FROM clerk";
            }
            else
            {
                SearchString = SearchString.Remove(SearchString.Length - 4, 4);
                SearchString = "SELECT * FROM clerk WHERE " + SearchString;
            }
            DataGridView1.DataSource = _DA.Do_Table(_DA.Do_Sql_Adapter(SearchString));
            elLabel1.Text = "تعداد سطرها :" + "     " + DataGridView1.Rows.Count.ToString();
            Modal1.Close();
        }

        //sub qurey for searching filled enterybox
        //without birth day salary and pay time and overtime and start work and end work
        public string Check_EntryBox_Out_RichPanel(object sender) 
        {
            string res = "";
            if ((sender as ELEntryBox).Value.ToString().Trim() != "" && (sender as ELEntryBox).Tag.ToString() != "mobile")
            {
                if ((Find_Like_Checkbox((sender as ELEntryBox).Tag.ToString()) as ELCheckBox).Checked == true)
                {
                    res = (sender as ELEntryBox).Tag + " LIKE '%" + (sender as ELEntryBox).Value + "%' AND ";
                }
                else
                {
                    res = (sender as ELEntryBox).Tag + " = '" + (sender as ELEntryBox).Value + "' AND ";
                }
            }
            else if ((sender as ELEntryBox).Value.ToString().Trim() != "09" && (sender as ELEntryBox).Tag.ToString() == "mobile")
            {
                if (mobile_LIKE.Checked == true)
                {
                    res = "mobile LIKE '%" + (sender as ELEntryBox).Value + "%' AND ";
                }
                else
                {
                    res = "mobile = '" + (sender as ELEntryBox).Value + "' AND ";
                }
            }

            return res;
        }

        //this is function for enterybox with richpanel // that profissional panel 
        public string Check_EntryBox_In_RichPanel(string tag)
        {
            string res = "";

            switch (tag)
            {
                case "birth":

                    if (birth_radio_1.Checked == true)
                    {
                        res = "birth_date = '" + birth_txt_1.Value + "' AND ";
                    }
                    else if (birth_radio_2.Checked == true)
                    {
                        res = "birth_date > '" + birth_txt_2.Value + "' AND ";
                    }
                    else if (birth_radio_3.Checked == true)
                    {
                        res = "birth_date < '" + birth_txt_3.Value + "' AND ";
                    }
                    else if (birth_radio_4.Checked == true)
                    {
                        res = "(birth_date > '" + birth_txt_4.Value + "' AND birth_date < '" + birth_txt_5.Value + "') AND ";
                    }

                    break;

                case "salary":

                    if (salary_radio_1.Checked == true)
                    {
                        res = "salary = '" + salary_txt_1.Value + "' AND ";
                    }
                    else if (salary_radio_2.Checked == true)
                    {
                        res = "salary > '" + salary_txt_2.Value + "' AND ";
                    }
                    else if (salary_radio_3.Checked == true)
                    {
                        res = "salary < '" + salary_txt_3.Value + "' AND ";
                    }
                    else if (salary_radio_4.Checked == true)
                    {
                        res = "(salary > '" + salary_txt_4.Value + "' AND salary < '" + salary_txt_5.Value + "') AND ";
                    }

                    break;

                case "overtime":

                    if (overtime_radio_1.Checked == true)
                    {
                        res = "overtime = '" + overtime_txt_1.Value + "' AND ";
                    }
                    else if (overtime_radio_2.Checked == true)
                    {
                        res = "overtime > '" + overtime_txt_2.Value + "' AND ";
                    }
                    else if (overtime_radio_3.Checked == true)
                    {
                        res = "overtime < '" + overtime_txt_3.Value + "' AND ";
                    }
                    else if (overtime_radio_4.Checked == true)
                    {
                        res = "(overtime > '" + overtime_txt_4.Value + "' AND overtime < '" + overtime_txt_5.Value + "') AND ";
                    }

                    break;

                case "pay_time":

                    if (payTime_radio_1.Checked == true)
                    {
                        res = "pay_time = '" + payTime_txt_1.Value + "' AND ";
                    }
                    else if (payTime_radio_2.Checked == true)
                    {
                        res = "pay_time > '" + payTime_txt_2.Value + "' AND ";
                    }
                    else if (payTime_radio_3.Checked == true)
                    {
                        res = "pay_time < '" + payTime_txt_3.Value + "' AND ";
                    }
                    else if (payTime_radio_4.Checked == true)
                    {
                        res = "(pay_time > '" + payTime_txt_4.Value + "' AND pay_time < '" + payTime_txt_5.Value + "') AND ";
                    }

                    break;
            }


            return res;
        }

        //======================================================
        //        END ===>      Main Search
        //------------------------------------------------------

    }
}




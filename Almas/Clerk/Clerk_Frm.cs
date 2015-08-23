using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Collections;
using Klik.Windows.Forms.v1.EntryLib;

namespace Almas
{
    public partial class Clerk : Form
    {
        BLL.public_class _PublicClass = new BLL.public_class();
        public Clerk()
        {
            InitializeComponent();
            time_picker1.TimePickerClicked += OnButtonsClicked;
            
            // add information of education on combobox 
            foreach (DataRow item in _PublicClass.EducationCombobox().Rows)
            {
                    ELListBoxItem ExItem = new ELListBoxItem();
                    ExItem.Key = item[0];
                    ExItem.Value = item[1];
                    elEntryBox10.Items.Add(ExItem);
            }
            // add information of religion on combobox 
            foreach (DataRow item in _PublicClass.Religion_pri().Rows)
            {
                ELListBoxItem ExItem = new ELListBoxItem();
                ExItem.Key = item[0];
                ExItem.Value = item[1];
                elEntryBox11.Items.Add(ExItem);
            }
            // add information of uniteds on combobox 
            foreach (DataRow item in _PublicClass.United().Rows)
            {
                ELListBoxItem ExItem = new ELListBoxItem();
                ExItem.Key = item[0];
                ExItem.Value = item[1];
                elEntryBox13.Items.Add(ExItem);
            }
            // add information of illness on combobox 
            foreach (DataRow item in _PublicClass.Illness().Rows)
            {
                ELListBoxItem ExItem = new ELListBoxItem();
                ExItem.Key = item[0];
                ExItem.Value = item[1];
                elEntryBox23.Items.Add(ExItem);
            }
            //set mask to special entrybox
            //personalization code
            elEntryBox1.ValidationStyle = _PublicClass.Mask_Format_Style("000000");
            //nation code
            elEntryBox5.ValidationStyle = _PublicClass.Mask_Format_Style("0000000000");
            //shenasname code
            elEntryBox6.ValidationStyle = _PublicClass.Mask_Format_Style("0000000000");
            //bithday date
            elEntryBox7.ValidationStyle = _PublicClass.Mask_Format_ReadOnly();
            //address 
            elEntryBox15.ValidationStyle = _PublicClass.Mask_Format_String_Address();
            //mobile number
            elEntryBox17.ValidationStyle = _PublicClass.Mask_Format_Style("\\0\\9000000000");
            //data of pay salary
            elEntryBox19.ValidationStyle = _PublicClass.Mask_Format_ReadOnly();
            //start job
            elEntryBox21.ValidationStyle = _PublicClass.Mask_Format_ReadOnly();
            //end job
            elEntryBox22.ValidationStyle = _PublicClass.Mask_Format_ReadOnly();

            //set string mask for all of string entrybox
            elEntryBox2.ValidationStyle = _PublicClass.Mask_Format_String();
            elEntryBox3.ValidationStyle = _PublicClass.Mask_Format_String();
            elEntryBox4.ValidationStyle = _PublicClass.Mask_Format_String();
        }

        private void elEntryBox19_ButtonClick(object sender, ELEntryBoxButtonClickEventArgs e)
        {
            Which_Button = sender;
        }

        private void elEntryBox7_ButtonClick(object sender, ELEntryBoxButtonClickEventArgs e)
        {
            Which_Button = sender;
        }
        //show calendar in under the entrybox 
        private void monthCalendarX1_SelectedDateChanged(DateTime selectedDateTime, BehComponents.PersianDateTime selectedPersianDateTime)
        {
            if (!((Which_Button as ELEntryBox).Tag.ToString() == "day"))
            {
                (Which_Button as ELEntryBox).Value = monthCalendarX1.GetSelectedDateInPersianDateTime().ToShortDateString();
            }
            else
            {
                (Which_Button as ELEntryBox).Value = monthCalendarX1.GetSelectedDateInPersianDateTime().Day.ToString();
            }
        }

        //open dialog box and show image in picturebox
        private void elButton4_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog OpenFile = new OpenFileDialog();
                OpenFile.ShowDialog();
                pictureBox1.Image = Image.FromFile(OpenFile.FileName);
            }
            catch {}
        }

        private void elButton5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Almas.Properties.Resources.user;
        }

        private void elButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //check empty entrybox for saveing data to db
        public bool Check_Empty_Entrybox()
        {
            bool empty_check = true;
            foreach (Control item in elRichPanel1.Controls)
            {
                if (item is ELEntryBox)
                {
                    empty_check = (item as ELEntryBox).Value.ToString().Trim().ToString() == "" ? false : true;
                }
                else if (item is ELComboBox)
                {
                    empty_check = (item as ELComboBox).SelectedIndex == -1 ? false : true;
                }

                if (!empty_check)
                    break;
            }
            if (empty_check) { empty_check = (elRadioButton1.Checked == true || elRadioButton2.Checked == true) ? true : false; }
            if (empty_check == false)
            {
                extramessage_frm.Show("لطفا اطلاعات را به طور کامل وارد نمایید", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return empty_check;
        }

        //{this function related to time picker 
        object Which_Button;
        private void elEntryBox21_ButtonClick(object sender, ELEntryBoxButtonClickEventArgs e)
        {
            Which_Button = sender;
            if ((string)(Which_Button as ELEntryBox).Value != "")
            {
                time_picker1.SetTime((Which_Button as ELEntryBox).Value.ToString());
            }
        }
        
        private void OnButtonsClicked(object sender, EventArgs e)
        {
            (Which_Button as ELEntryBox).Value = time_picker1.GetTime();
        }
        //}

        //when user choose a religion_pri this Function fill religion sub data in religion_sec combobox
        private void elEntryBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (elEntryBox11.SelectedKey != null)
            {
                elEntryBox12.Items.Clear();
                foreach (DataRow item in _PublicClass.Religion_sec(((int)elEntryBox11.SelectedKey)).Rows)
                {
                    ELListBoxItem NewItem = new ELListBoxItem();
                    NewItem.Key = item[0];
                    NewItem.Value = item[1];
                    elEntryBox12.Items.Add(NewItem);
                }
                elEntryBox12.SelectedIndex = 0;
            }
        }
        //when user choose a united this Function fill city sub data in city combobox
        private void elEntryBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (elEntryBox13.SelectedIndex != -1)
            {
                elEntryBox14.Items.Clear();
                foreach (DataRow item in _PublicClass.City((int.Parse(elEntryBox13.SelectedKey.ToString()))).Rows)
                {
                    ELListBoxItem NewItem = new ELListBoxItem();
                    NewItem.Key = item[0];
                    NewItem.Value = item[1];
                    elEntryBox14.Items.Add(NewItem);
                }
                elEntryBox14.SelectedIndex = 0;
            }
        }

        //empty all of entrybox 
        private void elButton2_Click(object sender, EventArgs e)
        {
            foreach (Control item in elRichPanel1.Controls)
            {
                if (item is ELEntryBox)
                {
                    (item as ELEntryBox).Value = "";
                }
                else if (item is ELComboBox)
                {
                    (item as ELComboBox).SelectedIndex = -1;
                }
            }
            foreach (ELListBoxItem item in elEntryBox23.Items)
            {
                item.CheckState = CheckState.Unchecked;
            }
            pictureBox1.Image =   Almas.Properties.Resources.user;
            elRadioButton1.Checked = false;
            elRadioButton2.Checked = false;
        }

        //make new personalization code
        private void elEntryBox1_ButtonClick(object sender, ELEntryBoxButtonClickEventArgs e)
        {
            elEntryBox1.Value = _PublicClass.Create_Personal_Code();
        }

        //check use number in numeric field 
        private void elEntryBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.KeyChar = (char)Keys.None;
            }
        }

        private void elEntryBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.KeyChar = (char)Keys.None;
            }
        }

        private void elEntryBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.KeyChar = (char)Keys.None;
            }
        }

        //store final clerk data in db
        private void elButton1_Click(object sender, EventArgs e)
        {
            if (Check_Empty_Entrybox())
            {
                if (extramessage_frm.Show("آیا مایل به ثبت اطلاعات این منشی هستید ؟ ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    byte sex = (elRadioButton1.Checked == true) ? (byte)0 : (byte)1;
                    byte insurance = (elCheckBox1.Checked == true) ? (byte)1 : (byte)0;
                    //search checked item in elentrybox23 and save item.key in new string
                    string disease = _PublicClass.Fetch_Checked_Item(elEntryBox23.CheckedItems);
                    
                    BLL.cleark crk = new BLL.cleark();
                    if (crk.Insert((string)elEntryBox1.Value, (string)elEntryBox2.Value, (string)elEntryBox3.Value,
                        (string)elEntryBox4.Value, (string)elEntryBox5.Value, (string)elEntryBox6.Value, sex,
                        (string)elEntryBox7.Value, byte.Parse(elEntryBox8.SelectedKey.ToString()), byte.Parse(elEntryBox9.SelectedKey.ToString()),
                        int.Parse(elEntryBox10.SelectedKey.ToString()), int.Parse(elEntryBox11.SelectedKey.ToString()), int.Parse(elEntryBox12.SelectedKey.ToString()),
                        int.Parse(elEntryBox13.SelectedKey.ToString()), int.Parse(elEntryBox14.SelectedKey.ToString()), (string)elEntryBox15.Value,
                        (string)elEntryBox16.Value, (string)elEntryBox17.Value, (string)elEntryBox18.Value,
                        int.Parse(elEntryBox19.Value.ToString()), (string)elEntryBox20.Value, insurance, (string)elEntryBox21.Value, (string)elEntryBox22.Value, disease))
                    {
                        //save user image into db [ image table ]
                        BLL.picture _Pic = new BLL.picture();
                        _Pic.InsertPicture((string)elEntryBox1.Value, pictureBox1.Image);
                        //empty all of elentrybox and combobox and picturebox
                        elButton2_Click(null, null);
                    }
                }
            }
        }

    }
}

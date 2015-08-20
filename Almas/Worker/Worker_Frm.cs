using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Klik.Windows.Forms.v1.EntryLib;

namespace Almas.Worker
{
    public partial class Worker_Frm : Form
    {
        BLL.public_class _PublicClass = new BLL.public_class();
        public Worker_Frm()
        {
            InitializeComponent();
            //......Set Mask For ElEntryBox (string)
            elEntryBox2.ValidationStyle = _PublicClass.Mask_Format_String();//......Name EntryBox
            elEntryBox3.ValidationStyle = _PublicClass.Mask_Format_String();//......Family Entry Box
            elEntryBox4.ValidationStyle = _PublicClass.Mask_Format_String();//......Father Name Entry Box
            
            //......Set Mask For ElEntryBox (Number)
            elEntryBox5.ValidationStyle = _PublicClass.Mask_Format_Style("0000000000");//......N_code 
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

            //......Fill Education List.......
            foreach (DataRow EDU in _PublicClass.EducationCombobox().Rows)
            {
                ELListBoxItem ellist = new ELListBoxItem();
                ellist.Key = EDU[0];
                ellist.Value = EDU[1];
                elEntryBox10.Items.Add(ellist);
            }
            //......Fill Religion ListBox
            foreach(DataRow Religion in _PublicClass.Religion_pri().Rows)
            {
                ELListBoxItem Ellist = new ELListBoxItem();
                Ellist.Key = Religion[0];
                Ellist.Value = Religion[1];
                elEntryBox11.Items.Add(Ellist);
            }

            //.....Fill United ListBox
            foreach(DataRow United in _PublicClass.United().Rows)
            {
                ELListBoxItem ellist = new ELListBoxItem();
                ellist.Key = United[0];
                ellist.Value = United[1];

                elEntryBox13.Items.Add(ellist);
            }

        }

        private void elEntryBox1_ButtonClick(object sender, Klik.Windows.Forms.v1.EntryLib.ELEntryBoxButtonClickEventArgs e)
        {
            //......Create ID For Worker And Fill EntryBox
            elEntryBox1.Value = _PublicClass.Create_Personal_Code();
        }

        private void elEntryBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            //......Fill Religion_Sec 
            elEntryBox12.Items.Clear();
            foreach(DataRow religion in _PublicClass.Religion_sec(int.Parse(elEntryBox11.SelectedKey.ToString())).Rows)
            {
                ELListBoxItem ellist = new ELListBoxItem();
                ellist.Key = religion[0];
                ellist.Value = religion[1];
                elEntryBox12.Items.Add(ellist);
            }
            elEntryBox12.SelectedIndex = 0;
        }

        private void elEntryBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            elEntryBox14.Items.Clear();
            foreach (DataRow City in _PublicClass.City(int.Parse(elEntryBox13.SelectedKey.ToString())).Rows)
            {
                ELListBoxItem ellist = new ELListBoxItem();
                ellist.Key = City[0];
                ellist.Value = City[1];
                elEntryBox14.Items.Add(ellist);
            }
            elEntryBox14.SelectedIndex= 0;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Almas
{
    public partial class extramessage_frm : Form
    {
        public extramessage_frm()
        {
            InitializeComponent();
        }

        static extramessage_frm Msgbox; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Caption,MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            Msgbox = new extramessage_frm();
            Msgbox.txt.Text = Caption;

            if (icon == MessageBoxIcon.Information)
            {
                Msgbox.pictureBox1.BackgroundImage = Almas.Properties.Resources.info;
                Msgbox.Text = "پیام";
            }
            else if (icon == MessageBoxIcon.Error)
            {
                Msgbox.pictureBox1.BackgroundImage = Almas.Properties.Resources.error;
                Msgbox.Text = "اخطار";
            }
            else if (icon == MessageBoxIcon.Warning)
            {
                Msgbox.pictureBox1.BackgroundImage = Almas.Properties.Resources.warning;
                Msgbox.Text = "هشدار";
            }

            if (buttons == MessageBoxButtons.OK)
            {
                Msgbox.panel1.Visible = true;
                Msgbox.panel2.Visible = false;
            }
            else if (buttons == MessageBoxButtons.YesNo)
            {
                Msgbox.panel2.Visible = true;
                Msgbox.panel1.Visible = false;
            }
            Msgbox.ShowDialog();
            return result;
        }

        private void elButton1_Click(object sender, EventArgs e)
        {
            Msgbox.Close();
        }

        private void elButton3_Click(object sender, EventArgs e)
        {
            result = System.Windows.Forms.DialogResult.Yes; Msgbox.Close();
        }

    }
}

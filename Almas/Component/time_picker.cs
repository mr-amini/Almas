using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Almas
{
    public partial class time_picker : UserControl
    {

        public delegate void ButtonClickEvent(object sender, EventArgs e);
        public event ButtonClickEvent TimePickerClicked;

        public time_picker()
        {
            InitializeComponent();
            elButton1.Click += new EventHandler(ButtonClicked);
            elButton2.Click += new EventHandler(ButtonClicked);
            elButton3.Click += new EventHandler(ButtonClicked);
            elButton4.Click += new EventHandler(ButtonClicked);
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            // Delegate the event to the caller
            if (TimePickerClicked != null)
                TimePickerClicked(this, e);
        }

        public delegate EventHandler click();
        

        private void time_picker_Load(object sender, EventArgs e)
        {
            timer3.Enabled = true;
        }
        
        public string GetTime()
        {
            return hour.Text + ":" + min.Text;
        }

        public void SetTime(string _hour_min)
        {
            hour.Text = int.Parse(_hour_min.Remove(_hour_min.IndexOf(':'), (int)_hour_min.Length - (int)_hour_min.IndexOf(':'))).ToString();
            min.Text = int.Parse(_hour_min.Remove(0, _hour_min.IndexOf(':') + 1).ToString()).ToString() ;
            fix_hour();
            fix_min();
        }


        public void fix_hour()
        {
            if ((int)hour.Text.Length < 2)
            {
                hour.Text = "0" + hour.Text;
            }
        }

        public bool hour_up()
        {
            if (int.Parse(hour.Text) < 23)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool hour_down()
        {
            if (int.Parse(hour.Text) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool min_up()
        {
            if (int.Parse(min.Text) < 59)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool min_down()
        {
            if (int.Parse(min.Text) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void fix_min()
        {
            if ((int)min.Text.Length < 2)
            {
                min.Text = "0" + min.Text;
            }
        }

        public void mouse_up_button()
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer_A = 0;
        }

        private void elButton1_MouseDown(object sender, MouseEventArgs e)
        {
            who = sender;
            timer1.Enabled = true;
        }

        private void elButton1_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_up_button();
        }

        static int timer_A = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = timer_A == 1 ? true : false;
            timer1.Enabled = timer_A == 1 ? false : true;
            timer_A++;
        }

        object who;
        private void timer2_Tick(object sender, EventArgs e)
        {
             elButton3_Click_1(who,null);
        }

        private void elButton2_MouseDown(object sender, MouseEventArgs e)
        {
            who = sender;
            timer1.Enabled = true;
        }

        private void elButton2_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_up_button();
        }

        private void elButton3_MouseDown(object sender, MouseEventArgs e)
        {
            who = sender;
            timer1.Enabled = true;
        }

        private void elButton3_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_up_button();
        }

        private void elButton4_MouseDown(object sender, MouseEventArgs e)
        {
            who = sender;
            timer1.Enabled = true;
        }

        private void elButton4_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_up_button();
        }

        int two_dot = 0;
        private void timer3_Tick(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(two_dot, two_dot, two_dot);
            if (two_dot >= 240)
            {
                timer3.Enabled = false;
                timer4.Enabled = true;
            }
            two_dot += 5;
            
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(two_dot, two_dot, two_dot);
            if (two_dot <= 6)
            {
                timer4.Enabled = false;
                timer3.Enabled = true;
            }
            two_dot -= 5;
        }


        private void elButton3_Click_1(object sender, EventArgs e)
        {
            int tag = int.Parse((sender as Klik.Windows.Forms.v1.EntryLib.ELButton).Tag.ToString());

            switch (tag)
            {
                case 1:
                    if (hour_up())
                        hour.Text = (int.Parse(hour.Text) + 1).ToString();
                    break;
                case 2:
                    if(hour_down())
                        hour.Text = (int.Parse(hour.Text) - 1).ToString();
                    break;
                case 3:
                    if(min_up())
                        min.Text = (int.Parse(min.Text) + 1).ToString();
                    break;
                case 4:
                    if(min_down())
                        min.Text = (int.Parse(min.Text) - 1).ToString();
                    break;
                    
            }
            fix_hour();
            fix_min();

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Almas
{
    public partial class Clerk_Show : Form
    {

        BLL.cleark _clrk = new BLL.cleark();
        public Clerk_Show()
        {
            InitializeComponent();

            DataGridView1.AutoGenerateColumns = false;
            DataGridView1.DataSource = _clrk.ShowDataGridView();
        }
    }
}

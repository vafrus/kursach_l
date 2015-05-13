using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach_l
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void Form_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void M_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void M_m1_Click(object sender, EventArgs e)
        {
            Form_1st_method f = new Form_1st_method();
            f.Show();
        }

        private void M_m2_Click(object sender, EventArgs e)
        {
            Form_2nd_method f = new Form_2nd_method();
            f.Show();
        }

        private void M_res_Click(object sender, EventArgs e)
        {
            Form_research f = new Form_research();
            f.Show();
        }

        private void M_m1_desc_Click(object sender, EventArgs e)
        {
            Form_1st_desc f = new Form_1st_desc();
            f.Show();
        }

        private void M_m1_fc_Click(object sender, EventArgs e)
        {
            Form_1st_fc f = new Form_1st_fc();
            f.Show();
        }

        private void M_m2_desc_Click(object sender, EventArgs e)
        {
            Form_2nd_desc f = new Form_2nd_desc();
            f.Show();
        }

        private void M_m2_fc_Click(object sender, EventArgs e)
        {
            Form_2nd_fc f = new Form_2nd_fc();
            f.Show();
        }

        private void M_ref_Click(object sender, EventArgs e)
        {
            Form_ref f = new Form_ref();
            f.Show();
        }

        private void M_about_Click(object sender, EventArgs e)
        {
            Form_about f = new Form_about();
            f.Show();
        }
    }
}

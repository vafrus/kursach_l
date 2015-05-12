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
        private Form_research rf;
        public Form_main()
        {
            InitializeComponent();
        }
        public void sort_shell(int[] A)
        {
            
        }

        public void sort_insert(int[] A)
        {
            int i, j, k, b;
            int n = A.Length;
            for (i = 1; i < n; i++)
            {
                b = A[i];
                j = 0;
                while (b > A[j] && j <= i)
                {
                    j = j + 1;
                }
                for (k = i; k <= j + 1; k--)
                {
                    A[k] = A[k - 1];
                }
                A[j] = b;
            }
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
            rf = new Form_research();
            rf.Show();
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

        private void Form_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}

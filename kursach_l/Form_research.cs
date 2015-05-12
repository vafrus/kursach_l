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
    public partial class Form_research : Form
    {
        public Form_research()
        {
            InitializeComponent();
        }

        private void Res_Click(object sender, EventArgs e)
        {
            Solve_DoWork(null,null);
        }

        private void Save_Click(object sender, EventArgs e)
        {

        }

        private void Solve_DoWork(object sender, DoWorkEventArgs e)
        {
            Save.Enabled = true;
        }
    }
}

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
    public partial class Form_Title : Form
    {
        public Form_Title()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_main f = new Form_main(this);
            f.Show();
            this.Visible = false;
        }
    }
}

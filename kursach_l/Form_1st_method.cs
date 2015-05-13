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
    public partial class Form_1st_method : Form
    {
        public Form_1st_method()
        {
            InitializeComponent();
            Out2.Image = new Bitmap(Out2.Width, Out2.Height);
            PreOut2.Image = new Bitmap(PreOut2.Width, PreOut2.Height);
            Graphics g1 = Graphics.FromImage(Out2.Image), g2 = Graphics.FromImage(PreOut2.Image);
            float H = Out2.Height, W = Out2.Width;
            Pen pb = Pens.Black;
            g1.DrawLine(pb, new PointF(0, H / 2), new PointF(W, H / 2));
            g1.DrawLine(pb, new PointF(0, 0), new PointF(0, H));
            g2.DrawLine(pb, new PointF(0, H / 2), new PointF(W, H / 2));
            g2.DrawLine(pb, new PointF(0, 0), new PointF(0, H));
        }

        private void Btn_Sort_Click(object sender, EventArgs e)
        {
            //initialization
            int N = Convert.ToInt32(In1.Text);
            int i, j, k;
            int[] A = new int[N];
            Out1.Items.Clear();
            PreOut1.Items.Clear();
            Random rd = new Random();
            Out2.Image = new Bitmap(Out2.Width, Out2.Height);
            PreOut2.Image = new Bitmap(PreOut2.Width, PreOut2.Height);
            Graphics g1 = Graphics.FromImage(PreOut2.Image), g2 = Graphics.FromImage(Out2.Image);
            Brush b = Brushes.Yellow;
            Pen pb = Pens.Black;
            float H = Out2.Height, W = Out2.Width;
            float Scale = 4;
            g1.DrawLine(pb, new PointF(0, H / 2), new PointF(W, H / 2));
            g1.DrawLine(pb, new PointF(0, 0), new PointF(0, H));
            g2.DrawLine(pb, new PointF(0, H / 2), new PointF(W, H / 2));
            g2.DrawLine(pb, new PointF(0, 0), new PointF(0, H));

            //generate
            for (i = 0; i < N; i++)
            {
                A[i] = rd.Next(-40, 40);
                PreOut1.Items.Add(A[i]);
                if (A[i] > 0)
                {
                    g1.FillRectangle(b, i * Scale, H / 2 - A[i], Scale, A[i]);
                    g1.DrawRectangle(pb, i * Scale, H / 2 - A[i], Scale, A[i]);
                }
                else
                {
                    g1.FillRectangle(b, i * Scale, H / 2, Scale, -A[i]);
                    g1.DrawRectangle(pb, i * Scale, H / 2, Scale, -A[i]);
                }
            }

            //sort
            Sort.insert(A);

            for (i = 0; i < N; i++)
            {
                Out1.Items.Add(A[i]);
                if (A[i] > 0)
                {
                    g2.FillRectangle(b, i * Scale, H / 2 - A[i], Scale, A[i]);
                    g2.DrawRectangle(pb, i * Scale, H / 2 - A[i], Scale, A[i]);
                }
                else
                {
                    g2.FillRectangle(b, i * Scale, H / 2, Scale, -A[i]);
                    g2.DrawRectangle(pb, i * Scale, H / 2, Scale, -A[i]);
                }
            }
            Out2.Invalidate();
            PreOut2.Invalidate();
        }
    }
}

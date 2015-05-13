using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace kursach_l
{
    public partial class Form_research : Form
    {
        private int[,] R = new int[2, 91];
        public Form_research()
        {
            InitializeComponent();
        }

        private void Res_Click(object sender, EventArgs e)
        {
            // initialization

            int i, n;
            int[] A, B;
            float H = Out1.Height, W = Out1.Width;
            float TimeScale = 30; // numbers
            float AmtScale = 500;
            int TimeStep = 50; // dots
            int AmtStep = 50;
            int Brd = 20;
            Pen pb = Pens.Black;
            Pen pg = Pens.Green;
            Pen pr = Pens.Red;
            Brush br = new SolidBrush(Color.Black);
            Font f7 = new Font("Times New Roman", 7);
            Font f10 = new Font("Times New Roman", 10);
            Out1.Image = new Bitmap(Out1.Width, Out1.Height);
            Graphics g = Graphics.FromImage(Out1.Image);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Random rd = new Random();
            Stopwatch sw = new Stopwatch();

            // initialization graph

            g.DrawLine(pb, new PointF(Brd, Brd), new PointF(Brd, H - Brd));
            g.DrawLine(pb, new PointF(Brd, H - Brd), new PointF(W - Brd, H - Brd));
            g.DrawLine(pr, new PointF(30, 30), new PointF(50, 30));
            g.DrawLine(pg, new PointF(30, 50), new PointF(50, 50));
            g.DrawString("Метод Шелла", f10, br, new PointF(55, 25));
            g.DrawString("Метод простых вставок", f10, br, new PointF(55, 45));

            for (i = (int)H - Brd; i > Brd; i -= TimeStep)
            {
                g.DrawLine(pb, new PointF(Brd - 2, i), new PointF(Brd + 2, i));
                g.DrawString(Convert.ToString(((H - Brd - i) / TimeStep) * TimeScale), f7, br, new PointF(0, i));
            }

            for (i = Brd; i < W - Brd; i += AmtStep)
            {
                g.DrawLine(pb, new PointF(i, H - Brd - 2), new PointF(i, H - Brd + 2));
                g.DrawString(Convert.ToString(((i - Brd) / AmtStep + 1) * AmtScale), f7, br, new PointF(i, H - Brd + 4));
            }

            // sort arrays

            for (n = 500; n <= 5000; n += 50)
            {
                Out2.ProgressBar.Value = n;
                Out3.Text = "n=" + n.ToString();
                A = new int[n];
                B = new int[n];
                for (i = 0; i < n; i++)
                {
                    A[i] = rd.Next(-1000, 1000);
                    B[i] = A[i];
                }

                sw.Reset();
                sw.Start();
                Sort.shell(A);
                sw.Stop();
                R[0, n / 50 - 10] = sw.Elapsed.Milliseconds;

                sw.Reset();
                sw.Start();
                Sort.insert(B);
                sw.Stop();
                R[1, n / 50 - 10] = sw.Elapsed.Milliseconds;
            }

            // draw graph

            float Coef = AmtStep/10;
            float TCoef = TimeStep / TimeScale;
            for (i = 1; i <= 90; i++)
            {
                g.DrawLine(pr, new PointF(Brd + i * Coef, H - Brd - (float)R[0, i] * TCoef),
                               new PointF(Brd + (i - 1) * Coef, H - Brd - (float)R[0, i - 1] * TCoef));
                g.DrawLine(pg, new PointF(Brd + i * Coef, H - Brd - (float)R[1, i] * TCoef),
                               new PointF(Brd + (i - 1) * Coef, H - Brd - (float)R[1, i - 1] * TCoef));
            }
            Save.Enabled = true;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveF.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string Path = SaveF.FileName;
            string[] S = new string[92];
            int i;
            S[0] = "n\tt1\tt2";
            for (i = 0; i <= 90; i++)
                S[i + 1] = (i*50+500).ToString() + "\t" + Convert.ToString(R[0, i]) + "\t" + Convert.ToString(R[1, i]);
            System.IO.File.WriteAllLines(Path, S);
        }
    }
}

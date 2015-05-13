namespace kursach_l
{
    partial class Form_research
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Res = new System.Windows.Forms.Button();
            this.Out1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Out2 = new System.Windows.Forms.ToolStripProgressBar();
            this.Out3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Save = new System.Windows.Forms.Button();
            this.SaveF = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Out1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Res
            // 
            this.Res.Location = new System.Drawing.Point(19, 12);
            this.Res.Name = "Res";
            this.Res.Size = new System.Drawing.Size(95, 23);
            this.Res.TabIndex = 0;
            this.Res.Text = "Исследовать";
            this.Res.UseVisualStyleBackColor = true;
            this.Res.Click += new System.EventHandler(this.Res_Click);
            // 
            // Out1
            // 
            this.Out1.Location = new System.Drawing.Point(6, 19);
            this.Out1.Name = "Out1";
            this.Out1.Size = new System.Drawing.Size(551, 293);
            this.Out1.TabIndex = 1;
            this.Out1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Out2,
            this.Out3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 362);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(588, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(116, 17);
            this.toolStripStatusLabel1.Text = "Прогресс подсчета:";
            // 
            // Out2
            // 
            this.Out2.Maximum = 5000;
            this.Out2.Minimum = 500;
            this.Out2.Name = "Out2";
            this.Out2.Size = new System.Drawing.Size(300, 16);
            this.Out2.Value = 500;
            // 
            // Out3
            // 
            this.Out3.Name = "Out3";
            this.Out3.Size = new System.Drawing.Size(22, 17);
            this.Out3.Text = "n=";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Out1);
            this.groupBox1.Location = new System.Drawing.Point(13, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 318);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "График зависимости времени сортировки от количества элементов массива";
            // 
            // Save
            // 
            this.Save.Enabled = false;
            this.Save.Location = new System.Drawing.Point(150, 12);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(139, 23);
            this.Save.TabIndex = 5;
            this.Save.Text = "Сохранить результат";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // SaveF
            // 
            this.SaveF.DefaultExt = "txt";
            this.SaveF.FileName = "Research_results";
            this.SaveF.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form_research
            // 
            this.AcceptButton = this.Res;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 384);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Res);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_research";
            this.Text = "Исследование методов";
            ((System.ComponentModel.ISupportInitialize)(this.Out1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Res;
        private System.Windows.Forms.PictureBox Out1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar Out2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ToolStripStatusLabel Out3;
        private System.Windows.Forms.SaveFileDialog SaveF;
    }
}
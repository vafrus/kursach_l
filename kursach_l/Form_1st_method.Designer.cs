namespace kursach_l
{
    partial class Form_1st_method
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Out2 = new System.Windows.Forms.PictureBox();
            this.Out1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PreOut2 = new System.Windows.Forms.PictureBox();
            this.PreOut1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.In1 = new System.Windows.Forms.TextBox();
            this.Btn_Sort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Out2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreOut2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Out2);
            this.groupBox3.Controls.Add(this.Out1);
            this.groupBox3.Location = new System.Drawing.Point(235, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 370);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Отсортированный массив";
            // 
            // Out2
            // 
            this.Out2.Location = new System.Drawing.Point(6, 251);
            this.Out2.Name = "Out2";
            this.Out2.Size = new System.Drawing.Size(204, 113);
            this.Out2.TabIndex = 1;
            this.Out2.TabStop = false;
            // 
            // Out1
            // 
            this.Out1.FormattingEnabled = true;
            this.Out1.Location = new System.Drawing.Point(6, 20);
            this.Out1.Name = "Out1";
            this.Out1.Size = new System.Drawing.Size(204, 225);
            this.Out1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PreOut2);
            this.groupBox2.Controls.Add(this.PreOut1);
            this.groupBox2.Location = new System.Drawing.Point(12, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 370);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Исходный массив";
            // 
            // PreOut2
            // 
            this.PreOut2.Location = new System.Drawing.Point(7, 251);
            this.PreOut2.Name = "PreOut2";
            this.PreOut2.Size = new System.Drawing.Size(204, 113);
            this.PreOut2.TabIndex = 1;
            this.PreOut2.TabStop = false;
            // 
            // PreOut1
            // 
            this.PreOut1.FormattingEnabled = true;
            this.PreOut1.Location = new System.Drawing.Point(7, 20);
            this.PreOut1.Name = "PreOut1";
            this.PreOut1.Size = new System.Drawing.Size(204, 225);
            this.PreOut1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.In1);
            this.groupBox1.Controls.Add(this.Btn_Sort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 60);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходные данные";
            // 
            // In1
            // 
            this.In1.Location = new System.Drawing.Point(239, 26);
            this.In1.Name = "In1";
            this.In1.Size = new System.Drawing.Size(59, 20);
            this.In1.TabIndex = 2;
            this.In1.Text = "10";
            // 
            // Btn_Sort
            // 
            this.Btn_Sort.Location = new System.Drawing.Point(323, 24);
            this.Btn_Sort.Name = "Btn_Sort";
            this.Btn_Sort.Size = new System.Drawing.Size(99, 23);
            this.Btn_Sort.TabIndex = 1;
            this.Btn_Sort.Text = "Отсортировать";
            this.Btn_Sort.UseVisualStyleBackColor = true;
            this.Btn_Sort.Click += new System.EventHandler(this.Btn_Sort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите количество элементов массива:";
            // 
            // Form_1st_method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 460);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_1st_method";
            this.Text = "Метод простых вставок";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Out2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PreOut2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox Out2;
        private System.Windows.Forms.ListBox Out1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox PreOut2;
        private System.Windows.Forms.ListBox PreOut1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox In1;
        private System.Windows.Forms.Button Btn_Sort;
        private System.Windows.Forms.Label label1;

    }
}
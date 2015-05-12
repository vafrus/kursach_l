namespace kursach_l
{
    partial class Form_main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.M_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.методыСортировкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.M_m1 = new System.Windows.Forms.ToolStripMenuItem();
            this.M_m2 = new System.Windows.Forms.ToolStripMenuItem();
            this.M_res = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.описаниеМетодаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.M_m1_desc = new System.Windows.Forms.ToolStripMenuItem();
            this.M_m1_fc = new System.Windows.Forms.ToolStripMenuItem();
            this.методШеллаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.M_m2_desc = new System.Windows.Forms.ToolStripMenuItem();
            this.M_m2_fc = new System.Windows.Forms.ToolStripMenuItem();
            this.M_ref = new System.Windows.Forms.ToolStripMenuItem();
            this.M_about = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.методыСортировкиToolStripMenuItem,
            this.M_res,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.M_exit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // M_exit
            // 
            this.M_exit.Name = "M_exit";
            this.M_exit.Size = new System.Drawing.Size(152, 22);
            this.M_exit.Text = "Выход";
            this.M_exit.Click += new System.EventHandler(this.M_exit_Click);
            // 
            // методыСортировкиToolStripMenuItem
            // 
            this.методыСортировкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.M_m1,
            this.M_m2});
            this.методыСортировкиToolStripMenuItem.Name = "методыСортировкиToolStripMenuItem";
            this.методыСортировкиToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.методыСортировкиToolStripMenuItem.Text = "Методы сортировки";
            // 
            // M_m1
            // 
            this.M_m1.Name = "M_m1";
            this.M_m1.Size = new System.Drawing.Size(167, 22);
            this.M_m1.Text = "Простых вставок";
            this.M_m1.Click += new System.EventHandler(this.M_m1_Click);
            // 
            // M_m2
            // 
            this.M_m2.Name = "M_m2";
            this.M_m2.Size = new System.Drawing.Size(167, 22);
            this.M_m2.Text = "Шелла";
            this.M_m2.Click += new System.EventHandler(this.M_m2_Click);
            // 
            // M_res
            // 
            this.M_res.Name = "M_res";
            this.M_res.Size = new System.Drawing.Size(98, 20);
            this.M_res.Text = "Исследование";
            this.M_res.Click += new System.EventHandler(this.M_res_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.описаниеМетодаToolStripMenuItem,
            this.методШеллаToolStripMenuItem,
            this.M_ref,
            this.M_about});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // описаниеМетодаToolStripMenuItem
            // 
            this.описаниеМетодаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.M_m1_desc,
            this.M_m1_fc});
            this.описаниеМетодаToolStripMenuItem.Name = "описаниеМетодаToolStripMenuItem";
            this.описаниеМетодаToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.описаниеМетодаToolStripMenuItem.Text = "Метод простых вставок";
            // 
            // M_m1_desc
            // 
            this.M_m1_desc.Name = "M_m1_desc";
            this.M_m1_desc.Size = new System.Drawing.Size(138, 22);
            this.M_m1_desc.Text = "Описание";
            this.M_m1_desc.Click += new System.EventHandler(this.M_m1_desc_Click);
            // 
            // M_m1_fc
            // 
            this.M_m1_fc.Name = "M_m1_fc";
            this.M_m1_fc.Size = new System.Drawing.Size(138, 22);
            this.M_m1_fc.Text = "Блок-схема";
            this.M_m1_fc.Click += new System.EventHandler(this.M_m1_fc_Click);
            // 
            // методШеллаToolStripMenuItem
            // 
            this.методШеллаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.M_m2_desc,
            this.M_m2_fc});
            this.методШеллаToolStripMenuItem.Name = "методШеллаToolStripMenuItem";
            this.методШеллаToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.методШеллаToolStripMenuItem.Text = "Метод Шелла";
            // 
            // M_m2_desc
            // 
            this.M_m2_desc.Name = "M_m2_desc";
            this.M_m2_desc.Size = new System.Drawing.Size(138, 22);
            this.M_m2_desc.Text = "Описание";
            this.M_m2_desc.Click += new System.EventHandler(this.M_m2_desc_Click);
            // 
            // M_m2_fc
            // 
            this.M_m2_fc.Name = "M_m2_fc";
            this.M_m2_fc.Size = new System.Drawing.Size(138, 22);
            this.M_m2_fc.Text = "Блок-схема";
            this.M_m2_fc.Click += new System.EventHandler(this.M_m2_fc_Click);
            // 
            // M_ref
            // 
            this.M_ref.Name = "M_ref";
            this.M_ref.Size = new System.Drawing.Size(203, 22);
            this.M_ref.Text = "Справка";
            this.M_ref.Click += new System.EventHandler(this.M_ref_Click);
            // 
            // M_about
            // 
            this.M_about.Name = "M_about";
            this.M_about.Size = new System.Drawing.Size(203, 22);
            this.M_about.Text = "О программе";
            this.M_about.Click += new System.EventHandler(this.M_about_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 271);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(632, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 293);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_main";
            this.Text = "Form_Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_main_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem описаниеМетодаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem M_m1_desc;
        private System.Windows.Forms.ToolStripMenuItem M_m1_fc;
        private System.Windows.Forms.ToolStripMenuItem методШеллаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem M_m2_desc;
        private System.Windows.Forms.ToolStripMenuItem M_m2_fc;
        private System.Windows.Forms.ToolStripMenuItem M_ref;
        private System.Windows.Forms.ToolStripMenuItem M_about;
        private System.Windows.Forms.ToolStripMenuItem M_exit;
        private System.Windows.Forms.ToolStripMenuItem методыСортировкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem M_m1;
        private System.Windows.Forms.ToolStripMenuItem M_m2;
        private System.Windows.Forms.ToolStripMenuItem M_res;
    }
}
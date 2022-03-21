namespace Praktikum_21_Maret
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbData = new System.Windows.Forms.TextBox();
            this.LbData = new System.Windows.Forms.Label();
            this.LbKoleksi = new System.Windows.Forms.Label();
            this.ListBoxData = new System.Windows.Forms.ListBox();
            this.RbWarnaMerah = new System.Windows.Forms.RadioButton();
            this.RbWarnaBiru = new System.Windows.Forms.RadioButton();
            this.LbKeluar = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.LbOutput = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.LbSetting = new System.Windows.Forms.Label();
            this.CbAktif = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TbData
            // 
            this.TbData.Location = new System.Drawing.Point(129, 52);
            this.TbData.Name = "TbData";
            this.TbData.Size = new System.Drawing.Size(356, 27);
            this.TbData.TabIndex = 0;
            // 
            // LbData
            // 
            this.LbData.AutoSize = true;
            this.LbData.Location = new System.Drawing.Point(30, 55);
            this.LbData.Name = "LbData";
            this.LbData.Size = new System.Drawing.Size(48, 20);
            this.LbData.TabIndex = 1;
            this.LbData.Text = "Data :";
            // 
            // LbKoleksi
            // 
            this.LbKoleksi.AutoSize = true;
            this.LbKoleksi.Location = new System.Drawing.Point(30, 96);
            this.LbKoleksi.Name = "LbKoleksi";
            this.LbKoleksi.Size = new System.Drawing.Size(63, 20);
            this.LbKoleksi.TabIndex = 2;
            this.LbKoleksi.Text = "Koleksi :";
            // 
            // ListBoxData
            // 
            this.ListBoxData.FormattingEnabled = true;
            this.ListBoxData.ItemHeight = 20;
            this.ListBoxData.Location = new System.Drawing.Point(30, 154);
            this.ListBoxData.Name = "ListBoxData";
            this.ListBoxData.Size = new System.Drawing.Size(187, 264);
            this.ListBoxData.TabIndex = 3;
            this.ListBoxData.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // RbWarnaMerah
            // 
            this.RbWarnaMerah.AutoSize = true;
            this.RbWarnaMerah.Location = new System.Drawing.Point(367, 140);
            this.RbWarnaMerah.Name = "RbWarnaMerah";
            this.RbWarnaMerah.Size = new System.Drawing.Size(118, 24);
            this.RbWarnaMerah.TabIndex = 4;
            this.RbWarnaMerah.TabStop = true;
            this.RbWarnaMerah.Text = "Warna Merah";
            this.RbWarnaMerah.UseVisualStyleBackColor = true;
            this.RbWarnaMerah.CheckedChanged += new System.EventHandler(this.RbWarnaMerah_CheckedChanged);
            // 
            // RbWarnaBiru
            // 
            this.RbWarnaBiru.AutoSize = true;
            this.RbWarnaBiru.Location = new System.Drawing.Point(367, 170);
            this.RbWarnaBiru.Name = "RbWarnaBiru";
            this.RbWarnaBiru.Size = new System.Drawing.Size(102, 24);
            this.RbWarnaBiru.TabIndex = 5;
            this.RbWarnaBiru.TabStop = true;
            this.RbWarnaBiru.Text = "Warna Biru";
            this.RbWarnaBiru.UseVisualStyleBackColor = true;
            this.RbWarnaBiru.CheckedChanged += new System.EventHandler(this.RbWarnaBiru_CheckedChanged);
            // 
            // LbKeluar
            // 
            this.LbKeluar.AutoSize = true;
            this.LbKeluar.Location = new System.Drawing.Point(366, 212);
            this.LbKeluar.Name = "LbKeluar";
            this.LbKeluar.Size = new System.Drawing.Size(62, 20);
            this.LbKeluar.TabIndex = 7;
            this.LbKeluar.Text = "Output :";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(580, 48);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(94, 29);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LbOutput
            // 
            this.LbOutput.AutoSize = true;
            this.LbOutput.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbOutput.Location = new System.Drawing.Point(457, 266);
            this.LbOutput.Name = "LbOutput";
            this.LbOutput.Size = new System.Drawing.Size(0, 81);
            this.LbOutput.TabIndex = 9;
            this.LbOutput.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(423, 368);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(265, 30);
            this.BtnClear.TabIndex = 10;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // LbSetting
            // 
            this.LbSetting.AutoSize = true;
            this.LbSetting.Location = new System.Drawing.Point(366, 108);
            this.LbSetting.Name = "LbSetting";
            this.LbSetting.Size = new System.Drawing.Size(63, 20);
            this.LbSetting.TabIndex = 11;
            this.LbSetting.Text = "Setting :";
            // 
            // CbAktif
            // 
            this.CbAktif.AutoSize = true;
            this.CbAktif.Location = new System.Drawing.Point(477, 107);
            this.CbAktif.Name = "CbAktif";
            this.CbAktif.Size = new System.Drawing.Size(62, 24);
            this.CbAktif.TabIndex = 12;
            this.CbAktif.Text = "Aktif";
            this.CbAktif.UseVisualStyleBackColor = true;
            this.CbAktif.CheckedChanged += new System.EventHandler(this.CbAktif_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CbAktif);
            this.Controls.Add(this.LbSetting);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.LbOutput);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LbKeluar);
            this.Controls.Add(this.RbWarnaBiru);
            this.Controls.Add(this.RbWarnaMerah);
            this.Controls.Add(this.ListBoxData);
            this.Controls.Add(this.LbKoleksi);
            this.Controls.Add(this.LbData);
            this.Controls.Add(this.TbData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TbData;
        private Label LbData;
        private Label LbKoleksi;
        private ListBox ListBoxData;
        private RadioButton RbWarnaMerah;
        private RadioButton RbWarnaBiru;
        private Label LbKeluar;
        private Button BtnAdd;
        private Label LbOutput;
        private Button BtnClear;
        private Label LbSetting;
        private CheckBox CbAktif;
    }
}
namespace DesainUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelutama = new System.Windows.Forms.Panel();
            this.panelDeskripsi = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panelPembuka = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.covid_halaman = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_MenuUtama = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelHalaman = new System.Windows.Forms.Panel();
            this.panelutama.SuspendLayout();
            this.panelDeskripsi.SuspendLayout();
            this.panelPembuka.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelutama
            // 
            this.panelutama.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelutama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelutama.Controls.Add(this.panelDeskripsi);
            this.panelutama.Controls.Add(this.button5);
            this.panelutama.Controls.Add(this.panelPembuka);
            this.panelutama.Controls.Add(this.button2);
            this.panelutama.Location = new System.Drawing.Point(2, 36);
            this.panelutama.Name = "panelutama";
            this.panelutama.Size = new System.Drawing.Size(144, 415);
            this.panelutama.TabIndex = 0;
            // 
            // panelDeskripsi
            // 
            this.panelDeskripsi.BackColor = System.Drawing.Color.Indigo;
            this.panelDeskripsi.Controls.Add(this.button1);
            this.panelDeskripsi.Controls.Add(this.button3);
            this.panelDeskripsi.Controls.Add(this.button4);
            this.panelDeskripsi.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDeskripsi.Location = new System.Drawing.Point(0, 154);
            this.panelDeskripsi.Name = "panelDeskripsi";
            this.panelDeskripsi.Size = new System.Drawing.Size(144, 100);
            this.panelDeskripsi.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-1, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Statistik";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "Data Universitas";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(-1, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 28);
            this.button4.TabIndex = 3;
            this.button4.Text = "Data Covid";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(0, 127);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 27);
            this.button5.TabIndex = 3;
            this.button5.Text = "Deskripsi Data";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panelPembuka
            // 
            this.panelPembuka.BackColor = System.Drawing.Color.Indigo;
            this.panelPembuka.Controls.Add(this.button6);
            this.panelPembuka.Controls.Add(this.button7);
            this.panelPembuka.Controls.Add(this.covid_halaman);
            this.panelPembuka.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPembuka.Location = new System.Drawing.Point(0, 27);
            this.panelPembuka.Name = "panelPembuka";
            this.panelPembuka.Size = new System.Drawing.Size(144, 100);
            this.panelPembuka.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(-1, 66);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 28);
            this.button6.TabIndex = 5;
            this.button6.Text = "Statistik";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(0, 36);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(132, 28);
            this.button7.TabIndex = 4;
            this.button7.Text = "Data Universitas";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // covid_halaman
            // 
            this.covid_halaman.Location = new System.Drawing.Point(-1, 4);
            this.covid_halaman.Name = "covid_halaman";
            this.covid_halaman.Size = new System.Drawing.Size(132, 28);
            this.covid_halaman.TabIndex = 3;
            this.covid_halaman.Text = "Data Covid";
            this.covid_halaman.UseVisualStyleBackColor = true;
            this.covid_halaman.Click += new System.EventHandler(this.covid_halaman_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "Lihat Data";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_MenuUtama
            // 
            this.btn_MenuUtama.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_MenuUtama.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_MenuUtama.BackgroundImage")));
            this.btn_MenuUtama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_MenuUtama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MenuUtama.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_MenuUtama.Location = new System.Drawing.Point(3, 0);
            this.btn_MenuUtama.Name = "btn_MenuUtama";
            this.btn_MenuUtama.Size = new System.Drawing.Size(61, 30);
            this.btn_MenuUtama.TabIndex = 0;
            this.btn_MenuUtama.UseVisualStyleBackColor = false;
            this.btn_MenuUtama.Click += new System.EventHandler(this.btn_MenuUtama_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btn_MenuUtama);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 34);
            this.panel1.TabIndex = 1;
            // 
            // panelHalaman
            // 
            this.panelHalaman.Location = new System.Drawing.Point(143, 36);
            this.panelHalaman.Name = "panelHalaman";
            this.panelHalaman.Size = new System.Drawing.Size(700, 418);
            this.panelHalaman.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.panelHalaman);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelutama);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.panelutama.ResumeLayout(false);
            this.panelDeskripsi.ResumeLayout(false);
            this.panelPembuka.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelutama;
        private System.Windows.Forms.Button btn_MenuUtama;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panelPembuka;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button covid_halaman;
        private System.Windows.Forms.Panel panelDeskripsi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelHalaman;
    }
}


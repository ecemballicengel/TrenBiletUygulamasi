namespace TrenBiletUygulamasi
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            label6 = new Label();
            txtIade = new TextBox();
            Satilan_Biletler = new ListBox();
            label5 = new Label();
            txtIsim = new TextBox();
            chkIndirim = new CheckBox();
            btnIade = new Button();
            btnSat = new Button();
            comboBoxGuzergah = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txtKoltukSayisi = new TextBox();
            label2 = new Label();
            btnBosKoltuk = new Button();
            btnToplamCiro = new Button();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Fuchsia;
            label1.Location = new Point(701, 52);
            label1.Name = "label1";
            label1.Size = new Size(506, 54);
            label1.TabIndex = 0;
            label1.Text = "Tren Bileti Satis Uygulamasi";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 192, 255);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtIade);
            groupBox1.Controls.Add(Satilan_Biletler);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtIsim);
            groupBox1.Controls.Add(chkIndirim);
            groupBox1.Controls.Add(btnIade);
            groupBox1.Controls.Add(btnSat);
            groupBox1.Controls.Add(comboBoxGuzergah);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtKoltukSayisi);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = Color.Fuchsia;
            groupBox1.Location = new Point(28, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(815, 814);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Veri Girisi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 369);
            label6.Name = "label6";
            label6.Size = new Size(154, 25);
            label6.TabIndex = 22;
            label6.Text = "Satilan Bilet Listesi";
            // 
            // txtIade
            // 
            txtIade.Location = new Point(434, 285);
            txtIade.Name = "txtIade";
            txtIade.Size = new Size(117, 31);
            txtIade.TabIndex = 21;
            // 
            // Satilan_Biletler
            // 
            Satilan_Biletler.FormattingEnabled = true;
            Satilan_Biletler.ItemHeight = 25;
            Satilan_Biletler.Location = new Point(39, 409);
            Satilan_Biletler.Name = "Satilan_Biletler";
            Satilan_Biletler.Size = new Size(673, 379);
            Satilan_Biletler.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Lavender;
            label5.ForeColor = Color.Fuchsia;
            label5.Location = new Point(280, 194);
            label5.Name = "label5";
            label5.Size = new Size(44, 25);
            label5.TabIndex = 18;
            label5.Text = "isim";
            // 
            // txtIsim
            // 
            txtIsim.Location = new Point(391, 191);
            txtIsim.Name = "txtIsim";
            txtIsim.Size = new Size(150, 31);
            txtIsim.TabIndex = 17;
            // 
            // chkIndirim
            // 
            chkIndirim.AutoSize = true;
            chkIndirim.BackColor = Color.FromArgb(255, 192, 255);
            chkIndirim.ForeColor = Color.FromArgb(192, 0, 192);
            chkIndirim.Location = new Point(254, 240);
            chkIndirim.Name = "chkIndirim";
            chkIndirim.Size = new Size(119, 29);
            chkIndirim.TabIndex = 14;
            chkIndirim.Text = "INDIRIMLI";
            chkIndirim.UseVisualStyleBackColor = false;
            // 
            // btnIade
            // 
            btnIade.ForeColor = Color.FromArgb(192, 0, 192);
            btnIade.Location = new Point(434, 330);
            btnIade.Name = "btnIade";
            btnIade.Size = new Size(112, 34);
            btnIade.TabIndex = 16;
            btnIade.Text = "IADE ET";
            btnIade.UseVisualStyleBackColor = true;
            btnIade.Click += btnIade_Click;
            // 
            // btnSat
            // 
            btnSat.ForeColor = Color.FromArgb(192, 0, 192);
            btnSat.Location = new Point(235, 330);
            btnSat.Name = "btnSat";
            btnSat.Size = new Size(112, 34);
            btnSat.TabIndex = 15;
            btnSat.Text = "SAT";
            btnSat.UseVisualStyleBackColor = true;
            btnSat.Click += btnSat_Click_1;
            // 
            // comboBoxGuzergah
            // 
            comboBoxGuzergah.FormattingEnabled = true;
            comboBoxGuzergah.Location = new Point(382, 72);
            comboBoxGuzergah.Name = "comboBoxGuzergah";
            comboBoxGuzergah.Size = new Size(182, 33);
            comboBoxGuzergah.TabIndex = 13;
            comboBoxGuzergah.Tag = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Lavender;
            label4.ForeColor = Color.Fuchsia;
            label4.Location = new Point(251, 140);
            label4.Name = "label4";
            label4.Size = new Size(115, 25);
            label4.TabIndex = 11;
            label4.Text = "Koltuk Sayisi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 116);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 10;
            // 
            // txtKoltukSayisi
            // 
            txtKoltukSayisi.Location = new Point(396, 134);
            txtKoltukSayisi.Name = "txtKoltukSayisi";
            txtKoltukSayisi.Size = new Size(150, 31);
            txtKoltukSayisi.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Lavender;
            label2.ForeColor = Color.Fuchsia;
            label2.Location = new Point(253, 72);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 7;
            label2.Text = "Guzergah Adi:";
            // 
            // btnBosKoltuk
            // 
            btnBosKoltuk.Location = new Point(28, 64);
            btnBosKoltuk.Name = "btnBosKoltuk";
            btnBosKoltuk.Size = new Size(170, 53);
            btnBosKoltuk.TabIndex = 0;
            btnBosKoltuk.Text = "Bos Koltuk Sayisi";
            btnBosKoltuk.UseVisualStyleBackColor = true;
            btnBosKoltuk.Click += btnBosKoltuk_Click;
            // 
            // btnToplamCiro
            // 
            btnToplamCiro.Location = new Point(28, 142);
            btnToplamCiro.Name = "btnToplamCiro";
            btnToplamCiro.Size = new Size(170, 53);
            btnToplamCiro.TabIndex = 1;
            btnToplamCiro.Text = "Toplam Ciro";
            btnToplamCiro.UseVisualStyleBackColor = true;
            btnToplamCiro.Click += btnToplamCiro_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(255, 192, 255);
            groupBox3.Controls.Add(btnToplamCiro);
            groupBox3.Controls.Add(btnBosKoltuk);
            groupBox3.ForeColor = Color.Fuchsia;
            groupBox3.Location = new Point(860, 631);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(257, 239);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "FINANS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1882, 957);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private TextBox txtKoltukSayisi;
        private Label label2;
        private ComboBox comboBoxGuzergah;
        private Label label5;
        private TextBox txtIsim;
        private CheckBox chkIndirim;
        private Button btnIade;
        private Button btnSat;
        private ListBox Satilan_Biletler;
        private TextBox txtIade;
        private Label label6;
        private Button btnBosKoltuk;
        private Button btnToplamCiro;
        private GroupBox groupBox3;
    }
}

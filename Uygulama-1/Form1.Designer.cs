﻿namespace Uygulama_1
{
    partial class randevuTakip
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(randevuTakip));
            this.randevuPanel = new System.Windows.Forms.Panel();
            this.linkedinBtn = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.githubProfile = new System.Windows.Forms.LinkLabel();
            this.github = new System.Windows.Forms.PictureBox();
            this.tümVeriBtn = new System.Windows.Forms.Button();
            this.araBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.aramaTxtBox = new System.Windows.Forms.TextBox();
            this.temizleBtn = new System.Windows.Forms.Button();
            this.güncelleBtn = new System.Windows.Forms.Button();
            this.silBtn = new System.Windows.Forms.Button();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.tarihDt = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.polikliniklerTxt = new System.Windows.Forms.ComboBox();
            this.telefonTxt = new System.Windows.Forms.TextBox();
            this.adSoyadTxt = new System.Windows.Forms.TextBox();
            this.protokolNoTxt = new System.Windows.Forms.TextBox();
            this.sigortaCheck = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.randevuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.github)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // randevuPanel
            // 
            this.randevuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.randevuPanel.AutoSize = true;
            this.randevuPanel.BackColor = System.Drawing.Color.Azure;
            this.randevuPanel.Controls.Add(this.linkedinBtn);
            this.randevuPanel.Controls.Add(this.pictureBox1);
            this.randevuPanel.Controls.Add(this.githubProfile);
            this.randevuPanel.Controls.Add(this.github);
            this.randevuPanel.Controls.Add(this.tümVeriBtn);
            this.randevuPanel.Controls.Add(this.araBtn);
            this.randevuPanel.Controls.Add(this.label7);
            this.randevuPanel.Controls.Add(this.aramaTxtBox);
            this.randevuPanel.Controls.Add(this.temizleBtn);
            this.randevuPanel.Controls.Add(this.güncelleBtn);
            this.randevuPanel.Controls.Add(this.silBtn);
            this.randevuPanel.Controls.Add(this.ekleBtn);
            this.randevuPanel.Controls.Add(this.tarihDt);
            this.randevuPanel.Controls.Add(this.label6);
            this.randevuPanel.Controls.Add(this.polikliniklerTxt);
            this.randevuPanel.Controls.Add(this.telefonTxt);
            this.randevuPanel.Controls.Add(this.adSoyadTxt);
            this.randevuPanel.Controls.Add(this.protokolNoTxt);
            this.randevuPanel.Controls.Add(this.sigortaCheck);
            this.randevuPanel.Controls.Add(this.label5);
            this.randevuPanel.Controls.Add(this.label4);
            this.randevuPanel.Controls.Add(this.label3);
            this.randevuPanel.Controls.Add(this.label1);
            this.randevuPanel.ForeColor = System.Drawing.Color.DarkMagenta;
            this.randevuPanel.Location = new System.Drawing.Point(31, 42);
            this.randevuPanel.Name = "randevuPanel";
            this.randevuPanel.Size = new System.Drawing.Size(1675, 239);
            this.randevuPanel.TabIndex = 1;
            // 
            // linkedinBtn
            // 
            this.linkedinBtn.AutoSize = true;
            this.linkedinBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.linkedinBtn.DisabledLinkColor = System.Drawing.Color.White;
            this.linkedinBtn.LinkColor = System.Drawing.Color.Black;
            this.linkedinBtn.Location = new System.Drawing.Point(1137, 129);
            this.linkedinBtn.Name = "linkedinBtn";
            this.linkedinBtn.Size = new System.Drawing.Size(57, 16);
            this.linkedinBtn.TabIndex = 23;
            this.linkedinBtn.TabStop = true;
            this.linkedinBtn.Text = "LinkedIn";
            this.linkedinBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Uygulama_1.Properties.Resources.linkedin;
            this.pictureBox1.Location = new System.Drawing.Point(1098, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // githubProfile
            // 
            this.githubProfile.AutoSize = true;
            this.githubProfile.BackColor = System.Drawing.Color.PaleTurquoise;
            this.githubProfile.DisabledLinkColor = System.Drawing.Color.White;
            this.githubProfile.LinkColor = System.Drawing.Color.Black;
            this.githubProfile.Location = new System.Drawing.Point(1137, 82);
            this.githubProfile.Name = "githubProfile";
            this.githubProfile.Size = new System.Drawing.Size(51, 16);
            this.githubProfile.TabIndex = 21;
            this.githubProfile.TabStop = true;
            this.githubProfile.Text = "GitHub ";
            this.githubProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubProfile_LinkClicked);
            // 
            // github
            // 
            this.github.Image = global::Uygulama_1.Properties.Resources.github;
            this.github.Location = new System.Drawing.Point(1098, 74);
            this.github.Name = "github";
            this.github.Size = new System.Drawing.Size(33, 32);
            this.github.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.github.TabIndex = 20;
            this.github.TabStop = false;
            // 
            // tümVeriBtn
            // 
            this.tümVeriBtn.BackColor = System.Drawing.Color.IndianRed;
            this.tümVeriBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tümVeriBtn.ForeColor = System.Drawing.Color.Black;
            this.tümVeriBtn.Location = new System.Drawing.Point(913, 135);
            this.tümVeriBtn.Name = "tümVeriBtn";
            this.tümVeriBtn.Size = new System.Drawing.Size(120, 38);
            this.tümVeriBtn.TabIndex = 19;
            this.tümVeriBtn.Text = "TÜMÜ";
            this.tümVeriBtn.UseVisualStyleBackColor = false;
            this.tümVeriBtn.Click += new System.EventHandler(this.tümVeriBtn_Click);
            // 
            // araBtn
            // 
            this.araBtn.BackColor = System.Drawing.Color.Thistle;
            this.araBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.araBtn.ForeColor = System.Drawing.Color.Black;
            this.araBtn.Location = new System.Drawing.Point(913, 86);
            this.araBtn.Name = "araBtn";
            this.araBtn.Size = new System.Drawing.Size(120, 38);
            this.araBtn.TabIndex = 18;
            this.araBtn.Text = "BUL";
            this.araBtn.UseVisualStyleBackColor = false;
            this.araBtn.Click += new System.EventHandler(this.araBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(759, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "PROTOKOL NO :";
            // 
            // aramaTxtBox
            // 
            this.aramaTxtBox.Location = new System.Drawing.Point(892, 46);
            this.aramaTxtBox.Name = "aramaTxtBox";
            this.aramaTxtBox.Size = new System.Drawing.Size(157, 22);
            this.aramaTxtBox.TabIndex = 16;
            // 
            // temizleBtn
            // 
            this.temizleBtn.BackColor = System.Drawing.Color.Cyan;
            this.temizleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizleBtn.ForeColor = System.Drawing.Color.Black;
            this.temizleBtn.Location = new System.Drawing.Point(195, 194);
            this.temizleBtn.Name = "temizleBtn";
            this.temizleBtn.Size = new System.Drawing.Size(120, 38);
            this.temizleBtn.TabIndex = 15;
            this.temizleBtn.Text = "TEMİZLE";
            this.temizleBtn.UseVisualStyleBackColor = false;
            this.temizleBtn.Click += new System.EventHandler(this.temizleBtn_Click);
            // 
            // güncelleBtn
            // 
            this.güncelleBtn.BackColor = System.Drawing.Color.Yellow;
            this.güncelleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.güncelleBtn.ForeColor = System.Drawing.Color.Black;
            this.güncelleBtn.Location = new System.Drawing.Point(548, 186);
            this.güncelleBtn.Name = "güncelleBtn";
            this.güncelleBtn.Size = new System.Drawing.Size(120, 38);
            this.güncelleBtn.TabIndex = 14;
            this.güncelleBtn.Text = "GÜNCELLE";
            this.güncelleBtn.UseVisualStyleBackColor = false;
            this.güncelleBtn.Click += new System.EventHandler(this.güncelleBtn_Click);
            // 
            // silBtn
            // 
            this.silBtn.BackColor = System.Drawing.Color.Tomato;
            this.silBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silBtn.ForeColor = System.Drawing.Color.Black;
            this.silBtn.Location = new System.Drawing.Point(548, 135);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(120, 38);
            this.silBtn.TabIndex = 13;
            this.silBtn.Text = "SİL";
            this.silBtn.UseVisualStyleBackColor = false;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // ekleBtn
            // 
            this.ekleBtn.BackColor = System.Drawing.Color.GreenYellow;
            this.ekleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekleBtn.ForeColor = System.Drawing.Color.Black;
            this.ekleBtn.Location = new System.Drawing.Point(548, 86);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(120, 38);
            this.ekleBtn.TabIndex = 12;
            this.ekleBtn.Text = "EKLE";
            this.ekleBtn.UseVisualStyleBackColor = false;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // tarihDt
            // 
            this.tarihDt.Location = new System.Drawing.Point(504, 47);
            this.tarihDt.Name = "tarihDt";
            this.tarihDt.Size = new System.Drawing.Size(215, 22);
            this.tarihDt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(432, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "TARIH :";
            // 
            // polikliniklerTxt
            // 
            this.polikliniklerTxt.FormattingEnabled = true;
            this.polikliniklerTxt.Location = new System.Drawing.Point(166, 84);
            this.polikliniklerTxt.Name = "polikliniklerTxt";
            this.polikliniklerTxt.Size = new System.Drawing.Size(190, 24);
            this.polikliniklerTxt.TabIndex = 9;
            // 
            // telefonTxt
            // 
            this.telefonTxt.Location = new System.Drawing.Point(166, 156);
            this.telefonTxt.Name = "telefonTxt";
            this.telefonTxt.Size = new System.Drawing.Size(190, 22);
            this.telefonTxt.TabIndex = 8;
            // 
            // adSoyadTxt
            // 
            this.adSoyadTxt.Location = new System.Drawing.Point(166, 119);
            this.adSoyadTxt.Name = "adSoyadTxt";
            this.adSoyadTxt.Size = new System.Drawing.Size(190, 22);
            this.adSoyadTxt.TabIndex = 7;
            // 
            // protokolNoTxt
            // 
            this.protokolNoTxt.Location = new System.Drawing.Point(166, 49);
            this.protokolNoTxt.Name = "protokolNoTxt";
            this.protokolNoTxt.ReadOnly = true;
            this.protokolNoTxt.Size = new System.Drawing.Size(190, 22);
            this.protokolNoTxt.TabIndex = 5;
            // 
            // sigortaCheck
            // 
            this.sigortaCheck.AutoSize = true;
            this.sigortaCheck.ForeColor = System.Drawing.Color.Black;
            this.sigortaCheck.Location = new System.Drawing.Point(77, 204);
            this.sigortaCheck.Name = "sigortaCheck";
            this.sigortaCheck.Size = new System.Drawing.Size(89, 20);
            this.sigortaCheck.TabIndex = 4;
            this.sigortaCheck.Text = "SIGORTA";
            this.sigortaCheck.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(49, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "POLIKLINIK :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(71, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "TELEFON :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(45, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "ADI - SOYADI :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROTOKOL NO :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(44, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Randevu Bilgileri";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(31, 287);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(1194, 307);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEnter);
            this.dataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_ColumnHeaderMouseClick);
            // 
            // randevuTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1260, 606);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.randevuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "randevuTakip";
            this.Text = "RANDEVU TAKİP SİSTEMİ";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.randevuTakip_Load);
            this.randevuPanel.ResumeLayout(false);
            this.randevuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.github)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel randevuPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox telefonTxt;
        private System.Windows.Forms.TextBox adSoyadTxt;
        private System.Windows.Forms.TextBox protokolNoTxt;
        private System.Windows.Forms.CheckBox sigortaCheck;
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.DateTimePicker tarihDt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox polikliniklerTxt;
        private System.Windows.Forms.Button güncelleBtn;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button temizleBtn;
        private System.Windows.Forms.Button araBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox aramaTxtBox;
        private System.Windows.Forms.Button tümVeriBtn;
        private System.Windows.Forms.PictureBox github;
        private System.Windows.Forms.LinkLabel githubProfile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkedinBtn;
    }
}


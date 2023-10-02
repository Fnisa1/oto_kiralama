namespace oto_kiralama
{
    partial class formmüşterilistele
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
            dataGridView1 = new DataGridView();
            button2 = new Button();
            ekle = new Button();
            txtAdres = new TextBox();
            txtEmail = new TextBox();
            txtTel = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            txtTc = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.HighlightText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(477, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(669, 344);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(222, 407);
            button2.Name = "button2";
            button2.Size = new Size(184, 74);
            button2.TabIndex = 27;
            button2.Text = "İPTAL";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ekle
            // 
            ekle.BackColor = SystemColors.ActiveBorder;
            ekle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ekle.ForeColor = SystemColors.ActiveCaptionText;
            ekle.Location = new Point(32, 407);
            ekle.Name = "ekle";
            ekle.Size = new Size(184, 74);
            ekle.TabIndex = 26;
            ekle.Text = "GÜNCELLE";
            ekle.UseVisualStyleBackColor = false;
            ekle.Click += ekle_Click;
            // 
            // txtAdres
            // 
            txtAdres.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAdres.Location = new Point(138, 307);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(234, 34);
            txtAdres.TabIndex = 25;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(138, 244);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(234, 34);
            txtEmail.TabIndex = 24;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtTel
            // 
            txtTel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTel.Location = new Point(138, 188);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(234, 34);
            txtTel.TabIndex = 23;
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoyad.Location = new Point(138, 136);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(234, 34);
            txtSoyad.TabIndex = 22;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAd.Location = new Point(138, 85);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(234, 34);
            txtAd.TabIndex = 21;
            // 
            // txtTc
            // 
            txtTc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTc.Location = new Point(138, 40);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(234, 34);
            txtTc.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.HighlightText;
            label6.Location = new Point(32, 307);
            label6.Name = "label6";
            label6.Size = new Size(62, 28);
            label6.TabIndex = 19;
            label6.Text = "Adres";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.HighlightText;
            label5.Location = new Point(32, 247);
            label5.Name = "label5";
            label5.Size = new Size(64, 28);
            label5.TabIndex = 18;
            label5.Text = "E mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.HighlightText;
            label4.Location = new Point(32, 194);
            label4.Name = "label4";
            label4.Size = new Size(74, 28);
            label4.TabIndex = 17;
            label4.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(32, 136);
            label3.Name = "label3";
            label3.Size = new Size(67, 28);
            label3.TabIndex = 16;
            label3.Text = "Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(32, 85);
            label2.Name = "label2";
            label2.Size = new Size(37, 28);
            label2.TabIndex = 15;
            label2.Text = "Ad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(32, 40);
            label1.Name = "label1";
            label1.Size = new Size(29, 28);
            label1.TabIndex = 14;
            label1.Text = "Tc";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(723, 407);
            button1.Name = "button1";
            button1.Size = new Size(199, 61);
            button1.TabIndex = 28;
            button1.Text = "SİL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // formmüşterilistele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1207, 563);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(ekle);
            Controls.Add(txtAdres);
            Controls.Add(txtEmail);
            Controls.Add(txtTel);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(txtTc);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "formmüşterilistele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formmüşterilistele";
            Load += formmüşterilistele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button2;
        private Button ekle;
        private TextBox txtAdres;
        private TextBox txtEmail;
        private TextBox txtTel;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private TextBox txtTc;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}
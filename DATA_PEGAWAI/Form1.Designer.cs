namespace DATA_PEGAWAI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNm_pegawai = new System.Windows.Forms.TextBox();
            this.txtNo_Pegawai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbJenisKelamin = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGaji_Pokok = new System.Windows.Forms.TextBox();
            this.txtUang_Makan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTransport = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNilai_Tunjangan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAMA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "NO PEGAWAI";
            // 
            // txtNm_pegawai
            // 
            this.txtNm_pegawai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNm_pegawai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNm_pegawai.Location = new System.Drawing.Point(177, 111);
            this.txtNm_pegawai.Margin = new System.Windows.Forms.Padding(4);
            this.txtNm_pegawai.Name = "txtNm_pegawai";
            this.txtNm_pegawai.Size = new System.Drawing.Size(285, 30);
            this.txtNm_pegawai.TabIndex = 74;
            // 
            // txtNo_Pegawai
            // 
            this.txtNo_Pegawai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNo_Pegawai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNo_Pegawai.Location = new System.Drawing.Point(177, 63);
            this.txtNo_Pegawai.Margin = new System.Windows.Forms.Padding(4);
            this.txtNo_Pegawai.Name = "txtNo_Pegawai";
            this.txtNo_Pegawai.Size = new System.Drawing.Size(285, 30);
            this.txtNo_Pegawai.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 75;
            this.label3.Text = "TANGGAL MASUK";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(177, 160);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(285, 30);
            this.dateTimePicker1.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 78;
            this.label4.Text = "JENIS KELAMIN";
            // 
            // cmbJenisKelamin
            // 
            this.cmbJenisKelamin.FormattingEnabled = true;
            this.cmbJenisKelamin.Location = new System.Drawing.Point(177, 219);
            this.cmbJenisKelamin.Margin = new System.Windows.Forms.Padding(4);
            this.cmbJenisKelamin.Name = "cmbJenisKelamin";
            this.cmbJenisKelamin.Size = new System.Drawing.Size(168, 24);
            this.cmbJenisKelamin.TabIndex = 86;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(177, 276);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(168, 24);
            this.cmbStatus.TabIndex = 88;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 87;
            this.label5.Text = "STATUS";
            // 
            // txtGaji_Pokok
            // 
            this.txtGaji_Pokok.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGaji_Pokok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGaji_Pokok.Location = new System.Drawing.Point(177, 328);
            this.txtGaji_Pokok.Margin = new System.Windows.Forms.Padding(4);
            this.txtGaji_Pokok.Name = "txtGaji_Pokok";
            this.txtGaji_Pokok.Size = new System.Drawing.Size(285, 30);
            this.txtGaji_Pokok.TabIndex = 92;
            // 
            // txtUang_Makan
            // 
            this.txtUang_Makan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUang_Makan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUang_Makan.Location = new System.Drawing.Point(177, 376);
            this.txtUang_Makan.Margin = new System.Windows.Forms.Padding(4);
            this.txtUang_Makan.Name = "txtUang_Makan";
            this.txtUang_Makan.Size = new System.Drawing.Size(285, 30);
            this.txtUang_Makan.TabIndex = 91;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 90;
            this.label6.Text = "GAJI POKOK";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 89;
            this.label7.Text = "UANG MAKAN";
            // 
            // txtTransport
            // 
            this.txtTransport.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransport.Location = new System.Drawing.Point(177, 426);
            this.txtTransport.Margin = new System.Windows.Forms.Padding(4);
            this.txtTransport.Name = "txtTransport";
            this.txtTransport.Size = new System.Drawing.Size(285, 30);
            this.txtTransport.TabIndex = 94;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 17);
            this.label8.TabIndex = 93;
            this.label8.Text = "UANG TRANSPORT";
            // 
            // txtNilai_Tunjangan
            // 
            this.txtNilai_Tunjangan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNilai_Tunjangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNilai_Tunjangan.Location = new System.Drawing.Point(177, 481);
            this.txtNilai_Tunjangan.Margin = new System.Windows.Forms.Padding(4);
            this.txtNilai_Tunjangan.Name = "txtNilai_Tunjangan";
            this.txtNilai_Tunjangan.Size = new System.Drawing.Size(285, 30);
            this.txtNilai_Tunjangan.TabIndex = 96;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 491);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 17);
            this.label9.TabIndex = 95;
            this.label9.Text = "NILAI_TUNJANGAN";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 552);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 64);
            this.button1.TabIndex = 97;
            this.button1.Text = "SIMPAN DATA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 653);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNilai_Tunjangan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTransport);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGaji_Pokok);
            this.Controls.Add(this.txtUang_Makan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbJenisKelamin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtNo_Pegawai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNm_pegawai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "INPUT DATA PEGAWAI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNm_pegawai;
        private System.Windows.Forms.TextBox txtNo_Pegawai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbJenisKelamin;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGaji_Pokok;
        private System.Windows.Forms.TextBox txtUang_Makan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTransport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNilai_Tunjangan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}


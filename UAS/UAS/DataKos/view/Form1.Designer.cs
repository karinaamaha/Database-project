namespace DataKos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Tombol_Hapus = new System.Windows.Forms.Button();
            this.Tombol_Ubah = new System.Windows.Forms.Button();
            this.Tombol_Simpan = new System.Windows.Forms.Button();
            this.Alamat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NoHp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NoKos = new System.Windows.Forms.TextBox();
            this.Nama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CariData = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataTable);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1241, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabel Data Penghuni";
            // 
            // DataTable
            // 
            this.DataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataTable.BackgroundColor = System.Drawing.Color.MintCream;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Location = new System.Drawing.Point(6, 21);
            this.DataTable.Name = "DataTable";
            this.DataTable.RowHeadersWidth = 51;
            this.DataTable.RowTemplate.Height = 24;
            this.DataTable.Size = new System.Drawing.Size(1208, 235);
            this.DataTable.TabIndex = 0;
            this.DataTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTable_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Tombol_Hapus);
            this.groupBox2.Controls.Add(this.Tombol_Ubah);
            this.groupBox2.Controls.Add(this.Tombol_Simpan);
            this.groupBox2.Controls.Add(this.Alamat);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.NoHp);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.NoKos);
            this.groupBox2.Controls.Add(this.Nama);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 344);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 373);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Input Data";
            // 
            // Tombol_Hapus
            // 
            this.Tombol_Hapus.BackColor = System.Drawing.Color.Red;
            this.Tombol_Hapus.Font = new System.Drawing.Font("Rufina", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tombol_Hapus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tombol_Hapus.Location = new System.Drawing.Point(56, 307);
            this.Tombol_Hapus.Name = "Tombol_Hapus";
            this.Tombol_Hapus.Size = new System.Drawing.Size(628, 37);
            this.Tombol_Hapus.TabIndex = 12;
            this.Tombol_Hapus.Text = "Hapus";
            this.Tombol_Hapus.UseVisualStyleBackColor = false;
            this.Tombol_Hapus.Click += new System.EventHandler(this.Tombol_Hapus_Click);
            // 
            // Tombol_Ubah
            // 
            this.Tombol_Ubah.BackColor = System.Drawing.Color.MediumBlue;
            this.Tombol_Ubah.Font = new System.Drawing.Font("Rufina", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tombol_Ubah.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tombol_Ubah.Location = new System.Drawing.Point(56, 252);
            this.Tombol_Ubah.Name = "Tombol_Ubah";
            this.Tombol_Ubah.Size = new System.Drawing.Size(628, 37);
            this.Tombol_Ubah.TabIndex = 11;
            this.Tombol_Ubah.Text = "Ubah";
            this.Tombol_Ubah.UseVisualStyleBackColor = false;
            this.Tombol_Ubah.Click += new System.EventHandler(this.Tombol_Ubah_Click);
            // 
            // Tombol_Simpan
            // 
            this.Tombol_Simpan.BackColor = System.Drawing.Color.Lime;
            this.Tombol_Simpan.FlatAppearance.BorderSize = 0;
            this.Tombol_Simpan.Font = new System.Drawing.Font("Rufina", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tombol_Simpan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Tombol_Simpan.Location = new System.Drawing.Point(56, 197);
            this.Tombol_Simpan.Name = "Tombol_Simpan";
            this.Tombol_Simpan.Size = new System.Drawing.Size(628, 37);
            this.Tombol_Simpan.TabIndex = 10;
            this.Tombol_Simpan.Text = "Simpan";
            this.Tombol_Simpan.UseVisualStyleBackColor = false;
            this.Tombol_Simpan.Click += new System.EventHandler(this.Tombol_Simpan_Click);
            // 
            // Alamat
            // 
            this.Alamat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Alamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Alamat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alamat.Location = new System.Drawing.Point(481, 55);
            this.Alamat.Name = "Alamat";
            this.Alamat.Size = new System.Drawing.Size(255, 27);
            this.Alamat.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rufina", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(396, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Alamat";
            // 
            // NoHp
            // 
            this.NoHp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NoHp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NoHp.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoHp.Location = new System.Drawing.Point(481, 109);
            this.NoHp.Name = "NoHp";
            this.NoHp.Size = new System.Drawing.Size(255, 27);
            this.NoHp.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rufina", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(394, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "No HP";
            // 
            // NoKos
            // 
            this.NoKos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NoKos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NoKos.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoKos.Location = new System.Drawing.Point(113, 109);
            this.NoKos.Name = "NoKos";
            this.NoKos.Size = new System.Drawing.Size(252, 27);
            this.NoKos.TabIndex = 5;
            // 
            // Nama
            // 
            this.Nama.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Nama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nama.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nama.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Nama.Location = new System.Drawing.Point(113, 56);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(252, 27);
            this.Nama.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rufina", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "No Kos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rufina", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CariData);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(803, 344);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(450, 97);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Form Pencarian";
            // 
            // CariData
            // 
            this.CariData.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CariData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CariData.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CariData.Location = new System.Drawing.Point(133, 33);
            this.CariData.Name = "CariData";
            this.CariData.Size = new System.Drawing.Size(280, 27);
            this.CariData.TabIndex = 11;
            this.CariData.TextChanged += new System.EventHandler(this.CariData_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rufina", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nama/No Kos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "SISTEM INFORMASI KOS KAK SRI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1265, 745);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataKos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox NoKos;
        private System.Windows.Forms.TextBox Nama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NoHp;
        private System.Windows.Forms.Button Tombol_Hapus;
        private System.Windows.Forms.Button Tombol_Ubah;
        private System.Windows.Forms.Button Tombol_Simpan;
        private System.Windows.Forms.TextBox Alamat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CariData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.Label label1;
    }
}


namespace PerjalananPenerbangan
{
    partial class FormJadwalPenerbangan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCariMaskapaiPenerbangan = new System.Windows.Forms.Label();
            this.dgvJadwalPenerbangan = new System.Windows.Forms.DataGridView();
            this.MaskapaiPenerbangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomorPenerbangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JamPenerbangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JamKetibaan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KotaAsal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destinasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblJamPenerbangan = new System.Windows.Forms.Label();
            this.lblJamKetibaan = new System.Windows.Forms.Label();
            this.lblDestinasi = new System.Windows.Forms.Label();
            this.lblKotaAsal = new System.Windows.Forms.Label();
            this.txtCariMaskapaiPenerbangan = new System.Windows.Forms.TextBox();
            this.txtJamPenerbangan = new System.Windows.Forms.TextBox();
            this.txtJamKetibaan = new System.Windows.Forms.TextBox();
            this.txtKotaAsal = new System.Windows.Forms.TextBox();
            this.txtDestinasi = new System.Windows.Forms.TextBox();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.lblHarga = new System.Windows.Forms.Label();
            this.txtNamaPerusahaan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwalPenerbangan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCariMaskapaiPenerbangan
            // 
            this.lblCariMaskapaiPenerbangan.AutoSize = true;
            this.lblCariMaskapaiPenerbangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCariMaskapaiPenerbangan.Location = new System.Drawing.Point(50, 21);
            this.lblCariMaskapaiPenerbangan.Name = "lblCariMaskapaiPenerbangan";
            this.lblCariMaskapaiPenerbangan.Size = new System.Drawing.Size(317, 29);
            this.lblCariMaskapaiPenerbangan.TabIndex = 0;
            this.lblCariMaskapaiPenerbangan.Text = "Cari Maskapai Penerbangan";
            // 
            // dgvJadwalPenerbangan
            // 
            this.dgvJadwalPenerbangan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJadwalPenerbangan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJadwalPenerbangan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvJadwalPenerbangan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJadwalPenerbangan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaskapaiPenerbangan,
            this.NomorPenerbangan,
            this.JamPenerbangan,
            this.JamKetibaan,
            this.KotaAsal,
            this.Destinasi,
            this.Harga});
            this.dgvJadwalPenerbangan.Location = new System.Drawing.Point(28, 270);
            this.dgvJadwalPenerbangan.Name = "dgvJadwalPenerbangan";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJadwalPenerbangan.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvJadwalPenerbangan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvJadwalPenerbangan.RowTemplate.Height = 24;
            this.dgvJadwalPenerbangan.Size = new System.Drawing.Size(1318, 268);
            this.dgvJadwalPenerbangan.TabIndex = 1;
            this.dgvJadwalPenerbangan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJadwalPenerbangan_CellClick);
            // 
            // MaskapaiPenerbangan
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MaskapaiPenerbangan.DefaultCellStyle = dataGridViewCellStyle11;
            this.MaskapaiPenerbangan.HeaderText = "Maskapai Penerbangan";
            this.MaskapaiPenerbangan.MaxInputLength = 255;
            this.MaskapaiPenerbangan.MinimumWidth = 6;
            this.MaskapaiPenerbangan.Name = "MaskapaiPenerbangan";
            // 
            // NomorPenerbangan
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NomorPenerbangan.DefaultCellStyle = dataGridViewCellStyle12;
            this.NomorPenerbangan.HeaderText = "Nomor Penerbangan";
            this.NomorPenerbangan.MaxInputLength = 255;
            this.NomorPenerbangan.MinimumWidth = 6;
            this.NomorPenerbangan.Name = "NomorPenerbangan";
            // 
            // JamPenerbangan
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.JamPenerbangan.DefaultCellStyle = dataGridViewCellStyle13;
            this.JamPenerbangan.HeaderText = "Jam Penerbangan";
            this.JamPenerbangan.MaxInputLength = 255;
            this.JamPenerbangan.MinimumWidth = 6;
            this.JamPenerbangan.Name = "JamPenerbangan";
            // 
            // JamKetibaan
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.JamKetibaan.DefaultCellStyle = dataGridViewCellStyle14;
            this.JamKetibaan.HeaderText = "Jam Ketibaan";
            this.JamKetibaan.MaxInputLength = 255;
            this.JamKetibaan.MinimumWidth = 6;
            this.JamKetibaan.Name = "JamKetibaan";
            // 
            // KotaAsal
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.KotaAsal.DefaultCellStyle = dataGridViewCellStyle15;
            this.KotaAsal.HeaderText = "Kota Asal";
            this.KotaAsal.MaxInputLength = 255;
            this.KotaAsal.MinimumWidth = 6;
            this.KotaAsal.Name = "KotaAsal";
            // 
            // Destinasi
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Destinasi.DefaultCellStyle = dataGridViewCellStyle16;
            this.Destinasi.HeaderText = "Destinasi";
            this.Destinasi.MaxInputLength = 255;
            this.Destinasi.MinimumWidth = 6;
            this.Destinasi.Name = "Destinasi";
            // 
            // Harga
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.Format = "N0";
            dataGridViewCellStyle17.NullValue = null;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Harga.DefaultCellStyle = dataGridViewCellStyle17;
            this.Harga.HeaderText = "Harga";
            this.Harga.MaxInputLength = 30;
            this.Harga.MinimumWidth = 6;
            this.Harga.Name = "Harga";
            // 
            // lblJamPenerbangan
            // 
            this.lblJamPenerbangan.AutoSize = true;
            this.lblJamPenerbangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJamPenerbangan.Location = new System.Drawing.Point(158, 59);
            this.lblJamPenerbangan.Name = "lblJamPenerbangan";
            this.lblJamPenerbangan.Size = new System.Drawing.Size(209, 29);
            this.lblJamPenerbangan.TabIndex = 2;
            this.lblJamPenerbangan.Text = "Jam Penerbangan";
            // 
            // lblJamKetibaan
            // 
            this.lblJamKetibaan.AutoSize = true;
            this.lblJamKetibaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJamKetibaan.Location = new System.Drawing.Point(208, 101);
            this.lblJamKetibaan.Name = "lblJamKetibaan";
            this.lblJamKetibaan.Size = new System.Drawing.Size(159, 29);
            this.lblJamKetibaan.TabIndex = 3;
            this.lblJamKetibaan.Text = "Jam Ketibaan";
            // 
            // lblDestinasi
            // 
            this.lblDestinasi.AutoSize = true;
            this.lblDestinasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinasi.Location = new System.Drawing.Point(257, 181);
            this.lblDestinasi.Name = "lblDestinasi";
            this.lblDestinasi.Size = new System.Drawing.Size(112, 29);
            this.lblDestinasi.TabIndex = 4;
            this.lblDestinasi.Text = "Destinasi";
            // 
            // lblKotaAsal
            // 
            this.lblKotaAsal.AutoSize = true;
            this.lblKotaAsal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKotaAsal.Location = new System.Drawing.Point(253, 141);
            this.lblKotaAsal.Name = "lblKotaAsal";
            this.lblKotaAsal.Size = new System.Drawing.Size(114, 29);
            this.lblKotaAsal.TabIndex = 5;
            this.lblKotaAsal.Text = "Kota Asal";
            // 
            // txtCariMaskapaiPenerbangan
            // 
            this.txtCariMaskapaiPenerbangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCariMaskapaiPenerbangan.Location = new System.Drawing.Point(375, 19);
            this.txtCariMaskapaiPenerbangan.Name = "txtCariMaskapaiPenerbangan";
            this.txtCariMaskapaiPenerbangan.Size = new System.Drawing.Size(741, 34);
            this.txtCariMaskapaiPenerbangan.TabIndex = 6;
            this.txtCariMaskapaiPenerbangan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCariMaskapaiPenerbangan_KeyDown);
            // 
            // txtJamPenerbangan
            // 
            this.txtJamPenerbangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJamPenerbangan.Location = new System.Drawing.Point(375, 59);
            this.txtJamPenerbangan.Name = "txtJamPenerbangan";
            this.txtJamPenerbangan.Size = new System.Drawing.Size(741, 34);
            this.txtJamPenerbangan.TabIndex = 7;
            this.txtJamPenerbangan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtJamPenerbangan_KeyDown);
            // 
            // txtJamKetibaan
            // 
            this.txtJamKetibaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJamKetibaan.Location = new System.Drawing.Point(375, 99);
            this.txtJamKetibaan.Name = "txtJamKetibaan";
            this.txtJamKetibaan.ReadOnly = true;
            this.txtJamKetibaan.Size = new System.Drawing.Size(741, 34);
            this.txtJamKetibaan.TabIndex = 8;
            // 
            // txtKotaAsal
            // 
            this.txtKotaAsal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKotaAsal.Location = new System.Drawing.Point(375, 139);
            this.txtKotaAsal.Name = "txtKotaAsal";
            this.txtKotaAsal.Size = new System.Drawing.Size(741, 34);
            this.txtKotaAsal.TabIndex = 9;
            this.txtKotaAsal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKotaAsal_KeyDown);
            // 
            // txtDestinasi
            // 
            this.txtDestinasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestinasi.Location = new System.Drawing.Point(375, 179);
            this.txtDestinasi.Name = "txtDestinasi";
            this.txtDestinasi.Size = new System.Drawing.Size(741, 34);
            this.txtDestinasi.TabIndex = 10;
            this.txtDestinasi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDestinasi_KeyDown);
            // 
            // btnBooking
            // 
            this.btnBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.Location = new System.Drawing.Point(28, 544);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(1088, 60);
            this.btnBooking.TabIndex = 11;
            this.btnBooking.Text = "BOOKING";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1122, 544);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(224, 60);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Location = new System.Drawing.Point(1122, 140);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(224, 114);
            this.btnSignOut.TabIndex = 13;
            this.btnSignOut.Text = "SIGN OUT";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // txtHarga
            // 
            this.txtHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHarga.Location = new System.Drawing.Point(375, 219);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.ReadOnly = true;
            this.txtHarga.Size = new System.Drawing.Size(741, 34);
            this.txtHarga.TabIndex = 15;
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHarga.Location = new System.Drawing.Point(293, 221);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(78, 29);
            this.lblHarga.TabIndex = 14;
            this.lblHarga.Text = "Harga";
            // 
            // txtNamaPerusahaan
            // 
            this.txtNamaPerusahaan.AutoSize = true;
            this.txtNamaPerusahaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaPerusahaan.Location = new System.Drawing.Point(421, 617);
            this.txtNamaPerusahaan.Name = "txtNamaPerusahaan";
            this.txtNamaPerusahaan.Size = new System.Drawing.Size(585, 91);
            this.txtNamaPerusahaan.TabIndex = 16;
            this.txtNamaPerusahaan.Text = "AH COMPANY";
            this.txtNamaPerusahaan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormJadwalPenerbangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 717);
            this.Controls.Add(this.txtNamaPerusahaan);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.txtDestinasi);
            this.Controls.Add(this.txtKotaAsal);
            this.Controls.Add(this.txtJamKetibaan);
            this.Controls.Add(this.txtJamPenerbangan);
            this.Controls.Add(this.txtCariMaskapaiPenerbangan);
            this.Controls.Add(this.lblKotaAsal);
            this.Controls.Add(this.lblDestinasi);
            this.Controls.Add(this.lblJamKetibaan);
            this.Controls.Add(this.lblJamPenerbangan);
            this.Controls.Add(this.dgvJadwalPenerbangan);
            this.Controls.Add(this.lblCariMaskapaiPenerbangan);
            this.Name = "FormJadwalPenerbangan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jadwal Penerbangan";
            this.Load += new System.EventHandler(this.FormJadwalPenerbangan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwalPenerbangan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCariMaskapaiPenerbangan;
        private System.Windows.Forms.DataGridView dgvJadwalPenerbangan;
        private System.Windows.Forms.Label lblJamPenerbangan;
        private System.Windows.Forms.Label lblJamKetibaan;
        private System.Windows.Forms.Label lblDestinasi;
        private System.Windows.Forms.Label lblKotaAsal;
        private System.Windows.Forms.TextBox txtCariMaskapaiPenerbangan;
        private System.Windows.Forms.TextBox txtJamPenerbangan;
        private System.Windows.Forms.TextBox txtJamKetibaan;
        private System.Windows.Forms.TextBox txtKotaAsal;
        private System.Windows.Forms.TextBox txtDestinasi;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaskapaiPenerbangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomorPenerbangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn JamPenerbangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn JamKetibaan;
        private System.Windows.Forms.DataGridViewTextBoxColumn KotaAsal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destinasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
        private System.Windows.Forms.Label txtNamaPerusahaan;
    }
}
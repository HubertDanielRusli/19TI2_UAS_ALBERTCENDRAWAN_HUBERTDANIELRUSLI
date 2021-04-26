namespace PerjalananPenerbangan
{
    partial class FormPembayaran
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
            this.lblMetodePembayaran = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnTunai = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblHarga = new System.Windows.Forms.Label();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMetodePembayaran
            // 
            this.lblMetodePembayaran.AutoSize = true;
            this.lblMetodePembayaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodePembayaran.Location = new System.Drawing.Point(251, 23);
            this.lblMetodePembayaran.Name = "lblMetodePembayaran";
            this.lblMetodePembayaran.Size = new System.Drawing.Size(288, 36);
            this.lblMetodePembayaran.TabIndex = 0;
            this.lblMetodePembayaran.Text = "Metode Pembayaran";
            // 
            // btnTransfer
            // 
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.Location = new System.Drawing.Point(125, 142);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(166, 46);
            this.btnTransfer.TabIndex = 2;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnTunai
            // 
            this.btnTunai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTunai.Location = new System.Drawing.Point(302, 142);
            this.btnTunai.Name = "btnTunai";
            this.btnTunai.Size = new System.Drawing.Size(169, 45);
            this.btnTunai.TabIndex = 3;
            this.btnTunai.Text = "Tunai";
            this.btnTunai.UseVisualStyleBackColor = true;
            this.btnTunai.Click += new System.EventHandler(this.btnTunai_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(488, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(183, 44);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHarga.Location = new System.Drawing.Point(217, 99);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(78, 29);
            this.lblHarga.TabIndex = 5;
            this.lblHarga.Text = "Harga";
            // 
            // txtHarga
            // 
            this.txtHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHarga.Location = new System.Drawing.Point(301, 96);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.ReadOnly = true;
            this.txtHarga.Size = new System.Drawing.Size(277, 34);
            this.txtHarga.TabIndex = 6;
            this.txtHarga.Text = "600.000,00";
            this.txtHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 213);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTunai);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.lblMetodePembayaran);
            this.Name = "FormPembayaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metode Pembayaran";
            this.Load += new System.EventHandler(this.FormPembayaran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMetodePembayaran;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnTunai;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.TextBox txtHarga;
    }
}
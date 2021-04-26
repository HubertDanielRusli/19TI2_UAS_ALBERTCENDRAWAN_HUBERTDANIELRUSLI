using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerjalananPenerbangan
{
    public partial class FormPembayaran : Form
    {
        // Variabel global
        private string caption;

        public string Caption { get => caption; set => caption = value; }

        public FormPembayaran()
        {
            InitializeComponent();
        }

        private void FormPembayaran_Load(object sender, EventArgs e)
        {
            // Harga akan ditampilkan dalam textBox
            txtHarga.Text = this.Caption;
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            string pemberitahuan;

            /*
            pemberitahuan = "Virtual Account: 01010121233445 \n\n" +
                "Jika sudah selesai, akan mendapat bon dan tiket dari e-mail. \n" +
                "Jika belum melakukan pembayaran dalam jangka waktu 15 menit, maka booking akan hangus. \n"; */

            pemberitahuan = "Anda telah memilih pembayaran \"TRANSFER\". \n" +
                "Pembayaran akan dilakukan dalam lokasi Virtual Account milik Anda. \n" +
                "Terkait bukti pembayaran (bon, tunai), segera cek dari e-mail. \n\n" + 
                "Setelah mengklik tombol \"OK\", Anda diminta waktu sekitar 30 menit untuk melakukan transfer pembiayaan. \n\n" +
                "Virtual Account: 01010121233445 \n\n";

            MessageBox.Show(pemberitahuan, "Metode Pembayaran: TRANSFER", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Langsung ke form untuk Login
            FormLogin formLogin = new FormLogin();
            formLogin.Show(); this.Hide();
        }

        private void btnTunai_Click(object sender, EventArgs e)
        {
            string pemberitahuan;

            pemberitahuan = "Anda telah memilih pembayaran \"TUNAI\". \n" +
                "Pembayaran akan diserahkan dan dilaksanakan di front-desk Airport. \n" +
                "Silakan Anda mengecek bukti pembayaran dalam e-mail Anda. \n";

            MessageBox.Show(pemberitahuan, "Metode Pembayaran: TUNAI", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Langsung ke form untuk Login
            FormLogin formLogin = new FormLogin();
            formLogin.Show(); this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // User ditanya, apakah serius ingin membatalkan pembayaran atau tetap lanjut
            string peringatan;
            DialogResult konfirmasi;

            peringatan = "Apakah Anda ingin kembali ke Halaman: \n\n" + "JADWAL PENERBANGAN \n" + "dan meninggalkan halaman ini? \n";
            konfirmasi = MessageBox.Show(peringatan, "Konfirmasi Keluar Form Pembayaran", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                // Kembali ke form jadwal penerbangan; pembayaran dibatalkan
                FormJadwalPenerbangan formJadwalPenerbangan = new FormJadwalPenerbangan();
                formJadwalPenerbangan.Show(); this.Hide();
            }
        }
    }
}

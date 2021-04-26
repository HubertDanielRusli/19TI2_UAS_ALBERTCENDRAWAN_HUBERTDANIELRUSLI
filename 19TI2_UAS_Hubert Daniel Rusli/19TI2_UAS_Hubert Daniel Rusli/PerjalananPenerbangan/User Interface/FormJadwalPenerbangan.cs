using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using PerjalananPenerbangan.Model;

namespace PerjalananPenerbangan
{
    public partial class FormJadwalPenerbangan : Form
    {
        /**
         * Notes:
         * Class ini digunakan dalam proses akses data dari Visual Studio C# ke Microsoft Access dan sebaliknya
         * Bahasa yang digunakan: C# dan SQL
         */

        // Connect dari Visual Studio ke Microsoft Access
        private const string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:/Computer/Universitas Pelita Harapan/UPH 25 - Pengembangan Piranti Lunak/PPL 15 -- 20 04 2021 -- Presentasi Dokumentasi & Project/FOLDER UAS/DatabasePerjalananPenerbangan.accdb; Persist Security Info = False";
        static readonly OleDbConnection dbConnection = new OleDbConnection(connectString);

        // Buat objek dalam hal pengaturan Database
        static OleDbCommand cmd;
        static OleDbDataAdapter adapter;

        static readonly DataTable dataTable = new DataTable();
        internal DataJadwalPenerbangan dataJadwalPenerbangan = new DataJadwalPenerbangan();

        // Variabel private, yang nanti diakses secara global melalui get-set
        private string caption;

        public string Caption { get => caption; set => caption = value; }

        public FormJadwalPenerbangan()
        {
            InitializeComponent();
        }

        private void FormJadwalPenerbangan_Load(object sender, EventArgs e)
        {
            // Ubah caption dari form Jadwal Penerbangan
            this.Text = "Selamat datang, " + Caption + "!";

            // Dari DataGridView, ubah tampilan data record dari String -> DateTime
            dgvJadwalPenerbangan.Columns[2].DefaultCellStyle.Format = "hh:mm";
            dgvJadwalPenerbangan.Columns[3].DefaultCellStyle.Format = "hh:mm";

            // Load database Tabel_JadwalPenerbangan
            SQL_Load("");
        }

        private void SQL_Load(string parameter1)
        {
            dgvJadwalPenerbangan.Rows.Clear();

            try
            {
                // Retrieve data from TabelBarang
                String sqlCommand = "SELECT * FROM Tabel_JadwalPenerbangan WHERE Nomor_Penerbangan LIKE '" + parameter1 + "%'";

                // Buat objek baru dari connection database
                cmd = new OleDbCommand(sqlCommand, dbConnection);

                // buka database Access
                dbConnection.Open();

                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dataTable);

                foreach (DataRow tableRow in dataTable.Rows)
                {
                    // Masukkan data dari tabel Database ke dalam DGV, sesuai posisi masing-masing
                    dataJadwalPenerbangan.MaskapaiPenerbangan = tableRow[1].ToString();
                    dataJadwalPenerbangan.NomorPenerbangan = tableRow[2].ToString();
                    dataJadwalPenerbangan.JamPenerbangan = DateTime.Parse(tableRow[3].ToString());
                    dataJadwalPenerbangan.JamKetibaan = DateTime.Parse(tableRow[4].ToString());
                    dataJadwalPenerbangan.KotaAsal = tableRow[5].ToString();
                    dataJadwalPenerbangan.Destinasi = tableRow[6].ToString();
                    dataJadwalPenerbangan.Harga = Int32.Parse(tableRow[7].ToString());

                    Populate();
                }

                dataTable.Rows.Clear();
            }
            catch (Exception ex)
            {
                // Bila proses terkait database mengalami masalah, tampilkan pesan error
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        private void SQL_Select_Where(string parameter, string value)
        {
            // Note: sudah bisa, mantep

            string[] parameterList;
            string SQLCommand = "";

            parameterList = new string[7];
            parameterList[0] = "maskapai penerbangan";
            parameterList[1] = "nomor penerbangan";
            parameterList[2] = "jam penerbangan";
            parameterList[3] = "jam ketibaan";
            parameterList[4] = "kota asal";
            parameterList[5] = "destinasi";
            parameterList[6] = "tanggal";

            dgvJadwalPenerbangan.Rows.Clear();

            try
            {   
                // Bandingkan parameter dengan elemen - elemen di parameterList
                if (parameter.ToLower().Equals(parameterList[0])) SQLCommand = "SELECT * FROM Tabel_JadwalPenerbangan WHERE " + "Maskapai_Penerbangan LIKE '%" + value + "%'";
                else if (parameter.ToLower().Equals(parameterList[1])) SQLCommand = "SELECT * FROM Tabel_JadwalPenerbangan WHERE " + "Nomor_Penerbangan LIKE '" + value + "%'";
                else if (parameter.ToLower().Equals(parameterList[2])) SQLCommand = "SELECT * FROM Tabel_JadwalPenerbangan WHERE " + "Jam_Penerbangan LIKE '%" + value + "%'";
                else if (parameter.ToLower().Equals(parameterList[3])) SQLCommand = "SELECT * FROM Tabel_JadwalPenerbangan WHERE " + "Jam_Ketibaan LIKE '%" + value + "%'";
                else if (parameter.ToLower().Equals(parameterList[4])) SQLCommand = "SELECT * FROM Tabel_JadwalPenerbangan WHERE " + "Kota_Asal LIKE '%" + value + "%'";
                else if (parameter.ToLower().Equals(parameterList[5])) SQLCommand = "SELECT * FROM Tabel_JadwalPenerbangan WHERE " + "Destinasi LIKE '%" + value + "%'";
                else if (parameter.ToLower().Equals(parameterList[6])) SQLCommand = "SELECT * FROM Tabel_JadwalPenerbangan WHERE " + "Tanggal LIKE '" + value + "%'";

                cmd = new OleDbCommand(SQLCommand, dbConnection);
                dbConnection.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dataTable);

                foreach (DataRow tableRow in dataTable.Rows)
                {
                    // Masukkan data dari Tabel_JadwalPenerbangan ke dalam DGV Jadwal Penerbangan di Form
                    dataJadwalPenerbangan.MaskapaiPenerbangan = tableRow[1].ToString();
                    dataJadwalPenerbangan.NomorPenerbangan = tableRow[2].ToString();
                    dataJadwalPenerbangan.JamPenerbangan = DateTime.Parse(tableRow[3].ToString());
                    dataJadwalPenerbangan.JamKetibaan = DateTime.Parse(tableRow[4].ToString());
                    dataJadwalPenerbangan.KotaAsal = tableRow[5].ToString();
                    dataJadwalPenerbangan.Destinasi = tableRow[6].ToString();
                    dataJadwalPenerbangan.Harga = Int32.Parse(tableRow[7].ToString());

                    Populate();
                }

                dataTable.Rows.Clear();
            }
            catch (Exception ex)
            {
                // Bila proses terkait database mengalami masalah, tampilkan pesan error
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        private void Populate()
        {
            // Masukkan data dari Model ke dataGridView
            dgvJadwalPenerbangan.Rows.Add(dataJadwalPenerbangan.MaskapaiPenerbangan, dataJadwalPenerbangan.NomorPenerbangan, dataJadwalPenerbangan.JamPenerbangan, dataJadwalPenerbangan.JamKetibaan, dataJadwalPenerbangan.KotaAsal, dataJadwalPenerbangan.Destinasi, dataJadwalPenerbangan.Harga);
        }

        private void txtCariMaskapaiPenerbangan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Bandingkan input "Maskapai Penerbangan" dengan data tabel di database Access
                SQL_Select_Where("Maskapai Penerbangan", txtCariMaskapaiPenerbangan.Text);
            }
        }
        private void txtJamPenerbangan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Bandingkan input "Jam Penerbangan" dengan data tabel di database Access
                SQL_Select_Where("Jam penerbangan", txtJamPenerbangan.Text);
            }
        }

        private void txtKotaAsal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Bandingkan input "Kota Asal" dengan data tabel di database Access
                SQL_Select_Where("Kota Asal", txtKotaAsal.Text);
            }
        }

        private void txtDestinasi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Bandingkan input "Destinasi" dengan data tabel di database Access
                SQL_Select_Where("Destinasi", txtDestinasi.Text);
            }
        }

        private void dgvJadwalPenerbangan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /**
             * Event ini terjadi apabila user mengklik sebuah cell dalam DGV
             * Hasil: data dari DGV akan masuk ke textBox secara otomatis
             */

            int dgv_Index;

            // Tentukan indeksnya terlebih dahulu
            dgv_Index = e.RowIndex;

            if (dgv_Index == dgvJadwalPenerbangan.Rows.Count - 1)
            {
                ClearAllInputBox();
            }
            else if (dgv_Index >= 0 && dgv_Index < dgvJadwalPenerbangan.Rows.Count - 1)
            {
                // Jadikan baris (record) dari cellClick tersebut ke 1 variabel
                DataGridViewRow tableRecord = dgvJadwalPenerbangan.Rows[dgv_Index];

                // Selanjutnya, object - object tersebut dibandingkan: apakah NULL atau NOTNULL
                // <K1> Bila semua nilai dalam sebuah record = NULL
                if (SomeCellsAreEmpty(tableRecord))
                {
                    ClearAllInputBox();
                }
                else
                {
                    txtCariMaskapaiPenerbangan.Text = tableRecord.Cells[0].Value.ToString();
                    txtJamPenerbangan.Text = DateTime.Parse(tableRecord.Cells[2].Value.ToString()).ToString("hh:mm");
                    txtJamKetibaan.Text = DateTime.Parse(tableRecord.Cells[3].Value.ToString()).ToString("hh:mm");
                    txtKotaAsal.Text = tableRecord.Cells[4].Value.ToString();
                    txtDestinasi.Text = tableRecord.Cells[5].Value.ToString();
                    txtHarga.Text = tableRecord.Cells[6].Value.ToString();
                }
            }
        }

        private bool SomeCellsAreEmpty(DataGridViewRow tableRecord)
        {
            object isi_MaskapaiPenerbangan, isi_NomorPenerbangan, isi_JamPenerbangan;
            object isi_JamKetibaan, isi_KotaAsal, isi_Destinasi, isi_Tanggal;

            bool cellMaskapaiPenerbangan_Kosong, cellNomorPenerbangan_Kosong, cellJamPenerbangan_Kosong;
            bool cellJamKetibaan_Kosong, cellKotaAsal_Kosong, cellDestinasi_Kosong, cellTanggal_Kosong;

            // Golongkan dalam bentuk object - object, sesuai dengan field (column)-nya
            isi_MaskapaiPenerbangan = tableRecord.Cells[0].Value;
            isi_NomorPenerbangan = tableRecord.Cells[1].Value;
            isi_JamPenerbangan = tableRecord.Cells[2].Value;
            isi_JamKetibaan = tableRecord.Cells[3].Value;
            isi_KotaAsal = tableRecord.Cells[4].Value;
            isi_Destinasi = tableRecord.Cells[5].Value;
            isi_Tanggal = tableRecord.Cells[6].Value;

            cellMaskapaiPenerbangan_Kosong = (isi_MaskapaiPenerbangan == null);
            cellNomorPenerbangan_Kosong = (isi_NomorPenerbangan == null);
            cellJamPenerbangan_Kosong = (isi_JamPenerbangan == null);
            cellJamKetibaan_Kosong = (isi_JamKetibaan == null);
            cellKotaAsal_Kosong = (isi_KotaAsal == null);
            cellDestinasi_Kosong = (isi_Destinasi == null);
            cellTanggal_Kosong = (isi_Tanggal == null);

            if (cellMaskapaiPenerbangan_Kosong || cellNomorPenerbangan_Kosong || cellJamPenerbangan_Kosong || cellJamKetibaan_Kosong || cellKotaAsal_Kosong || cellDestinasi_Kosong || cellTanggal_Kosong) return true;
            return false;
        }

        private bool SomeTextBoxesAreEmpty()
        {
            bool txtCariMaskapaiPenerbangan_Kosong, txtJamPenerbangan_Kosong, txtJamKetibaan_Kosong;
            bool txtKotaAsal_Kosong, txtDestinasi_Kosong;

            txtCariMaskapaiPenerbangan_Kosong = (txtCariMaskapaiPenerbangan.Text == String.Empty);
            txtJamPenerbangan_Kosong = (txtJamPenerbangan.Text == String.Empty);
            txtJamKetibaan_Kosong = (txtJamKetibaan.Text == String.Empty);

            txtKotaAsal_Kosong = (txtKotaAsal.Text == String.Empty);
            txtDestinasi_Kosong = (txtDestinasi.Text == String.Empty);

            if (txtCariMaskapaiPenerbangan_Kosong || txtJamPenerbangan_Kosong || txtJamKetibaan_Kosong || txtKotaAsal_Kosong || txtDestinasi_Kosong) return true;
            else return false;
        }
        
        private void btnBooking_Click(object sender, EventArgs e)
        {
            string peringatan;
            DialogResult konfirmasi;

            if (SomeTextBoxesAreEmpty()) // Bila salah satu input masih kosong
            {
                peringatan = "Mohon maaf, input masih belum lengkap. \n\n" + "Silakan cek input Anda kembali. \n";

                MessageBox.Show(peringatan, "Input Tidak Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else // Semua textBox sudah terisi
            {
                peringatan = "Apakah Anda yakin dengan pesanan yang telah diinput? \n";
                konfirmasi = MessageBox.Show(peringatan, "Konfirmasi Pesanan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (konfirmasi == DialogResult.Yes)
                {
                    FormPembayaran formPembayaran = new FormPembayaran();

                    // Input harga akan dimasukkan dalam Caption
                    formPembayaran.Caption = txtHarga.Text;

                    // Langsung masuk ke form Pembayaran
                    formPembayaran.Show(); this.Hide();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Hapus semua data input dalam TextBox, sehingga jadi bersih seperti semula
            ClearAllInputBox();

            // Setelah itu, load kembali database seperti semula
            SQL_Load("");
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            string peringatan;
            DialogResult konfirmasi;

            peringatan = "Button ini akan mengarahkan Anda ke halaman LOGIN. \n\n" + "Anda yakin? \n";
            konfirmasi = MessageBox.Show(peringatan, "Konfirmasi ke Halaman Login", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                // Hapus isi data dalam TextBox
                ClearAllInputBox();

                // Kembali ke Form Login seperti semula
                FormLogin formLogin = new FormLogin();
                formLogin.Show(); this.Hide();
            }
        }

        private void ClearAllInputBox()
        {
            txtCariMaskapaiPenerbangan.Text = txtJamPenerbangan.Text = String.Empty;
            txtJamKetibaan.Text = txtKotaAsal.Text = String.Empty;
            txtDestinasi.Text = txtHarga.Text = String.Empty;
        }
    }
}
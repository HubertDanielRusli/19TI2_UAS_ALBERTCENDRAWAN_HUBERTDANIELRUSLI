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
    public partial class FormLogin : Form
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

        // Object global
        static readonly DataTable dataTable = new DataTable();
        private DataAkun dataAkun;
        private List<DataAkun> daftarAkun = new List<DataAkun>();

        // Variabel global
        private int numberOfRecords;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            SQL_Load("");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Ketika username mengklik Login, data username dan data password akan dicek oleh sistem
            CekAkun(txtUsername.Text, txtPassword.Text);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // User diarahkan untuk masuk ke Form Sign Up untuk mendaftarkan akun
            FormSignUp formSignUp = new FormSignUp();
            formSignUp.Show(); this.Hide();
        }

        private void CekAkun(string stringUsername, string stringPassword)
        {
            // Bila akun sudah ada dalam daftarAkun, berarti bisa Login
            // Bila akun belum ada dalam daftarAkun, berarti tidak bisa Login

            // Cek username dulu
            int accountOrder;
            string inputUsername;

            SQL_Load("");

            // Kalau daftar akun yang masuk = MASIH KOSONG (daftarAkun.Count == 0), tampilkan pesan bahwa tidak ada akun
            // Kalau daftar akun yang masuk = TIDAK KOSONG, cek kesamaan username.

            if (daftarAkun.Count == 0) PesanAkunTidakAda();
            else
            {
                for (accountOrder = 0; accountOrder < daftarAkun.Count; accountOrder++)
                {
                    inputUsername = txtUsername.Text.Trim();
                    // Kalau username tidak sesuai, tampilkan pesan bahwa tidak ada akun
                    // Kalau username ----- sesuai, CekPassword()

                    if (inputUsername.Equals(daftarAkun[accountOrder].Username))
                    {
                        CekPassword(accountOrder);
                        break;
                    }
                    else
                    {
                        if (accountOrder == daftarAkun.Count - 1) PesanAkunTidakAda();
                    }
                }

                daftarAkun.Clear();
            }
        }

        private void CekPassword(int accountOrder)
        {
            bool passwordSudahTepat;
            string inputPassword;

            inputPassword = txtPassword.Text.Trim();
            passwordSudahTepat = inputPassword.Equals(daftarAkun[accountOrder].Password);

            // Kalau password tidak sesuai, tampilkan pesan bahwa tidak ada akun
            // Kalau password ----- sesuai, baru bisa masuk

            if (passwordSudahTepat)
            {
                FormJadwalPenerbangan formJadwalPenerbangan = new FormJadwalPenerbangan();

                // Masukkan username ke dalam caption form Jadwal Penerbangan
                formJadwalPenerbangan.Caption = txtUsername.Text.Trim();

                // Langsung masuk ke form Jadwal Penerbangan
                formJadwalPenerbangan.Show(); this.Hide();
            }
            else PesanAkunTidakAda();
        }

        private void PesanAkunTidakAda()
        {
            string peringatan;
            DialogResult konfirmasi;

            peringatan = "Mohon maaf, data yang Anda input tidak ada di sistem. \n" +
                    "Silakan cek username maupun password Anda.";
            konfirmasi = MessageBox.Show(peringatan, "Login Tidak Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Error);

            peringatan = "Apakah Anda ingin mendaftarkan akun yang baru? \n\n";
            konfirmasi = MessageBox.Show(peringatan, "Konfirmasi Sign In", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (konfirmasi == DialogResult.Yes)
            {
                // Masuk ke form untuk Sign Up
                FormSignUp formSignUp = new FormSignUp();
                formSignUp.Show(); this.Hide();
            }
        }

        private void SQL_Load(string parameter1)
        {
            try
            {
                // buka database Access
                dbConnection.Open();

                // Retrieve data from TabelBarang
                String sqlCommand = "SELECT * FROM Tabel_Akun WHERE Username LIKE '%" + parameter1 + "%'";

                // Buat objek baru dari connection database
                cmd = new OleDbCommand(sqlCommand, dbConnection);

                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dataTable);

                foreach (DataRow tableRow in dataTable.Rows)
                {
                    // Ambil kumpulan data dalam tabel, dari Access ke C#
                    dataAkun = new DataAkun();

                    dataAkun.Username = tableRow[1].ToString();
                    dataAkun.Password = tableRow[2].ToString();
                    dataAkun.EmailAddress = tableRow[3].ToString();
                    dataAkun.NomorHP = tableRow[4].ToString();
                    dataAkun.NegaraAsal = tableRow[5].ToString();

                    daftarAkun.Add(dataAkun);
                }
            }
            catch (Exception ex)
            {
                // Tampilkan pesan error
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            this.Hide();
        }
    }
}
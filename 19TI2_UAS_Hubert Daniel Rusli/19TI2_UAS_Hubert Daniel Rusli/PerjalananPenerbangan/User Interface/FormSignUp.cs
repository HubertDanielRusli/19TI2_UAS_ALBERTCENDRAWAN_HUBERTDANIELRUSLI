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
    public partial class FormSignUp : Form
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
        private DataAkun dataAkun;
        private ComboBoxItems comboBoxItems = new ComboBoxItems();

        private List<ComboBoxItems> comboBoxItemsList = new List<ComboBoxItems>();

        private string messageBoxText;
        private string messageBoxCaption;

        public FormSignUp()
        {
            InitializeComponent();
        }
        private void FormSignUp_Load(object sender, EventArgs e)
        {
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            int order;

            comboBoxItemsList.Add(new ComboBoxItems(0, "Indonesia"));
            comboBoxItemsList.Add(new ComboBoxItems(1, "Malaysia"));
            comboBoxItemsList.Add(new ComboBoxItems(2, "Singapura"));
            comboBoxItemsList.Add(new ComboBoxItems(3, "Thailand"));
            comboBoxItemsList.Add(new ComboBoxItems(4, "Myanmar"));
            comboBoxItemsList.Add(new ComboBoxItems(5, "Vietnam"));

            for (order = 0; order < comboBoxItemsList.Count; order++)
            {
                cbNegaraAsal.Items.Add((object)comboBoxItemsList[order].Values);
            }
        }

        private void txtAlamatEMail_TextChanged(object sender, EventArgs e)
        {
            if (txtAlamatEMail.Text == String.Empty)
            {
                txtKonfirmasiAlamatEMail.Text = "Isi e-mail Anda.";
                txtKonfirmasiAlamatEMail.Enabled = false;
            }
            else
            {
                txtKonfirmasiAlamatEMail.Enabled = true;
                txtKonfirmasiAlamatEMail.Text = String.Empty;
            }
        }

        private void txtKonfirmasiAlamatEMail_TextChanged(object sender, EventArgs e)
        {
            if (txtAlamatEMail.Text == String.Empty)
            {
                txtKonfirmasiAlamatEMail.Text = "Isi e-mail Anda.";
                txtKonfirmasiAlamatEMail.Enabled = false;
            }
            else
            {
                // Cek kembali, apakah input di txtAlamatEMail sama dengan txtKonfirmasiAlamatEMail atau tidak
                if (!txtKonfirmasiAlamatEMail.Text.Equals(txtAlamatEMail.Text)) txtKonfirmasiAlamatEMail.ForeColor = Color.Red;
                else
                {
                    txtKonfirmasiAlamatEMail.Enabled = true;
                    txtKonfirmasiAlamatEMail.ForeColor = Color.Green;
                }
            }
        }

        private void txtKonfirmasiPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == String.Empty)
            {
                txtKonfirmasiPassword.PasswordChar = '\0';

                txtKonfirmasiPassword.Text = "Isi password Anda.";
                txtKonfirmasiPassword.Enabled = false;
            }
            else
            {
                if (!txtKonfirmasiPassword.Text.Equals(txtPassword.Text)) txtKonfirmasiPassword.ForeColor = Color.Red;
                else
                {
                    txtKonfirmasiPassword.Enabled = true;
                    txtKonfirmasiPassword.ForeColor = Color.Green;
                }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == String.Empty)
            {
                txtKonfirmasiPassword.PasswordChar = '\0';
                txtKonfirmasiPassword.Text = "Isi password Anda.";
                txtKonfirmasiPassword.Enabled = false;
            }
            else
            {
                txtKonfirmasiPassword.PasswordChar = '*';
                txtKonfirmasiPassword.Enabled = true;
                txtKonfirmasiPassword.Text = String.Empty;
            }
        }
        
        private void LoadFromDatabase(string namaBarang)
        {
            try
            {
                // Retrieve data from TabelBarang
                String sqlCommand = "SELECT * FROM Tabel_Akun WHERE Username LIKE '%" + namaBarang + "%'";

                // Buat objek baru dari connection database
                cmd = new OleDbCommand(sqlCommand, dbConnection);

                // buka database Access
                dbConnection.Open();

                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dataTable);

                foreach (DataRow tableRow in dataTable.Rows)
                {
                    // Masukkan data dari Tabel ke dgvBarang
                    dataAkun.Username = tableRow[1].ToString();
                    dataAkun.Password = tableRow[2].ToString();
                    dataAkun.EmailAddress = tableRow[3].ToString();
                    dataAkun.NomorHP = tableRow[4].ToString();
                    dataAkun.NegaraAsal = tableRow[5].ToString();
                }

                dbConnection.Close(); //CLEAR DATATABLE 
                dataTable.Rows.Clear();
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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (SomeTextBoxesAreEmpty())
            {
                messageBoxCaption = "Tidak bisa Login";
                messageBoxText = "Mohon maaf. \n" + "Anda harus mengisi input dengan lengkap. \n";
                MessageBox.Show(messageBoxText, messageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // INSERT ke database
                InsertToModel();
                InsertToDatabase(dataAkun);

                // Sambung atau lanjut ke database
                FormLogin formLogin = new FormLogin();
                formLogin.Show(); this.Hide();
            }
        }

        private void InsertToModel()
        {
            // udah benar
            dataAkun = new DataAkun();

            dataAkun.Username = txtUsername.Text;
            dataAkun.Password = txtPassword.Text;
            dataAkun.EmailAddress = txtAlamatEMail.Text;
            dataAkun.NomorHP = txtNomorHP.Text;
            dataAkun.NegaraAsal = comboBoxItems.Values;
        }

        private void InsertToDatabase(DataAkun dataAkun)
        {
            const string SQLCommand = "INSERT INTO Tabel_Akun(Username, [Password], Email_Address, Nomor_HP, Negara_Asal) VALUES(@Username, @Password, @Email_Address, @Nomor_HP, @Negara_Asal)";
            
            cmd = new OleDbCommand(SQLCommand, dbConnection);
            cmd.Parameters.AddWithValue("@Username", dataAkun.Username);
            cmd.Parameters.AddWithValue("@Password", dataAkun.Password);
            cmd.Parameters.AddWithValue("@Email_Address", dataAkun.EmailAddress);
            cmd.Parameters.AddWithValue("@Nomor_HP", dataAkun.NomorHP);
            cmd.Parameters.AddWithValue("@Negara_Asal", dataAkun.NegaraAsal);

            try
            {
                dbConnection.Open();
                if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Data berhasil disimpan ke DataBase.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        private bool SomeTextBoxesAreEmpty()
        {
            bool txtAlamatEMail_Kosong, txtKonfirmasiAlamatEMail_Kosong;
            bool txtUsername_Kosong, txtPassword_Kosong, txtKonfirmasiPassword_Kosong;

            txtAlamatEMail_Kosong = txtAlamatEMail.Text.Equals(String.Empty);
            txtKonfirmasiAlamatEMail_Kosong = txtKonfirmasiAlamatEMail.Text.Equals(String.Empty);

            txtUsername_Kosong = txtUsername.Text.Equals(String.Empty);
            txtPassword_Kosong = txtPassword.Text.Equals(String.Empty);
            txtKonfirmasiPassword_Kosong = txtKonfirmasiPassword.Text.Equals(String.Empty);

            if (txtAlamatEMail_Kosong || txtKonfirmasiAlamatEMail_Kosong || txtUsername_Kosong || txtPassword_Kosong || txtKonfirmasiPassword_Kosong) return true;
            else return false;
        }

        private void cbNegaraAsal_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox;

            comboBox = (ComboBox)sender;
            comboBoxItems.Key = comboBox.SelectedIndex;
            comboBoxItems.Values = comboBox.SelectedItem.ToString();
        }

        private void FormSignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Balik lagi ke FormLogin sebagai form utama
            FormLogin formLogin = new FormLogin();
            formLogin.Show(); this.Hide();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerjalananPenerbangan.Model
{
    class DataPembayaran
    {
        private string username;
        private string emailAddress;
        private int biayaPembayaran;
        private string metodePembayaran;

        public string Username { get => username; set => username = value; }
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public int BiayaPembayaran { get => biayaPembayaran; set => biayaPembayaran = value; }
        public string MetodePembayaran { get => metodePembayaran; set => metodePembayaran = value; }

        public DataPembayaran() { }
        public DataPembayaran(string username, string emailAddress, int biayaPembayaran, string metodePembayaran)
        {
            this.Username = username;
            this.EmailAddress = emailAddress;
            this.biayaPembayaran = biayaPembayaran;
            this.metodePembayaran = metodePembayaran;
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerjalananPenerbangan.Model
{
    class DataAkun
    {
        private string username;
        private string password;
        private string emailAddress;
        private string nomorHP;
        private string negaraAsal;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public string NomorHP { get => nomorHP; set => nomorHP = value; }
        public string NegaraAsal { get => negaraAsal; set => negaraAsal = value; }

        public DataAkun() { }
        public DataAkun(string Username, string Password, string EmailAddress, string NomorHP, string NegaraAsal)
        {
            this.username = Username;
            this.password = Password;
            this.emailAddress = EmailAddress;
            this.nomorHP = NomorHP;
            this.negaraAsal = NegaraAsal;
        }
    }
}

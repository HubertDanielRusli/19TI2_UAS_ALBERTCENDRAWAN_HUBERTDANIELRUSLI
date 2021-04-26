using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerjalananPenerbangan.Model
{
    class DataJadwalPenerbangan
    {
        private string maskapaiPenerbangan;
        private string nomorPenerbangan;
        private DateTime jamPenerbangan;
        private DateTime jamKetibaan;
        private string kotaAsal;
        private string destinasi;
        private int harga;

        public string MaskapaiPenerbangan { get => maskapaiPenerbangan; set => maskapaiPenerbangan = value; }
        public string NomorPenerbangan { get => nomorPenerbangan; set => nomorPenerbangan = value; }
        public DateTime JamPenerbangan { get => jamPenerbangan; set => jamPenerbangan = value; }
        public DateTime JamKetibaan { get => jamKetibaan; set => jamKetibaan = value; }
        public string KotaAsal { get => kotaAsal; set => kotaAsal = value; }
        public string Destinasi { get => destinasi; set => destinasi = value; }
        public int Harga { get => harga; set => harga = value; }

        public DataJadwalPenerbangan() { }
        public DataJadwalPenerbangan(string MaskapaiPenerbangan, string NomorPenerbangan, DateTime JamPenerbangan, DateTime JamKetibaan, string KotaAsal, string Destinasi, int Harga)
        {
            this.maskapaiPenerbangan = MaskapaiPenerbangan;
            this.nomorPenerbangan = NomorPenerbangan;
            this.jamPenerbangan = JamPenerbangan;
            this.jamKetibaan = JamKetibaan;
            this.kotaAsal = KotaAsal;
            this.destinasi = Destinasi;
            this.harga = Harga;
        }
    }
}

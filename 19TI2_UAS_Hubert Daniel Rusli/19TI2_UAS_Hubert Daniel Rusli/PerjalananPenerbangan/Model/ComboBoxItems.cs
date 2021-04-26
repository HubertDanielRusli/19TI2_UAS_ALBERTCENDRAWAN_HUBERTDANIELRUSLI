using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerjalananPenerbangan.Model
{
    class ComboBoxItems
    {
        private int key;
        private string values;

        public int Key { get => key; set => key = value; }
        public string Values { get => values; set => values = value; }

        public ComboBoxItems() { }
        public ComboBoxItems(int key, string values)
        {
            this.Key = key;
            this.Values = values;
        }
    }
}

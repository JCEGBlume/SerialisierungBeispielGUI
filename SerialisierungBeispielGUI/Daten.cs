using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialisierungBeispielGUI
{
    [Serializable] //als serialisierbar kennzeichnen
    public class Daten //für xml muss Klasse public sein
    {
        public string text;
        public int num;
        public bool check;
        public Daten() { }
        public Daten(string text, int num, bool check)
        {
            this.text = text;
            this.num = num;
            this.check = check;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SerialisierungBeispielGUI
{
    [Serializable] //als serialisierbar kennzeichnen
    public class Daten : ISerializable //für xml muss Klasse public sein
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

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("text", text, typeof(string));
            info.AddValue("num", num, typeof(int));
            info.AddValue("check", check, typeof(bool));
        }

        public Daten(SerializationInfo info, StreamingContext context)
        {
            this.text = info.GetString("text");
            this.num = info.GetInt32("num");
            this.check = info.GetBoolean("check");
        }
    }
}

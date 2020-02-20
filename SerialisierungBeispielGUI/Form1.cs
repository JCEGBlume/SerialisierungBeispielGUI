using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialisierungBeispielGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            int num = (int)numericUpDown1.Value;
            bool check = checkBox1.Checked;

            Daten daten = new Daten(text, num, check);

            Serialisierung.Serialize(daten);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Daten daten = Serialisierung.Deserialize();

            textBox1.Text = daten.text;
            numericUpDown1.Value = daten.num;
            checkBox1.Checked = daten.check;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            int num = (int)numericUpDown1.Value;
            bool check = checkBox1.Checked;

            Daten daten = new Daten(text, num, check);

            Serialisierung.SerializeXML(daten);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Daten daten = Serialisierung.DeserializeXML();

            textBox1.Text = daten.text;
            numericUpDown1.Value = daten.num;
            checkBox1.Checked = daten.check;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Serialisierung.BinaerDateiLoeschen();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Serialisierung.XMLDateiLoeschen();
        }
    }
}

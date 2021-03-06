﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.IO;


namespace SerialisierungBeispielGUI
{
    class Serialisierung
    {

        private static string filePath = "Test.bin";
        private static string filePathXml = "Test.xml";

        public static void Serialize(Daten daten)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            FileStream output = new FileStream(filePath, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(output, daten);
            output.Close();
        }

        public static Daten Deserialize()
        {
            try
            {
                using (FileStream input = new FileStream(filePath, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    Daten daten = (Daten)bf.Deserialize(input);
                    input.Close();

                    return daten;
                }
            }
            catch (IOException ioe)
            {
                Console.WriteLine("Dateifehler!");
            }
            return new Daten("Fehler", 0, false);
        }

        public static void SerializeXML(Daten daten)
        {
            if (File.Exists(filePathXml))
            {
                File.Delete(filePathXml);
            }
            FileStream output = new FileStream(filePathXml, FileMode.OpenOrCreate);
            XmlSerializer xmls = new XmlSerializer(typeof(Daten));
            xmls.Serialize(output, daten);
            output.Close();
        }

        public static Daten DeserializeXML()
        {
            try
            {
                using (FileStream input = new FileStream(filePathXml, FileMode.Open))
                {
                    XmlSerializer xmls = new XmlSerializer(typeof(Daten));
                    Daten daten = (Daten)xmls.Deserialize(input);
                    input.Close();

                    return daten;
                }
            }
            catch (IOException ioe)
            {
                Console.WriteLine("Dateifehler!");
            }
            return new Daten("Fehler", 0, false);
        }

        public static void BinaerDateiLoeschen()
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        public static void XMLDateiLoeschen()
        {
            if (File.Exists(filePathXml))
            {
                File.Delete(filePathXml);
            }
        }
    }
}

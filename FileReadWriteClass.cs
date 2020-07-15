using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydroHomie
{
    class FileReadWriteClass
    {
        public int cupsDrunk = 0;
        public int ReadCups()
        {
            try
            {
                cupsDrunk = Convert.ToInt32(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\HydroHomie\cups.txt"));
                return cupsDrunk;
            } catch
            {
                System.Windows.Forms.MessageBox.Show("Failed to receive total cups of water consumed.");
                return 0;
            }
            
        }

        public void WriteCups(int cups)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\HydroHomie\cups.txt"))
                {
                    writer.Write($"{cups}");
                }
            } catch 
            {
                System.Windows.Forms.MessageBox.Show("Failed to store new cup total.");
            }
        }

        public void CreateFolder()
        {
            try
            {
                if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\HydroHomie"))
                {
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\HydroHomie");
                }
            } catch
            {
                System.Windows.Forms.MessageBox.Show("Error occured while creating HydroHomie Folder!");
            }

            try
            {
                if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\HydroHomie\cups.txt"))
                {
                    using (StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\HydroHomie\cups.txt"))
                    {
                        writer.Write("0");
                    }
                }
            }
            catch 
            { 
                System.Windows.Forms.MessageBox.Show("Error occured while creating cups Record!");
            }
            
        }
    }
}

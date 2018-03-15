using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace SoadLab1
{
    class Loader
    {

        public string filePath;
        public bool ReadDataInt(List<int> data)
        {
            if (File.Exists(filePath))
                try
                {
                    using (StreamReader reader = File.OpenText(filePath))
                    {
                        string text;
                        while (!reader.EndOfStream)
                        {

                            text = reader.ReadLine();
                            data.Add(int.Parse(text));


                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка при считывании файла!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            else
            {
                MessageBox.Show("Файла не существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        public bool ReadDataText(List<string> data)
        {
            if (File.Exists(filePath))
                try
                {
                    using (StreamReader reader = File.OpenText(filePath))
                    {
                        string text;
                        while (!reader.EndOfStream)
                        {

                            text = reader.ReadLine();
                            data.Add(text);


                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка при считывании файла!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            else
            {
                MessageBox.Show("Файла не существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


    }
}

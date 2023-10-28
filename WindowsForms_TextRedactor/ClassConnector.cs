using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsForms_TextRedactor
{
    // класс-коннектор
    internal class ClassConnector
    {
        OpenFileDialog openFD = new OpenFileDialog();
        SaveFileDialog saveFD;

        // метод Открыть файл
        public string Open()
        {
            string s;
            openFD.ShowDialog();
            using (StreamReader sr = new StreamReader(openFD.FileName))
            {
                s = sr.ReadToEnd();
            }
            return s;
        }

        // метод Сохранить файл
        // перезапишет данные в прежде Открытый файл без вопроса, в какой файл сохранять
        public void Save(string s)
        {
            using (StreamWriter sw = new StreamWriter(openFD.FileName))
            {
                sw.WriteLine(s);
            }
        }

        // метод Сохранить как
        public void SaveAs(string s)
        {
            saveFD = new SaveFileDialog();
            saveFD.ShowDialog();
            using (StreamWriter sw = new StreamWriter(saveFD.FileName))
            {
                sw.WriteLine(s);
            }
        }
    }
}

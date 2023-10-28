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

namespace WindowsForms_TextRedactor
{
    public partial class Form1 : Form
    {
        ClassConnector connector;
        public Form1()
        {
            InitializeComponent();
            connector = new ClassConnector();  // создадим объект класса-посредника
            this.Text = "Текстовый редактор";  // имя формы
        }

        // обработчик пункта меню Файл-Открыть
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // вызов метода Открыть файл
            // в текстБокс запишем результат метода Открыть файл
            textBox1.Text = connector.Open();
        }

        // обработчик пункта меню Файл-Сохранить
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // вызов метода Сохранить файл
            connector.Save(textBox1.Text);
        }

        // обработчик пункта меню Сохранить как
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // вызов метода Сохранить как 
            connector.SaveAs(textBox1.Text);
        }

        // обработчик пункта меню Выбрать все
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // вызов встроенной ф-ии SelectAll()
            textBox1.SelectAll();
        }
        
        // обработчик пункта меню Копировать
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // вызов встроенной ф-ии Copy()
            textBox1.Copy();
        }

        // обработчик пункта меню Вырезать
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // вызов встроенной ф-ии Cut()
            textBox1.Cut();
        }

        // обработчик пункта меню Ввставить
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // вызов встроенной ф-ии Paste()
            textBox1.Paste();
        }
        
        // далее обработчики кнопок контекстного меню
        // Копировать/Вырезать/Вставить, дублируют главное меню
        private void copyContextToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void cutContextToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void pasteContextToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        // далее обработчики кнопок Панелт инструментов: Открыть/Сохранить/
        // Копировать/Вырезать/Вставить, дублируют главное меню
        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            textBox1.Text = connector.Open();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            connector.Save(textBox1.Text);
        }

        private void toolStripButtonCopy_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void toolStripButtonCut_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void toolStripButtonPaste_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

       
        // обрабочик выбранного индекса в комбоБокс Выбрать цвет фона
        private void toolStripComboBox_selectColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(toolStripComboBox_selectColor.SelectedIndex)
            {
                case 0:
                    textBox1.BackColor = Color.White;
                    break;
                case 1:
                    textBox1.BackColor = Color.Red;
                    break;
                case 2:
                    textBox1.BackColor = Color.Blue;
                    break;
                case 3:
                    textBox1.BackColor = Color.Green;
                    break;
                case 4:
                    textBox1.BackColor = Color.Black;
                    break;
                case 5:
                    textBox1.BackColor = Color.Pink;
                    break;
                case 6:
                    textBox1.ForeColor = Color.Yellow;
                    break;
            }
        }

        // обрабочик выбранного индекса в комбоБокс Выбрать цвет шрифта
        private void toolStripComboBox_selectFontColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(toolStripComboBox_selectFontColor.SelectedIndex)
            {
                case 0:
                    textBox1.ForeColor = Color.White;
                    break;
                case 1:
                    textBox1.ForeColor = Color.Red;
                    break;
                case 2:
                    textBox1.ForeColor = Color.Blue;
                    break;
                case 3:
                    textBox1.ForeColor = Color.Green;
                    break;
                case 4:
                    textBox1.ForeColor = Color.Black;
                    break;
                case 5:
                    textBox1.ForeColor = Color.Pink;
                    break;
                case 6:
                    textBox1.ForeColor = Color.Yellow;
                    break;
            }
        }

        // обрабочик выбранного индекса в комбоБокс Выбрать шрифт
        private void toolStripComboBox_fontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(toolStripComboBox_fontFamily.SelectedIndex)
            {
                case 0:
                    textBox1.Font = new Font("Times Mew Roman", 9);
                    break;
                case 1:
                    textBox1.Font = new Font("Arial", 9);
                    break;
                case 2:
                    textBox1.Font = new Font("Verdana", 9);
                    break;
            }
        }
    }
    
}

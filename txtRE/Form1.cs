using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace txtRE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text File(*.txt)|*.txt|Vva TxtPad file (*.tnf)|*.tnf";
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.Cancel) 
            
                          return;
                string filename = saveFileDialog1.FileName;
                File.WriteAllText(filename, richTextBox1.Text);
                MessageBox.Show("Файл сохранен!", "Внимание!");
            
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)

                return;
            string filename = openFileDialog1.FileName;
            string fileText= File.ReadAllText(filename);
            richTextBox1.Text = fileText;
            MessageBox.Show("Файл открыт!", "Внимание!");
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.TextLength > 0)
            {
                richTextBox1.Copy();
            }

           
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.TextLength > 0)
            {
                richTextBox1.Paste();
            }

        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Cut();
            }

        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font= fontDialog1.Font;
        }

        private void настройкиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;

        }

        private void выделитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right) 
            {
                richTextBox1.ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void копироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void вставитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Paste();
            }

        }

        private void вырезатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.SelectAll();
            }
        }

        private void заменаТекстаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Поиск";
            textBox1.ForeColor = Color.Gray;

            textBox2.Text = "Замена";
            textBox2.ForeColor = Color.Gray;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = null;
            textBox1.ForeColor = Color.Black;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = null;
            textBox2.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Contains(textBox1.Text)) 
            {
                int index = richTextBox1.Text.IndexOf(textBox1.Text);  
                string str1, str2;
                str1 = richTextBox1.Text.Substring(0, index); 
                str2 = richTextBox1.Text.Substring((index + textBox1.TextLength), (richTextBox1.TextLength - (index + textBox1.TextLength))); 
                string result = str1 + textBox2.Text + str2; 
                richTextBox1.Clear(); 
                richTextBox1.AppendText(result); 
                richTextBox1.Select(str1.Length, textBox2.Text.Length);
                
            }
            else
                MessageBox.Show("Такого слова не нашлось!", "Увы!"); 
        }
    }
}

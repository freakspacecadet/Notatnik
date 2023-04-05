using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool zapisany;
        string name;
        private void Form1_Load(object sender, EventArgs e)
        {
            zapisany = true;
            name = "Untitled";
        }

        private void finishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (zapisany == true)
            {
                Application.Exit();
            }
            else
            {
                ;

                if (MessageBox.Show("Czy na pewno chcesz odrzucić wszystkie zmiany?", "Ostrzeżenie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }


            }
            
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Notes. Scalable window. .rtf format. (c) 2023", "Notatnik");
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (zapisany == true)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //openFileDialog1.ShowDialog();
                    richTextBox1.LoadFile(openFileDialog1.FileName);
                    name = openFileDialog1.FileName;
                }
            }
            else
            {
                
                
                if (MessageBox.Show("Czy na pewno chcesz odrzucić wszystkie zmiany?", "Ostrzeżenie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        //openFileDialog1.ShowDialog();
                        richTextBox1.LoadFile(openFileDialog1.FileName);
                        name = openFileDialog1.FileName;
                    }
                }
                

            }
            
            
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //saveFileDialog1.ShowDialog();
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                name = saveFileDialog1.FileName;
                zapisany = true;
            }
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            zapisany = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                string pom = Convert.ToString(comboBox1.SelectedItem);
                richTextBox1.Font = new Font(pom, richTextBox1.Font.Size,
                richTextBox1.Font.Style, richTextBox1.Font.Unit);
                //richTextBox1.Font = "Microfsoft Sans Serif";
            
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            string pom = Convert.ToString(numericUpDown1.Value);
            float currentSize = float.Parse(pom);
            //currentSize ;
            richTextBox1.Font = new Font(richTextBox1.Font.Name, currentSize,
                richTextBox1.Font.Style, richTextBox1.Font.Unit);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (name == "Untitled")
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else {
                richTextBox1.SaveFile(name);
            }

            //richTextBox1.SaveFile(name);

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}

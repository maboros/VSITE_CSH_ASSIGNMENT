using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SvaVelikaSlova_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText.Length < 1)
            {
                textBox1.Text = textBox1.Text.ToUpper();
            }
            else
            {
                textBox1.SelectedText = textBox1.SelectedText.ToUpper();
            }
        }

        private void PremaPravopisu_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText.Length < 1)
            {
                textBox1.Text = toGrammar(textBox1.Text);
            }
            else
            {
                textBox1.SelectedText = toGrammar(textBox1.SelectedText);
            }
        }

        private void LoadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
            }
        }
        private string toGrammar(string originalString)
        {
            bool flag = true;
            StringBuilder newString = new StringBuilder(originalString.Length);
            foreach (var ch in originalString)
            {
                if (ch.Equals('.') || ch.Equals('!') || ch.Equals('?'))
                {
                    flag = true;
                }
                if (flag&&char.IsLetter(ch))
                {
                    newString.Append(char.ToUpper(ch));
                    flag = false;
                }
                else
                {
                    newString.Append(char.ToLower(ch));
                }
            }

            return newString.ToString();
        }
    }
}

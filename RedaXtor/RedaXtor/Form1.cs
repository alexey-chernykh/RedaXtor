using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedaXtor
{
    public partial class MainForm : Form
    {
        ConfigForm dialog = null;
        FormClosingEventArgs e;
        bool isSaved = false;
        string[] fileName = null;
        public MainForm()
        {
            InitializeComponent();
        }
        private void UpdateFormCaption()
        {
            Text = $"МойБлокнот - {fileName[fileName.Length-1]}";
        }
        private void CheckNotSavedMsg()
        {
            switch (MessageBox.Show("Данные не сохранены. Хотите сохранить перед выходом?", "Внимание!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning))
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    saveFileDialog1.ShowDialog(this);
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog(this);
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            using (StreamReader reader = File.OpenText(openFileDialog.FileName))
            {
                fileName = openFileDialog.FileName.Split('\\');
               
                UpdateFormCaption();
                try
                {
                    richTextBox1.LoadFile(openFileDialog.FileName);
                }
                catch
                {
                    richTextBox1.Text = reader.ReadToEnd();
                }
            }
        }        
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog(this);
        }
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            using (StreamWriter writer = File.CreateText(saveFileDialog1.FileName))
            {
                fileName = saveFileDialog1.FileName.Split('\\');
                UpdateFormCaption();
                writer.Write(richTextBox1.Text);
            }
            isSaved = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = richTextBox1.ForeColor;
            if (colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
                isSaved = false;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = richTextBox1.Font;
            if(fontDialog1.ShowDialog(this) == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
                isSaved = false;
            }
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = richTextBox1.BackColor;
            if (colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
                isSaved = false;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.e = e;
            if (!isSaved)
            {
                CheckNotSavedMsg();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            isSaved = false;
        }
        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dialog == null)
            {
                dialog = new ConfigForm();
            }
            dialog.Show();
        }
        private void LoadConfig()
        {
            using (StreamReader reader = File.OpenText("config.txt"))
            {
                string[] pars = reader.ReadToEnd().Split(';');
                richTextBox1.ForeColor = Color.FromArgb(Int32.Parse(pars[0]), Int32.Parse(pars[1]), Int32.Parse(pars[2]), Int32.Parse(pars[3]));
                richTextBox1.BackColor = Color.FromArgb(Int32.Parse(pars[4]), Int32.Parse(pars[5]), Int32.Parse(pars[6]), Int32.Parse(pars[7]));
                string[] fontStyle = pars[10].Split(',');
                switch (fontStyle.Length)
                {
                    case 1:
                        richTextBox1.Font =
                            new Font
                            (
                                new FontFamily(pars[8]),
                                float.Parse(pars[9]),
                                (FontStyle)Int32.Parse(fontStyle[0])
                            );
                        break;
                    case 2:
                        richTextBox1.Font =
                            new Font
                            (
                                new FontFamily(pars[8]),
                                float.Parse(pars[9]),
                                (FontStyle)Int32.Parse(fontStyle[0]) |
                                (FontStyle)Int32.Parse(fontStyle[1])
                            );
                        break;
                    case 3:
                        richTextBox1.Font =
                            new Font
                            (
                                new FontFamily(pars[8]),
                                float.Parse(pars[9]),
                                (FontStyle)Int32.Parse(fontStyle[0]) |
                                (FontStyle)Int32.Parse(fontStyle[1]) |
                                (FontStyle)Int32.Parse(fontStyle[2])
                            );
                        break;
                    case 4:
                        richTextBox1.Font =
                            new Font
                            (
                                new FontFamily(pars[8]),
                                float.Parse(pars[9]),
                                (FontStyle)Int32.Parse(fontStyle[0]) |
                                (FontStyle)Int32.Parse(fontStyle[1]) |
                                (FontStyle)Int32.Parse(fontStyle[2]) |
                                (FontStyle)Int32.Parse(fontStyle[3])
                            );
                        break;
                    case 5:
                        richTextBox1.Font =
                            new Font
                            (
                                new FontFamily(pars[8]),
                                float.Parse(pars[9]),
                                (FontStyle)Int32.Parse(fontStyle[0]) |
                                (FontStyle)Int32.Parse(fontStyle[1]) |
                                (FontStyle)Int32.Parse(fontStyle[2]) |
                                (FontStyle)Int32.Parse(fontStyle[3]) |
                                (FontStyle)Int32.Parse(fontStyle[4])
                            );
                        break;
                    default:
                        break;
                }
            }
        }
        private void WriteConfig()
        {
            using (StreamWriter writer = File.CreateText("config.txt"))
            {
                writer.Write($"{richTextBox1.ForeColor.A};{richTextBox1.ForeColor.R};{richTextBox1.ForeColor.G};{richTextBox1.ForeColor.B};{richTextBox1.BackColor.A};{richTextBox1.BackColor.R};{richTextBox1.BackColor.G};{richTextBox1.BackColor.B};{richTextBox1.Font.FontFamily.Name};{richTextBox1.Font.Size};{(int)richTextBox1.Font.Style}");
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadConfig();
            }
            catch(FileNotFoundException)
            {
                WriteConfig();
                LoadConfig();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog(this);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog(this);
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}

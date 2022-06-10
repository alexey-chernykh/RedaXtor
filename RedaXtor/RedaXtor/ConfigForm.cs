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
namespace RedaXtor
{
    public partial class ConfigForm : Form
    {
        MainForm mf = new MainForm();
        bool isSaved = true;
        Color textColor;
        Color backColor;
        Font font;
        public ConfigForm()
        {
            textColor = mf.richTextBox1.ForeColor;
            backColor = mf.richTextBox1.BackColor;
            font = mf.richTextBox1.Font;
            InitializeComponent();
        }
        private void WriteConfig()
        {
            using (StreamWriter writer = File.CreateText("config.txt"))
            {
                //writer.Write($"{mf.richTextBox1.ForeColor.A};{mf.richTextBox1.ForeColor.R};{mf.richTextBox1.ForeColor.G};{mf.richTextBox1.ForeColor.B};{mf.richTextBox1.BackColor.A};{mf.richTextBox1.BackColor.R};{mf.richTextBox1.BackColor.G};{mf.richTextBox1.BackColor.B};{mf.richTextBox1.Font.FontFamily.Name};{mf.richTextBox1.Font.Size};{(int)mf.richTextBox1.Font.Style}");
                writer.Write($"{textColor.A};{textColor.R};{textColor.G};{textColor.B};{backColor.A};{backColor.R};{backColor.G};{backColor.B};{font.FontFamily.Name};{font.Size};{(int)font.Style}");
            }
        }
        private void ApplyConfig()
        {
            //UpdateStaff();
            WriteConfig();
            isSaved = true;
            MessageBox.Show("Настройки сохранены!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        private void CheckNotSavedMsg()
        {
            switch (MessageBox.Show("Данные не сохранены. Хотите сохранить перед выходом?", "Внимание!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning))
            {
                case DialogResult.Cancel:
                    break;
                case DialogResult.Yes:
                    ApplyConfig();
                    break;
                case DialogResult.No:
                    Close();
                    break;
                default:
                    break;
            }
        }
        private void ConfigForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Visible = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (!isSaved)
            {
                CheckNotSavedMsg();
            }
            else
            {
                Close();
            }
        }

        private void buttonTextColorDef_Click(object sender, EventArgs e)
        {
            if (defaultColorDialog.ShowDialog(this) == DialogResult.OK)
            {
                textColor = defaultColorDialog.Color;
                isSaved = false;
            }
        }

        private void buttonBackColorDef_Click(object sender, EventArgs e)
        {
            if (defaultColorDialog.ShowDialog(this) == DialogResult.OK)
            {
                backColor = defaultColorDialog.Color;
                isSaved = false;
            }
        }

        private void buttonFontDef_Click(object sender, EventArgs e)
        {
            if (defaultFontDialog.ShowDialog(this) == DialogResult.OK)
            {
                font = defaultFontDialog.Font; isSaved = false;
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            ApplyConfig();
        }
        private void UpdateStaff()
        {
            textColor = mf.richTextBox1.ForeColor;
            backColor = mf.richTextBox1.BackColor;
            font = mf.richTextBox1.Font;
        }
        private void ConfigForm_Load(object sender, EventArgs e)
        {
            UpdateStaff();
            //WriteConfig();
        }
    }
}

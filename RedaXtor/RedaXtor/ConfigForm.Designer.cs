
namespace RedaXtor
{
    partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.defaultColorDialog = new System.Windows.Forms.ColorDialog();
            this.defaultFontDialog = new System.Windows.Forms.FontDialog();
            this.buttonTextColorDef = new System.Windows.Forms.Button();
            this.buttonBackColorDef = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonFontDef = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTextColorDef
            // 
            this.buttonTextColorDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTextColorDef.Location = new System.Drawing.Point(13, 13);
            this.buttonTextColorDef.Name = "buttonTextColorDef";
            this.buttonTextColorDef.Size = new System.Drawing.Size(287, 34);
            this.buttonTextColorDef.TabIndex = 0;
            this.buttonTextColorDef.Text = "Цвет текста по умолчанию";
            this.buttonTextColorDef.UseVisualStyleBackColor = true;
            this.buttonTextColorDef.Click += new System.EventHandler(this.buttonTextColorDef_Click);
            // 
            // buttonBackColorDef
            // 
            this.buttonBackColorDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBackColorDef.Location = new System.Drawing.Point(12, 53);
            this.buttonBackColorDef.Name = "buttonBackColorDef";
            this.buttonBackColorDef.Size = new System.Drawing.Size(288, 34);
            this.buttonBackColorDef.TabIndex = 1;
            this.buttonBackColorDef.Text = "Цвет заднего фона по умолчанию";
            this.buttonBackColorDef.UseVisualStyleBackColor = true;
            this.buttonBackColorDef.Click += new System.EventHandler(this.buttonBackColorDef_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonApply.Location = new System.Drawing.Point(13, 140);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(136, 32);
            this.buttonApply.TabIndex = 2;
            this.buttonApply.Text = "Применить";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(164, 140);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(136, 32);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonFontDef
            // 
            this.buttonFontDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFontDef.Location = new System.Drawing.Point(13, 94);
            this.buttonFontDef.Name = "buttonFontDef";
            this.buttonFontDef.Size = new System.Drawing.Size(287, 34);
            this.buttonFontDef.TabIndex = 4;
            this.buttonFontDef.Text = "Шрифт по умолчанию";
            this.buttonFontDef.UseVisualStyleBackColor = true;
            this.buttonFontDef.Click += new System.EventHandler(this.buttonFontDef_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 184);
            this.Controls.Add(this.buttonFontDef);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonBackColorDef);
            this.Controls.Add(this.buttonTextColorDef);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigForm";
            this.Text = "Настройки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigForm_FormClosing);
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog defaultColorDialog;
        private System.Windows.Forms.FontDialog defaultFontDialog;
        private System.Windows.Forms.Button buttonTextColorDef;
        private System.Windows.Forms.Button buttonBackColorDef;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonFontDef;
    }
}
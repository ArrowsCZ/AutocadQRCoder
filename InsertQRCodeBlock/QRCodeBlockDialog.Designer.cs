namespace InsertQRCodeBlock
{
    partial class QrCodeBlockDialog
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelTextToEncode = new System.Windows.Forms.Label();
            this.textBoxPlainText = new System.Windows.Forms.TextBox();
            this.comboBoxEccLevel = new System.Windows.Forms.ComboBox();
            this.labelEccLevel = new System.Windows.Forms.Label();
            this.checkBoxUtf8 = new System.Windows.Forms.CheckBox();
            this.checkBoxUtf8Bom = new System.Windows.Forms.CheckBox();
            this.groupBoxEncoding = new System.Windows.Forms.GroupBox();
            this.comboBoxRequestVersion = new System.Windows.Forms.ComboBox();
            this.labelRequestVersion = new System.Windows.Forms.Label();
            this.comboBoxECI = new System.Windows.Forms.ComboBox();
            this.labelECI = new System.Windows.Forms.Label();
            this.groupBoxBlock = new System.Windows.Forms.GroupBox();
            this.pictureBoxForeground = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.buttonForeground = new System.Windows.Forms.Button();
            this.buttonBackground = new System.Windows.Forms.Button();
            this.numericBoxScale = new InsertQRCodeBlock.NumericBox();
            this.checkBoxAttribute = new System.Windows.Forms.CheckBox();
            this.labelScale = new System.Windows.Forms.Label();
            this.labelLayer = new System.Windows.Forms.Label();
            this.comboBoxLayer = new System.Windows.Forms.ComboBox();
            this.textBoxBlockName = new System.Windows.Forms.TextBox();
            this.labelBlockName = new System.Windows.Forms.Label();
            this.groupBoxEncoding.SuspendLayout();
            this.groupBoxBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForeground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(66, 227);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 21);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(165, 227);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 21);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelTextToEncode
            // 
            this.labelTextToEncode.AutoSize = true;
            this.labelTextToEncode.Location = new System.Drawing.Point(13, 12);
            this.labelTextToEncode.Name = "labelTextToEncode";
            this.labelTextToEncode.Size = new System.Drawing.Size(59, 12);
            this.labelTextToEncode.TabIndex = 2;
            this.labelTextToEncode.Text = "输入文本:";
            // 
            // textBoxPlainText
            // 
            this.textBoxPlainText.AcceptsReturn = true;
            this.textBoxPlainText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPlainText.Location = new System.Drawing.Point(13, 30);
            this.textBoxPlainText.Multiline = true;
            this.textBoxPlainText.Name = "textBoxPlainText";
            this.textBoxPlainText.Size = new System.Drawing.Size(429, 34);
            this.textBoxPlainText.TabIndex = 0;
            // 
            // comboBoxEccLevel
            // 
            this.comboBoxEccLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEccLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEccLevel.FormattingEnabled = true;
            this.comboBoxEccLevel.Location = new System.Drawing.Point(200, 18);
            this.comboBoxEccLevel.Name = "comboBoxEccLevel";
            this.comboBoxEccLevel.Size = new System.Drawing.Size(69, 20);
            this.comboBoxEccLevel.TabIndex = 4;
            // 
            // labelEccLevel
            // 
            this.labelEccLevel.AutoSize = true;
            this.labelEccLevel.Location = new System.Drawing.Point(6, 20);
            this.labelEccLevel.Name = "labelEccLevel";
            this.labelEccLevel.Size = new System.Drawing.Size(131, 12);
            this.labelEccLevel.TabIndex = 5;
            this.labelEccLevel.Text = "错误控制码级别 (ECC):";
            // 
            // checkBoxUtf8
            // 
            this.checkBoxUtf8.AutoSize = true;
            this.checkBoxUtf8.Location = new System.Drawing.Point(9, 44);
            this.checkBoxUtf8.Name = "checkBoxUtf8";
            this.checkBoxUtf8.Size = new System.Drawing.Size(108, 16);
            this.checkBoxUtf8.TabIndex = 6;
            this.checkBoxUtf8.Text = "强制使用 UTF-8";
            this.checkBoxUtf8.UseVisualStyleBackColor = true;
            // 
            // checkBoxUtf8Bom
            // 
            this.checkBoxUtf8Bom.AutoSize = true;
            this.checkBoxUtf8Bom.Location = new System.Drawing.Point(129, 44);
            this.checkBoxUtf8Bom.Name = "checkBoxUtf8Bom";
            this.checkBoxUtf8Bom.Size = new System.Drawing.Size(132, 16);
            this.checkBoxUtf8Bom.TabIndex = 7;
            this.checkBoxUtf8Bom.Text = "强制使用 UTF-8 BOM";
            this.checkBoxUtf8Bom.UseVisualStyleBackColor = true;
            // 
            // groupBoxEncoding
            // 
            this.groupBoxEncoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxEncoding.Controls.Add(this.comboBoxRequestVersion);
            this.groupBoxEncoding.Controls.Add(this.labelRequestVersion);
            this.groupBoxEncoding.Controls.Add(this.comboBoxECI);
            this.groupBoxEncoding.Controls.Add(this.labelECI);
            this.groupBoxEncoding.Controls.Add(this.labelEccLevel);
            this.groupBoxEncoding.Controls.Add(this.checkBoxUtf8Bom);
            this.groupBoxEncoding.Controls.Add(this.comboBoxEccLevel);
            this.groupBoxEncoding.Controls.Add(this.checkBoxUtf8);
            this.groupBoxEncoding.Location = new System.Drawing.Point(12, 72);
            this.groupBoxEncoding.Name = "groupBoxEncoding";
            this.groupBoxEncoding.Size = new System.Drawing.Size(275, 123);
            this.groupBoxEncoding.TabIndex = 8;
            this.groupBoxEncoding.TabStop = false;
            this.groupBoxEncoding.Text = "编码设置";
            // 
            // comboBoxRequestVersion
            // 
            this.comboBoxRequestVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRequestVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRequestVersion.FormattingEnabled = true;
            this.comboBoxRequestVersion.Items.AddRange(new object[] {
            "Auto",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40"});
            this.comboBoxRequestVersion.Location = new System.Drawing.Point(200, 95);
            this.comboBoxRequestVersion.Name = "comboBoxRequestVersion";
            this.comboBoxRequestVersion.Size = new System.Drawing.Size(69, 20);
            this.comboBoxRequestVersion.TabIndex = 11;
            // 
            // labelRequestVersion
            // 
            this.labelRequestVersion.AutoSize = true;
            this.labelRequestVersion.Location = new System.Drawing.Point(6, 98);
            this.labelRequestVersion.Name = "labelRequestVersion";
            this.labelRequestVersion.Size = new System.Drawing.Size(59, 12);
            this.labelRequestVersion.TabIndex = 10;
            this.labelRequestVersion.Text = "发布版本:";
            // 
            // comboBoxECI
            // 
            this.comboBoxECI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxECI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxECI.FormattingEnabled = true;
            this.comboBoxECI.Location = new System.Drawing.Point(200, 70);
            this.comboBoxECI.Name = "comboBoxECI";
            this.comboBoxECI.Size = new System.Drawing.Size(69, 20);
            this.comboBoxECI.TabIndex = 9;
            // 
            // labelECI
            // 
            this.labelECI.AutoSize = true;
            this.labelECI.Location = new System.Drawing.Point(6, 73);
            this.labelECI.Name = "labelECI";
            this.labelECI.Size = new System.Drawing.Size(131, 12);
            this.labelECI.TabIndex = 8;
            this.labelECI.Text = "扩展翻译字符集 (ECI):";
            // 
            // groupBoxBlock
            // 
            this.groupBoxBlock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBlock.Controls.Add(this.pictureBoxForeground);
            this.groupBoxBlock.Controls.Add(this.pictureBoxBackground);
            this.groupBoxBlock.Controls.Add(this.buttonForeground);
            this.groupBoxBlock.Controls.Add(this.buttonBackground);
            this.groupBoxBlock.Controls.Add(this.numericBoxScale);
            this.groupBoxBlock.Controls.Add(this.checkBoxAttribute);
            this.groupBoxBlock.Controls.Add(this.labelScale);
            this.groupBoxBlock.Controls.Add(this.labelLayer);
            this.groupBoxBlock.Controls.Add(this.comboBoxLayer);
            this.groupBoxBlock.Controls.Add(this.textBoxBlockName);
            this.groupBoxBlock.Controls.Add(this.labelBlockName);
            this.groupBoxBlock.Location = new System.Drawing.Point(293, 72);
            this.groupBoxBlock.Name = "groupBoxBlock";
            this.groupBoxBlock.Size = new System.Drawing.Size(149, 176);
            this.groupBoxBlock.TabIndex = 9;
            this.groupBoxBlock.TabStop = false;
            this.groupBoxBlock.Text = "块";
            // 
            // pictureBoxForeground
            // 
            this.pictureBoxForeground.BackColor = System.Drawing.Color.Black;
            this.pictureBoxForeground.Location = new System.Drawing.Point(9, 146);
            this.pictureBoxForeground.Name = "pictureBoxForeground";
            this.pictureBoxForeground.Size = new System.Drawing.Size(22, 20);
            this.pictureBoxForeground.TabIndex = 11;
            this.pictureBoxForeground.TabStop = false;
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.BackColor = System.Drawing.Color.White;
            this.pictureBoxBackground.Location = new System.Drawing.Point(9, 118);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(22, 20);
            this.pictureBoxBackground.TabIndex = 10;
            this.pictureBoxBackground.TabStop = false;
            // 
            // buttonForeground
            // 
            this.buttonForeground.Location = new System.Drawing.Point(37, 146);
            this.buttonForeground.Name = "buttonForeground";
            this.buttonForeground.Size = new System.Drawing.Size(106, 21);
            this.buttonForeground.TabIndex = 9;
            this.buttonForeground.Text = "前景色";
            this.buttonForeground.UseVisualStyleBackColor = true;
            this.buttonForeground.Click += new System.EventHandler(this.buttonForeground_Click);
            // 
            // buttonBackground
            // 
            this.buttonBackground.Location = new System.Drawing.Point(37, 118);
            this.buttonBackground.Name = "buttonBackground";
            this.buttonBackground.Size = new System.Drawing.Size(106, 21);
            this.buttonBackground.TabIndex = 8;
            this.buttonBackground.Text = "背景色";
            this.buttonBackground.UseVisualStyleBackColor = true;
            this.buttonBackground.Click += new System.EventHandler(this.ButtonBackground_Click);
            // 
            // numericBoxScale
            // 
            this.numericBoxScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericBoxScale.DecimalPlaces = 0;
            this.numericBoxScale.ErrorMsg = "Incorrect number";
            this.numericBoxScale.Location = new System.Drawing.Point(75, 70);
            this.numericBoxScale.Maximum = 1.7976931348623157E+308D;
            this.numericBoxScale.Minimum = 1E-16D;
            this.numericBoxScale.Name = "numericBoxScale";
            this.numericBoxScale.Size = new System.Drawing.Size(68, 21);
            this.numericBoxScale.TabIndex = 7;
            this.numericBoxScale.Text = "1";
            this.numericBoxScale.Value = 1D;
            // 
            // checkBoxAttribute
            // 
            this.checkBoxAttribute.AutoSize = true;
            this.checkBoxAttribute.Checked = true;
            this.checkBoxAttribute.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAttribute.Location = new System.Drawing.Point(6, 97);
            this.checkBoxAttribute.Name = "checkBoxAttribute";
            this.checkBoxAttribute.Size = new System.Drawing.Size(96, 16);
            this.checkBoxAttribute.TabIndex = 6;
            this.checkBoxAttribute.Text = "添加文字提示";
            this.checkBoxAttribute.UseVisualStyleBackColor = true;
            // 
            // labelScale
            // 
            this.labelScale.AutoSize = true;
            this.labelScale.Location = new System.Drawing.Point(6, 73);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(59, 12);
            this.labelScale.TabIndex = 5;
            this.labelScale.Text = "全局比例:";
            // 
            // labelLayer
            // 
            this.labelLayer.AutoSize = true;
            this.labelLayer.Location = new System.Drawing.Point(6, 45);
            this.labelLayer.Name = "labelLayer";
            this.labelLayer.Size = new System.Drawing.Size(35, 12);
            this.labelLayer.TabIndex = 3;
            this.labelLayer.Text = "图层:";
            // 
            // comboBoxLayer
            // 
            this.comboBoxLayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLayer.FormattingEnabled = true;
            this.comboBoxLayer.Location = new System.Drawing.Point(48, 42);
            this.comboBoxLayer.Name = "comboBoxLayer";
            this.comboBoxLayer.Size = new System.Drawing.Size(95, 20);
            this.comboBoxLayer.TabIndex = 2;
            // 
            // textBoxBlockName
            // 
            this.textBoxBlockName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBlockName.Location = new System.Drawing.Point(48, 18);
            this.textBoxBlockName.Name = "textBoxBlockName";
            this.textBoxBlockName.Size = new System.Drawing.Size(95, 21);
            this.textBoxBlockName.TabIndex = 1;
            this.textBoxBlockName.Text = "*U";
            // 
            // labelBlockName
            // 
            this.labelBlockName.AutoSize = true;
            this.labelBlockName.Location = new System.Drawing.Point(6, 21);
            this.labelBlockName.Name = "labelBlockName";
            this.labelBlockName.Size = new System.Drawing.Size(35, 12);
            this.labelBlockName.TabIndex = 0;
            this.labelBlockName.Text = "块名:";
            // 
            // QrCodeBlockDialog
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(454, 259);
            this.Controls.Add(this.groupBoxBlock);
            this.Controls.Add(this.groupBoxEncoding);
            this.Controls.Add(this.textBoxPlainText);
            this.Controls.Add(this.labelTextToEncode);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(470, 298);
            this.Name = "QrCodeBlockDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "二维码块";
            this.groupBoxEncoding.ResumeLayout(false);
            this.groupBoxEncoding.PerformLayout();
            this.groupBoxBlock.ResumeLayout(false);
            this.groupBoxBlock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForeground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelTextToEncode;
        private System.Windows.Forms.TextBox textBoxPlainText;
        private System.Windows.Forms.ComboBox comboBoxEccLevel;
        private System.Windows.Forms.Label labelEccLevel;
        private System.Windows.Forms.CheckBox checkBoxUtf8;
        private System.Windows.Forms.CheckBox checkBoxUtf8Bom;
        private System.Windows.Forms.GroupBox groupBoxEncoding;
        private System.Windows.Forms.Label labelECI;
        private System.Windows.Forms.ComboBox comboBoxRequestVersion;
        private System.Windows.Forms.Label labelRequestVersion;
        private System.Windows.Forms.ComboBox comboBoxECI;
        private System.Windows.Forms.GroupBox groupBoxBlock;
        private System.Windows.Forms.TextBox textBoxBlockName;
        private System.Windows.Forms.Label labelBlockName;
        private System.Windows.Forms.Label labelLayer;
        private System.Windows.Forms.ComboBox comboBoxLayer;
        private System.Windows.Forms.Label labelScale;
        private System.Windows.Forms.CheckBox checkBoxAttribute;
        private NumericBox numericBoxScale;
        private System.Windows.Forms.Button buttonBackground;
        private System.Windows.Forms.PictureBox pictureBoxForeground;
        private System.Windows.Forms.PictureBox pictureBoxBackground;
        private System.Windows.Forms.Button buttonForeground;
    }
}
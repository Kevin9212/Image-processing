namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.checkBoxReflectY = new System.Windows.Forms.CheckBox();
            this.checkBoxReflectX = new System.Windows.Forms.CheckBox();
            this.textBoxRotate = new System.Windows.Forms.TextBox();
            this.checkBoxThresholding = new System.Windows.Forms.CheckBox();
            this.checkBoxGrayScale = new System.Windows.Forms.CheckBox();
            this.textBoxShearX = new System.Windows.Forms.TextBox();
            this.textBoxShearY = new System.Windows.Forms.TextBox();
            this.textBoxPepperNoisePercent = new System.Windows.Forms.TextBox();
            this.comboBoxK_size = new System.Windows.Forms.ComboBox();
            this.checkBoxHistogram = new System.Windows.Forms.CheckBox();
            this.textBoxCannyLow = new System.Windows.Forms.TextBox();
            this.labelRotate = new System.Windows.Forms.Label();
            this.labelShearX = new System.Windows.Forms.Label();
            this.labelShearY = new System.Windows.Forms.Label();
            this.labelPepperNoisePercent = new System.Windows.Forms.Label();
            this.labelmedianBlurImage = new System.Windows.Forms.Label();
            this.labelCannyLow = new System.Windows.Forms.Label();
            this.labelCannyHigh = new System.Windows.Forms.Label();
            this.textBoxCannyHigh = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(118, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "顯示影像";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(41, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "檔案:";
            // 
            // tbFileName
            // 
            this.tbFileName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbFileName.Location = new System.Drawing.Point(25, 49);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(288, 27);
            this.tbFileName.TabIndex = 2;
            // 
            // btnbrowse
            // 
            this.btnbrowse.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnbrowse.Location = new System.Drawing.Point(336, 46);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(81, 37);
            this.btnbrowse.TabIndex = 3;
            this.btnbrowse.Text = "瀏覽";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkBoxReflectY
            // 
            this.checkBoxReflectY.AutoSize = true;
            this.checkBoxReflectY.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBoxReflectY.Location = new System.Drawing.Point(117, 186);
            this.checkBoxReflectY.Name = "checkBoxReflectY";
            this.checkBoxReflectY.Size = new System.Drawing.Size(101, 28);
            this.checkBoxReflectY.TabIndex = 5;
            this.checkBoxReflectY.Text = "ReflectY";
            this.checkBoxReflectY.UseVisualStyleBackColor = true;
            // 
            // checkBoxReflectX
            // 
            this.checkBoxReflectX.AutoSize = true;
            this.checkBoxReflectX.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBoxReflectX.Location = new System.Drawing.Point(116, 237);
            this.checkBoxReflectX.Name = "checkBoxReflectX";
            this.checkBoxReflectX.Size = new System.Drawing.Size(102, 28);
            this.checkBoxReflectX.TabIndex = 6;
            this.checkBoxReflectX.Text = "ReflectX";
            this.checkBoxReflectX.UseVisualStyleBackColor = true;
            this.checkBoxReflectX.CheckedChanged += new System.EventHandler(this.checkBoxReflectX_CheckedChanged);
            // 
            // textBoxRotate
            // 
            this.textBoxRotate.Location = new System.Drawing.Point(118, 146);
            this.textBoxRotate.Name = "textBoxRotate";
            this.textBoxRotate.Size = new System.Drawing.Size(100, 22);
            this.textBoxRotate.TabIndex = 7;
            // 
            // checkBoxThresholding
            // 
            this.checkBoxThresholding.AutoSize = true;
            this.checkBoxThresholding.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBoxThresholding.Location = new System.Drawing.Point(116, 337);
            this.checkBoxThresholding.Name = "checkBoxThresholding";
            this.checkBoxThresholding.Size = new System.Drawing.Size(149, 28);
            this.checkBoxThresholding.TabIndex = 8;
            this.checkBoxThresholding.Text = "Thresholding";
            this.checkBoxThresholding.UseVisualStyleBackColor = true;
            this.checkBoxThresholding.CheckedChanged += new System.EventHandler(this.checkBoxThresholding_CheckedChanged);
            // 
            // checkBoxGrayScale
            // 
            this.checkBoxGrayScale.AutoSize = true;
            this.checkBoxGrayScale.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBoxGrayScale.Location = new System.Drawing.Point(116, 280);
            this.checkBoxGrayScale.Name = "checkBoxGrayScale";
            this.checkBoxGrayScale.Size = new System.Drawing.Size(121, 28);
            this.checkBoxGrayScale.TabIndex = 9;
            this.checkBoxGrayScale.Text = "Gray Scale";
            this.checkBoxGrayScale.UseVisualStyleBackColor = true;
            this.checkBoxGrayScale.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBoxShearX
            // 
            this.textBoxShearX.Location = new System.Drawing.Point(379, 147);
            this.textBoxShearX.Name = "textBoxShearX";
            this.textBoxShearX.Size = new System.Drawing.Size(100, 22);
            this.textBoxShearX.TabIndex = 10;
            // 
            // textBoxShearY
            // 
            this.textBoxShearY.Location = new System.Drawing.Point(379, 195);
            this.textBoxShearY.Name = "textBoxShearY";
            this.textBoxShearY.Size = new System.Drawing.Size(100, 22);
            this.textBoxShearY.TabIndex = 11;
            // 
            // textBoxPepperNoisePercent
            // 
            this.textBoxPepperNoisePercent.Location = new System.Drawing.Point(379, 280);
            this.textBoxPepperNoisePercent.Name = "textBoxPepperNoisePercent";
            this.textBoxPepperNoisePercent.Size = new System.Drawing.Size(100, 22);
            this.textBoxPepperNoisePercent.TabIndex = 12;
            // 
            // comboBoxK_size
            // 
            this.comboBoxK_size.FormattingEnabled = true;
            this.comboBoxK_size.Items.AddRange(new object[] {
            "0",
            "3",
            "5",
            "7",
            "9"});
            this.comboBoxK_size.Location = new System.Drawing.Point(379, 364);
            this.comboBoxK_size.Name = "comboBoxK_size";
            this.comboBoxK_size.Size = new System.Drawing.Size(100, 20);
            this.comboBoxK_size.TabIndex = 13;
            // 
            // checkBoxHistogram
            // 
            this.checkBoxHistogram.AutoSize = true;
            this.checkBoxHistogram.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBoxHistogram.Location = new System.Drawing.Point(356, 409);
            this.checkBoxHistogram.Name = "checkBoxHistogram";
            this.checkBoxHistogram.Size = new System.Drawing.Size(123, 28);
            this.checkBoxHistogram.TabIndex = 14;
            this.checkBoxHistogram.Text = "Histogram";
            this.checkBoxHistogram.UseVisualStyleBackColor = true;
            // 
            // textBoxCannyLow
            // 
            this.textBoxCannyLow.Location = new System.Drawing.Point(568, 95);
            this.textBoxCannyLow.Name = "textBoxCannyLow";
            this.textBoxCannyLow.Size = new System.Drawing.Size(100, 22);
            this.textBoxCannyLow.TabIndex = 15;
            // 
            // labelRotate
            // 
            this.labelRotate.AutoSize = true;
            this.labelRotate.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelRotate.Location = new System.Drawing.Point(31, 147);
            this.labelRotate.Name = "labelRotate";
            this.labelRotate.Size = new System.Drawing.Size(69, 24);
            this.labelRotate.TabIndex = 16;
            this.labelRotate.Text = "Rotate";
            // 
            // labelShearX
            // 
            this.labelShearX.AutoSize = true;
            this.labelShearX.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelShearX.Location = new System.Drawing.Point(292, 147);
            this.labelShearX.Name = "labelShearX";
            this.labelShearX.Size = new System.Drawing.Size(73, 24);
            this.labelShearX.TabIndex = 17;
            this.labelShearX.Text = "ShearX";
            // 
            // labelShearY
            // 
            this.labelShearY.AutoSize = true;
            this.labelShearY.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelShearY.Location = new System.Drawing.Point(292, 193);
            this.labelShearY.Name = "labelShearY";
            this.labelShearY.Size = new System.Drawing.Size(72, 24);
            this.labelShearY.TabIndex = 18;
            this.labelShearY.Text = "ShearY";
            // 
            // labelPepperNoisePercent
            // 
            this.labelPepperNoisePercent.AutoSize = true;
            this.labelPepperNoisePercent.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelPepperNoisePercent.Location = new System.Drawing.Point(285, 237);
            this.labelPepperNoisePercent.Name = "labelPepperNoisePercent";
            this.labelPepperNoisePercent.Size = new System.Drawing.Size(204, 24);
            this.labelPepperNoisePercent.TabIndex = 19;
            this.labelPepperNoisePercent.Text = "Pepper Noise Percent";
            // 
            // labelmedianBlurImage
            // 
            this.labelmedianBlurImage.AutoSize = true;
            this.labelmedianBlurImage.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelmedianBlurImage.Location = new System.Drawing.Point(309, 326);
            this.labelmedianBlurImage.Name = "labelmedianBlurImage";
            this.labelmedianBlurImage.Size = new System.Drawing.Size(180, 24);
            this.labelmedianBlurImage.TabIndex = 20;
            this.labelmedianBlurImage.Text = "Median Blur Image";
            // 
            // labelCannyLow
            // 
            this.labelCannyLow.AutoSize = true;
            this.labelCannyLow.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelCannyLow.Location = new System.Drawing.Point(539, 46);
            this.labelCannyLow.Name = "labelCannyLow";
            this.labelCannyLow.Size = new System.Drawing.Size(109, 24);
            this.labelCannyLow.TabIndex = 21;
            this.labelCannyLow.Text = "Canny Low";
            // 
            // labelCannyHigh
            // 
            this.labelCannyHigh.AutoSize = true;
            this.labelCannyHigh.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelCannyHigh.Location = new System.Drawing.Point(539, 140);
            this.labelCannyHigh.Name = "labelCannyHigh";
            this.labelCannyHigh.Size = new System.Drawing.Size(115, 24);
            this.labelCannyHigh.TabIndex = 23;
            this.labelCannyHigh.Text = "Canny High";
            // 
            // textBoxCannyHigh
            // 
            this.textBoxCannyHigh.Location = new System.Drawing.Point(568, 186);
            this.textBoxCannyHigh.Name = "textBoxCannyHigh";
            this.textBoxCannyHigh.Size = new System.Drawing.Size(100, 22);
            this.textBoxCannyHigh.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 464);
            this.Controls.Add(this.labelCannyHigh);
            this.Controls.Add(this.textBoxCannyHigh);
            this.Controls.Add(this.labelCannyLow);
            this.Controls.Add(this.labelmedianBlurImage);
            this.Controls.Add(this.labelPepperNoisePercent);
            this.Controls.Add(this.labelShearY);
            this.Controls.Add(this.labelShearX);
            this.Controls.Add(this.labelRotate);
            this.Controls.Add(this.textBoxCannyLow);
            this.Controls.Add(this.checkBoxHistogram);
            this.Controls.Add(this.comboBoxK_size);
            this.Controls.Add(this.textBoxPepperNoisePercent);
            this.Controls.Add(this.textBoxShearY);
            this.Controls.Add(this.textBoxShearX);
            this.Controls.Add(this.checkBoxGrayScale);
            this.Controls.Add(this.checkBoxThresholding);
            this.Controls.Add(this.textBoxRotate);
            this.Controls.Add(this.checkBoxReflectX);
            this.Controls.Add(this.checkBoxReflectY);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "openCV test program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox checkBoxReflectY;
        private System.Windows.Forms.CheckBox checkBoxReflectX;
        private System.Windows.Forms.TextBox textBoxRotate;
        private System.Windows.Forms.CheckBox checkBoxThresholding;
        private System.Windows.Forms.CheckBox checkBoxGrayScale;
        private System.Windows.Forms.TextBox textBoxShearX;
        private System.Windows.Forms.TextBox textBoxShearY;
        private System.Windows.Forms.TextBox textBoxPepperNoisePercent;
        private System.Windows.Forms.ComboBox comboBoxK_size;
        private System.Windows.Forms.CheckBox checkBoxHistogram;
        private System.Windows.Forms.TextBox textBoxCannyLow;
        private System.Windows.Forms.Label labelRotate;
        private System.Windows.Forms.Label labelShearX;
        private System.Windows.Forms.Label labelShearY;
        private System.Windows.Forms.Label labelPepperNoisePercent;
        private System.Windows.Forms.Label labelmedianBlurImage;
        private System.Windows.Forms.Label labelCannyLow;
        private System.Windows.Forms.Label labelCannyHigh;
        private System.Windows.Forms.TextBox textBoxCannyHigh;
    }
}


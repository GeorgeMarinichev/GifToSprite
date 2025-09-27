namespace GifToSprite
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.buttonSelectGif = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxOrientation = new System.Windows.Forms.GroupBox();
            this.radioButtonHorizontal = new System.Windows.Forms.RadioButton();
            this.radioButtonVertical = new System.Windows.Forms.RadioButton();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.labelMaxFrames = new System.Windows.Forms.Label();
            this.numericUpDownMaxFrames = new System.Windows.Forms.NumericUpDown();
            this.groupBoxOrientation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxFrames)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSelectGif
            // 
            this.buttonSelectGif.Location = new System.Drawing.Point(12, 12);
            this.buttonSelectGif.Name = "buttonSelectGif";
            this.buttonSelectGif.Size = new System.Drawing.Size(150, 35);
            this.buttonSelectGif.TabIndex = 0;
            this.buttonSelectGif.Text = "Выбрать GIF";
            this.buttonSelectGif.UseVisualStyleBackColor = true;
            this.buttonSelectGif.Click += new System.EventHandler(this.buttonSelectGif_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(12, 53);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(150, 35);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Сохранить как";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 95);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(100, 15);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "Выберите GIF для начала.";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "GIF файлы (*.gif)|*.gif|Все файлы (*.*)|*.*";
            this.openFileDialog1.Title = "Выберите GIF-файл";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "png";
            this.saveFileDialog1.Filter = "PNG файлы (*.png)|*.png|Все файлы (*.*)|*.*";
            this.saveFileDialog1.Title = "Сохранить спрайт-шит как PNG";
            // 
            // groupBoxOrientation
            // 
            this.groupBoxOrientation.Controls.Add(this.radioButtonVertical);
            this.groupBoxOrientation.Controls.Add(this.radioButtonHorizontal);
            this.groupBoxOrientation.Location = new System.Drawing.Point(12, 115);
            this.groupBoxOrientation.Name = "groupBoxOrientation";
            this.groupBoxOrientation.Size = new System.Drawing.Size(200, 60);
            this.groupBoxOrientation.TabIndex = 3;
            this.groupBoxOrientation.TabStop = false;
            this.groupBoxOrientation.Text = "Ориентация спрайт-шита";
            // 
            // radioButtonHorizontal
            // 
            this.radioButtonHorizontal.AutoSize = true;
            this.radioButtonHorizontal.Checked = true;
            this.radioButtonHorizontal.Location = new System.Drawing.Point(6, 20);
            this.radioButtonHorizontal.Name = "radioButtonHorizontal";
            this.radioButtonHorizontal.Size = new System.Drawing.Size(90, 19);
            this.radioButtonHorizontal.TabIndex = 0;
            this.radioButtonHorizontal.TabStop = true;
            this.radioButtonHorizontal.Text = "Горизонтальный";
            this.radioButtonHorizontal.UseVisualStyleBackColor = true;
            this.radioButtonHorizontal.CheckedChanged += new System.EventHandler(this.radioButtonOrientation_CheckedChanged);
            // 
            // radioButtonVertical
            // 
            this.radioButtonVertical.AutoSize = true;
            this.radioButtonVertical.Location = new System.Drawing.Point(6, 40);
            this.radioButtonVertical.Name = "radioButtonVertical";
            this.radioButtonVertical.Size = new System.Drawing.Size(80, 19);
            this.radioButtonVertical.TabIndex = 1;
            this.radioButtonVertical.TabStop = true;
            this.radioButtonVertical.Text = "Вертикальный";
            this.radioButtonVertical.UseVisualStyleBackColor = true;
            this.radioButtonVertical.CheckedChanged += new System.EventHandler(this.radioButtonOrientation_CheckedChanged);
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPreview.Location = new System.Drawing.Point(270, 12);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(350, 350);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPreview.TabIndex = 4;
            this.pictureBoxPreview.TabStop = false;
            // 
            // labelMaxFrames
            // 
            this.labelMaxFrames.AutoSize = true;
            this.labelMaxFrames.Location = new System.Drawing.Point(12, 185);
            this.labelMaxFrames.Name = "labelMaxFrames";
            this.labelMaxFrames.Size = new System.Drawing.Size(120, 15);
            this.labelMaxFrames.TabIndex = 5;
            this.labelMaxFrames.Text = "Максимум кадров в строке";
            // 
            // numericUpDownMaxFrames
            // 
            this.numericUpDownMaxFrames.Location = new System.Drawing.Point(140, 180);
            this.numericUpDownMaxFrames.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numericUpDownMaxFrames.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericUpDownMaxFrames.Name = "numericUpDownMaxFrames";
            this.numericUpDownMaxFrames.Size = new System.Drawing.Size(70, 23);
            this.numericUpDownMaxFrames.TabIndex = 6;
            this.numericUpDownMaxFrames.Value = new decimal(new int[] { 10, 0, 0, 0 });
            this.numericUpDownMaxFrames.ValueChanged += new System.EventHandler(this.numericUpDownMaxFrames_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.numericUpDownMaxFrames);
            this.Controls.Add(this.labelMaxFrames);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.groupBoxOrientation);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonSelectGif);
            this.Name = "Form1";
            this.Text = "Конвертер GIF в спрайт-шит";
            this.groupBoxOrientation.ResumeLayout(false);
            this.groupBoxOrientation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxFrames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonSelectGif;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBoxOrientation;
        private System.Windows.Forms.RadioButton radioButtonHorizontal;
        private System.Windows.Forms.RadioButton radioButtonVertical;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.Label labelMaxFrames;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxFrames;
    }
}

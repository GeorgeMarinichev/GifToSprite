using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace GifToSprite
{
    public partial class Form1 : Form
    {
        private List<Bitmap> frames = new List<Bitmap>();
        private int frameCount = 0;
        private int frameWidth = 0;
        private int frameHeight = 0;
        private bool isVertical = false;
        private int maxFramesPerLine = 10; // Максимум кадров в строке/столбце

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSelectGif_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string gifPath = openFileDialog1.FileName;

                try
                {
                    foreach (Bitmap frame in frames)
                    {
                        frame.Dispose();
                    }
                    frames.Clear();
                    pictureBoxPreview.Image?.Dispose();
                    pictureBoxPreview.Image = null;

                    using (Image gifImage = Image.FromFile(gifPath))
                    {
                        FrameDimension dimension = new FrameDimension(gifImage.FrameDimensionsList[0]);
                        frameCount = gifImage.GetFrameCount(dimension);

                        if (frameCount == 0)
                        {
                            labelStatus.Text = "Ошибка: В GIF нет кадров!";
                            buttonSave.Enabled = false;
                            return;
                        }

                        for (int i = 0; i < frameCount; i++)
                        {
                            gifImage.SelectActiveFrame(dimension, i);
                            Bitmap bitmap = new Bitmap(gifImage);
                            frames.Add(bitmap);
                        }

                        frameWidth = frames[0].Width;
                        frameHeight = frames[0].Height;

                        labelStatus.Text = $"GIF загружен. Кадров: {frameCount}, Размер кадра: {frameWidth}x{frameHeight}";
                        buttonSave.Enabled = true;

                        UpdatePreview();
                    }
                }
                catch (Exception ex)
                {
                    labelStatus.Text = $"Ошибка загрузки: {ex.Message}";
                    buttonSave.Enabled = false;
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (frames.Count == 0)
            {
                labelStatus.Text = "Сначала выберите GIF!";
                return;
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string outputPath = saveFileDialog1.FileName;

                try
                {
                    Bitmap spriteSheet = CreateSpriteSheet();
                    spriteSheet.Save(outputPath, ImageFormat.Png);
                    spriteSheet.Dispose();

                    labelStatus.Text = $"Готово! Спрайт-шит сохранён в: {outputPath}";
                }
                catch (Exception ex)
                {
                    labelStatus.Text = $"Ошибка сохранения: {ex.Message}";
                }
            }
        }

        private void radioButtonOrientation_CheckedChanged(object sender, EventArgs e)
        {
            isVertical = radioButtonVertical.Checked;
            labelMaxFrames.Text = isVertical ? "Максимум кадров в столбце" : "Максимум кадров в строке";
            if (frames.Count > 0)
            {
                UpdatePreview();
            }
        }

        private void numericUpDownMaxFrames_ValueChanged(object sender, EventArgs e)
        {
            maxFramesPerLine = (int)numericUpDownMaxFrames.Value;
            if (frames.Count > 0)
            {
                UpdatePreview();
            }
        }

        private Bitmap CreateSpriteSheet()
        {
            int columns, rows;

            if (isVertical)
            {
                // Вертикальный: кадры в столбце, если > maxFramesPerLine, то несколько столбцов
                columns = (int)Math.Ceiling((double)frameCount / maxFramesPerLine);
                rows = Math.Min(frameCount, maxFramesPerLine);
            }
            else
            {
                // Горизонтальный: кадры в строке, если > maxFramesPerLine, то несколько строк
                rows = (int)Math.Ceiling((double)frameCount / maxFramesPerLine);
                columns = Math.Min(frameCount, maxFramesPerLine);
            }

            int totalWidth = columns * frameWidth;
            int totalHeight = rows * frameHeight;

            Bitmap spriteSheet = new Bitmap(totalWidth, totalHeight);
            using (Graphics g = Graphics.FromImage(spriteSheet))
            {
                g.Clear(Color.Transparent);
                int currentX = 0, currentY = 0;

                for (int i = 0; i < frameCount; i++)
                {
                    g.DrawImage(frames[i], currentX, currentY, frameWidth, frameHeight);

                    if (isVertical)
                    {
                        currentY += frameHeight;
                        if ((i + 1) % rows == 0)
                        {
                            currentY = 0;
                            currentX += frameWidth;
                        }
                    }
                    else
                    {
                        currentX += frameWidth;
                        if ((i + 1) % columns == 0)
                        {
                            currentX = 0;
                            currentY += frameHeight;
                        }
                    }
                }
            }

            return spriteSheet;
        }

        private void UpdatePreview()
        {
            pictureBoxPreview.Image?.Dispose();
            pictureBoxPreview.Image = CreateSpriteSheet();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            foreach (Bitmap frame in frames)
            {
                frame.Dispose();
            }
            pictureBoxPreview.Image?.Dispose();
            base.OnFormClosing(e);
        }
    }
}

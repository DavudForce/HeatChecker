using System;
using System.Drawing;
using System.Windows.Forms;

namespace HeatChecker
{
    public class CustomProgressBar : ProgressBar
    {
        public CustomProgressBar()
        {
            // Set the style to not use the default painting
            this.Style = ProgressBarStyle.Continuous;
            this.ForeColor = Color.DeepSkyBlue;
            this.BackColor = Color.DarkGray;
        }

        // Override OnPaint to customize the appearance
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Calculate the filled area based on the progress value
            float percentage = (float)this.Value / (float)this.Maximum;
            int fillWidth = (int)(this.Width * percentage);

            // Draw the background
            e.Graphics.FillRectangle(new SolidBrush(Color.DarkGray), 0, 0, this.Width, this.Height);

            // Draw the foreground with custom color
            e.Graphics.FillRectangle(new SolidBrush(Color.DeepSkyBlue), 0, 0, fillWidth, this.Height);
        }
    }
}
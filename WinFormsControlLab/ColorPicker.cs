using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LabControls
{
    public partial class ColorPicker : UserControl
    {
        private int _redChannel = 0;
        private int _greenChannel = 0;
        private int _blueChannel = 0;

        public Color Color
        {
            get { return Color.FromArgb(_redChannel, _greenChannel, _blueChannel); }
            set { }
        }

        public event EventHandler ColorChanged;

        protected virtual void OnColorChanged(EventArgs e)
        {
            ColorChanged?.Invoke(this, e);
        }

        public ColorPicker()
        {
            InitializeComponent();

            redColorBox.DecOrHex = decCheckBox.Checked;
            greenColorBox.DecOrHex = decCheckBox.Checked;
            blueColorBox.DecOrHex = decCheckBox.Checked;
        }

        private void ChangeDataFromDecChecked(bool isChecked)
        {
            redColorBox.DecOrHex = isChecked;
            greenColorBox.DecOrHex = isChecked;
            blueColorBox.DecOrHex = isChecked;

            if (isChecked)
            {
                redColorBox.Text = Convert.ToInt32(redColorBox.Text, 16).ToString();
                greenColorBox.Text = Convert.ToInt32(greenColorBox.Text, 16).ToString();
                blueColorBox.Text = Convert.ToInt32(blueColorBox.Text, 16).ToString();
            }
            else
            {
                redColorBox.Text = Convert.ToInt32(redColorBox.Text).ToString("X");
                greenColorBox.Text = Convert.ToInt32(greenColorBox.Text).ToString("X");
                blueColorBox.Text = Convert.ToInt32(blueColorBox.Text).ToString("X");
            }
        }

        private void hexCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            decCheckBox.Checked = !hexCheckBox.Checked;
        }

        private void decCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            hexCheckBox.Checked = !decCheckBox.Checked;

            ChangeDataFromDecChecked(decCheckBox.Checked);
        }

        private void redColorBox_TextChanged(object sender, EventArgs e)
        {
            _redChannel = decCheckBox.Checked ? int.Parse(redColorBox.Text) : Convert.ToInt32(redColorBox.Text, 16);
            Color = Color.FromArgb(_redChannel, _greenChannel, _blueChannel);
            colorPanel.BackColor = Color;

            OnColorChanged(EventArgs.Empty);
        }

        private void greenColorBox_TextChanged(object sender, EventArgs e)
        {
            _greenChannel = decCheckBox.Checked ? int.Parse(greenColorBox.Text) : Convert.ToInt32(greenColorBox.Text, 16);
            Color = Color.FromArgb(_redChannel, _greenChannel, _blueChannel);
            colorPanel.BackColor = Color;

            OnColorChanged(EventArgs.Empty);
        }

        private void blueColorBox_TextChanged(object sender, EventArgs e)
        {
            _blueChannel = decCheckBox.Checked ? int.Parse(blueColorBox.Text) : Convert.ToInt32(blueColorBox.Text, 16);
            Color = Color.FromArgb(_redChannel, _greenChannel, _blueChannel);
            colorPanel.BackColor = Color;

            OnColorChanged(EventArgs.Empty);
        }
    }
}

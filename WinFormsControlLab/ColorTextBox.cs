using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace LabControls
{
    public partial class ColorTextBox : TextBox
    {
        [Description("Dec or Hex?"), Category("Data")]
        public bool DecOrHex { get; set; }

        public ColorTextBox()
        {
            InitializeComponent();

            Text = "0";
        }

        public ColorTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private string ProcessForDec(string text)
        {
            if (text == "")
                return "0";

            var lastNum = 0;
            if (!int.TryParse(text[^1].ToString(), out lastNum))
                return text[..^1];

            var number = 0;
            if (!int.TryParse(text, out number))
                return "0";

            if (number < 0)
                return "0";

            if (number > 255)
                return "255";

            return text;

        }

        private string ProcessForHex(string text)
        {
            if (text == "")
                return "0";

            try
            {
                var number = Convert.ToInt32(text, 16);

                if (number < 0)
                    return "0";

                if (number > 255)
                    return "FF";

                return number.ToString("X");
            }
            catch
            {
                return "0";
            }

        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (DecOrHex)
                Text = ProcessForDec(Text);
            else
                Text = ProcessForHex(Text);
            base.OnTextChanged(e);
        }
    }
}

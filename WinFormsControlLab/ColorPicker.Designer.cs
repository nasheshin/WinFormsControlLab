
namespace LabControls
{
    partial class ColorPicker
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.redColorBox = new LabControls.ColorTextBox(this.components);
            this.labe1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.greenColorBox = new LabControls.ColorTextBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.blueColorBox = new LabControls.ColorTextBox(this.components);
            this.decCheckBox = new System.Windows.Forms.CheckBox();
            this.hexCheckBox = new System.Windows.Forms.CheckBox();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // redColorBox
            // 
            this.redColorBox.DecOrHex = false;
            this.redColorBox.Location = new System.Drawing.Point(75, 10);
            this.redColorBox.Name = "redColorBox";
            this.redColorBox.Size = new System.Drawing.Size(100, 23);
            this.redColorBox.TabIndex = 0;
            this.redColorBox.Text = "0";
            this.redColorBox.TextChanged += new System.EventHandler(this.redColorBox_TextChanged);
            // 
            // labe1
            // 
            this.labe1.AutoSize = true;
            this.labe1.Location = new System.Drawing.Point(10, 13);
            this.labe1.Name = "labe1";
            this.labe1.Size = new System.Drawing.Size(59, 15);
            this.labe1.TabIndex = 1;
            this.labe1.Text = "Красный:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Зеленый:";
            // 
            // greenColorBox
            // 
            this.greenColorBox.DecOrHex = false;
            this.greenColorBox.Location = new System.Drawing.Point(75, 39);
            this.greenColorBox.Name = "greenColorBox";
            this.greenColorBox.Size = new System.Drawing.Size(100, 23);
            this.greenColorBox.TabIndex = 2;
            this.greenColorBox.Text = "0";
            this.greenColorBox.TextChanged += new System.EventHandler(this.greenColorBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Синий:";
            // 
            // blueColorBox
            // 
            this.blueColorBox.DecOrHex = false;
            this.blueColorBox.Location = new System.Drawing.Point(75, 68);
            this.blueColorBox.Name = "blueColorBox";
            this.blueColorBox.Size = new System.Drawing.Size(100, 23);
            this.blueColorBox.TabIndex = 4;
            this.blueColorBox.Text = "0";
            this.blueColorBox.TextChanged += new System.EventHandler(this.blueColorBox_TextChanged);
            // 
            // decCheckBox
            // 
            this.decCheckBox.AutoSize = true;
            this.decCheckBox.Checked = true;
            this.decCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.decCheckBox.Location = new System.Drawing.Point(10, 97);
            this.decCheckBox.Name = "decCheckBox";
            this.decCheckBox.Size = new System.Drawing.Size(46, 19);
            this.decCheckBox.TabIndex = 6;
            this.decCheckBox.Text = "Dec";
            this.decCheckBox.UseVisualStyleBackColor = true;
            this.decCheckBox.CheckedChanged += new System.EventHandler(this.decCheckBox_CheckedChanged);
            // 
            // hexCheckBox
            // 
            this.hexCheckBox.AutoSize = true;
            this.hexCheckBox.Location = new System.Drawing.Point(62, 97);
            this.hexCheckBox.Name = "hexCheckBox";
            this.hexCheckBox.Size = new System.Drawing.Size(47, 19);
            this.hexCheckBox.TabIndex = 7;
            this.hexCheckBox.Text = "Hex";
            this.hexCheckBox.UseVisualStyleBackColor = true;
            this.hexCheckBox.CheckedChanged += new System.EventHandler(this.hexCheckBox_CheckedChanged);
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.Color.Black;
            this.colorPanel.Location = new System.Drawing.Point(181, 10);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(145, 100);
            this.colorPanel.TabIndex = 8;
            // 
            // ColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.hexCheckBox);
            this.Controls.Add(this.decCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.blueColorBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.greenColorBox);
            this.Controls.Add(this.labe1);
            this.Controls.Add(this.redColorBox);
            this.Name = "ColorPicker";
            this.Size = new System.Drawing.Size(338, 124);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColorTextBox redColorBox;
        private System.Windows.Forms.Label labe1;
        private System.Windows.Forms.Label label1;
        private ColorTextBox greenColorBox;
        private System.Windows.Forms.Label label2;
        private ColorTextBox blueColorBox;
        private System.Windows.Forms.CheckBox decCheckBox;
        private System.Windows.Forms.CheckBox hexCheckBox;
        private System.Windows.Forms.Panel colorPanel;
    }
}

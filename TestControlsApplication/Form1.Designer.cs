
namespace TestControlsApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.numberBox1 = new LabControls.NumberBox(this.components);
            this.filePathSelect1 = new LabControls.FilePathSelect();
            this.colorTextBox1 = new LabControls.ColorTextBox(this.components);
            this.colorPicker1 = new LabControls.ColorPicker();
            this.SuspendLayout();
            // 
            // numberBox1
            // 
            this.numberBox1.ForeColor = System.Drawing.Color.Red;
            this.numberBox1.Location = new System.Drawing.Point(12, 12);
            this.numberBox1.Name = "numberBox1";
            this.numberBox1.Size = new System.Drawing.Size(100, 23);
            this.numberBox1.TabIndex = 0;
            // 
            // filePathSelect1
            // 
            this.filePathSelect1.FileName = "";
            this.filePathSelect1.Location = new System.Drawing.Point(12, 391);
            this.filePathSelect1.Name = "filePathSelect1";
            this.filePathSelect1.Size = new System.Drawing.Size(370, 47);
            this.filePathSelect1.TabIndex = 1;
            // 
            // colorTextBox1
            // 
            this.colorTextBox1.DecOrHex = false;
            this.colorTextBox1.Location = new System.Drawing.Point(532, 12);
            this.colorTextBox1.Name = "colorTextBox1";
            this.colorTextBox1.Size = new System.Drawing.Size(100, 23);
            this.colorTextBox1.TabIndex = 2;
            this.colorTextBox1.Text = "1";
            // 
            // colorPicker1
            // 
            this.colorPicker1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorPicker1.Location = new System.Drawing.Point(450, 69);
            this.colorPicker1.Name = "colorPicker1";
            this.colorPicker1.Size = new System.Drawing.Size(338, 124);
            this.colorPicker1.TabIndex = 3;
            this.colorPicker1.ColorChanged += new System.EventHandler(this.colorPicker1_ColorChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.colorPicker1);
            this.Controls.Add(this.colorTextBox1);
            this.Controls.Add(this.filePathSelect1);
            this.Controls.Add(this.numberBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabControls.NumberBox numberBox1;
        private LabControls.FilePathSelect filePathSelect1;
        private LabControls.ColorTextBox colorTextBox1;
        private LabControls.ColorPicker colorPicker1;
    }
}


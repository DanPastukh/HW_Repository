
namespace Lesson1_HW06._09._21
{
    partial class Form1
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
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.numericUpDownStart = new System.Windows.Forms.NumericUpDown();
            this.textBoxEnd = new System.Windows.Forms.TextBox();
            this.numericUpDownEnd = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownPortStart = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPortEnd = new System.Windows.Forms.NumericUpDown();
            this.buttonScan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPortStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPortEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(273, 11);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(59, 20);
            this.textBoxStart.TabIndex = 0;
            this.textBoxStart.Text = "192.168.0.";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(198, 342);
            this.listBox1.TabIndex = 1;
            // 
            // numericUpDownStart
            // 
            this.numericUpDownStart.Location = new System.Drawing.Point(338, 12);
            this.numericUpDownStart.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownStart.Name = "numericUpDownStart";
            this.numericUpDownStart.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownStart.TabIndex = 2;
            // 
            // textBoxEnd
            // 
            this.textBoxEnd.Location = new System.Drawing.Point(273, 43);
            this.textBoxEnd.Name = "textBoxEnd";
            this.textBoxEnd.Size = new System.Drawing.Size(59, 20);
            this.textBoxEnd.TabIndex = 3;
            this.textBoxEnd.Text = "192.168.0.";
            // 
            // numericUpDownEnd
            // 
            this.numericUpDownEnd.Location = new System.Drawing.Point(338, 43);
            this.numericUpDownEnd.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownEnd.Name = "numericUpDownEnd";
            this.numericUpDownEnd.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownEnd.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "IPStart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "IPEnd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "PortStart";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "PortEnd";
            // 
            // numericUpDownPortStart
            // 
            this.numericUpDownPortStart.Location = new System.Drawing.Point(273, 71);
            this.numericUpDownPortStart.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownPortStart.Name = "numericUpDownPortStart";
            this.numericUpDownPortStart.Size = new System.Drawing.Size(104, 20);
            this.numericUpDownPortStart.TabIndex = 9;
            // 
            // numericUpDownPortEnd
            // 
            this.numericUpDownPortEnd.Location = new System.Drawing.Point(273, 104);
            this.numericUpDownPortEnd.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownPortEnd.Name = "numericUpDownPortEnd";
            this.numericUpDownPortEnd.Size = new System.Drawing.Size(104, 20);
            this.numericUpDownPortEnd.TabIndex = 10;
            // 
            // buttonScan
            // 
            this.buttonScan.Location = new System.Drawing.Point(219, 130);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(158, 73);
            this.buttonScan.TabIndex = 11;
            this.buttonScan.Text = "Scan Ports";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 357);
            this.Controls.Add(this.buttonScan);
            this.Controls.Add(this.numericUpDownPortEnd);
            this.Controls.Add(this.numericUpDownPortStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownEnd);
            this.Controls.Add(this.textBoxEnd);
            this.Controls.Add(this.numericUpDownStart);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxStart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPortStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPortEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownStart;
        private System.Windows.Forms.TextBox textBoxEnd;
        private System.Windows.Forms.NumericUpDown numericUpDownEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownPortStart;
        private System.Windows.Forms.NumericUpDown numericUpDownPortEnd;
        private System.Windows.Forms.Button buttonScan;
    }
}


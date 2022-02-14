
namespace WinFormsApp1
{
    partial class Stopwatch
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
            this.labelMinutes = new System.Windows.Forms.Label();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelStotinka = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUnosMinuta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.buttonResume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMinutes.Location = new System.Drawing.Point(129, 107);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(67, 54);
            this.labelMinutes.TabIndex = 0;
            this.labelMinutes.Text = "00";
            this.labelMinutes.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSeconds.Location = new System.Drawing.Point(217, 107);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(67, 54);
            this.labelSeconds.TabIndex = 1;
            this.labelSeconds.Text = "00";
            this.labelSeconds.Click += new System.EventHandler(this.labelSeconds_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(190, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(46, 242);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(119, 42);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(191, 242);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(119, 42);
            this.buttonStop.TabIndex = 4;
            this.buttonStop.Text = "PAUSE";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(336, 242);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(119, 42);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // labelStotinka
            // 
            this.labelStotinka.AutoSize = true;
            this.labelStotinka.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStotinka.Location = new System.Drawing.Point(301, 107);
            this.labelStotinka.Name = "labelStotinka";
            this.labelStotinka.Size = new System.Drawing.Size(67, 54);
            this.labelStotinka.TabIndex = 6;
            this.labelStotinka.Text = "00";
            this.labelStotinka.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(278, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 54);
            this.label2.TabIndex = 7;
            this.label2.Text = ".";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // textBoxUnosMinuta
            // 
            this.textBoxUnosMinuta.Location = new System.Drawing.Point(46, 49);
            this.textBoxUnosMinuta.Name = "textBoxUnosMinuta";
            this.textBoxUnosMinuta.Size = new System.Drawing.Size(41, 23);
            this.textBoxUnosMinuta.TabIndex = 8;
            this.textBoxUnosMinuta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Unesi broj minuta odbrojavanja pa klikni START";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 600;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // buttonResume
            // 
            this.buttonResume.Location = new System.Drawing.Point(191, 291);
            this.buttonResume.Name = "buttonResume";
            this.buttonResume.Size = new System.Drawing.Size(119, 39);
            this.buttonResume.TabIndex = 10;
            this.buttonResume.Text = "RESUME";
            this.buttonResume.UseVisualStyleBackColor = true;
            this.buttonResume.Click += new System.EventHandler(this.buttonResume_Click);
            // 
            // Stopwatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(481, 342);
            this.Controls.Add(this.buttonResume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUnosMinuta);
            this.Controls.Add(this.labelStotinka);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSeconds);
            this.Controls.Add(this.labelMinutes);
            this.Controls.Add(this.label2);
            this.Name = "Stopwatch";
            this.Text = "Stopwatch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelStotinka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUnosMinuta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button buttonResume;
    }
}


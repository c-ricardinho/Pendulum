namespace Pendulum
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
            this.components = new System.ComponentModel.Container();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timerDown = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPlus1 = new System.Windows.Forms.Button();
            this.buttonMinus1 = new System.Windows.Forms.Button();
            this.progressBarTime = new System.Windows.Forms.ProgressBar();
            this.labelLength = new System.Windows.Forms.Label();
            this.timerUp = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.BackColor = System.Drawing.Color.Lime;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonStart.Location = new System.Drawing.Point(250, 226);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // timerDown
            // 
            this.timerDown.Interval = 1000;
            this.timerDown.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Lime;
            this.labelTime.Location = new System.Drawing.Point(26, 67);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(284, 108);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "01:00";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStop.BackColor = System.Drawing.Color.Red;
            this.buttonStop.Enabled = false;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonStop.Location = new System.Drawing.Point(169, 226);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 0;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // buttonPlus1
            // 
            this.buttonPlus1.Location = new System.Drawing.Point(250, 12);
            this.buttonPlus1.Name = "buttonPlus1";
            this.buttonPlus1.Size = new System.Drawing.Size(75, 52);
            this.buttonPlus1.TabIndex = 8;
            this.buttonPlus1.Text = "+1 Minute";
            this.buttonPlus1.UseVisualStyleBackColor = true;
            this.buttonPlus1.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus1
            // 
            this.buttonMinus1.Location = new System.Drawing.Point(12, 12);
            this.buttonMinus1.Name = "buttonMinus1";
            this.buttonMinus1.Size = new System.Drawing.Size(75, 52);
            this.buttonMinus1.TabIndex = 9;
            this.buttonMinus1.Text = "-1 Minute";
            this.buttonMinus1.UseVisualStyleBackColor = true;
            this.buttonMinus1.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // progressBarTime
            // 
            this.progressBarTime.Location = new System.Drawing.Point(12, 178);
            this.progressBarTime.Name = "progressBarTime";
            this.progressBarTime.Size = new System.Drawing.Size(313, 23);
            this.progressBarTime.TabIndex = 11;
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLength.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelLength.Location = new System.Drawing.Point(96, 9);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(145, 55);
            this.labelLength.TabIndex = 14;
            this.labelLength.Text = "01:00";
            this.labelLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerUp
            // 
            this.timerUp.Interval = 1000;
            this.timerUp.Tick += new System.EventHandler(this.timerUp_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(337, 261);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.progressBarTime);
            this.Controls.Add(this.buttonMinus1);
            this.Controls.Add(this.buttonPlus1);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pendulum [Screen 1]";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timerDown;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonPlus1;
        private System.Windows.Forms.Button buttonMinus1;
        private System.Windows.Forms.ProgressBar progressBarTime;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Timer timerUp;
    }
}


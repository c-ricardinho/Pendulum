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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Lime;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonStart.Location = new System.Drawing.Point(305, 186);
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
            this.labelTime.BackColor = System.Drawing.Color.Black;
            this.labelTime.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Lime;
            this.labelTime.Location = new System.Drawing.Point(12, 39);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(287, 115);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "01:00";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Red;
            this.buttonStop.Enabled = false;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonStop.Location = new System.Drawing.Point(224, 186);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 0;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // buttonPlus1
            // 
            this.buttonPlus1.Location = new System.Drawing.Point(305, 39);
            this.buttonPlus1.Name = "buttonPlus1";
            this.buttonPlus1.Size = new System.Drawing.Size(75, 52);
            this.buttonPlus1.TabIndex = 8;
            this.buttonPlus1.Text = "+1 Minute";
            this.buttonPlus1.UseVisualStyleBackColor = true;
            this.buttonPlus1.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus1
            // 
            this.buttonMinus1.Location = new System.Drawing.Point(305, 102);
            this.buttonMinus1.Name = "buttonMinus1";
            this.buttonMinus1.Size = new System.Drawing.Size(75, 52);
            this.buttonMinus1.TabIndex = 9;
            this.buttonMinus1.Text = "-1 Minute";
            this.buttonMinus1.UseVisualStyleBackColor = true;
            this.buttonMinus1.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // progressBarTime
            // 
            this.progressBarTime.Location = new System.Drawing.Point(12, 157);
            this.progressBarTime.Name = "progressBarTime";
            this.progressBarTime.Size = new System.Drawing.Size(368, 23);
            this.progressBarTime.TabIndex = 11;
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLength.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelLength.Location = new System.Drawing.Point(227, 9);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(72, 30);
            this.labelLength.TabIndex = 14;
            this.labelLength.Text = "01:00";
            this.labelLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerUp
            // 
            this.timerUp.Interval = 1000;
            this.timerUp.Tick += new System.EventHandler(this.timerUp_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Talk Length:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(387, 219);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.progressBarTime);
            this.Controls.Add(this.buttonMinus1);
            this.Controls.Add(this.buttonPlus1);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Label label1;
    }
}


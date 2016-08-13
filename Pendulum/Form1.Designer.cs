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
            this.groupBoxTimerControls = new System.Windows.Forms.GroupBox();
            this.groupBoxPresets = new System.Windows.Forms.GroupBox();
            this.radioButtonTreasures = new System.Windows.Forms.RadioButton();
            this.radioButtonDigging = new System.Windows.Forms.RadioButton();
            this.radioButtonBibleReading = new System.Windows.Forms.RadioButton();
            this.radioButtonInitialCall = new System.Windows.Forms.RadioButton();
            this.radioButtonReturnVisit = new System.Windows.Forms.RadioButton();
            this.radioButtonBibleStudy = new System.Windows.Forms.RadioButton();
            this.radioButtonPublicTalk = new System.Windows.Forms.RadioButton();
            this.buttonSound = new System.Windows.Forms.Button();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.labelClock = new System.Windows.Forms.Label();
            this.groupBoxClocksTimers = new System.Windows.Forms.GroupBox();
            this.groupBoxTimerControls.SuspendLayout();
            this.groupBoxPresets.SuspendLayout();
            this.groupBoxClocksTimers.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Lime;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonStart.Location = new System.Drawing.Point(454, 19);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(100, 100);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.StartButton_Click);
            this.buttonStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // timerDown
            // 
            this.timerDown.Interval = 1000;
            this.timerDown.Tick += new System.EventHandler(this.timerDown_Tick);
            // 
            // labelTime
            // 
            this.labelTime.BackColor = System.Drawing.Color.Black;
            this.labelTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTime.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Lime;
            this.labelTime.Location = new System.Drawing.Point(6, 20);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(324, 179);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "01:00";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.SystemColors.Control;
            this.buttonStop.Enabled = false;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.ForeColor = System.Drawing.Color.Maroon;
            this.buttonStop.Location = new System.Drawing.Point(342, 19);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(100, 100);
            this.buttonStop.TabIndex = 4;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.StopButton_Click);
            this.buttonStop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // buttonPlus1
            // 
            this.buttonPlus1.BackColor = System.Drawing.Color.Orange;
            this.buttonPlus1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlus1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonPlus1.Location = new System.Drawing.Point(230, 19);
            this.buttonPlus1.Name = "buttonPlus1";
            this.buttonPlus1.Size = new System.Drawing.Size(100, 100);
            this.buttonPlus1.TabIndex = 2;
            this.buttonPlus1.Text = "+1";
            this.buttonPlus1.UseVisualStyleBackColor = false;
            this.buttonPlus1.Click += new System.EventHandler(this.buttonPlus_Click);
            this.buttonPlus1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // buttonMinus1
            // 
            this.buttonMinus1.BackColor = System.Drawing.Color.Orange;
            this.buttonMinus1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinus1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinus1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonMinus1.Location = new System.Drawing.Point(118, 19);
            this.buttonMinus1.Name = "buttonMinus1";
            this.buttonMinus1.Size = new System.Drawing.Size(100, 100);
            this.buttonMinus1.TabIndex = 1;
            this.buttonMinus1.Text = "-1";
            this.buttonMinus1.UseVisualStyleBackColor = false;
            this.buttonMinus1.Click += new System.EventHandler(this.buttonMinus_Click);
            this.buttonMinus1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // progressBarTime
            // 
            this.progressBarTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarTime.BackColor = System.Drawing.SystemColors.Control;
            this.progressBarTime.Location = new System.Drawing.Point(12, 220);
            this.progressBarTime.Name = "progressBarTime";
            this.progressBarTime.Size = new System.Drawing.Size(560, 23);
            this.progressBarTime.TabIndex = 11;
            // 
            // labelLength
            // 
            this.labelLength.BackColor = System.Drawing.Color.Black;
            this.labelLength.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLength.ForeColor = System.Drawing.Color.Lime;
            this.labelLength.Location = new System.Drawing.Point(6, 21);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(324, 50);
            this.labelLength.TabIndex = 14;
            this.labelLength.Text = "Talk Length: 01:00";
            this.labelLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerUp
            // 
            this.timerUp.Interval = 1000;
            this.timerUp.Tick += new System.EventHandler(this.timerUp_Tick);
            // 
            // groupBoxTimerControls
            // 
            this.groupBoxTimerControls.Controls.Add(this.buttonSound);
            this.groupBoxTimerControls.Controls.Add(this.buttonMinus1);
            this.groupBoxTimerControls.Controls.Add(this.buttonPlus1);
            this.groupBoxTimerControls.Controls.Add(this.buttonStop);
            this.groupBoxTimerControls.Controls.Add(this.buttonStart);
            this.groupBoxTimerControls.Location = new System.Drawing.Point(12, 249);
            this.groupBoxTimerControls.Name = "groupBoxTimerControls";
            this.groupBoxTimerControls.Size = new System.Drawing.Size(560, 125);
            this.groupBoxTimerControls.TabIndex = 16;
            this.groupBoxTimerControls.TabStop = false;
            this.groupBoxTimerControls.Text = "Timer Controls";
            // 
            // groupBoxPresets
            // 
            this.groupBoxPresets.Controls.Add(this.radioButtonPublicTalk);
            this.groupBoxPresets.Controls.Add(this.radioButtonBibleStudy);
            this.groupBoxPresets.Controls.Add(this.radioButtonReturnVisit);
            this.groupBoxPresets.Controls.Add(this.radioButtonInitialCall);
            this.groupBoxPresets.Controls.Add(this.radioButtonBibleReading);
            this.groupBoxPresets.Controls.Add(this.radioButtonDigging);
            this.groupBoxPresets.Controls.Add(this.radioButtonTreasures);
            this.groupBoxPresets.Location = new System.Drawing.Point(354, 12);
            this.groupBoxPresets.Name = "groupBoxPresets";
            this.groupBoxPresets.Size = new System.Drawing.Size(218, 202);
            this.groupBoxPresets.TabIndex = 20;
            this.groupBoxPresets.TabStop = false;
            this.groupBoxPresets.Text = "Presets";
            // 
            // radioButtonTreasures
            // 
            this.radioButtonTreasures.AutoSize = true;
            this.radioButtonTreasures.Location = new System.Drawing.Point(6, 20);
            this.radioButtonTreasures.Name = "radioButtonTreasures";
            this.radioButtonTreasures.Size = new System.Drawing.Size(154, 17);
            this.radioButtonTreasures.TabIndex = 0;
            this.radioButtonTreasures.TabStop = true;
            this.radioButtonTreasures.Text = "Treasures from God\'s Word";
            this.radioButtonTreasures.UseVisualStyleBackColor = true;
            this.radioButtonTreasures.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            this.radioButtonTreasures.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // radioButtonDigging
            // 
            this.radioButtonDigging.AutoSize = true;
            this.radioButtonDigging.Location = new System.Drawing.Point(6, 43);
            this.radioButtonDigging.Name = "radioButtonDigging";
            this.radioButtonDigging.Size = new System.Drawing.Size(166, 17);
            this.radioButtonDigging.TabIndex = 1;
            this.radioButtonDigging.TabStop = true;
            this.radioButtonDigging.Text = "Digging for Spiritual Treasures";
            this.radioButtonDigging.UseVisualStyleBackColor = true;
            this.radioButtonDigging.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            this.radioButtonDigging.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // radioButtonBibleReading
            // 
            this.radioButtonBibleReading.AutoSize = true;
            this.radioButtonBibleReading.Location = new System.Drawing.Point(6, 66);
            this.radioButtonBibleReading.Name = "radioButtonBibleReading";
            this.radioButtonBibleReading.Size = new System.Drawing.Size(91, 17);
            this.radioButtonBibleReading.TabIndex = 2;
            this.radioButtonBibleReading.TabStop = true;
            this.radioButtonBibleReading.Text = "Bible Reading";
            this.radioButtonBibleReading.UseVisualStyleBackColor = true;
            this.radioButtonBibleReading.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            this.radioButtonBibleReading.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // radioButtonInitialCall
            // 
            this.radioButtonInitialCall.AutoSize = true;
            this.radioButtonInitialCall.Location = new System.Drawing.Point(6, 89);
            this.radioButtonInitialCall.Name = "radioButtonInitialCall";
            this.radioButtonInitialCall.Size = new System.Drawing.Size(67, 17);
            this.radioButtonInitialCall.TabIndex = 3;
            this.radioButtonInitialCall.TabStop = true;
            this.radioButtonInitialCall.Text = "Inital Call";
            this.radioButtonInitialCall.UseVisualStyleBackColor = true;
            this.radioButtonInitialCall.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            this.radioButtonInitialCall.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // radioButtonReturnVisit
            // 
            this.radioButtonReturnVisit.AutoSize = true;
            this.radioButtonReturnVisit.Location = new System.Drawing.Point(6, 112);
            this.radioButtonReturnVisit.Name = "radioButtonReturnVisit";
            this.radioButtonReturnVisit.Size = new System.Drawing.Size(79, 17);
            this.radioButtonReturnVisit.TabIndex = 4;
            this.radioButtonReturnVisit.TabStop = true;
            this.radioButtonReturnVisit.Text = "Return Visit";
            this.radioButtonReturnVisit.UseVisualStyleBackColor = true;
            this.radioButtonReturnVisit.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            this.radioButtonReturnVisit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // radioButtonBibleStudy
            // 
            this.radioButtonBibleStudy.AutoSize = true;
            this.radioButtonBibleStudy.Location = new System.Drawing.Point(6, 135);
            this.radioButtonBibleStudy.Name = "radioButtonBibleStudy";
            this.radioButtonBibleStudy.Size = new System.Drawing.Size(78, 17);
            this.radioButtonBibleStudy.TabIndex = 5;
            this.radioButtonBibleStudy.TabStop = true;
            this.radioButtonBibleStudy.Text = "Bible Study";
            this.radioButtonBibleStudy.UseVisualStyleBackColor = true;
            this.radioButtonBibleStudy.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            this.radioButtonBibleStudy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // radioButtonPublicTalk
            // 
            this.radioButtonPublicTalk.AutoSize = true;
            this.radioButtonPublicTalk.Location = new System.Drawing.Point(6, 158);
            this.radioButtonPublicTalk.Name = "radioButtonPublicTalk";
            this.radioButtonPublicTalk.Size = new System.Drawing.Size(182, 17);
            this.radioButtonPublicTalk.TabIndex = 6;
            this.radioButtonPublicTalk.TabStop = true;
            this.radioButtonPublicTalk.Text = "Congregation Study / Public Talk\r\n";
            this.radioButtonPublicTalk.UseVisualStyleBackColor = true;
            this.radioButtonPublicTalk.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            this.radioButtonPublicTalk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // buttonSound
            // 
            this.buttonSound.BackColor = System.Drawing.Color.Red;
            this.buttonSound.BackgroundImage = global::Pendulum.Properties.Resources.SoundOff;
            this.buttonSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSound.Location = new System.Drawing.Point(6, 19);
            this.buttonSound.Name = "buttonSound";
            this.buttonSound.Size = new System.Drawing.Size(100, 100);
            this.buttonSound.TabIndex = 21;
            this.buttonSound.UseVisualStyleBackColor = false;
            this.buttonSound.Click += new System.EventHandler(this.buttonSound_Click);
            this.buttonSound.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // timerClock
            // 
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // labelClock
            // 
            this.labelClock.BackColor = System.Drawing.Color.Black;
            this.labelClock.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClock.ForeColor = System.Drawing.Color.Lime;
            this.labelClock.Location = new System.Drawing.Point(6, 149);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(324, 50);
            this.labelClock.TabIndex = 21;
            this.labelClock.Text = "CurrentTime";
            this.labelClock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxClocksTimers
            // 
            this.groupBoxClocksTimers.Controls.Add(this.labelLength);
            this.groupBoxClocksTimers.Controls.Add(this.labelClock);
            this.groupBoxClocksTimers.Controls.Add(this.labelTime);
            this.groupBoxClocksTimers.Location = new System.Drawing.Point(12, 12);
            this.groupBoxClocksTimers.Name = "groupBoxClocksTimers";
            this.groupBoxClocksTimers.Size = new System.Drawing.Size(336, 202);
            this.groupBoxClocksTimers.TabIndex = 22;
            this.groupBoxClocksTimers.TabStop = false;
            this.groupBoxClocksTimers.Text = "Clocks and Timers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 386);
            this.Controls.Add(this.groupBoxClocksTimers);
            this.Controls.Add(this.groupBoxPresets);
            this.Controls.Add(this.groupBoxTimerControls);
            this.Controls.Add(this.progressBarTime);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 425);
            this.MinimumSize = new System.Drawing.Size(600, 425);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pendulum [Screen 1]";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBoxTimerControls.ResumeLayout(false);
            this.groupBoxPresets.ResumeLayout(false);
            this.groupBoxPresets.PerformLayout();
            this.groupBoxClocksTimers.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBoxTimerControls;
        private System.Windows.Forms.GroupBox groupBoxPresets;
        private System.Windows.Forms.RadioButton radioButtonPublicTalk;
        private System.Windows.Forms.RadioButton radioButtonBibleStudy;
        private System.Windows.Forms.RadioButton radioButtonReturnVisit;
        private System.Windows.Forms.RadioButton radioButtonInitialCall;
        private System.Windows.Forms.RadioButton radioButtonBibleReading;
        private System.Windows.Forms.RadioButton radioButtonDigging;
        private System.Windows.Forms.RadioButton radioButtonTreasures;
        private System.Windows.Forms.Button buttonSound;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.GroupBox groupBoxClocksTimers;
    }
}


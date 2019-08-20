namespace Tortoise_Hare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbTortoiseTrack = new System.Windows.Forms.PictureBox();
            this.pbHareTrack = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rbtnFast = new System.Windows.Forms.RadioButton();
            this.rbtnMedium = new System.Windows.Forms.RadioButton();
            this.rbtnSlow = new System.Windows.Forms.RadioButton();
            this.lbl_output = new System.Windows.Forms.Label();
            this.gbScoreboard = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblHareScore = new System.Windows.Forms.Label();
            this.lblTortoiseScore = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbTortoise = new System.Windows.Forms.PictureBox();
            this.pbHare = new System.Windows.Forms.PictureBox();
            this.gb_speed = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lb_output = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTortoiseTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHareTrack)).BeginInit();
            this.gbScoreboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTortoise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHare)).BeginInit();
            this.gb_speed.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbTortoiseTrack
            // 
            this.pbTortoiseTrack.Location = new System.Drawing.Point(12, 25);
            this.pbTortoiseTrack.Name = "pbTortoiseTrack";
            this.pbTortoiseTrack.Size = new System.Drawing.Size(870, 50);
            this.pbTortoiseTrack.TabIndex = 0;
            this.pbTortoiseTrack.TabStop = false;
            this.pbTortoiseTrack.Paint += new System.Windows.Forms.PaintEventHandler(this.pbTortoiseTrack_Paint);
            // 
            // pbHareTrack
            // 
            this.pbHareTrack.Location = new System.Drawing.Point(12, 103);
            this.pbHareTrack.Name = "pbHareTrack";
            this.pbHareTrack.Size = new System.Drawing.Size(870, 50);
            this.pbHareTrack.TabIndex = 1;
            this.pbHareTrack.TabStop = false;
            this.pbHareTrack.Paint += new System.Windows.Forms.PaintEventHandler(this.pbHareTrack_Paint);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(342, 184);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(342, 213);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rbtnFast
            // 
            this.rbtnFast.AutoSize = true;
            this.rbtnFast.Location = new System.Drawing.Point(21, 19);
            this.rbtnFast.Name = "rbtnFast";
            this.rbtnFast.Size = new System.Drawing.Size(45, 17);
            this.rbtnFast.TabIndex = 4;
            this.rbtnFast.TabStop = true;
            this.rbtnFast.Text = "Fast";
            this.rbtnFast.UseVisualStyleBackColor = true;
            this.rbtnFast.CheckedChanged += new System.EventHandler(this.rbtnFast_CheckedChanged);
            // 
            // rbtnMedium
            // 
            this.rbtnMedium.AutoSize = true;
            this.rbtnMedium.Location = new System.Drawing.Point(21, 42);
            this.rbtnMedium.Name = "rbtnMedium";
            this.rbtnMedium.Size = new System.Drawing.Size(62, 17);
            this.rbtnMedium.TabIndex = 5;
            this.rbtnMedium.TabStop = true;
            this.rbtnMedium.Text = "Medium";
            this.rbtnMedium.UseVisualStyleBackColor = true;
            this.rbtnMedium.CheckedChanged += new System.EventHandler(this.rbtnMedium_CheckedChanged);
            // 
            // rbtnSlow
            // 
            this.rbtnSlow.AutoSize = true;
            this.rbtnSlow.Location = new System.Drawing.Point(21, 63);
            this.rbtnSlow.Name = "rbtnSlow";
            this.rbtnSlow.Size = new System.Drawing.Size(48, 17);
            this.rbtnSlow.TabIndex = 6;
            this.rbtnSlow.TabStop = true;
            this.rbtnSlow.Text = "Slow";
            this.rbtnSlow.UseVisualStyleBackColor = true;
            this.rbtnSlow.CheckedChanged += new System.EventHandler(this.rbtnSlow_CheckedChanged);
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Location = new System.Drawing.Point(618, 177);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(95, 13);
            this.lbl_output.TabIndex = 8;
            this.lbl_output.Text = "GAME UPDATES!";
            this.lbl_output.Click += new System.EventHandler(this.lbl_output_Click);
            // 
            // gbScoreboard
            // 
            this.gbScoreboard.Controls.Add(this.btnClear);
            this.gbScoreboard.Controls.Add(this.lblHareScore);
            this.gbScoreboard.Controls.Add(this.lblTortoiseScore);
            this.gbScoreboard.Controls.Add(this.label4);
            this.gbScoreboard.Controls.Add(this.label3);
            this.gbScoreboard.Controls.Add(this.label1);
            this.gbScoreboard.Location = new System.Drawing.Point(173, 177);
            this.gbScoreboard.Name = "gbScoreboard";
            this.gbScoreboard.Size = new System.Drawing.Size(135, 124);
            this.gbScoreboard.TabIndex = 9;
            this.gbScoreboard.TabStop = false;
            this.gbScoreboard.Text = "Score Board";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(28, 84);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblHareScore
            // 
            this.lblHareScore.AutoSize = true;
            this.lblHareScore.Location = new System.Drawing.Point(91, 59);
            this.lblHareScore.Name = "lblHareScore";
            this.lblHareScore.Size = new System.Drawing.Size(13, 13);
            this.lblHareScore.TabIndex = 4;
            this.lblHareScore.Text = "0";
            // 
            // lblTortoiseScore
            // 
            this.lblTortoiseScore.AutoSize = true;
            this.lblTortoiseScore.Location = new System.Drawing.Point(26, 59);
            this.lblTortoiseScore.Name = "lblTortoiseScore";
            this.lblTortoiseScore.Size = new System.Drawing.Size(13, 13);
            this.lblTortoiseScore.TabIndex = 3;
            this.lblTortoiseScore.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(62, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hare";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tortoise";
            // 
            // pbTortoise
            // 
            this.pbTortoise.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbTortoise.BackgroundImage")));
            this.pbTortoise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbTortoise.Location = new System.Drawing.Point(12, 35);
            this.pbTortoise.Name = "pbTortoise";
            this.pbTortoise.Size = new System.Drawing.Size(65, 30);
            this.pbTortoise.TabIndex = 10;
            this.pbTortoise.TabStop = false;
            // 
            // pbHare
            // 
            this.pbHare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbHare.BackgroundImage")));
            this.pbHare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbHare.Location = new System.Drawing.Point(12, 119);
            this.pbHare.Name = "pbHare";
            this.pbHare.Size = new System.Drawing.Size(65, 34);
            this.pbHare.TabIndex = 11;
            this.pbHare.TabStop = false;
            // 
            // gb_speed
            // 
            this.gb_speed.Controls.Add(this.rbtnMedium);
            this.gb_speed.Controls.Add(this.rbtnFast);
            this.gb_speed.Controls.Add(this.rbtnSlow);
            this.gb_speed.Location = new System.Drawing.Point(12, 171);
            this.gb_speed.Name = "gb_speed";
            this.gb_speed.Size = new System.Drawing.Size(100, 94);
            this.gb_speed.TabIndex = 12;
            this.gb_speed.TabStop = false;
            this.gb_speed.Text = "Timer";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(342, 242);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lb_output
            // 
            this.lb_output.FormattingEnabled = true;
            this.lb_output.Location = new System.Drawing.Point(558, 193);
            this.lb_output.Name = "lb_output";
            this.lb_output.Size = new System.Drawing.Size(211, 108);
            this.lb_output.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(933, 313);
            this.Controls.Add(this.lb_output);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gb_speed);
            this.Controls.Add(this.pbHare);
            this.Controls.Add(this.pbTortoise);
            this.Controls.Add(this.gbScoreboard);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pbHareTrack);
            this.Controls.Add(this.pbTortoiseTrack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tortoise and the Hare";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTortoiseTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHareTrack)).EndInit();
            this.gbScoreboard.ResumeLayout(false);
            this.gbScoreboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTortoise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHare)).EndInit();
            this.gb_speed.ResumeLayout(false);
            this.gb_speed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTortoiseTrack;
        private System.Windows.Forms.PictureBox pbHareTrack;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton rbtnFast;
        private System.Windows.Forms.RadioButton rbtnMedium;
        private System.Windows.Forms.RadioButton rbtnSlow;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.GroupBox gbScoreboard;
        private System.Windows.Forms.Label lblHareScore;
        private System.Windows.Forms.Label lblTortoiseScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbTortoise;
        private System.Windows.Forms.PictureBox pbHare;
        private System.Windows.Forms.GroupBox gb_speed;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListBox lb_output;
        private System.Windows.Forms.Button btnClear;
    }
}


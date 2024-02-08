namespace Assingment1MCQGame_AnyaScheinman
{
    partial class Form24
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form24));
            this.btnOption1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnOption2 = new System.Windows.Forms.Button();
            this.btnOption3 = new System.Windows.Forms.Button();
            this.btnOption4 = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.timerQuiz = new System.Windows.Forms.Timer(this.components);
            this.lblGoodJob = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOption1
            // 
            this.btnOption1.BackgroundImage = global::Assingment1MCQGame_AnyaScheinman.Properties.Resources._l;
            this.btnOption1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOption1.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption1.Location = new System.Drawing.Point(274, 225);
            this.btnOption1.Name = "btnOption1";
            this.btnOption1.Size = new System.Drawing.Size(104, 42);
            this.btnOption1.TabIndex = 0;
            this.btnOption1.Text = "button1";
            this.btnOption1.UseVisualStyleBackColor = true;
            this.btnOption1.Click += new System.EventHandler(this.btnOption1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.timerQuiz_Tick);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.timerQuiz_Tick);
            // 
            // btnOption2
            // 
            this.btnOption2.BackgroundImage = global::Assingment1MCQGame_AnyaScheinman.Properties.Resources._l;
            this.btnOption2.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption2.Location = new System.Drawing.Point(416, 225);
            this.btnOption2.Name = "btnOption2";
            this.btnOption2.Size = new System.Drawing.Size(122, 42);
            this.btnOption2.TabIndex = 1;
            this.btnOption2.Text = "button2";
            this.btnOption2.UseVisualStyleBackColor = true;
            this.btnOption2.Click += new System.EventHandler(this.btnOption2_Click);
            // 
            // btnOption3
            // 
            this.btnOption3.BackgroundImage = global::Assingment1MCQGame_AnyaScheinman.Properties.Resources._l;
            this.btnOption3.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption3.Location = new System.Drawing.Point(274, 296);
            this.btnOption3.Name = "btnOption3";
            this.btnOption3.Size = new System.Drawing.Size(104, 38);
            this.btnOption3.TabIndex = 2;
            this.btnOption3.Text = "button3";
            this.btnOption3.UseVisualStyleBackColor = true;
            this.btnOption3.Click += new System.EventHandler(this.btnOption3_Click);
            // 
            // btnOption4
            // 
            this.btnOption4.BackgroundImage = global::Assingment1MCQGame_AnyaScheinman.Properties.Resources._l;
            this.btnOption4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOption4.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption4.Location = new System.Drawing.Point(416, 296);
            this.btnOption4.Name = "btnOption4";
            this.btnOption4.Size = new System.Drawing.Size(122, 38);
            this.btnOption4.TabIndex = 3;
            this.btnOption4.Text = "button4";
            this.btnOption4.UseVisualStyleBackColor = true;
            this.btnOption4.Click += new System.EventHandler(this.btnOption4_Click);
            // 
            // lblScore
            // 
            this.lblScore.AccessibleDescription = "lblScore";
            this.lblScore.BackColor = System.Drawing.Color.White;
            this.lblScore.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(200, 95);
            this.lblScore.Name = "lblScore";
            this.lblScore.Padding = new System.Windows.Forms.Padding(2);
            this.lblScore.Size = new System.Drawing.Size(420, 37);
            this.lblScore.TabIndex = 9;
            this.lblScore.Text = "0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblScore.Click += new System.EventHandler(this.btnOption1_Click);
            // 
            // lblGoodJob
            // 
            this.lblGoodJob.AutoSize = true;
            this.lblGoodJob.Location = new System.Drawing.Point(357, 174);
            this.lblGoodJob.Name = "lblGoodJob";
            this.lblGoodJob.Size = new System.Drawing.Size(0, 13);
            this.lblGoodJob.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 11;
            // 
            // lblScore1
            // 
            this.lblScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore1.Location = new System.Drawing.Point(441, 392);
            this.lblScore1.Margin = new System.Windows.Forms.Padding(2);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(237, 47);
            this.lblScore1.TabIndex = 12;
            this.lblScore1.Text = "the score";
            this.lblScore1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Microsoft Uighur", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form24
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblScore1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGoodJob);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnOption4);
            this.Controls.Add(this.btnOption3);
            this.Controls.Add(this.btnOption2);
            this.Controls.Add(this.btnOption1);
            this.DoubleBuffered = true;
            this.Name = "Form24";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form24_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOption1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnOption2;
        private System.Windows.Forms.Button btnOption3;
        private System.Windows.Forms.Button btnOption4;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer timerQuiz;
        private System.Windows.Forms.Label lblGoodJob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.Button button1;
    }
}
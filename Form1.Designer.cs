namespace RockPaperScissor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.resultYou = new System.Windows.Forms.Label();
            this.resultComputer = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btHelp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pgBarrYou = new System.Windows.Forms.ProgressBar();
            this.pgBarrComputer = new System.Windows.Forms.ProgressBar();
            this.btNewGame = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btPaper1 = new System.Windows.Forms.PictureBox();
            this.pictureComputer = new System.Windows.Forms.PictureBox();
            this.btScissor = new System.Windows.Forms.PictureBox();
            this.btRock = new System.Windows.Forms.PictureBox();
            this.picturePlayer = new System.Windows.Forms.PictureBox();
            this.pictureBoxBG = new System.Windows.Forms.PictureBox();
            this.labelResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btPaper1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btScissor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBG)).BeginInit();
            this.SuspendLayout();
            // 
            // resultYou
            // 
            this.resultYou.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resultYou.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultYou.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.resultYou.Location = new System.Drawing.Point(151, 15);
            this.resultYou.Name = "resultYou";
            this.resultYou.Size = new System.Drawing.Size(250, 46);
            this.resultYou.TabIndex = 2;
            this.resultYou.Text = "0";
            this.resultYou.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // resultComputer
            // 
            this.resultComputer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resultComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultComputer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.resultComputer.Location = new System.Drawing.Point(509, 15);
            this.resultComputer.Name = "resultComputer";
            this.resultComputer.Size = new System.Drawing.Size(250, 46);
            this.resultComputer.TabIndex = 3;
            this.resultComputer.Text = "0";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(778, 410);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "&Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click_1);
            // 
            // btHelp
            // 
            this.btHelp.Location = new System.Drawing.Point(778, 381);
            this.btHelp.Name = "btHelp";
            this.btHelp.Size = new System.Drawing.Size(75, 23);
            this.btHelp.TabIndex = 12;
            this.btHelp.Text = "&Help";
            this.btHelp.UseVisualStyleBackColor = true;
            this.btHelp.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(397, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "VS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(151, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 46);
            this.label2.TabIndex = 14;
            this.label2.Text = "You";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(563, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 46);
            this.label3.TabIndex = 15;
            this.label3.Text = "Computer";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pgBarrYou
            // 
            this.pgBarrYou.Location = new System.Drawing.Point(153, 0);
            this.pgBarrYou.Name = "pgBarrYou";
            this.pgBarrYou.Size = new System.Drawing.Size(294, 10);
            this.pgBarrYou.TabIndex = 16;
            // 
            // pgBarrComputer
            // 
            this.pgBarrComputer.Location = new System.Drawing.Point(460, 0);
            this.pgBarrComputer.Name = "pgBarrComputer";
            this.pgBarrComputer.Size = new System.Drawing.Size(296, 10);
            this.pgBarrComputer.TabIndex = 17;
            // 
            // btNewGame
            // 
            this.btNewGame.Location = new System.Drawing.Point(778, 352);
            this.btNewGame.Name = "btNewGame";
            this.btNewGame.Size = new System.Drawing.Size(75, 23);
            this.btNewGame.TabIndex = 18;
            this.btNewGame.Text = "&New Game";
            this.btNewGame.UseVisualStyleBackColor = true;
            this.btNewGame.Click += new System.EventHandler(this.btNewGame_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RockPaperScissor.Properties.Resources.animated_arrow;
            this.pictureBox1.Location = new System.Drawing.Point(23, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btPaper1
            // 
            this.btPaper1.BackColor = System.Drawing.Color.Transparent;
            this.btPaper1.Image = global::RockPaperScissor.Properties.Resources.PaperL;
            this.btPaper1.Location = new System.Drawing.Point(0, 381);
            this.btPaper1.Name = "btPaper1";
            this.btPaper1.Size = new System.Drawing.Size(89, 47);
            this.btPaper1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btPaper1.TabIndex = 11;
            this.btPaper1.TabStop = false;
            this.btPaper1.Click += new System.EventHandler(this.btPaper1_Click);
            // 
            // pictureComputer
            // 
            this.pictureComputer.BackColor = System.Drawing.Color.Transparent;
            this.pictureComputer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureComputer.Location = new System.Drawing.Point(463, 286);
            this.pictureComputer.Name = "pictureComputer";
            this.pictureComputer.Size = new System.Drawing.Size(269, 141);
            this.pictureComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureComputer.TabIndex = 10;
            this.pictureComputer.TabStop = false;
            // 
            // btScissor
            // 
            this.btScissor.BackColor = System.Drawing.Color.Transparent;
            this.btScissor.Image = global::RockPaperScissor.Properties.Resources.ScissorL;
            this.btScissor.Location = new System.Drawing.Point(0, 328);
            this.btScissor.Name = "btScissor";
            this.btScissor.Size = new System.Drawing.Size(89, 47);
            this.btScissor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btScissor.TabIndex = 9;
            this.btScissor.TabStop = false;
            this.btScissor.Click += new System.EventHandler(this.btScissor_Click_1);
            // 
            // btRock
            // 
            this.btRock.BackColor = System.Drawing.Color.Transparent;
            this.btRock.Image = global::RockPaperScissor.Properties.Resources.RockL;
            this.btRock.Location = new System.Drawing.Point(0, 275);
            this.btRock.Name = "btRock";
            this.btRock.Size = new System.Drawing.Size(89, 47);
            this.btRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btRock.TabIndex = 7;
            this.btRock.TabStop = false;
            this.btRock.Tag = "";
            this.btRock.Click += new System.EventHandler(this.btRock_Click_1);
            // 
            // picturePlayer
            // 
            this.picturePlayer.BackColor = System.Drawing.Color.Transparent;
            this.picturePlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturePlayer.Location = new System.Drawing.Point(184, 286);
            this.picturePlayer.Name = "picturePlayer";
            this.picturePlayer.Size = new System.Drawing.Size(269, 141);
            this.picturePlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePlayer.TabIndex = 6;
            this.picturePlayer.TabStop = false;
            // 
            // pictureBoxBG
            // 
            this.pictureBoxBG.Image = global::RockPaperScissor.Properties.Resources.background1;
            this.pictureBoxBG.Location = new System.Drawing.Point(0, 16);
            this.pictureBoxBG.Name = "pictureBoxBG";
            this.pictureBoxBG.Size = new System.Drawing.Size(865, 429);
            this.pictureBoxBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBG.TabIndex = 5;
            this.pictureBoxBG.TabStop = false;
            // 
            // labelResult
            // 
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelResult.Location = new System.Drawing.Point(363, 186);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(168, 41);
            this.labelResult.TabIndex = 20;
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(865, 445);
            this.ControlBox = false;
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btNewGame);
            this.Controls.Add(this.pgBarrYou);
            this.Controls.Add(this.pgBarrComputer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btHelp);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btPaper1);
            this.Controls.Add(this.pictureComputer);
            this.Controls.Add(this.resultComputer);
            this.Controls.Add(this.btScissor);
            this.Controls.Add(this.resultYou);
            this.Controls.Add(this.btRock);
            this.Controls.Add(this.picturePlayer);
            this.Controls.Add(this.pictureBoxBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Game - RockPaperScissor - by Alexander Souza - G00317835";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btPaper1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btScissor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picturePlayer;
        private System.Windows.Forms.Label resultYou;
        private System.Windows.Forms.Label resultComputer;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.PictureBox btRock;
        private System.Windows.Forms.PictureBox btScissor;
        private System.Windows.Forms.PictureBox pictureComputer;
        private System.Windows.Forms.PictureBox btPaper1;
        private System.Windows.Forms.Button btHelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pgBarrYou;
        private System.Windows.Forms.ProgressBar pgBarrComputer;
        private System.Windows.Forms.PictureBox pictureBoxBG;
        private System.Windows.Forms.Button btNewGame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelResult;

    }
}


namespace BlackJackApp1
{
    partial class BlackJackApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackJackApplication));
            this.PicCardOne = new System.Windows.Forms.PictureBox();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.LbltotalDisplay = new System.Windows.Forms.Label();
            this.PicCardTwo = new System.Windows.Forms.PictureBox();
            this.LblDisplayPlayer = new System.Windows.Forms.Label();
            this.BtnHit = new System.Windows.Forms.Button();
            this.BtnStay = new System.Windows.Forms.Button();
            this.PicCardThree = new System.Windows.Forms.PictureBox();
            this.PicCardFour = new System.Windows.Forms.PictureBox();
            this.PicCardFive = new System.Windows.Forms.PictureBox();
            this.PicDealerOne = new System.Windows.Forms.PictureBox();
            this.PicDealerTwo = new System.Windows.Forms.PictureBox();
            this.PicDealerThree = new System.Windows.Forms.PictureBox();
            this.PicDealerFour = new System.Windows.Forms.PictureBox();
            this.PicDealerFive = new System.Windows.Forms.PictureBox();
            this.LblDisplayHouse = new System.Windows.Forms.Label();
            this.LblHouseTotalDisplay = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicCardOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCardTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCardThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCardFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCardFive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDealerOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDealerTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDealerThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDealerFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDealerFive)).BeginInit();
            this.SuspendLayout();
            // 
            // PicCardOne
            // 
            this.PicCardOne.Location = new System.Drawing.Point(12, 61);
            this.PicCardOne.Name = "PicCardOne";
            this.PicCardOne.Size = new System.Drawing.Size(120, 146);
            this.PicCardOne.TabIndex = 0;
            this.PicCardOne.TabStop = false;
            // 
            // BtnPlay
            // 
            this.BtnPlay.BackColor = System.Drawing.Color.Lime;
            this.BtnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlay.Location = new System.Drawing.Point(138, 414);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(121, 36);
            this.BtnPlay.TabIndex = 1;
            this.BtnPlay.Text = "Play!";
            this.BtnPlay.UseVisualStyleBackColor = false;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "red back of cards.png");
            this.imageList1.Images.SetKeyName(1, "2c.png");
            this.imageList1.Images.SetKeyName(2, "2d.png");
            this.imageList1.Images.SetKeyName(3, "2h.png");
            this.imageList1.Images.SetKeyName(4, "2s.png");
            this.imageList1.Images.SetKeyName(5, "3c.png");
            this.imageList1.Images.SetKeyName(6, "3d.png");
            this.imageList1.Images.SetKeyName(7, "3h.png");
            this.imageList1.Images.SetKeyName(8, "3s.png");
            this.imageList1.Images.SetKeyName(9, "4c.png");
            this.imageList1.Images.SetKeyName(10, "4d.png");
            this.imageList1.Images.SetKeyName(11, "4h.png");
            this.imageList1.Images.SetKeyName(12, "4s.png");
            this.imageList1.Images.SetKeyName(13, "5c.png");
            this.imageList1.Images.SetKeyName(14, "5d.png");
            this.imageList1.Images.SetKeyName(15, "5h.png");
            this.imageList1.Images.SetKeyName(16, "5s.png");
            this.imageList1.Images.SetKeyName(17, "6c.png");
            this.imageList1.Images.SetKeyName(18, "6d.png");
            this.imageList1.Images.SetKeyName(19, "6h.png");
            this.imageList1.Images.SetKeyName(20, "6s.png");
            this.imageList1.Images.SetKeyName(21, "7c.png");
            this.imageList1.Images.SetKeyName(22, "7d.png");
            this.imageList1.Images.SetKeyName(23, "7h.png");
            this.imageList1.Images.SetKeyName(24, "7s.png");
            this.imageList1.Images.SetKeyName(25, "8c.png");
            this.imageList1.Images.SetKeyName(26, "8d.png");
            this.imageList1.Images.SetKeyName(27, "8h.png");
            this.imageList1.Images.SetKeyName(28, "8s.png");
            this.imageList1.Images.SetKeyName(29, "9c.png");
            this.imageList1.Images.SetKeyName(30, "9d.png");
            this.imageList1.Images.SetKeyName(31, "9h.png");
            this.imageList1.Images.SetKeyName(32, "9s.png");
            this.imageList1.Images.SetKeyName(33, "10c.png");
            this.imageList1.Images.SetKeyName(34, "10d.png");
            this.imageList1.Images.SetKeyName(35, "10h.png");
            this.imageList1.Images.SetKeyName(36, "10s.png");
            this.imageList1.Images.SetKeyName(37, "ac.png");
            this.imageList1.Images.SetKeyName(38, "ad.png");
            this.imageList1.Images.SetKeyName(39, "ah.png");
            this.imageList1.Images.SetKeyName(40, "as.png");
            this.imageList1.Images.SetKeyName(41, "jc.png");
            this.imageList1.Images.SetKeyName(42, "jd.png");
            this.imageList1.Images.SetKeyName(43, "jh.png");
            this.imageList1.Images.SetKeyName(44, "js.png");
            this.imageList1.Images.SetKeyName(45, "kc.png");
            this.imageList1.Images.SetKeyName(46, "kd.png");
            this.imageList1.Images.SetKeyName(47, "kh.png");
            this.imageList1.Images.SetKeyName(48, "ks.png");
            this.imageList1.Images.SetKeyName(49, "qc.png");
            this.imageList1.Images.SetKeyName(50, "qd.png");
            this.imageList1.Images.SetKeyName(51, "qh.png");
            this.imageList1.Images.SetKeyName(52, "qs.png");
            this.imageList1.Images.SetKeyName(53, "blue back of cards.png");
            // 
            // LbltotalDisplay
            // 
            this.LbltotalDisplay.BackColor = System.Drawing.Color.White;
            this.LbltotalDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbltotalDisplay.Location = new System.Drawing.Point(137, 24);
            this.LbltotalDisplay.Name = "LbltotalDisplay";
            this.LbltotalDisplay.Size = new System.Drawing.Size(246, 23);
            this.LbltotalDisplay.TabIndex = 2;
            this.LbltotalDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PicCardTwo
            // 
            this.PicCardTwo.Location = new System.Drawing.Point(138, 61);
            this.PicCardTwo.Name = "PicCardTwo";
            this.PicCardTwo.Size = new System.Drawing.Size(120, 146);
            this.PicCardTwo.TabIndex = 3;
            this.PicCardTwo.TabStop = false;
            // 
            // LblDisplayPlayer
            // 
            this.LblDisplayPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDisplayPlayer.ForeColor = System.Drawing.Color.White;
            this.LblDisplayPlayer.Location = new System.Drawing.Point(12, 9);
            this.LblDisplayPlayer.Name = "LblDisplayPlayer";
            this.LblDisplayPlayer.Size = new System.Drawing.Size(119, 45);
            this.LblDisplayPlayer.TabIndex = 4;
            this.LblDisplayPlayer.Text = "Player";
            this.LblDisplayPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnHit
            // 
            this.BtnHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHit.Location = new System.Drawing.Point(263, 414);
            this.BtnHit.Name = "BtnHit";
            this.BtnHit.Size = new System.Drawing.Size(120, 36);
            this.BtnHit.TabIndex = 5;
            this.BtnHit.Text = "HIT";
            this.BtnHit.UseVisualStyleBackColor = true;
            this.BtnHit.Click += new System.EventHandler(this.BtnHit_Click);
            // 
            // BtnStay
            // 
            this.BtnStay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStay.Location = new System.Drawing.Point(390, 414);
            this.BtnStay.Name = "BtnStay";
            this.BtnStay.Size = new System.Drawing.Size(120, 36);
            this.BtnStay.TabIndex = 6;
            this.BtnStay.Text = "Stay";
            this.BtnStay.UseVisualStyleBackColor = true;
            this.BtnStay.Click += new System.EventHandler(this.BtnStay_Click);
            // 
            // PicCardThree
            // 
            this.PicCardThree.Location = new System.Drawing.Point(264, 61);
            this.PicCardThree.Name = "PicCardThree";
            this.PicCardThree.Size = new System.Drawing.Size(120, 146);
            this.PicCardThree.TabIndex = 7;
            this.PicCardThree.TabStop = false;
            // 
            // PicCardFour
            // 
            this.PicCardFour.Location = new System.Drawing.Point(390, 61);
            this.PicCardFour.Name = "PicCardFour";
            this.PicCardFour.Size = new System.Drawing.Size(120, 146);
            this.PicCardFour.TabIndex = 8;
            this.PicCardFour.TabStop = false;
            // 
            // PicCardFive
            // 
            this.PicCardFive.Location = new System.Drawing.Point(516, 61);
            this.PicCardFive.Name = "PicCardFive";
            this.PicCardFive.Size = new System.Drawing.Size(120, 146);
            this.PicCardFive.TabIndex = 9;
            this.PicCardFive.TabStop = false;
            // 
            // PicDealerOne
            // 
            this.PicDealerOne.Location = new System.Drawing.Point(12, 262);
            this.PicDealerOne.Name = "PicDealerOne";
            this.PicDealerOne.Size = new System.Drawing.Size(120, 146);
            this.PicDealerOne.TabIndex = 10;
            this.PicDealerOne.TabStop = false;
            // 
            // PicDealerTwo
            // 
            this.PicDealerTwo.Location = new System.Drawing.Point(138, 262);
            this.PicDealerTwo.Name = "PicDealerTwo";
            this.PicDealerTwo.Size = new System.Drawing.Size(120, 146);
            this.PicDealerTwo.TabIndex = 11;
            this.PicDealerTwo.TabStop = false;
            // 
            // PicDealerThree
            // 
            this.PicDealerThree.Location = new System.Drawing.Point(263, 262);
            this.PicDealerThree.Name = "PicDealerThree";
            this.PicDealerThree.Size = new System.Drawing.Size(120, 146);
            this.PicDealerThree.TabIndex = 12;
            this.PicDealerThree.TabStop = false;
            // 
            // PicDealerFour
            // 
            this.PicDealerFour.Location = new System.Drawing.Point(390, 262);
            this.PicDealerFour.Name = "PicDealerFour";
            this.PicDealerFour.Size = new System.Drawing.Size(120, 146);
            this.PicDealerFour.TabIndex = 13;
            this.PicDealerFour.TabStop = false;
            // 
            // PicDealerFive
            // 
            this.PicDealerFive.Location = new System.Drawing.Point(516, 262);
            this.PicDealerFive.Name = "PicDealerFive";
            this.PicDealerFive.Size = new System.Drawing.Size(120, 146);
            this.PicDealerFive.TabIndex = 14;
            this.PicDealerFive.TabStop = false;
            // 
            // LblDisplayHouse
            // 
            this.LblDisplayHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDisplayHouse.ForeColor = System.Drawing.Color.White;
            this.LblDisplayHouse.Location = new System.Drawing.Point(12, 210);
            this.LblDisplayHouse.Name = "LblDisplayHouse";
            this.LblDisplayHouse.Size = new System.Drawing.Size(119, 45);
            this.LblDisplayHouse.TabIndex = 15;
            this.LblDisplayHouse.Text = "House";
            this.LblDisplayHouse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblHouseTotalDisplay
            // 
            this.LblHouseTotalDisplay.BackColor = System.Drawing.Color.White;
            this.LblHouseTotalDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHouseTotalDisplay.Location = new System.Drawing.Point(134, 225);
            this.LblHouseTotalDisplay.Name = "LblHouseTotalDisplay";
            this.LblHouseTotalDisplay.Size = new System.Drawing.Size(246, 23);
            this.LblHouseTotalDisplay.TabIndex = 16;
            this.LblHouseTotalDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Red;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(515, 414);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(121, 36);
            this.BtnExit.TabIndex = 17;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnHelp
            // 
            this.BtnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHelp.Location = new System.Drawing.Point(11, 414);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(121, 36);
            this.BtnHelp.TabIndex = 18;
            this.BtnHelp.Text = "Help";
            this.BtnHelp.UseVisualStyleBackColor = false;
            this.BtnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // BlackJackApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(650, 464);
            this.Controls.Add(this.BtnHelp);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LblHouseTotalDisplay);
            this.Controls.Add(this.LblDisplayHouse);
            this.Controls.Add(this.PicDealerFive);
            this.Controls.Add(this.PicDealerFour);
            this.Controls.Add(this.PicDealerThree);
            this.Controls.Add(this.PicDealerTwo);
            this.Controls.Add(this.PicDealerOne);
            this.Controls.Add(this.PicCardFive);
            this.Controls.Add(this.PicCardFour);
            this.Controls.Add(this.PicCardThree);
            this.Controls.Add(this.BtnStay);
            this.Controls.Add(this.BtnHit);
            this.Controls.Add(this.LblDisplayPlayer);
            this.Controls.Add(this.PicCardTwo);
            this.Controls.Add(this.LbltotalDisplay);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.PicCardOne);
            this.Name = "BlackJackApplication";
            this.Text = "BlackJackApplication";
            ((System.ComponentModel.ISupportInitialize)(this.PicCardOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCardTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCardThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCardFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCardFive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDealerOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDealerTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDealerThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDealerFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDealerFive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicCardOne;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label LbltotalDisplay;
        private System.Windows.Forms.PictureBox PicCardTwo;
        private System.Windows.Forms.Label LblDisplayPlayer;
        private System.Windows.Forms.Button BtnHit;
        private System.Windows.Forms.Button BtnStay;
        private System.Windows.Forms.PictureBox PicCardThree;
        private System.Windows.Forms.PictureBox PicCardFour;
        private System.Windows.Forms.PictureBox PicCardFive;
        private System.Windows.Forms.PictureBox PicDealerOne;
        private System.Windows.Forms.PictureBox PicDealerTwo;
        private System.Windows.Forms.PictureBox PicDealerThree;
        private System.Windows.Forms.PictureBox PicDealerFour;
        private System.Windows.Forms.PictureBox PicDealerFive;
        private System.Windows.Forms.Label LblDisplayHouse;
        private System.Windows.Forms.Label LblHouseTotalDisplay;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnHelp;
    }
}
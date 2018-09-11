namespace BlackJackApp1
{
    partial class FrmLogin
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
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblSurName = new System.Windows.Forms.Label();
            this.LblAge = new System.Windows.Forms.Label();
            this.LblPleaseCompleteDetails = new System.Windows.Forms.Label();
            this.BtnGo = new System.Windows.Forms.Button();
            this.LblGo = new System.Windows.Forms.Label();
            this.RadMale = new System.Windows.Forms.RadioButton();
            this.RadFemale = new System.Windows.Forms.RadioButton();
            this.RadAccept = new System.Windows.Forms.RadioButton();
            this.RadReject = new System.Windows.Forms.RadioButton();
            this.GrpGender = new System.Windows.Forms.GroupBox();
            this.GrpAcceptReject = new System.Windows.Forms.GroupBox();
            this.BtnLoginExit = new System.Windows.Forms.Button();
            this.GrpGender.SuspendLayout();
            this.GrpAcceptReject.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(138, 69);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(115, 20);
            this.TxtFirstName.TabIndex = 0;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(138, 95);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(115, 20);
            this.TxtSurname.TabIndex = 1;
            // 
            // TxtAge
            // 
            this.TxtAge.Location = new System.Drawing.Point(138, 121);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(115, 20);
            this.TxtAge.TabIndex = 2;
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFirstName.Location = new System.Drawing.Point(12, 74);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(75, 15);
            this.LblFirstName.TabIndex = 5;
            this.LblFirstName.Text = "First name";
            // 
            // LblSurName
            // 
            this.LblSurName.AutoSize = true;
            this.LblSurName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSurName.Location = new System.Drawing.Point(13, 101);
            this.LblSurName.Name = "LblSurName";
            this.LblSurName.Size = new System.Drawing.Size(65, 15);
            this.LblSurName.TabIndex = 6;
            this.LblSurName.Text = "Surname";
            // 
            // LblAge
            // 
            this.LblAge.AutoSize = true;
            this.LblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAge.Location = new System.Drawing.Point(12, 128);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(31, 15);
            this.LblAge.TabIndex = 7;
            this.LblAge.Text = "Age";
            // 
            // LblPleaseCompleteDetails
            // 
            this.LblPleaseCompleteDetails.AutoSize = true;
            this.LblPleaseCompleteDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPleaseCompleteDetails.Location = new System.Drawing.Point(50, 23);
            this.LblPleaseCompleteDetails.Name = "LblPleaseCompleteDetails";
            this.LblPleaseCompleteDetails.Size = new System.Drawing.Size(166, 15);
            this.LblPleaseCompleteDetails.TabIndex = 12;
            this.LblPleaseCompleteDetails.Text = "Please enter your details";
            // 
            // BtnGo
            // 
            this.BtnGo.BackColor = System.Drawing.Color.Green;
            this.BtnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGo.ForeColor = System.Drawing.Color.White;
            this.BtnGo.Location = new System.Drawing.Point(12, 341);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(115, 31);
            this.BtnGo.TabIndex = 13;
            this.BtnGo.Text = "GO!";
            this.BtnGo.UseVisualStyleBackColor = false;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // LblGo
            // 
            this.LblGo.AutoSize = true;
            this.LblGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGo.Location = new System.Drawing.Point(10, 323);
            this.LblGo.Name = "LblGo";
            this.LblGo.Size = new System.Drawing.Size(237, 15);
            this.LblGo.TabIndex = 14;
            this.LblGo.Text = "Click go to launch the blackjack app";
            // 
            // RadMale
            // 
            this.RadMale.AutoSize = true;
            this.RadMale.Location = new System.Drawing.Point(8, 20);
            this.RadMale.Name = "RadMale";
            this.RadMale.Size = new System.Drawing.Size(57, 19);
            this.RadMale.TabIndex = 16;
            this.RadMale.TabStop = true;
            this.RadMale.Text = "Male";
            this.RadMale.UseVisualStyleBackColor = true;
            // 
            // RadFemale
            // 
            this.RadFemale.AutoSize = true;
            this.RadFemale.Location = new System.Drawing.Point(147, 20);
            this.RadFemale.Name = "RadFemale";
            this.RadFemale.Size = new System.Drawing.Size(73, 19);
            this.RadFemale.TabIndex = 17;
            this.RadFemale.TabStop = true;
            this.RadFemale.Text = "Female";
            this.RadFemale.UseVisualStyleBackColor = true;
            // 
            // RadAccept
            // 
            this.RadAccept.AutoSize = true;
            this.RadAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadAccept.ForeColor = System.Drawing.Color.Green;
            this.RadAccept.Location = new System.Drawing.Point(6, 20);
            this.RadAccept.Name = "RadAccept";
            this.RadAccept.Size = new System.Drawing.Size(77, 22);
            this.RadAccept.TabIndex = 18;
            this.RadAccept.TabStop = true;
            this.RadAccept.Text = "Accept";
            this.RadAccept.UseVisualStyleBackColor = true;
            // 
            // RadReject
            // 
            this.RadReject.AutoSize = true;
            this.RadReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadReject.ForeColor = System.Drawing.Color.Red;
            this.RadReject.Location = new System.Drawing.Point(145, 20);
            this.RadReject.Name = "RadReject";
            this.RadReject.Size = new System.Drawing.Size(74, 22);
            this.RadReject.TabIndex = 19;
            this.RadReject.TabStop = true;
            this.RadReject.Text = "Reject";
            this.RadReject.UseVisualStyleBackColor = true;
            // 
            // GrpGender
            // 
            this.GrpGender.Controls.Add(this.RadMale);
            this.GrpGender.Controls.Add(this.RadFemale);
            this.GrpGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpGender.Location = new System.Drawing.Point(14, 158);
            this.GrpGender.Name = "GrpGender";
            this.GrpGender.Size = new System.Drawing.Size(239, 51);
            this.GrpGender.TabIndex = 20;
            this.GrpGender.TabStop = false;
            this.GrpGender.Text = "Gender";
            // 
            // GrpAcceptReject
            // 
            this.GrpAcceptReject.Controls.Add(this.RadAccept);
            this.GrpAcceptReject.Controls.Add(this.RadReject);
            this.GrpAcceptReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpAcceptReject.Location = new System.Drawing.Point(16, 237);
            this.GrpAcceptReject.Name = "GrpAcceptReject";
            this.GrpAcceptReject.Size = new System.Drawing.Size(237, 49);
            this.GrpAcceptReject.TabIndex = 21;
            this.GrpAcceptReject.TabStop = false;
            this.GrpAcceptReject.Text = "Terms and conditions";
            // 
            // BtnLoginExit
            // 
            this.BtnLoginExit.BackColor = System.Drawing.Color.Red;
            this.BtnLoginExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoginExit.ForeColor = System.Drawing.Color.White;
            this.BtnLoginExit.Location = new System.Drawing.Point(133, 341);
            this.BtnLoginExit.Name = "BtnLoginExit";
            this.BtnLoginExit.Size = new System.Drawing.Size(114, 31);
            this.BtnLoginExit.TabIndex = 22;
            this.BtnLoginExit.Text = "Exit";
            this.BtnLoginExit.UseVisualStyleBackColor = false;
            this.BtnLoginExit.Click += new System.EventHandler(this.BtnLoginExit_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(265, 384);
            this.Controls.Add(this.BtnLoginExit);
            this.Controls.Add(this.GrpAcceptReject);
            this.Controls.Add(this.GrpGender);
            this.Controls.Add(this.LblGo);
            this.Controls.Add(this.BtnGo);
            this.Controls.Add(this.LblPleaseCompleteDetails);
            this.Controls.Add(this.LblAge);
            this.Controls.Add(this.LblSurName);
            this.Controls.Add(this.LblFirstName);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.TxtFirstName);
            this.Name = "FrmLogin";
            this.Text = "LOGIN";
            this.GrpGender.ResumeLayout(false);
            this.GrpGender.PerformLayout();
            this.GrpAcceptReject.ResumeLayout(false);
            this.GrpAcceptReject.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.Label LblSurName;
        private System.Windows.Forms.Label LblAge;
        private System.Windows.Forms.Label LblPleaseCompleteDetails;
        private System.Windows.Forms.Button BtnGo;
        private System.Windows.Forms.Label LblGo;
        private System.Windows.Forms.RadioButton RadMale;
        private System.Windows.Forms.RadioButton RadFemale;
        private System.Windows.Forms.RadioButton RadAccept;
        private System.Windows.Forms.RadioButton RadReject;
        private System.Windows.Forms.GroupBox GrpGender;
        private System.Windows.Forms.GroupBox GrpAcceptReject;
        private System.Windows.Forms.Button BtnLoginExit;
    }
}


namespace CS_2017_020
{
    partial class Hang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblL4 = new System.Windows.Forms.Label();
            this.lblL3 = new System.Windows.Forms.Label();
            this.lblL2 = new System.Windows.Forms.Label();
            this.lblL1 = new System.Windows.Forms.Label();
            this.lblAttempts = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtGuessLetter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guess the word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter your guessed letter";
            // 
            // lblL4
            // 
            this.lblL4.AutoSize = true;
            this.lblL4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblL4.Location = new System.Drawing.Point(241, 98);
            this.lblL4.Name = "lblL4";
            this.lblL4.Size = new System.Drawing.Size(23, 20);
            this.lblL4.TabIndex = 2;
            this.lblL4.Text = "#";
            // 
            // lblL3
            // 
            this.lblL3.AutoSize = true;
            this.lblL3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblL3.Location = new System.Drawing.Point(176, 98);
            this.lblL3.Name = "lblL3";
            this.lblL3.Size = new System.Drawing.Size(23, 20);
            this.lblL3.TabIndex = 3;
            this.lblL3.Text = "#";
            // 
            // lblL2
            // 
            this.lblL2.AutoSize = true;
            this.lblL2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblL2.Location = new System.Drawing.Point(112, 98);
            this.lblL2.Name = "lblL2";
            this.lblL2.Size = new System.Drawing.Size(23, 20);
            this.lblL2.TabIndex = 4;
            this.lblL2.Text = "#";
            // 
            // lblL1
            // 
            this.lblL1.AutoSize = true;
            this.lblL1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblL1.Location = new System.Drawing.Point(51, 98);
            this.lblL1.Name = "lblL1";
            this.lblL1.Size = new System.Drawing.Size(23, 20);
            this.lblL1.TabIndex = 5;
            this.lblL1.Text = "#";
            // 
            // lblAttempts
            // 
            this.lblAttempts.AutoSize = true;
            this.lblAttempts.ForeColor = System.Drawing.Color.Red;
            this.lblAttempts.Location = new System.Drawing.Point(276, 41);
            this.lblAttempts.Name = "lblAttempts";
            this.lblAttempts.Size = new System.Drawing.Size(0, 13);
            this.lblAttempts.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(176, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Attempts : ";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(104, 228);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 36);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtGuessLetter
            // 
            this.txtGuessLetter.Location = new System.Drawing.Point(207, 171);
            this.txtGuessLetter.Name = "txtGuessLetter";
            this.txtGuessLetter.Size = new System.Drawing.Size(47, 20);
            this.txtGuessLetter.TabIndex = 9;
            this.txtGuessLetter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGuessLetter_KeyDown);
            // 
            // Hang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(310, 276);
            this.Controls.Add(this.txtGuessLetter);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblAttempts);
            this.Controls.Add(this.lblL1);
            this.Controls.Add(this.lblL2);
            this.Controls.Add(this.lblL3);
            this.Controls.Add(this.lblL4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Hang";
            this.Text = "Hang Man";
            this.Load += new System.EventHandler(this.Hang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblL4;
        private System.Windows.Forms.Label lblL3;
        private System.Windows.Forms.Label lblL2;
        private System.Windows.Forms.Label lblL1;
        private System.Windows.Forms.Label lblAttempts;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtGuessLetter;
    }
}


namespace NumberGuessingGame
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
            this.btnstart = new System.Windows.Forms.Button();
            this.btnguessnumber = new System.Windows.Forms.Button();
            this.txtguessnumber = new System.Windows.Forms.TextBox();
            this.lblguessnumber = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnstart
            // 
            this.btnstart.ForeColor = System.Drawing.Color.Blue;
            this.btnstart.Location = new System.Drawing.Point(260, 66);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(212, 83);
            this.btnstart.TabIndex = 0;
            this.btnstart.Text = "START";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnguessnumber
            // 
            this.btnguessnumber.ForeColor = System.Drawing.Color.Red;
            this.btnguessnumber.Location = new System.Drawing.Point(260, 155);
            this.btnguessnumber.Name = "btnguessnumber";
            this.btnguessnumber.Size = new System.Drawing.Size(212, 83);
            this.btnguessnumber.TabIndex = 1;
            this.btnguessnumber.Text = "Guess the Number";
            this.btnguessnumber.UseVisualStyleBackColor = true;
            this.btnguessnumber.Click += new System.EventHandler(this.btnguessnumber_Click);
            // 
            // txtguessnumber
            // 
            this.txtguessnumber.Location = new System.Drawing.Point(260, 34);
            this.txtguessnumber.Name = "txtguessnumber";
            this.txtguessnumber.Size = new System.Drawing.Size(212, 26);
            this.txtguessnumber.TabIndex = 2;
            // 
            // lblguessnumber
            // 
            this.lblguessnumber.AutoSize = true;
            this.lblguessnumber.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblguessnumber.Location = new System.Drawing.Point(256, 11);
            this.lblguessnumber.Name = "lblguessnumber";
            this.lblguessnumber.Size = new System.Drawing.Size(141, 20);
            this.lblguessnumber.TabIndex = 3;
            this.lblguessnumber.Text = "Guess the number";
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblscore.Location = new System.Drawing.Point(256, 261);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(66, 20);
            this.lblscore.TabIndex = 4;
            this.lblscore.Text = "SCORE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.lblguessnumber);
            this.Controls.Add(this.txtguessnumber);
            this.Controls.Add(this.btnguessnumber);
            this.Controls.Add(this.btnstart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnguessnumber;
        private System.Windows.Forms.TextBox txtguessnumber;
        private System.Windows.Forms.Label lblguessnumber;
        private System.Windows.Forms.Label lblscore;
    }
}


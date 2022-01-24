namespace MathFunctions
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
            this.btnSQRT = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.btnTruncate = new System.Windows.Forms.Button();
            this.btnRound = new System.Windows.Forms.Button();
            this.btnCeiling = new System.Windows.Forms.Button();
            this.btnFloor = new System.Windows.Forms.Button();
            this.btnABS = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.txtVeri = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSQRT
            // 
            this.btnSQRT.Location = new System.Drawing.Point(421, 233);
            this.btnSQRT.Name = "btnSQRT";
            this.btnSQRT.Size = new System.Drawing.Size(169, 52);
            this.btnSQRT.TabIndex = 0;
            this.btnSQRT.Text = "sqrt";
            this.btnSQRT.UseVisualStyleBackColor = true;
            this.btnSQRT.Click += new System.EventHandler(this.btnSQRT_Click);
            // 
            // btnPow
            // 
            this.btnPow.Location = new System.Drawing.Point(421, 172);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(169, 55);
            this.btnPow.TabIndex = 1;
            this.btnPow.Text = "pow";
            this.btnPow.UseVisualStyleBackColor = true;
            this.btnPow.Click += new System.EventHandler(this.btnPow_Click);
            // 
            // btnTruncate
            // 
            this.btnTruncate.Location = new System.Drawing.Point(421, 114);
            this.btnTruncate.Name = "btnTruncate";
            this.btnTruncate.Size = new System.Drawing.Size(169, 52);
            this.btnTruncate.TabIndex = 2;
            this.btnTruncate.Text = "truncate";
            this.btnTruncate.UseVisualStyleBackColor = true;
            this.btnTruncate.Click += new System.EventHandler(this.btnTruncate_Click);
            // 
            // btnRound
            // 
            this.btnRound.Location = new System.Drawing.Point(421, 56);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(169, 52);
            this.btnRound.TabIndex = 3;
            this.btnRound.Text = "round";
            this.btnRound.UseVisualStyleBackColor = true;
            this.btnRound.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // btnCeiling
            // 
            this.btnCeiling.Location = new System.Drawing.Point(246, 233);
            this.btnCeiling.Name = "btnCeiling";
            this.btnCeiling.Size = new System.Drawing.Size(169, 52);
            this.btnCeiling.TabIndex = 4;
            this.btnCeiling.Text = "ceiling";
            this.btnCeiling.UseVisualStyleBackColor = true;
            this.btnCeiling.Click += new System.EventHandler(this.btnCeiling_Click);
            // 
            // btnFloor
            // 
            this.btnFloor.Location = new System.Drawing.Point(246, 172);
            this.btnFloor.Name = "btnFloor";
            this.btnFloor.Size = new System.Drawing.Size(169, 55);
            this.btnFloor.TabIndex = 5;
            this.btnFloor.Text = "floor";
            this.btnFloor.UseVisualStyleBackColor = true;
            this.btnFloor.Click += new System.EventHandler(this.btnFloor_Click);
            // 
            // btnABS
            // 
            this.btnABS.Location = new System.Drawing.Point(246, 114);
            this.btnABS.Name = "btnABS";
            this.btnABS.Size = new System.Drawing.Size(169, 52);
            this.btnABS.TabIndex = 6;
            this.btnABS.Text = "ABS";
            this.btnABS.UseVisualStyleBackColor = true;
            this.btnABS.Click += new System.EventHandler(this.btnABS_Click);
            // 
            // btnPi
            // 
            this.btnPi.Location = new System.Drawing.Point(246, 56);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(169, 52);
            this.btnPi.TabIndex = 7;
            this.btnPi.Text = "Pi";
            this.btnPi.UseVisualStyleBackColor = true;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // txtVeri
            // 
            this.txtVeri.Location = new System.Drawing.Point(210, 24);
            this.txtVeri.Name = "txtVeri";
            this.txtVeri.Size = new System.Drawing.Size(416, 26);
            this.txtVeri.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 393);
            this.Controls.Add(this.txtVeri);
            this.Controls.Add(this.btnPi);
            this.Controls.Add(this.btnABS);
            this.Controls.Add(this.btnFloor);
            this.Controls.Add(this.btnCeiling);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.btnTruncate);
            this.Controls.Add(this.btnPow);
            this.Controls.Add(this.btnSQRT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSQRT;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button btnTruncate;
        private System.Windows.Forms.Button btnRound;
        private System.Windows.Forms.Button btnCeiling;
        private System.Windows.Forms.Button btnFloor;
        private System.Windows.Forms.Button btnABS;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.TextBox txtVeri;
    }
}


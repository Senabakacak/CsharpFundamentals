namespace If_Else
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtvisaexam = new System.Windows.Forms.TextBox();
            this.txtfinalexam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.btnExamCalculate = new System.Windows.Forms.Button();
            this.lblstatus = new System.Windows.Forms.Label();
            this.txtheight = new System.Windows.Forms.TextBox();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblindex = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBMIcalculate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblstatus);
            this.groupBox2.Controls.Add(this.btnExamCalculate);
            this.groupBox2.Controls.Add(this.lblAvg);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtfinalexam);
            this.groupBox2.Controls.Add(this.txtvisaexam);
            this.groupBox2.Location = new System.Drawing.Point(321, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 250);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exam Grade Calculate";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtheight);
            this.groupBox3.Controls.Add(this.txtweight);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lblindex);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btnBMIcalculate);
            this.groupBox3.Location = new System.Drawing.Point(23, 268);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 313);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Body Mass Index";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(92, 65);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(150, 26);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(92, 121);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(150, 26);
            this.txtPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(116, 185);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(126, 59);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtvisaexam
            // 
            this.txtvisaexam.Location = new System.Drawing.Point(112, 59);
            this.txtvisaexam.Name = "txtvisaexam";
            this.txtvisaexam.Size = new System.Drawing.Size(136, 26);
            this.txtvisaexam.TabIndex = 0;
            // 
            // txtfinalexam
            // 
            this.txtfinalexam.Location = new System.Drawing.Point(112, 99);
            this.txtfinalexam.Name = "txtfinalexam";
            this.txtfinalexam.Size = new System.Drawing.Size(136, 26);
            this.txtfinalexam.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "visa exam:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "final exam:";
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Location = new System.Drawing.Point(27, 204);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(72, 20);
            this.lblAvg.TabIndex = 4;
            this.lblAvg.Text = "Average:";
            // 
            // btnExamCalculate
            // 
            this.btnExamCalculate.Location = new System.Drawing.Point(112, 154);
            this.btnExamCalculate.Name = "btnExamCalculate";
            this.btnExamCalculate.Size = new System.Drawing.Size(136, 34);
            this.btnExamCalculate.TabIndex = 6;
            this.btnExamCalculate.Text = "Calculate";
            this.btnExamCalculate.UseVisualStyleBackColor = true;
            this.btnExamCalculate.Click += new System.EventHandler(this.btnExamCalculate_Click);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(120, 204);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(0, 20);
            this.lblstatus.TabIndex = 7;
            // 
            // txtheight
            // 
            this.txtheight.Location = new System.Drawing.Point(92, 76);
            this.txtheight.Name = "txtheight";
            this.txtheight.Size = new System.Drawing.Size(136, 26);
            this.txtheight.TabIndex = 1;
            // 
            // txtweight
            // 
            this.txtweight.Location = new System.Drawing.Point(92, 121);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(136, 26);
            this.txtweight.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Height:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Weight:";
            // 
            // lblindex
            // 
            this.lblindex.AutoSize = true;
            this.lblindex.Location = new System.Drawing.Point(34, 238);
            this.lblindex.Name = "lblindex";
            this.lblindex.Size = new System.Drawing.Size(42, 20);
            this.lblindex.TabIndex = 5;
            this.lblindex.Text = "BMI:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(112, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Status:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(112, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 8;
            // 
            // btnBMIcalculate
            // 
            this.btnBMIcalculate.Location = new System.Drawing.Point(92, 162);
            this.btnBMIcalculate.Name = "btnBMIcalculate";
            this.btnBMIcalculate.Size = new System.Drawing.Size(136, 41);
            this.btnBMIcalculate.TabIndex = 9;
            this.btnBMIcalculate.Text = "calculate";
            this.btnBMIcalculate.UseVisualStyleBackColor = true;
            this.btnBMIcalculate.Click += new System.EventHandler(this.btnBMIcalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 615);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExamCalculate;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfinalexam;
        private System.Windows.Forms.TextBox txtvisaexam;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.TextBox txtheight;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblindex;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBMIcalculate;
    }
}


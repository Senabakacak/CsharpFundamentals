namespace Switch_case
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
            this.txtusername = new System.Windows.Forms.TextBox();
            this.btnUserlogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncevir = new System.Windows.Forms.Button();
            this.txtgunler = new System.Windows.Forms.TextBox();
            this.btn_days = new System.Windows.Forms.Button();
            this.txtdays = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtusername);
            this.groupBox1.Controls.Add(this.btnUserlogin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Login";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtdays);
            this.groupBox2.Controls.Add(this.btn_days);
            this.groupBox2.Location = new System.Drawing.Point(542, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 251);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Days";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtgunler);
            this.groupBox3.Controls.Add(this.btncevir);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(277, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 251);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "çeviri";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(89, 70);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(137, 26);
            this.txtusername.TabIndex = 1;
            // 
            // btnUserlogin
            // 
            this.btnUserlogin.Location = new System.Drawing.Point(89, 122);
            this.btnUserlogin.Name = "btnUserlogin";
            this.btnUserlogin.Size = new System.Drawing.Size(137, 42);
            this.btnUserlogin.TabIndex = 2;
            this.btnUserlogin.Text = "User Login";
            this.btnUserlogin.UseVisualStyleBackColor = true;
            this.btnUserlogin.Click += new System.EventHandler(this.btnUserlogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "günler";
            // 
            // btncevir
            // 
            this.btncevir.Location = new System.Drawing.Point(103, 122);
            this.btncevir.Name = "btncevir";
            this.btncevir.Size = new System.Drawing.Size(137, 42);
            this.btncevir.TabIndex = 1;
            this.btncevir.Text = "çevir";
            this.btncevir.UseVisualStyleBackColor = true;
            this.btncevir.Click += new System.EventHandler(this.btncevir_Click);
            // 
            // txtgunler
            // 
            this.txtgunler.Location = new System.Drawing.Point(103, 70);
            this.txtgunler.Name = "txtgunler";
            this.txtgunler.Size = new System.Drawing.Size(137, 26);
            this.txtgunler.TabIndex = 2;
            // 
            // btn_days
            // 
            this.btn_days.Location = new System.Drawing.Point(103, 122);
            this.btn_days.Name = "btn_days";
            this.btn_days.Size = new System.Drawing.Size(137, 42);
            this.btn_days.TabIndex = 2;
            this.btn_days.Text = "show";
            this.btn_days.UseVisualStyleBackColor = true;
            this.btn_days.Click += new System.EventHandler(this.btn_days_Click);
            // 
            // txtdays
            // 
            this.txtdays.Location = new System.Drawing.Point(103, 73);
            this.txtdays.Name = "txtdays";
            this.txtdays.Size = new System.Drawing.Size(137, 26);
            this.txtdays.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "days";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 320);
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
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Button btnUserlogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdays;
        private System.Windows.Forms.Button btn_days;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtgunler;
        private System.Windows.Forms.Button btncevir;
        private System.Windows.Forms.Label label2;
    }
}


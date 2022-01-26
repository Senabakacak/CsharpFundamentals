namespace ATMapp
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
            this.btnbakiyegoruntule = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtverigirisi = new System.Windows.Forms.TextBox();
            this.btnparacek = new System.Windows.Forms.Button();
            this.btnparayatır = new System.Windows.Forms.Button();
            this.txtcaptcha = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.txttcno = new System.Windows.Forms.TextBox();
            this.lbltcno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblcaptcha = new System.Windows.Forms.Label();
            this.btngirisyap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btngirisyap);
            this.groupBox1.Controls.Add(this.lblcaptcha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbltcno);
            this.groupBox1.Controls.Add(this.txttcno);
            this.groupBox1.Controls.Add(this.txtsifre);
            this.groupBox1.Controls.Add(this.txtcaptcha);
            this.groupBox1.Location = new System.Drawing.Point(88, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 525);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GİRİŞ YAP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnparayatır);
            this.groupBox2.Controls.Add(this.btnparacek);
            this.groupBox2.Controls.Add(this.txtverigirisi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnbakiyegoruntule);
            this.groupBox2.Location = new System.Drawing.Point(652, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 525);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HESAP";
            // 
            // btnbakiyegoruntule
            // 
            this.btnbakiyegoruntule.ForeColor = System.Drawing.Color.Red;
            this.btnbakiyegoruntule.Location = new System.Drawing.Point(153, 57);
            this.btnbakiyegoruntule.Name = "btnbakiyegoruntule";
            this.btnbakiyegoruntule.Size = new System.Drawing.Size(216, 110);
            this.btnbakiyegoruntule.TabIndex = 3;
            this.btnbakiyegoruntule.Text = "BAKİYE GÖRÜNTÜLE";
            this.btnbakiyegoruntule.UseVisualStyleBackColor = true;
            this.btnbakiyegoruntule.Click += new System.EventHandler(this.btnbakiyegoruntule_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Yapmak istediğiniz işlemi tuşlayınız";
            // 
            // txtverigirisi
            // 
            this.txtverigirisi.Location = new System.Drawing.Point(47, 202);
            this.txtverigirisi.Name = "txtverigirisi";
            this.txtverigirisi.Size = new System.Drawing.Size(450, 26);
            this.txtverigirisi.TabIndex = 5;
            // 
            // btnparacek
            // 
            this.btnparacek.ForeColor = System.Drawing.Color.Red;
            this.btnparacek.Location = new System.Drawing.Point(162, 382);
            this.btnparacek.Name = "btnparacek";
            this.btnparacek.Size = new System.Drawing.Size(216, 110);
            this.btnparacek.TabIndex = 6;
            this.btnparacek.Text = "PARA ÇEK";
            this.btnparacek.UseVisualStyleBackColor = true;
            this.btnparacek.Click += new System.EventHandler(this.btnparacek_Click);
            // 
            // btnparayatır
            // 
            this.btnparayatır.ForeColor = System.Drawing.Color.Red;
            this.btnparayatır.Location = new System.Drawing.Point(162, 253);
            this.btnparayatır.Name = "btnparayatır";
            this.btnparayatır.Size = new System.Drawing.Size(216, 110);
            this.btnparayatır.TabIndex = 7;
            this.btnparayatır.Text = "PARA YATIR";
            this.btnparayatır.UseVisualStyleBackColor = true;
            this.btnparayatır.Click += new System.EventHandler(this.btnparayatır_Click);
            // 
            // txtcaptcha
            // 
            this.txtcaptcha.Location = new System.Drawing.Point(205, 359);
            this.txtcaptcha.Name = "txtcaptcha";
            this.txtcaptcha.Size = new System.Drawing.Size(274, 26);
            this.txtcaptcha.TabIndex = 0;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(205, 216);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(274, 26);
            this.txtsifre.TabIndex = 1;
            // 
            // txttcno
            // 
            this.txttcno.Location = new System.Drawing.Point(205, 96);
            this.txttcno.Name = "txttcno";
            this.txttcno.Size = new System.Drawing.Size(274, 26);
            this.txttcno.TabIndex = 2;
            // 
            // lbltcno
            // 
            this.lbltcno.AutoSize = true;
            this.lbltcno.Location = new System.Drawing.Point(53, 102);
            this.lbltcno.Name = "lbltcno";
            this.lbltcno.Size = new System.Drawing.Size(56, 20);
            this.lbltcno.TabIndex = 3;
            this.lbltcno.Text = "TC NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "ŞİFRE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "captcha";
            // 
            // lblcaptcha
            // 
            this.lblcaptcha.AutoSize = true;
            this.lblcaptcha.Location = new System.Drawing.Point(201, 319);
            this.lblcaptcha.Name = "lblcaptcha";
            this.lblcaptcha.Size = new System.Drawing.Size(0, 20);
            this.lblcaptcha.TabIndex = 6;
            // 
            // btngirisyap
            // 
            this.btngirisyap.ForeColor = System.Drawing.Color.Red;
            this.btngirisyap.Location = new System.Drawing.Point(205, 434);
            this.btngirisyap.Name = "btngirisyap";
            this.btngirisyap.Size = new System.Drawing.Size(274, 58);
            this.btngirisyap.TabIndex = 7;
            this.btngirisyap.Text = "GİRİŞ YAP";
            this.btngirisyap.UseVisualStyleBackColor = true;
            this.btngirisyap.Click += new System.EventHandler(this.btngirisyap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Çekilecek veya Yatırılacak Tutarı giriniz..\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 623);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btngirisyap;
        private System.Windows.Forms.Label lblcaptcha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltcno;
        private System.Windows.Forms.TextBox txttcno;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TextBox txtcaptcha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnparayatır;
        private System.Windows.Forms.Button btnparacek;
        private System.Windows.Forms.TextBox txtverigirisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbakiyegoruntule;
        private System.Windows.Forms.Label label2;
    }
}


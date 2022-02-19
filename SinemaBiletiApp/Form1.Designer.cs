namespace SinemaBiletiApp
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
            this.grpPersonalInformation = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.rdnWoman = new System.Windows.Forms.RadioButton();
            this.rdnMan = new System.Windows.Forms.RadioButton();
            this.btnAvaliable = new System.Windows.Forms.Button();
            this.mskPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.mskTcNo = new System.Windows.Forms.MaskedTextBox();
            this.GrpChairs = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.mskExpireDate = new System.Windows.Forms.MaskedTextBox();
            this.mskCVS = new System.Windows.Forms.MaskedTextBox();
            this.mskCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.grpPersonalInformation.SuspendLayout();
            this.GrpChairs.SuspendLayout();
            this.grpPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPersonalInformation
            // 
            this.grpPersonalInformation.Controls.Add(this.mskTcNo);
            this.grpPersonalInformation.Controls.Add(this.mskPhoneNumber);
            this.grpPersonalInformation.Controls.Add(this.btnAvaliable);
            this.grpPersonalInformation.Controls.Add(this.rdnMan);
            this.grpPersonalInformation.Controls.Add(this.rdnWoman);
            this.grpPersonalInformation.Controls.Add(this.txtFirstName);
            this.grpPersonalInformation.Controls.Add(this.txtLastName);
            this.grpPersonalInformation.Controls.Add(this.label5);
            this.grpPersonalInformation.Controls.Add(this.label4);
            this.grpPersonalInformation.Controls.Add(this.label3);
            this.grpPersonalInformation.Controls.Add(this.label2);
            this.grpPersonalInformation.Controls.Add(this.label1);
            this.grpPersonalInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpPersonalInformation.Location = new System.Drawing.Point(12, 12);
            this.grpPersonalInformation.Name = "grpPersonalInformation";
            this.grpPersonalInformation.Size = new System.Drawing.Size(496, 308);
            this.grpPersonalInformation.TabIndex = 0;
            this.grpPersonalInformation.TabStop = false;
            this.grpPersonalInformation.Text = "Personal Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tc No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sex:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(185, 109);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(232, 32);
            this.txtLastName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(185, 71);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(232, 32);
            this.txtFirstName.TabIndex = 8;
            // 
            // rdnWoman
            // 
            this.rdnWoman.AutoSize = true;
            this.rdnWoman.Location = new System.Drawing.Point(115, 186);
            this.rdnWoman.Name = "rdnWoman";
            this.rdnWoman.Size = new System.Drawing.Size(113, 30);
            this.rdnWoman.TabIndex = 9;
            this.rdnWoman.TabStop = true;
            this.rdnWoman.Text = "Woman";
            this.rdnWoman.UseVisualStyleBackColor = true;
            // 
            // rdnMan
            // 
            this.rdnMan.AutoSize = true;
            this.rdnMan.Location = new System.Drawing.Point(281, 186);
            this.rdnMan.Name = "rdnMan";
            this.rdnMan.Size = new System.Drawing.Size(79, 30);
            this.rdnMan.TabIndex = 10;
            this.rdnMan.TabStop = true;
            this.rdnMan.Text = "Man";
            this.rdnMan.UseVisualStyleBackColor = true;
            // 
            // btnAvaliable
            // 
            this.btnAvaliable.Location = new System.Drawing.Point(133, 239);
            this.btnAvaliable.Name = "btnAvaliable";
            this.btnAvaliable.Size = new System.Drawing.Size(232, 43);
            this.btnAvaliable.TabIndex = 11;
            this.btnAvaliable.Text = "Avaliable";
            this.btnAvaliable.UseVisualStyleBackColor = true;
            this.btnAvaliable.Click += new System.EventHandler(this.btnAvaliable_Click);
            // 
            // mskPhoneNumber
            // 
            this.mskPhoneNumber.Location = new System.Drawing.Point(185, 148);
            this.mskPhoneNumber.Mask = "(999) 000-0000";
            this.mskPhoneNumber.Name = "mskPhoneNumber";
            this.mskPhoneNumber.Size = new System.Drawing.Size(232, 32);
            this.mskPhoneNumber.TabIndex = 12;
            // 
            // mskTcNo
            // 
            this.mskTcNo.Location = new System.Drawing.Point(185, 31);
            this.mskTcNo.Mask = "00000000000";
            this.mskTcNo.Name = "mskTcNo";
            this.mskTcNo.Size = new System.Drawing.Size(232, 32);
            this.mskTcNo.TabIndex = 13;
            // 
            // GrpChairs
            // 
            this.GrpChairs.Controls.Add(this.btnNext);
            this.GrpChairs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrpChairs.Location = new System.Drawing.Point(514, 12);
            this.GrpChairs.Name = "GrpChairs";
            this.GrpChairs.Size = new System.Drawing.Size(838, 308);
            this.GrpChairs.TabIndex = 1;
            this.GrpChairs.TabStop = false;
            this.GrpChairs.Text = "Avaliable Chairs";
            this.GrpChairs.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(673, 267);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(146, 35);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.lblUser);
            this.grpPayment.Controls.Add(this.mskCardNumber);
            this.grpPayment.Controls.Add(this.mskCVS);
            this.grpPayment.Controls.Add(this.mskExpireDate);
            this.grpPayment.Controls.Add(this.btnPayment);
            this.grpPayment.Controls.Add(this.label10);
            this.grpPayment.Controls.Add(this.label9);
            this.grpPayment.Controls.Add(this.label8);
            this.grpPayment.Controls.Add(this.lblTotal);
            this.grpPayment.Controls.Add(this.label6);
            this.grpPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpPayment.Location = new System.Drawing.Point(12, 341);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(582, 228);
            this.grpPayment.TabIndex = 1;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Payment";
            this.grpPayment.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(110, 28);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 26);
            this.lblTotal.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "Card Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 26);
            this.label9.TabIndex = 3;
            this.label9.Text = "Expire Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(296, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 26);
            this.label10.TabIndex = 4;
            this.label10.Text = "CVS:";
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(165, 168);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(185, 36);
            this.btnPayment.TabIndex = 5;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_click);
            // 
            // mskExpireDate
            // 
            this.mskExpireDate.Location = new System.Drawing.Point(165, 112);
            this.mskExpireDate.Mask = "00 00";
            this.mskExpireDate.Name = "mskExpireDate";
            this.mskExpireDate.Size = new System.Drawing.Size(125, 32);
            this.mskExpireDate.TabIndex = 6;
            // 
            // mskCVS
            // 
            this.mskCVS.Location = new System.Drawing.Point(366, 118);
            this.mskCVS.Mask = "000";
            this.mskCVS.Name = "mskCVS";
            this.mskCVS.Size = new System.Drawing.Size(115, 32);
            this.mskCVS.TabIndex = 7;
            // 
            // mskCardNumber
            // 
            this.mskCardNumber.Location = new System.Drawing.Point(165, 69);
            this.mskCardNumber.Mask = "0000 0000 0000 0000";
            this.mskCardNumber.Name = "mskCardNumber";
            this.mskCardNumber.Size = new System.Drawing.Size(316, 32);
            this.mskCardNumber.TabIndex = 8;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(370, 28);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 26);
            this.lblUser.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 592);
            this.Controls.Add(this.grpPayment);
            this.Controls.Add(this.GrpChairs);
            this.Controls.Add(this.grpPersonalInformation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPersonalInformation.ResumeLayout(false);
            this.grpPersonalInformation.PerformLayout();
            this.GrpChairs.ResumeLayout(false);
            this.grpPayment.ResumeLayout(false);
            this.grpPayment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPersonalInformation;
        private System.Windows.Forms.MaskedTextBox mskTcNo;
        private System.Windows.Forms.MaskedTextBox mskPhoneNumber;
        private System.Windows.Forms.Button btnAvaliable;
        private System.Windows.Forms.RadioButton rdnMan;
        private System.Windows.Forms.RadioButton rdnWoman;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GrpChairs;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.MaskedTextBox mskCardNumber;
        private System.Windows.Forms.MaskedTextBox mskCVS;
        private System.Windows.Forms.MaskedTextBox mskExpireDate;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUser;
    }
}


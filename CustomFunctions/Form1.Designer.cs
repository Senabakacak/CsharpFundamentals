namespace CustomFunctions
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
            this.btnexample2 = new System.Windows.Forms.Button();
            this.btnexample1 = new System.Windows.Forms.Button();
            this.btnexample3 = new System.Windows.Forms.Button();
            this.btnexample4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtVeri1 = new System.Windows.Forms.TextBox();
            this.txtVeri2 = new System.Windows.Forms.TextBox();
            this.cmbRenkler = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnexample2
            // 
            this.btnexample2.Location = new System.Drawing.Point(12, 113);
            this.btnexample2.Name = "btnexample2";
            this.btnexample2.Size = new System.Drawing.Size(195, 56);
            this.btnexample2.TabIndex = 0;
            this.btnexample2.Text = "Example 2";
            this.btnexample2.UseVisualStyleBackColor = true;
            this.btnexample2.Click += new System.EventHandler(this.btnexample2_Click);
            // 
            // btnexample1
            // 
            this.btnexample1.Location = new System.Drawing.Point(12, 54);
            this.btnexample1.Name = "btnexample1";
            this.btnexample1.Size = new System.Drawing.Size(195, 53);
            this.btnexample1.TabIndex = 1;
            this.btnexample1.Text = "Example 1";
            this.btnexample1.UseVisualStyleBackColor = true;
            this.btnexample1.Click += new System.EventHandler(this.btnexample1_Click);
            // 
            // btnexample3
            // 
            this.btnexample3.Location = new System.Drawing.Point(231, 51);
            this.btnexample3.Name = "btnexample3";
            this.btnexample3.Size = new System.Drawing.Size(195, 56);
            this.btnexample3.TabIndex = 2;
            this.btnexample3.Text = "Example 3";
            this.btnexample3.UseVisualStyleBackColor = true;
            this.btnexample3.Click += new System.EventHandler(this.btnexample3_Click);
            // 
            // btnexample4
            // 
            this.btnexample4.Location = new System.Drawing.Point(12, 270);
            this.btnexample4.Name = "btnexample4";
            this.btnexample4.Size = new System.Drawing.Size(195, 56);
            this.btnexample4.TabIndex = 3;
            this.btnexample4.Text = "Example 4";
            this.btnexample4.UseVisualStyleBackColor = true;
            this.btnexample4.Click += new System.EventHandler(this.btnexample4_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(459, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(246, 424);
            this.listBox1.TabIndex = 4;
            // 
            // txtVeri1
            // 
            this.txtVeri1.Location = new System.Drawing.Point(12, 22);
            this.txtVeri1.Name = "txtVeri1";
            this.txtVeri1.Size = new System.Drawing.Size(195, 26);
            this.txtVeri1.TabIndex = 5;
            // 
            // txtVeri2
            // 
            this.txtVeri2.Location = new System.Drawing.Point(231, 22);
            this.txtVeri2.Name = "txtVeri2";
            this.txtVeri2.Size = new System.Drawing.Size(195, 26);
            this.txtVeri2.TabIndex = 6;
            // 
            // cmbRenkler
            // 
            this.cmbRenkler.FormattingEnabled = true;
            this.cmbRenkler.Items.AddRange(new object[] {
            "pink",
            "black",
            "green",
            "blue",
            "purple"});
            this.cmbRenkler.Location = new System.Drawing.Point(12, 236);
            this.cmbRenkler.Name = "cmbRenkler";
            this.cmbRenkler.Size = new System.Drawing.Size(195, 28);
            this.cmbRenkler.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbRenkler);
            this.Controls.Add(this.txtVeri2);
            this.Controls.Add(this.txtVeri1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnexample4);
            this.Controls.Add(this.btnexample3);
            this.Controls.Add(this.btnexample1);
            this.Controls.Add(this.btnexample2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexample2;
        private System.Windows.Forms.Button btnexample1;
        private System.Windows.Forms.Button btnexample3;
        private System.Windows.Forms.Button btnexample4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtVeri1;
        private System.Windows.Forms.TextBox txtVeri2;
        private System.Windows.Forms.ComboBox cmbRenkler;
    }
}


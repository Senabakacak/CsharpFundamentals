namespace Introduction
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
            this.btnDivison = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnExtraction = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblConclusion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDivison
            // 
            this.btnDivison.Location = new System.Drawing.Point(358, 167);
            this.btnDivison.Name = "btnDivison";
            this.btnDivison.Size = new System.Drawing.Size(139, 69);
            this.btnDivison.TabIndex = 0;
            this.btnDivison.Text = "/";
            this.btnDivison.UseVisualStyleBackColor = true;
            this.btnDivison.Click += new System.EventHandler(this.btnDivison_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Location = new System.Drawing.Point(358, 92);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(139, 69);
            this.btnMultiplication.TabIndex = 1;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnExtraction
            // 
            this.btnExtraction.Location = new System.Drawing.Point(213, 167);
            this.btnExtraction.Name = "btnExtraction";
            this.btnExtraction.Size = new System.Drawing.Size(139, 69);
            this.btnExtraction.TabIndex = 2;
            this.btnExtraction.Text = "-";
            this.btnExtraction.UseVisualStyleBackColor = true;
            this.btnExtraction.Click += new System.EventHandler(this.btnExtraction_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(213, 92);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(139, 69);
            this.btnAddition.TabIndex = 3;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(358, 60);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(139, 26);
            this.txtNum2.TabIndex = 4;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(213, 60);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(139, 26);
            this.txtNum1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Conclusion:";
            // 
            // lblConclusion
            // 
            this.lblConclusion.AutoSize = true;
            this.lblConclusion.Location = new System.Drawing.Point(306, 260);
            this.lblConclusion.Name = "lblConclusion";
            this.lblConclusion.Size = new System.Drawing.Size(0, 20);
            this.lblConclusion.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 352);
            this.Controls.Add(this.lblConclusion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.btnExtraction);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnDivison);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDivison;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnExtraction;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblConclusion;
    }
}


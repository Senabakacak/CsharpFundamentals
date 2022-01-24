namespace StringFunctions
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
            this.btnToLower = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnToUpper = new System.Windows.Forms.Button();
            this.btnLastIndexOf = new System.Windows.Forms.Button();
            this.btnTrim = new System.Windows.Forms.Button();
            this.btnSubString = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnIndexOf = new System.Windows.Forms.Button();
            this.btnEndsWith = new System.Windows.Forms.Button();
            this.btnStartWith = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnCompareTo = new System.Windows.Forms.Button();
            this.txtVeriGirisi1 = new System.Windows.Forms.TextBox();
            this.txtVeriGirisi2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnToLower
            // 
            this.btnToLower.Location = new System.Drawing.Point(358, 321);
            this.btnToLower.Name = "btnToLower";
            this.btnToLower.Size = new System.Drawing.Size(167, 47);
            this.btnToLower.TabIndex = 0;
            this.btnToLower.Text = "lower";
            this.btnToLower.UseVisualStyleBackColor = true;
            this.btnToLower.Click += new System.EventHandler(this.btnToLower_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(174, 321);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(167, 47);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnToUpper
            // 
            this.btnToUpper.Location = new System.Drawing.Point(358, 273);
            this.btnToUpper.Name = "btnToUpper";
            this.btnToUpper.Size = new System.Drawing.Size(167, 42);
            this.btnToUpper.TabIndex = 2;
            this.btnToUpper.Text = "upper";
            this.btnToUpper.UseVisualStyleBackColor = true;
            this.btnToUpper.Click += new System.EventHandler(this.btnToUpper_Click);
            // 
            // btnLastIndexOf
            // 
            this.btnLastIndexOf.Location = new System.Drawing.Point(174, 273);
            this.btnLastIndexOf.Name = "btnLastIndexOf";
            this.btnLastIndexOf.Size = new System.Drawing.Size(167, 42);
            this.btnLastIndexOf.TabIndex = 3;
            this.btnLastIndexOf.Text = "LastIndex of";
            this.btnLastIndexOf.UseVisualStyleBackColor = true;
            this.btnLastIndexOf.Click += new System.EventHandler(this.btnLastIndexOf_Click);
            // 
            // btnTrim
            // 
            this.btnTrim.Location = new System.Drawing.Point(358, 224);
            this.btnTrim.Name = "btnTrim";
            this.btnTrim.Size = new System.Drawing.Size(167, 43);
            this.btnTrim.TabIndex = 4;
            this.btnTrim.Text = "Trim";
            this.btnTrim.UseVisualStyleBackColor = true;
            this.btnTrim.Click += new System.EventHandler(this.btnTrim_Click);
            // 
            // btnSubString
            // 
            this.btnSubString.Location = new System.Drawing.Point(358, 175);
            this.btnSubString.Name = "btnSubString";
            this.btnSubString.Size = new System.Drawing.Size(167, 43);
            this.btnSubString.TabIndex = 5;
            this.btnSubString.Text = "Substring";
            this.btnSubString.UseVisualStyleBackColor = true;
            this.btnSubString.Click += new System.EventHandler(this.btnSubString_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(358, 129);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(167, 40);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(358, 85);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(167, 38);
            this.btnSplit.TabIndex = 7;
            this.btnSplit.Text = "split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(358, 43);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(167, 36);
            this.btnReplace.TabIndex = 8;
            this.btnReplace.Text = "replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnIndexOf
            // 
            this.btnIndexOf.Location = new System.Drawing.Point(174, 224);
            this.btnIndexOf.Name = "btnIndexOf";
            this.btnIndexOf.Size = new System.Drawing.Size(167, 43);
            this.btnIndexOf.TabIndex = 9;
            this.btnIndexOf.Text = "Index of";
            this.btnIndexOf.UseVisualStyleBackColor = true;
            this.btnIndexOf.Click += new System.EventHandler(this.btnIndexOf_Click);
            // 
            // btnEndsWith
            // 
            this.btnEndsWith.Location = new System.Drawing.Point(174, 175);
            this.btnEndsWith.Name = "btnEndsWith";
            this.btnEndsWith.Size = new System.Drawing.Size(167, 43);
            this.btnEndsWith.TabIndex = 10;
            this.btnEndsWith.Text = "Ends with";
            this.btnEndsWith.UseVisualStyleBackColor = true;
            this.btnEndsWith.Click += new System.EventHandler(this.btnEndsWith_Click);
            // 
            // btnStartWith
            // 
            this.btnStartWith.Location = new System.Drawing.Point(174, 129);
            this.btnStartWith.Name = "btnStartWith";
            this.btnStartWith.Size = new System.Drawing.Size(167, 40);
            this.btnStartWith.TabIndex = 11;
            this.btnStartWith.Text = "Start with";
            this.btnStartWith.UseVisualStyleBackColor = true;
            this.btnStartWith.Click += new System.EventHandler(this.btnStartWith_Click);
            // 
            // btnContains
            // 
            this.btnContains.Location = new System.Drawing.Point(174, 85);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(167, 38);
            this.btnContains.TabIndex = 12;
            this.btnContains.Text = "Contains";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // btnCompareTo
            // 
            this.btnCompareTo.Location = new System.Drawing.Point(174, 46);
            this.btnCompareTo.Name = "btnCompareTo";
            this.btnCompareTo.Size = new System.Drawing.Size(167, 33);
            this.btnCompareTo.TabIndex = 13;
            this.btnCompareTo.Text = "Compare To";
            this.btnCompareTo.UseVisualStyleBackColor = true;
            this.btnCompareTo.Click += new System.EventHandler(this.btnCompareTo_Click);
            // 
            // txtVeriGirisi1
            // 
            this.txtVeriGirisi1.Location = new System.Drawing.Point(174, 14);
            this.txtVeriGirisi1.Name = "txtVeriGirisi1";
            this.txtVeriGirisi1.Size = new System.Drawing.Size(167, 26);
            this.txtVeriGirisi1.TabIndex = 14;
            // 
            // txtVeriGirisi2
            // 
            this.txtVeriGirisi2.Location = new System.Drawing.Point(358, 14);
            this.txtVeriGirisi2.Name = "txtVeriGirisi2";
            this.txtVeriGirisi2.Size = new System.Drawing.Size(167, 26);
            this.txtVeriGirisi2.TabIndex = 15;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(547, 14);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 364);
            this.listBox1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtVeriGirisi2);
            this.Controls.Add(this.txtVeriGirisi1);
            this.Controls.Add(this.btnCompareTo);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.btnStartWith);
            this.Controls.Add(this.btnEndsWith);
            this.Controls.Add(this.btnIndexOf);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnSubString);
            this.Controls.Add(this.btnTrim);
            this.Controls.Add(this.btnLastIndexOf);
            this.Controls.Add(this.btnToUpper);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnToLower);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToLower;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnToUpper;
        private System.Windows.Forms.Button btnLastIndexOf;
        private System.Windows.Forms.Button btnTrim;
        private System.Windows.Forms.Button btnSubString;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnIndexOf;
        private System.Windows.Forms.Button btnEndsWith;
        private System.Windows.Forms.Button btnStartWith;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnCompareTo;
        private System.Windows.Forms.TextBox txtVeriGirisi1;
        private System.Windows.Forms.TextBox txtVeriGirisi2;
        private System.Windows.Forms.ListBox listBox1;
    }
}


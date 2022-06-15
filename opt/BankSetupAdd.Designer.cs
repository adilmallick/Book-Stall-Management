
namespace opt
{
    partial class BankSetupAdd
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.acctype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.RichTextBox();
            this.holdername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.branch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.micr = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ifsc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.accno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.remark = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.bankname = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.GroupBox1.Controls.Add(this.acctype);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.address);
            this.GroupBox1.Controls.Add(this.holdername);
            this.GroupBox1.Controls.Add(this.label4);
            this.GroupBox1.Controls.Add(this.label11);
            this.GroupBox1.Controls.Add(this.branch);
            this.GroupBox1.Controls.Add(this.label10);
            this.GroupBox1.Controls.Add(this.micr);
            this.GroupBox1.Controls.Add(this.label9);
            this.GroupBox1.Controls.Add(this.ifsc);
            this.GroupBox1.Controls.Add(this.label8);
            this.GroupBox1.Controls.Add(this.accno);
            this.GroupBox1.Controls.Add(this.label7);
            this.GroupBox1.Controls.Add(this.remark);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.bankname);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.White;
            this.GroupBox1.Location = new System.Drawing.Point(12, 11);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(467, 415);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            // 
            // acctype
            // 
            this.acctype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.acctype.FormattingEnabled = true;
            this.acctype.Items.AddRange(new object[] {
            "--Select--",
            "Savings",
            "Current"});
            this.acctype.Location = new System.Drawing.Point(193, 99);
            this.acctype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.acctype.Name = "acctype";
            this.acctype.Size = new System.Drawing.Size(239, 30);
            this.acctype.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "A/C Type :";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(193, 266);
            this.address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.address.MaxLength = 200;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(239, 106);
            this.address.TabIndex = 7;
            this.address.Text = "";
            // 
            // holdername
            // 
            this.holdername.BackColor = System.Drawing.Color.White;
            this.holdername.Location = new System.Drawing.Point(193, 34);
            this.holdername.Margin = new System.Windows.Forms.Padding(4);
            this.holdername.MaxLength = 50;
            this.holdername.Name = "holdername";
            this.holdername.Size = new System.Drawing.Size(239, 28);
            this.holdername.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "A/C Holder Name :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 318);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 24);
            this.label11.TabIndex = 20;
            this.label11.Text = "Address :";
            // 
            // branch
            // 
            this.branch.BackColor = System.Drawing.Color.White;
            this.branch.Location = new System.Drawing.Point(193, 234);
            this.branch.Margin = new System.Windows.Forms.Padding(4);
            this.branch.MaxLength = 50;
            this.branch.Name = "branch";
            this.branch.Size = new System.Drawing.Size(239, 28);
            this.branch.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 236);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 24);
            this.label10.TabIndex = 18;
            this.label10.Text = "Branch :";
            // 
            // micr
            // 
            this.micr.BackColor = System.Drawing.Color.White;
            this.micr.Location = new System.Drawing.Point(193, 200);
            this.micr.Margin = new System.Windows.Forms.Padding(4);
            this.micr.MaxLength = 20;
            this.micr.Name = "micr";
            this.micr.Size = new System.Drawing.Size(239, 28);
            this.micr.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 202);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "MICR Code :";
            // 
            // ifsc
            // 
            this.ifsc.BackColor = System.Drawing.Color.White;
            this.ifsc.Location = new System.Drawing.Point(193, 166);
            this.ifsc.Margin = new System.Windows.Forms.Padding(4);
            this.ifsc.MaxLength = 20;
            this.ifsc.Name = "ifsc";
            this.ifsc.Size = new System.Drawing.Size(239, 28);
            this.ifsc.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 169);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "IFSC Code :";
            // 
            // accno
            // 
            this.accno.BackColor = System.Drawing.Color.White;
            this.accno.Location = new System.Drawing.Point(193, 133);
            this.accno.Margin = new System.Windows.Forms.Padding(4);
            this.accno.MaxLength = 30;
            this.accno.Name = "accno";
            this.accno.Size = new System.Drawing.Size(239, 28);
            this.accno.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "A/C No :";
            // 
            // remark
            // 
            this.remark.BackColor = System.Drawing.Color.White;
            this.remark.Location = new System.Drawing.Point(193, 377);
            this.remark.Margin = new System.Windows.Forms.Padding(4);
            this.remark.MaxLength = 200;
            this.remark.Name = "remark";
            this.remark.Size = new System.Drawing.Size(239, 28);
            this.remark.TabIndex = 8;
            this.remark.TextChanged += new System.EventHandler(this.txtbrand_TextChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(20, 379);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(85, 24);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Remark :";
            // 
            // bankname
            // 
            this.bankname.BackColor = System.Drawing.Color.White;
            this.bankname.Location = new System.Drawing.Point(193, 67);
            this.bankname.Margin = new System.Windows.Forms.Padding(4);
            this.bankname.MaxLength = 50;
            this.bankname.Name = "bankname";
            this.bankname.Size = new System.Drawing.Size(239, 28);
            this.bankname.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(20, 70);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(118, 24);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Bank Name :";
            // 
            // btnclose
            // 
            this.btnclose.AutoSize = true;
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.FlatAppearance.BorderSize = 5;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Image = global::opt.Properties.Resources.close4;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(373, 434);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(105, 37);
            this.btnclose.TabIndex = 4;
            this.btnclose.Text = "Close";
            this.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnsave
            // 
            this.btnsave.AutoSize = true;
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.FlatAppearance.BorderSize = 5;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Image = global::opt.Properties.Resources.save4;
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(260, 434);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(105, 37);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Save";
            this.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 483);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 31);
            this.panel1.TabIndex = 210;
            // 
            // BankSetupAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(491, 514);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BankSetupAdd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Bank Details";
            this.Load += new System.EventHandler(this.BankSetupAdd_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox holdername;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox branch;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox micr;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox ifsc;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox accno;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox remark;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox bankname;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.RichTextBox address;
        internal System.Windows.Forms.ComboBox acctype;
    }
}
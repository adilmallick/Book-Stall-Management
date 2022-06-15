
namespace opt
{
    partial class Party
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
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnm = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnclose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btndlt = new System.Windows.Forms.Button();
            this.btnclr = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.serialno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billingdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nowpaying = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.GroupBox2.Controls.Add(this.btnsearch);
            this.GroupBox2.Controls.Add(this.label1);
            this.GroupBox2.Controls.Add(this.txtnm);
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.ForeColor = System.Drawing.Color.White;
            this.GroupBox2.Location = new System.Drawing.Point(12, 11);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox2.Size = new System.Drawing.Size(990, 62);
            this.GroupBox2.TabIndex = 0;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Search / Edit";
            // 
            // btnsearch
            // 
            this.btnsearch.AutoSize = true;
            this.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearch.FlatAppearance.BorderSize = 5;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnsearch.Image = global::opt.Properties.Resources.search4;
            this.btnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsearch.Location = new System.Drawing.Point(456, 18);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(114, 37);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.Text = "Search";
            this.btnsearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Invoice No :";
            // 
            // txtnm
            // 
            this.txtnm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtnm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtnm.BackColor = System.Drawing.Color.White;
            this.txtnm.Location = new System.Drawing.Point(151, 23);
            this.txtnm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnm.Name = "txtnm";
            this.txtnm.Size = new System.Drawing.Size(279, 28);
            this.txtnm.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.groupBox3.Controls.Add(this.DataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 72);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(990, 454);
            this.groupBox3.TabIndex = 212;
            this.groupBox3.TabStop = false;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialno,
            this.invoiceno,
            this.partyname,
            this.billingdate,
            this.totalamount,
            this.paidamount,
            this.dueamount,
            this.nowpaying,
            this.date,
            this.remark});
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.Location = new System.Drawing.Point(4, 23);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersWidth = 62;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(982, 427);
            this.DataGridView1.TabIndex = 1;
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
            this.btnclose.Location = new System.Drawing.Point(889, 534);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(114, 37);
            this.btnclose.TabIndex = 5;
            this.btnclose.Text = "Close";
            this.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 583);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 31);
            this.panel1.TabIndex = 219;
            // 
            // btndlt
            // 
            this.btndlt.AutoSize = true;
            this.btndlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btndlt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndlt.FlatAppearance.BorderSize = 5;
            this.btndlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndlt.ForeColor = System.Drawing.Color.White;
            this.btndlt.Image = global::opt.Properties.Resources.delete3;
            this.btndlt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndlt.Location = new System.Drawing.Point(767, 534);
            this.btndlt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndlt.Name = "btndlt";
            this.btndlt.Size = new System.Drawing.Size(114, 37);
            this.btndlt.TabIndex = 4;
            this.btndlt.Text = "Delete";
            this.btndlt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndlt.UseVisualStyleBackColor = false;
            // 
            // btnclr
            // 
            this.btnclr.AutoSize = true;
            this.btnclr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnclr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclr.FlatAppearance.BorderSize = 5;
            this.btnclr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclr.ForeColor = System.Drawing.Color.White;
            this.btnclr.Image = global::opt.Properties.Resources.clear3;
            this.btnclr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclr.Location = new System.Drawing.Point(646, 534);
            this.btnclr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(114, 37);
            this.btnclr.TabIndex = 3;
            this.btnclr.Text = "Clear";
            this.btnclr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclr.UseVisualStyleBackColor = false;
            // 
            // btnedit
            // 
            this.btnedit.AutoSize = true;
            this.btnedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnedit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnedit.FlatAppearance.BorderSize = 5;
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.Color.White;
            this.btnedit.Image = global::opt.Properties.Resources.update2;
            this.btnedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnedit.Location = new System.Drawing.Point(525, 534);
            this.btnedit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(114, 37);
            this.btnedit.TabIndex = 2;
            this.btnedit.Text = "Update";
            this.btnedit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnedit.UseVisualStyleBackColor = false;
            // 
            // btnadd
            // 
            this.btnadd.AutoSize = true;
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.FlatAppearance.BorderSize = 5;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Image = global::opt.Properties.Resources.add1;
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.Location = new System.Drawing.Point(404, 534);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(114, 37);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "Add";
            this.btnadd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // serialno
            // 
            this.serialno.HeaderText = "Serial No";
            this.serialno.MinimumWidth = 8;
            this.serialno.Name = "serialno";
            this.serialno.ReadOnly = true;
            // 
            // invoiceno
            // 
            this.invoiceno.HeaderText = "Invoice No";
            this.invoiceno.MinimumWidth = 8;
            this.invoiceno.Name = "invoiceno";
            this.invoiceno.ReadOnly = true;
            // 
            // partyname
            // 
            this.partyname.HeaderText = "Party Name";
            this.partyname.MinimumWidth = 8;
            this.partyname.Name = "partyname";
            this.partyname.ReadOnly = true;
            // 
            // billingdate
            // 
            this.billingdate.HeaderText = "Billing Date";
            this.billingdate.MinimumWidth = 8;
            this.billingdate.Name = "billingdate";
            this.billingdate.ReadOnly = true;
            // 
            // totalamount
            // 
            this.totalamount.HeaderText = "Total Amount";
            this.totalamount.MinimumWidth = 8;
            this.totalamount.Name = "totalamount";
            this.totalamount.ReadOnly = true;
            // 
            // paidamount
            // 
            this.paidamount.HeaderText = "Paid Amount";
            this.paidamount.MinimumWidth = 8;
            this.paidamount.Name = "paidamount";
            this.paidamount.ReadOnly = true;
            // 
            // dueamount
            // 
            this.dueamount.HeaderText = "Due Amount";
            this.dueamount.MinimumWidth = 8;
            this.dueamount.Name = "dueamount";
            this.dueamount.ReadOnly = true;
            // 
            // nowpaying
            // 
            this.nowpaying.HeaderText = "Now Paying";
            this.nowpaying.MinimumWidth = 8;
            this.nowpaying.Name = "nowpaying";
            this.nowpaying.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 8;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // remark
            // 
            this.remark.HeaderText = "Remark";
            this.remark.MinimumWidth = 8;
            this.remark.Name = "remark";
            this.remark.ReadOnly = true;
            // 
            // Party
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1014, 614);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btndlt);
            this.Controls.Add(this.btnclr);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(370, 90);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Party";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PARTY";
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtnm;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btndlt;
        private System.Windows.Forms.Button btnclr;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialno;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceno;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyname;
        private System.Windows.Forms.DataGridViewTextBoxColumn billingdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn nowpaying;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
    }
}
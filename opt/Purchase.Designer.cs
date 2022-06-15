
namespace opt
{
    partial class Purchase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnm = new System.Windows.Forms.TextBox();
            this.serialno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.btndlt = new System.Windows.Forms.Button();
            this.btnclr = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.itemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hsncode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company_publishers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasefrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cgst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sgst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sortinqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
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
            this.GroupBox2.Location = new System.Drawing.Point(13, 14);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox2.Size = new System.Drawing.Size(1114, 77);
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
            this.btnsearch.Location = new System.Drawing.Point(524, 21);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(128, 46);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.Text = "Search";
            this.btnsearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Product Name :";
            // 
            // txtnm
            // 
            this.txtnm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtnm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtnm.BackColor = System.Drawing.Color.White;
            this.txtnm.Location = new System.Drawing.Point(181, 28);
            this.txtnm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnm.Name = "txtnm";
            this.txtnm.Size = new System.Drawing.Size(313, 32);
            this.txtnm.TabIndex = 0;
            // 
            // serialno
            // 
            this.serialno.HeaderText = "Serial No";
            this.serialno.MinimumWidth = 8;
            this.serialno.Name = "serialno";
            this.serialno.Width = 61;
            // 
            // DataGridView1
            // 
            this.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialno,
            this.itemname,
            this.itemcode,
            this.hsncode,
            this.company_publishers,
            this.purchasefrom,
            this.edition,
            this.genre,
            this.classes,
            this.mrp,
            this.rate,
            this.qty,
            this.sellingrate,
            this.gst,
            this.cgst,
            this.sgst,
            this.sortinqty});
            this.DataGridView1.Location = new System.Drawing.Point(4, 28);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGridView1.Name = "DataGridView1";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.RowHeadersWidth = 62;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(1106, 535);
            this.DataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 731);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 39);
            this.panel1.TabIndex = 220;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 90);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(1114, 568);
            this.groupBox3.TabIndex = 219;
            this.groupBox3.TabStop = false;
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
            this.btnclose.Location = new System.Drawing.Point(995, 668);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(128, 46);
            this.btnclose.TabIndex = 5;
            this.btnclose.Text = "Close";
            this.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
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
            this.btndlt.Location = new System.Drawing.Point(858, 668);
            this.btndlt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndlt.Name = "btndlt";
            this.btndlt.Size = new System.Drawing.Size(128, 46);
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
            this.btnclr.Location = new System.Drawing.Point(722, 668);
            this.btnclr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(128, 46);
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
            this.btnedit.Location = new System.Drawing.Point(586, 668);
            this.btnedit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(128, 46);
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
            this.btnadd.Location = new System.Drawing.Point(449, 668);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(128, 46);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "Add";
            this.btnadd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // itemname
            // 
            this.itemname.HeaderText = "Item Name";
            this.itemname.MinimumWidth = 8;
            this.itemname.Name = "itemname";
            this.itemname.Width = 62;
            // 
            // itemcode
            // 
            this.itemcode.HeaderText = "Item Code";
            this.itemcode.MinimumWidth = 8;
            this.itemcode.Name = "itemcode";
            this.itemcode.Width = 61;
            // 
            // hsncode
            // 
            this.hsncode.HeaderText = "HSN Code";
            this.hsncode.MinimumWidth = 8;
            this.hsncode.Name = "hsncode";
            this.hsncode.Width = 61;
            // 
            // company_publishers
            // 
            this.company_publishers.HeaderText = "Company/Publishers";
            this.company_publishers.MinimumWidth = 8;
            this.company_publishers.Name = "company_publishers";
            this.company_publishers.Width = 61;
            // 
            // purchasefrom
            // 
            this.purchasefrom.HeaderText = "Purchase From";
            this.purchasefrom.MinimumWidth = 8;
            this.purchasefrom.Name = "purchasefrom";
            this.purchasefrom.Width = 62;
            // 
            // edition
            // 
            this.edition.HeaderText = "Edition";
            this.edition.MinimumWidth = 8;
            this.edition.Name = "edition";
            this.edition.Width = 61;
            // 
            // genre
            // 
            this.genre.HeaderText = "Genre";
            this.genre.MinimumWidth = 8;
            this.genre.Name = "genre";
            this.genre.Width = 61;
            // 
            // classes
            // 
            this.classes.HeaderText = "Class";
            this.classes.MinimumWidth = 8;
            this.classes.Name = "classes";
            this.classes.Width = 62;
            // 
            // mrp
            // 
            this.mrp.HeaderText = "MRP";
            this.mrp.MinimumWidth = 8;
            this.mrp.Name = "mrp";
            this.mrp.Width = 61;
            // 
            // rate
            // 
            this.rate.HeaderText = "Rate";
            this.rate.MinimumWidth = 8;
            this.rate.Name = "rate";
            this.rate.Width = 61;
            // 
            // qty
            // 
            this.qty.HeaderText = "QTY";
            this.qty.MinimumWidth = 8;
            this.qty.Name = "qty";
            this.qty.Width = 62;
            // 
            // sellingrate
            // 
            this.sellingrate.HeaderText = "Selling Rate";
            this.sellingrate.MinimumWidth = 8;
            this.sellingrate.Name = "sellingrate";
            this.sellingrate.Width = 61;
            // 
            // gst
            // 
            this.gst.HeaderText = "GST (%)";
            this.gst.MinimumWidth = 8;
            this.gst.Name = "gst";
            this.gst.Width = 61;
            // 
            // cgst
            // 
            this.cgst.HeaderText = "CGST (%)";
            this.cgst.MinimumWidth = 8;
            this.cgst.Name = "cgst";
            this.cgst.Width = 61;
            // 
            // sgst
            // 
            this.sgst.HeaderText = "SGST (%)";
            this.sgst.MinimumWidth = 8;
            this.sgst.Name = "sgst";
            this.sgst.Width = 62;
            // 
            // sortinqty
            // 
            this.sortinqty.HeaderText = "Sort In QTY";
            this.sortinqty.MinimumWidth = 8;
            this.sortinqty.Name = "sortinqty";
            this.sortinqty.Width = 61;
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1139, 770);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btndlt);
            this.Controls.Add(this.btnclr);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(370, 90);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Purchase";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase";
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtnm;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialno;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btndlt;
        private System.Windows.Forms.Button btnclr;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn hsncode;
        private System.Windows.Forms.DataGridViewTextBoxColumn company_publishers;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasefrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn edition;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn classes;
        private System.Windows.Forms.DataGridViewTextBoxColumn mrp;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gst;
        private System.Windows.Forms.DataGridViewTextBoxColumn cgst;
        private System.Windows.Forms.DataGridViewTextBoxColumn sgst;
        private System.Windows.Forms.DataGridViewTextBoxColumn sortinqty;
        private System.Windows.Forms.DataGridView DataGridView1;
    }
}
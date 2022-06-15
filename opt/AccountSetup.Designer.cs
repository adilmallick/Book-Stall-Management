
namespace opt
{
    partial class AccountSetup
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
            this.txtdist = new System.Windows.Forms.TextBox();
            this.cmbstate = new System.Windows.Forms.ComboBox();
            this.cmbcntry = new System.Windows.Forms.ComboBox();
            this.txtweb = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.labwebsite = new System.Windows.Forms.Label();
            this.labemailid = new System.Windows.Forms.Label();
            this.txtstatecode = new System.Windows.Forms.TextBox();
            this.txtlicns = new System.Windows.Forms.TextBox();
            this.txtgst = new System.Windows.Forms.TextBox();
            this.txtpan = new System.Windows.Forms.TextBox();
            this.txtpin = new System.Windows.Forms.TextBox();
            this.txtvill = new System.Windows.Forms.TextBox();
            this.txtps = new System.Windows.Forms.TextBox();
            this.txtcont2 = new System.Windows.Forms.TextBox();
            this.txtcont1 = new System.Windows.Forms.TextBox();
            this.txtshopnm = new System.Windows.Forms.TextBox();
            this.labstatecode = new System.Windows.Forms.Label();
            this.labliesenceno = new System.Windows.Forms.Label();
            this.labgstno = new System.Windows.Forms.Label();
            this.labpanno = new System.Windows.Forms.Label();
            this.labpin = new System.Windows.Forms.Label();
            this.labvillstr = new System.Windows.Forms.Label();
            this.labps = new System.Windows.Forms.Label();
            this.labdist = new System.Windows.Forms.Label();
            this.labstate = new System.Windows.Forms.Label();
            this.labcountry = new System.Windows.Forms.Label();
            this.labcontno2 = new System.Windows.Forms.Label();
            this.labcontno1 = new System.Windows.Forms.Label();
            this.labname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.groupBox1.Controls.Add(this.txtdist);
            this.groupBox1.Controls.Add(this.cmbstate);
            this.groupBox1.Controls.Add(this.cmbcntry);
            this.groupBox1.Controls.Add(this.txtweb);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.labwebsite);
            this.groupBox1.Controls.Add(this.labemailid);
            this.groupBox1.Controls.Add(this.txtstatecode);
            this.groupBox1.Controls.Add(this.txtlicns);
            this.groupBox1.Controls.Add(this.txtgst);
            this.groupBox1.Controls.Add(this.txtpan);
            this.groupBox1.Controls.Add(this.txtpin);
            this.groupBox1.Controls.Add(this.txtvill);
            this.groupBox1.Controls.Add(this.txtps);
            this.groupBox1.Controls.Add(this.txtcont2);
            this.groupBox1.Controls.Add(this.txtcont1);
            this.groupBox1.Controls.Add(this.txtshopnm);
            this.groupBox1.Controls.Add(this.labstatecode);
            this.groupBox1.Controls.Add(this.labliesenceno);
            this.groupBox1.Controls.Add(this.labgstno);
            this.groupBox1.Controls.Add(this.labpanno);
            this.groupBox1.Controls.Add(this.labpin);
            this.groupBox1.Controls.Add(this.labvillstr);
            this.groupBox1.Controls.Add(this.labps);
            this.groupBox1.Controls.Add(this.labdist);
            this.groupBox1.Controls.Add(this.labstate);
            this.groupBox1.Controls.Add(this.labcountry);
            this.groupBox1.Controls.Add(this.labcontno2);
            this.groupBox1.Controls.Add(this.labcontno1);
            this.groupBox1.Controls.Add(this.labname);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 533);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PROFILE";
            // 
            // txtdist
            // 
            this.txtdist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdist.Location = new System.Drawing.Point(164, 208);
            this.txtdist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdist.Name = "txtdist";
            this.txtdist.Size = new System.Drawing.Size(251, 26);
            this.txtdist.TabIndex = 5;
            this.txtdist.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdist_KeyDown);
            // 
            // cmbstate
            // 
            this.cmbstate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbstate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbstate.FormattingEnabled = true;
            this.cmbstate.Items.AddRange(new object[] {
            "--Select--",
            "Andaman & Nicobar Islands",
            "Andhra Pradesh",
            "Andhra Pradesh (New)",
            "Arunachal Pradesh",
            "Assam",
            "Bihar",
            "Chandigarh",
            "Chhattisgarh",
            "Dadra and Nagar Haveli",
            "Daman and Diu",
            "Delhi",
            "Goa",
            "Gujarat",
            "Haryana",
            "Himachal Pradesh",
            "Jammu and Kashmir",
            "Jharkhand",
            "Karnataka",
            "Kerala",
            "Lakshadweep Islands",
            "Madhya Pradesh",
            "Maharashtra",
            "Manipur",
            "Meghalaya",
            "Mizoram",
            "Nagaland",
            "Odisha",
            "Pondicherry",
            "Punjab",
            "Rajasthan",
            "Sikkim",
            "Tamil Nadu",
            "Telangana",
            "Tripura",
            "Uttar Pradesh",
            "Uttarakhand",
            "West Bengal"});
            this.cmbstate.Location = new System.Drawing.Point(164, 174);
            this.cmbstate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbstate.Name = "cmbstate";
            this.cmbstate.Size = new System.Drawing.Size(251, 28);
            this.cmbstate.TabIndex = 4;
            this.cmbstate.SelectedIndexChanged += new System.EventHandler(this.cmbstate_SelectedIndexChanged);
            this.cmbstate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbstate_KeyDown);
            // 
            // cmbcntry
            // 
            this.cmbcntry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcntry.FormattingEnabled = true;
            this.cmbcntry.Items.AddRange(new object[] {
            "--Select--",
            "India"});
            this.cmbcntry.Location = new System.Drawing.Point(164, 139);
            this.cmbcntry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbcntry.Name = "cmbcntry";
            this.cmbcntry.Size = new System.Drawing.Size(251, 28);
            this.cmbcntry.TabIndex = 3;
            this.cmbcntry.SelectedIndexChanged += new System.EventHandler(this.cmbcntry_SelectedIndexChanged);
            this.cmbcntry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbcntry_KeyDown);
            // 
            // txtweb
            // 
            this.txtweb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtweb.Location = new System.Drawing.Point(164, 491);
            this.txtweb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtweb.Name = "txtweb";
            this.txtweb.Size = new System.Drawing.Size(251, 26);
            this.txtweb.TabIndex = 14;
            this.txtweb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtweb_KeyDown);
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(164, 460);
            this.txtemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(251, 26);
            this.txtemail.TabIndex = 13;
            this.txtemail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtemail_KeyDown);
            // 
            // labwebsite
            // 
            this.labwebsite.AutoSize = true;
            this.labwebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labwebsite.ForeColor = System.Drawing.Color.White;
            this.labwebsite.Location = new System.Drawing.Point(28, 494);
            this.labwebsite.Name = "labwebsite";
            this.labwebsite.Size = new System.Drawing.Size(80, 20);
            this.labwebsite.TabIndex = 67;
            this.labwebsite.Text = "Website :";
            // 
            // labemailid
            // 
            this.labemailid.AutoSize = true;
            this.labemailid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labemailid.ForeColor = System.Drawing.Color.White;
            this.labemailid.Location = new System.Drawing.Point(28, 462);
            this.labemailid.Name = "labemailid";
            this.labemailid.Size = new System.Drawing.Size(79, 20);
            this.labemailid.TabIndex = 66;
            this.labemailid.Text = "Email Id :";
            // 
            // txtstatecode
            // 
            this.txtstatecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstatecode.Location = new System.Drawing.Point(164, 429);
            this.txtstatecode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtstatecode.Name = "txtstatecode";
            this.txtstatecode.ReadOnly = true;
            this.txtstatecode.Size = new System.Drawing.Size(251, 26);
            this.txtstatecode.TabIndex = 12;
            this.txtstatecode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtstatecode_KeyDown);
            // 
            // txtlicns
            // 
            this.txtlicns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlicns.Location = new System.Drawing.Point(164, 398);
            this.txtlicns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtlicns.Name = "txtlicns";
            this.txtlicns.Size = new System.Drawing.Size(251, 26);
            this.txtlicns.TabIndex = 11;
            this.txtlicns.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtlicns_KeyDown);
            // 
            // txtgst
            // 
            this.txtgst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgst.Location = new System.Drawing.Point(164, 366);
            this.txtgst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtgst.Name = "txtgst";
            this.txtgst.Size = new System.Drawing.Size(251, 26);
            this.txtgst.TabIndex = 10;
            this.txtgst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtgst_KeyDown);
            // 
            // txtpan
            // 
            this.txtpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpan.Location = new System.Drawing.Point(164, 335);
            this.txtpan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpan.Name = "txtpan";
            this.txtpan.Size = new System.Drawing.Size(251, 26);
            this.txtpan.TabIndex = 9;
            this.txtpan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpan_KeyDown);
            // 
            // txtpin
            // 
            this.txtpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpin.Location = new System.Drawing.Point(164, 304);
            this.txtpin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpin.MaxLength = 6;
            this.txtpin.Name = "txtpin";
            this.txtpin.Size = new System.Drawing.Size(251, 26);
            this.txtpin.TabIndex = 8;
            this.txtpin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpin_KeyDown);
            this.txtpin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpin_KeyPress);
            // 
            // txtvill
            // 
            this.txtvill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvill.Location = new System.Drawing.Point(164, 273);
            this.txtvill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtvill.Name = "txtvill";
            this.txtvill.Size = new System.Drawing.Size(251, 26);
            this.txtvill.TabIndex = 7;
            this.txtvill.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtvill_KeyDown);
            // 
            // txtps
            // 
            this.txtps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtps.Location = new System.Drawing.Point(164, 242);
            this.txtps.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtps.Name = "txtps";
            this.txtps.Size = new System.Drawing.Size(251, 26);
            this.txtps.TabIndex = 6;
            this.txtps.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtps_KeyDown);
            // 
            // txtcont2
            // 
            this.txtcont2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcont2.Location = new System.Drawing.Point(164, 107);
            this.txtcont2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcont2.MaxLength = 10;
            this.txtcont2.Name = "txtcont2";
            this.txtcont2.Size = new System.Drawing.Size(251, 26);
            this.txtcont2.TabIndex = 2;
            this.txtcont2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcont2_KeyDown);
            this.txtcont2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcont2_KeyPress);
            // 
            // txtcont1
            // 
            this.txtcont1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcont1.Location = new System.Drawing.Point(164, 76);
            this.txtcont1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcont1.MaxLength = 10;
            this.txtcont1.Name = "txtcont1";
            this.txtcont1.Size = new System.Drawing.Size(251, 26);
            this.txtcont1.TabIndex = 1;
            this.txtcont1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcont1_KeyDown);
            this.txtcont1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcont1_KeyPress);
            // 
            // txtshopnm
            // 
            this.txtshopnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtshopnm.Location = new System.Drawing.Point(164, 45);
            this.txtshopnm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtshopnm.Name = "txtshopnm";
            this.txtshopnm.Size = new System.Drawing.Size(251, 26);
            this.txtshopnm.TabIndex = 0;
            this.txtshopnm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtshopnm_KeyDown);
            // 
            // labstatecode
            // 
            this.labstatecode.AutoSize = true;
            this.labstatecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labstatecode.ForeColor = System.Drawing.Color.White;
            this.labstatecode.Location = new System.Drawing.Point(28, 431);
            this.labstatecode.Name = "labstatecode";
            this.labstatecode.Size = new System.Drawing.Size(102, 20);
            this.labstatecode.TabIndex = 50;
            this.labstatecode.Text = "State Code :";
            // 
            // labliesenceno
            // 
            this.labliesenceno.AutoSize = true;
            this.labliesenceno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labliesenceno.ForeColor = System.Drawing.Color.White;
            this.labliesenceno.Location = new System.Drawing.Point(28, 400);
            this.labliesenceno.Name = "labliesenceno";
            this.labliesenceno.Size = new System.Drawing.Size(113, 20);
            this.labliesenceno.TabIndex = 49;
            this.labliesenceno.Text = "Liecence No :";
            // 
            // labgstno
            // 
            this.labgstno.AutoSize = true;
            this.labgstno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labgstno.ForeColor = System.Drawing.Color.White;
            this.labgstno.Location = new System.Drawing.Point(28, 369);
            this.labgstno.Name = "labgstno";
            this.labgstno.Size = new System.Drawing.Size(79, 20);
            this.labgstno.TabIndex = 48;
            this.labgstno.Text = "GST No :";
            // 
            // labpanno
            // 
            this.labpanno.AutoSize = true;
            this.labpanno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labpanno.ForeColor = System.Drawing.Color.White;
            this.labpanno.Location = new System.Drawing.Point(28, 338);
            this.labpanno.Name = "labpanno";
            this.labpanno.Size = new System.Drawing.Size(79, 20);
            this.labpanno.TabIndex = 47;
            this.labpanno.Text = "PAN No :";
            // 
            // labpin
            // 
            this.labpin.AutoSize = true;
            this.labpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labpin.ForeColor = System.Drawing.Color.White;
            this.labpin.Location = new System.Drawing.Point(28, 306);
            this.labpin.Name = "labpin";
            this.labpin.Size = new System.Drawing.Size(46, 20);
            this.labpin.TabIndex = 46;
            this.labpin.Text = "PIN :";
            // 
            // labvillstr
            // 
            this.labvillstr.AutoSize = true;
            this.labvillstr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labvillstr.ForeColor = System.Drawing.Color.White;
            this.labvillstr.Location = new System.Drawing.Point(28, 275);
            this.labvillstr.Name = "labvillstr";
            this.labvillstr.Size = new System.Drawing.Size(102, 20);
            this.labvillstr.TabIndex = 45;
            this.labvillstr.Text = "Street / Vill :";
            // 
            // labps
            // 
            this.labps.AutoSize = true;
            this.labps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labps.ForeColor = System.Drawing.Color.White;
            this.labps.Location = new System.Drawing.Point(28, 244);
            this.labps.Name = "labps";
            this.labps.Size = new System.Drawing.Size(49, 20);
            this.labps.TabIndex = 44;
            this.labps.Text = "P.S. :";
            // 
            // labdist
            // 
            this.labdist.AutoSize = true;
            this.labdist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labdist.ForeColor = System.Drawing.Color.White;
            this.labdist.Location = new System.Drawing.Point(28, 210);
            this.labdist.Name = "labdist";
            this.labdist.Size = new System.Drawing.Size(74, 20);
            this.labdist.TabIndex = 43;
            this.labdist.Text = "District :";
            // 
            // labstate
            // 
            this.labstate.AutoSize = true;
            this.labstate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labstate.ForeColor = System.Drawing.Color.White;
            this.labstate.Location = new System.Drawing.Point(28, 176);
            this.labstate.Name = "labstate";
            this.labstate.Size = new System.Drawing.Size(58, 20);
            this.labstate.TabIndex = 42;
            this.labstate.Text = "State :";
            // 
            // labcountry
            // 
            this.labcountry.AutoSize = true;
            this.labcountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcountry.ForeColor = System.Drawing.Color.White;
            this.labcountry.Location = new System.Drawing.Point(28, 142);
            this.labcountry.Name = "labcountry";
            this.labcountry.Size = new System.Drawing.Size(77, 20);
            this.labcountry.TabIndex = 41;
            this.labcountry.Text = "Country :";
            // 
            // labcontno2
            // 
            this.labcontno2.AutoSize = true;
            this.labcontno2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcontno2.ForeColor = System.Drawing.Color.White;
            this.labcontno2.Location = new System.Drawing.Point(28, 110);
            this.labcontno2.Name = "labcontno2";
            this.labcontno2.Size = new System.Drawing.Size(117, 20);
            this.labcontno2.TabIndex = 40;
            this.labcontno2.Text = "Contact No 2 :";
            // 
            // labcontno1
            // 
            this.labcontno1.AutoSize = true;
            this.labcontno1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcontno1.ForeColor = System.Drawing.Color.White;
            this.labcontno1.Location = new System.Drawing.Point(28, 78);
            this.labcontno1.Name = "labcontno1";
            this.labcontno1.Size = new System.Drawing.Size(117, 20);
            this.labcontno1.TabIndex = 39;
            this.labcontno1.Text = "Contact No 1 :";
            // 
            // labname
            // 
            this.labname.AutoSize = true;
            this.labname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labname.ForeColor = System.Drawing.Color.White;
            this.labname.Location = new System.Drawing.Point(28, 47);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(106, 20);
            this.labname.TabIndex = 37;
            this.labname.Text = "Shop Name :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 617);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 31);
            this.panel1.TabIndex = 211;
            // 
            // btnsave
            // 
            this.btnsave.AutoSize = true;
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnsave.FlatAppearance.BorderSize = 2;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Image = global::opt.Properties.Resources.save4;
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(88, 555);
            this.btnsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(107, 35);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "SAVE";
            this.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::opt.Properties.Resources.close4;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(342, 555);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "CLOSE";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.AutoSize = true;
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnupdate.FlatAppearance.BorderSize = 2;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Image = global::opt.Properties.Resources.update2;
            this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.Location = new System.Drawing.Point(212, 555);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(113, 35);
            this.btnupdate.TabIndex = 212;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click_1);
            // 
            // AccountSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(472, 648);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(580, 65);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Setup";
            this.Load += new System.EventHandler(this.AccountSetup_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AccountSetup_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labwebsite;
        private System.Windows.Forms.Label labemailid;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label labstatecode;
        private System.Windows.Forms.Label labliesenceno;
        private System.Windows.Forms.Label labgstno;
        private System.Windows.Forms.Label labpanno;
        private System.Windows.Forms.Label labpin;
        private System.Windows.Forms.Label labvillstr;
        private System.Windows.Forms.Label labps;
        private System.Windows.Forms.Label labdist;
        private System.Windows.Forms.Label labstate;
        private System.Windows.Forms.Label labcountry;
        private System.Windows.Forms.Label labcontno2;
        private System.Windows.Forms.Label labcontno1;
        private System.Windows.Forms.Label labname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnupdate;
        internal System.Windows.Forms.TextBox txtweb;
        internal System.Windows.Forms.TextBox txtemail;
        internal System.Windows.Forms.TextBox txtstatecode;
        internal System.Windows.Forms.TextBox txtlicns;
        internal System.Windows.Forms.TextBox txtgst;
        internal System.Windows.Forms.TextBox txtpan;
        internal System.Windows.Forms.TextBox txtpin;
        internal System.Windows.Forms.TextBox txtvill;
        internal System.Windows.Forms.TextBox txtps;
        internal System.Windows.Forms.TextBox txtcont2;
        internal System.Windows.Forms.TextBox txtcont1;
        internal System.Windows.Forms.TextBox txtshopnm;
        internal System.Windows.Forms.ComboBox cmbstate;
        internal System.Windows.Forms.ComboBox cmbcntry;
        internal System.Windows.Forms.TextBox txtdist;
    }
}
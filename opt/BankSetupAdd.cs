using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace opt
{
    public partial class BankSetupAdd : Form
    {
        BankSetup bs;
        internal bool isAdd = true;

        public BankSetupAdd()
        {
            InitializeComponent();
        }

        public BankSetupAdd(BankSetup bs)
        {
            InitializeComponent();
            this.bs = bs;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbrand_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            bool valid = validation();
            if (valid)
            {
                if (isAdd)
                {
                    addUpdate(true);
                }
                else
                {
                    addUpdate(false);
                }
            }

        }


        internal bool validation()
        {
            if(holdername.Text == string.Empty || holdername.Text.Length < 4)
            {
                MessageBox.Show("Enter valid name.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                holdername.SelectAll();
                holdername.Focus();
                return false;
            }
            else if (bankname.Text == string.Empty || bankname.Text.Length < 3)
            {
                MessageBox.Show("Enter valid bank name", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bankname.SelectAll();
                bankname.Focus();
                return false;
            }
            else if (accno.Text == string.Empty || accno.Text.Length < 11)
            {
                MessageBox.Show("Enter valid account number.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                accno.SelectAll();
                accno.Focus();
                return false;
            }
            else if (ifsc.Text == string.Empty || ifsc.Text.Length < 11)
            {
                MessageBox.Show("Enter valid IFSC code.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ifsc.SelectAll();
                ifsc.Focus();
                return false;
            }

            return true;
        }


        internal void addUpdate(bool add)
        {
            SqlConnection con = new SqlConnection(log.constr);
            SqlCommand cmd = new SqlCommand();
            if (add)
            {
                
                cmd = new SqlCommand("procbanksetup", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@holder_name", holdername.Text);
                cmd.Parameters.AddWithValue("@bank_name", bankname.Text);
                cmd.Parameters.AddWithValue("@actype", acctype.Text);
                cmd.Parameters.AddWithValue("@acno", accno.Text);
                cmd.Parameters.AddWithValue("@ifsc", ifsc.Text);
                cmd.Parameters.AddWithValue("@micr", micr.Text);
                cmd.Parameters.AddWithValue("@branch", branch.Text);
                cmd.Parameters.AddWithValue("@addrs", address.Text);
                cmd.Parameters.AddWithValue("@remark", remark.Text);
            }
            else
            {
                cmd = new SqlCommand("update banksetup set holder_name = '" + holdername.Text + "', bank_name = '" + bankname.Text + "', actype = '" + acctype.Text + "', acno = '" + accno.Text + "', ifsc = '" + ifsc.Text + "', micr = '" + micr.Text + "', branch = '" + branch.Text + "', addrs = '" + address.Text + "', remark = '" + remark.Text + "' where acno = '" + accno.Text + "' ", con);
            }
           

            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {

                    bs.bankclear();
                    bs.load(true);
                    this.Close();
                }


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }

        private void BankSetupAdd_Load(object sender, EventArgs e)
        {
            if (isAdd)
            {
                acctype.Text = "--Select--";
            }
        }
    }
}

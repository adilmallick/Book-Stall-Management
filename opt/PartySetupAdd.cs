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
    
    public partial class PartySetupAdd : Form
    {
        internal bool isAdd = true;
        internal static string partyid;
        SqlCommand cmd;
        PartySetup fgrid;

        public PartySetupAdd( )
        {
            InitializeComponent();
            
        }
        public PartySetupAdd(PartySetup fg)
        {
            InitializeComponent();
            this.fgrid = fg;
        }
         
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            
            if(isAdd && isValid())
            {
                addData();
            }
            if(!isAdd && isValid())
            {
                updateData();
            }
            
           
            
        }
        private void addData()
        {
            SqlConnection con = new SqlConnection(log.constr);
            SqlCommand cmd = new SqlCommand("procpartysetup", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@party_id", txtpartyid.Text);
            cmd.Parameters.AddWithValue("@pt_name", txtpartynm.Text);
            cmd.Parameters.AddWithValue("@pt_type", cmbtp.Text);
            cmd.Parameters.AddWithValue("@addrs", txtadd.Text);
            cmd.Parameters.AddWithValue("@cont_no", txtcon.Text);
            cmd.Parameters.AddWithValue("@email", txtemail.Text);
            cmd.Parameters.AddWithValue("@pan_no", txtpan.Text);
            cmd.Parameters.AddWithValue("@gst_no", txtgst.Text);
            cmd.Parameters.AddWithValue("@statecode", txtscode.Text);
            cmd.Parameters.AddWithValue("@payment_mode", cmbpay.Text);
            cmd.Parameters.AddWithValue("@details", txtdtls.Text);
            cmd.Parameters.AddWithValue("@remark", txtremark.Text);

            //string[] strdata = { "", txtpartyid.Text, txtpartynm.Text, cmbtp.Text, txtadd.Text, txtcon.Text, txtemail.Text, txtpan.Text, txtgst.Text, txtscode.Text, cmbpay.Text, txtdtls.Text, txtremark.Text };
            //fgrid.DataGridView1.Rows.Add(strdata);



            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    
                    fgrid.partyclear();
                    fgrid.load();
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

        private bool isValid()
        {
            bool retval = true;
            if(txtpartyid.Text == string.Empty)
            {
                MessageBox.Show("Enter  Party ID", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpartyid.Focus();
                retval = false;
                return retval;
            }

            if (txtpartynm.Text == string.Empty)
            {
                MessageBox.Show("Enter  Party Name", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpartynm.Focus();
                retval = false;
                return retval;
            }

            if (cmbtp.Text == string.Empty)
            {
                MessageBox.Show("Enter Party Type", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbtp.Focus();
                retval = false;
                return retval;
            }
            return retval;
        }

        private void updateData()
        {
            SqlConnection con = new SqlConnection(log.constr);

            cmd = new SqlCommand("update partysetup set pt_name = '"+txtpartynm.Text+"', pt_type = '"+cmbtp.Text+"', addrs = '"+txtadd.Text+"', cont_no = '"+txtcon.Text+ "', email = '" + txtemail.Text + "', pan_no = '" + txtpan.Text + "', gst_no = '" + txtgst.Text + "', statecode = '" + txtscode.Text + "', payment_mode = '" + cmbpay.Text + "', details = '" + txtdtls.Text + "', remark = '" + txtremark.Text + "' where party_id = '" + txtpartyid.Text + "' ", con);


            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    con.Close();
                    fgrid.partyclear();
                    fgrid.load();
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

        private void PartySetupAdd_Load(object sender, EventArgs e)
        {

            if (isAdd) 
            { 
                txtpartyid.Text = partyid;
            }
            if (txtpartyid.Text.Length == 0)
            {
                txtpartyid.Text = "PAR01";
                txtpartyid.ReadOnly = true;
            }

        }

        private void txtpartynm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtcon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}

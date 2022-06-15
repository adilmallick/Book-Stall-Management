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
    public partial class ItemSetupAdd : Form
    {
        internal bool isAdd = true;
        SqlCommand cmd;
        ItemSetup fgrid;
        public ItemSetupAdd()
        {
            InitializeComponent();
        }
        public ItemSetupAdd(ItemSetup fg)
        {
            InitializeComponent();
            this.fgrid = fg;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (isAdd && isValid())
            {
                addData();
            }
            if (!isAdd && isValid())
            {
                updateData();

            }


        }

        private void addData()
        {
            SqlConnection con = new SqlConnection(log.constr);
            cmd = new SqlCommand("procitemsetup", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@book_name", txtbooknm.Text);
            cmd.Parameters.AddWithValue("@isbn_code", txtisbncode.Text);
            cmd.Parameters.AddWithValue("@pub_comp", txtpublishers.Text);
            cmd.Parameters.AddWithValue("@gst", txtgst.Text);
            cmd.Parameters.AddWithValue("@cgst", txtcgst.Text);
            cmd.Parameters.AddWithValue("@sgst", txtsgst.Text);
            cmd.Parameters.AddWithValue("@remark", txtremark.Text);
          
            

            //string[] strdata = { "", txtpartyid.Text, txtpartynm.Text, cmbtp.Text, txtadd.Text, txtcon.Text, txtemail.Text, txtpan.Text, txtgst.Text, txtscode.Text, cmbpay.Text, txtdtls.Text, txtremark.Text };
            //fgrid.DataGridView1.Rows.Add(strdata);



            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    con.Close();
                    fgrid.itemclear();
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
            if (txtbooknm.Text == string.Empty)
            {
                MessageBox.Show("Enter  Party ID", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbooknm.Focus();
                retval = false;
                
            }

            if (txtisbncode.Text == string.Empty)
            {
                MessageBox.Show("Enter  Party Name", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtisbncode.Focus();
                retval = false;
                
            }

            if (txtpublishers.Text == string.Empty)
            {
                MessageBox.Show("Enter Party Type", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpublishers.Focus();
                retval = false;
                
            }

            return retval;
        }

        private void updateData()
        {
            SqlConnection con = new SqlConnection(log.constr);

                                                                                                                        
            cmd = new SqlCommand("update itemsetup set book_name = '" + txtbooknm.Text + "', pub_comp = '" + txtpublishers.Text + "', gst = '" + txtcgst.Text + "', cgst = '"+txtsgst.Text+"' , sgst = '" + txtsgst.Text + "', remark = '" + txtremark.Text + "' where isbn_code = '"+txtisbncode.Text+"' ", con);


            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    con.Close();
                    fgrid.itemclear();
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
    }
}

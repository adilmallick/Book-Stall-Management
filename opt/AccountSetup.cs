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
    public partial class AccountSetup : Form
    {
        internal static bool isUpdate = false;
        public AccountSetup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //close btn
        {
            this.Close();
        }

        private void txtcont1_KeyPress(object sender, KeyPressEventArgs e) // only number allowed in cont no 1
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtcont2_KeyPress(object sender, KeyPressEventArgs e) // only number allowed in cont no 2
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtpin_KeyPress(object sender, KeyPressEventArgs e) // only number allowed in pin code
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnsave_Click(object sender, EventArgs e) //Save Buttona
        {
            bool valid = isValid();
            if (valid && isUpdate)
            {
      
                SqlConnection con = new SqlConnection(log.constr);
                SqlCommand cmd = new SqlCommand("procacsetup", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@shopnm", txtshopnm.Text);
                cmd.Parameters.AddWithValue("@cont1", txtcont1.Text);
                cmd.Parameters.AddWithValue("@cont2", txtcont2.Text);
                cmd.Parameters.AddWithValue("@cntry", cmbcntry.Text);
                cmd.Parameters.AddWithValue("@state", cmbstate.Text);
                cmd.Parameters.AddWithValue("@dist", txtdist.Text);
                cmd.Parameters.AddWithValue("@ps", txtps.Text);
                cmd.Parameters.AddWithValue("@vill", txtvill.Text);
                cmd.Parameters.AddWithValue("@pin", txtpin.Text);
                cmd.Parameters.AddWithValue("@pan", txtpan.Text);
                cmd.Parameters.AddWithValue("@gst", txtgst.Text);
                cmd.Parameters.AddWithValue("@licns", txtlicns.Text);
                cmd.Parameters.AddWithValue("@statecode", txtstatecode.Text);
                cmd.Parameters.AddWithValue("@email", txtemail.Text);
                cmd.Parameters.AddWithValue("@web", txtweb.Text);

                try
                {
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        update();
                        readOnly(false);
                        MessageBox.Show("Data save successfully.");
                        isUpdate = false;
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

        internal void update()
        {
            SqlConnection con = new SqlConnection(log.constr);
            SqlCommand cmd = new SqlCommand("select * from acsetup", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                da.Fill(dt);
                foreach (DataRow drow in dt.Rows)
                {
                    txtshopnm.Text = drow["stallname"].ToString();
                    txtcont1.Text = drow["cont_no1"].ToString();
                    txtcont2.Text = drow["cont_no2"].ToString();
                    cmbcntry.Text = drow["country"].ToString();
                    cmbstate.Text = drow["statenm"].ToString();
                    txtdist.Text = drow["dist"].ToString();
                    txtps.Text = drow["ps"].ToString();
                    txtvill.Text = drow["vill"].ToString();
                    txtpin.Text = drow["pin"].ToString();
                    txtpan.Text = drow["panno"].ToString();
                    txtgst.Text = drow["gstno"].ToString();
                    txtlicns.Text = drow["liecenceno"].ToString();
                    txtstatecode.Text = drow["statecode"].ToString();
                    txtemail.Text = drow["email"].ToString();
                    txtweb.Text = drow["website"].ToString();
                }

                dt.Dispose();
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
               
                cmd.Dispose();
                da.Dispose();
                con.Close();
            }
        }


        internal bool isValid()
        {
            if (txtshopnm.Text == string.Empty)
            {
                MessageBox.Show("Enter Shop Name");
                txtshopnm.Focus();
                return false;
            }
            else if (txtcont1.Text == string.Empty)
            {
                MessageBox.Show("Enter Contact No 1");
                txtcont1.Focus();
                return false;
            }
            else if (cmbcntry.Text == string.Empty)
            {
                MessageBox.Show("Enter Country Name");
                cmbcntry.Focus();
                return false;
            }
            else if (cmbstate.Text == string.Empty)
            {
                MessageBox.Show("Enter State Name");
                cmbstate.Focus();
                return false;
            }
            else if (txtdist.Text == string.Empty)
            {
                MessageBox.Show("Enter District Name");
                txtdist.Focus();
                return false;
            }
            else if (txtps.Text == string.Empty)
            {
                MessageBox.Show("Enter P.S. Name");
                txtps.Focus();
                return false;
            }
            else if (txtvill.Text == string.Empty)
            {
                MessageBox.Show("Enter Village Name");
                txtvill.Focus();
                return false;
            }
            else if (txtstatecode.Text == string.Empty)
            {
                MessageBox.Show("Enter State Code");
                txtstatecode.Focus();
                return false;
            }

            if (cmbcntry.Text == "--Select--") //If User select "Select" item
            {
                MessageBox.Show("Chose Your Country", "error data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbcntry.Focus();
                return false;
            }
            if (cmbstate.Text == "--Select--") //If User select "Select" item
            {
                MessageBox.Show("Chose Your State", "error data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbstate.Focus();
                return false;
            }
            return true;
        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            isUpdate = true;
            update();
            readOnly(true);
            txtshopnm.Focus();

        }

        private void txtshopnm_KeyDown(object sender, KeyEventArgs e) //Click Enter to next text box
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcont1.Focus();
            }
        }

        private void txtcont1_KeyDown(object sender, KeyEventArgs e) //Click Enter to next text box
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcont2.Focus();
            }
        }

        private void txtcont2_KeyDown(object sender, KeyEventArgs e) //Click Enter to next text box
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbcntry.Focus();
            }
        }

        private void cmbcntry_KeyDown(object sender, KeyEventArgs e) //Click Enter to next text box
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbstate.Focus();
            }
        }

        private void cmbstate_KeyDown(object sender, KeyEventArgs e) //Click Enter to next text box
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtdist.Focus();
            }
        }

        private void txtdist_KeyDown(object sender, KeyEventArgs e) //Click Enter to next text box
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtps.Focus();
            }
        }

        private void txtps_KeyDown(object sender, KeyEventArgs e) //Click Enter to next text box
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtvill.Focus();
            }
        }

        private void txtvill_KeyDown(object sender, KeyEventArgs e) //Click Enter to next text box
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpin.Focus();
            }
        }

        private void txtpin_KeyDown(object sender, KeyEventArgs e) //Click Enter to next text box
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpan.Focus();
            }
        }

        private void txtpan_KeyDown(object sender, KeyEventArgs e) //Click Enter to next text box
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtgst.Focus();
            }
        }

        private void txtgst_KeyDown(object sender, KeyEventArgs e) //Click Enter to next text box
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtlicns.Focus();
            }
        }

        private void txtlicns_KeyDown(object sender, KeyEventArgs e) //Click Enter to next text box
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtstatecode.Focus();
            }
        }

        private void txtstatecode_KeyDown(object sender, KeyEventArgs e) //Click Enter to next text box
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtemail.Focus();
            }
        }

        private void txtemail_KeyDown(object sender, KeyEventArgs e) //Click Enter to next text box
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtweb.Focus();
            }
        }

        private void txtweb_KeyDown(object sender, KeyEventArgs e) //Click Enter to next text box
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnsave.Focus();
            }
        }

        private void AccountSetup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void AccountSetup_Load(object sender, EventArgs e) //Load
        {
            cmbcntry.SelectedIndex = 0;
            cmbstate.SelectedIndex = 0;
            update();
            readOnly(false);
          
        }

        internal void readOnly(bool t)
        {
            txtshopnm.Enabled = t;
            txtcont1.Enabled = t;
            txtcont2.Enabled = t;
            txtdist.Enabled = t;
            txtstatecode.Enabled = t;
            txtps.Enabled = t;
            txtvill.Enabled = t;
            txtpin.Enabled = t;
            txtpan.Enabled = t;
            txtgst.Enabled = t;
            txtlicns.Enabled = t;
            txtemail.Enabled = t;
            txtweb.Enabled = t;
            cmbcntry.Enabled = t;
            cmbstate.Enabled = t;
        }

        internal void autostcode()
        {
            if(cmbstate.SelectedItem == "Andaman & Nicobar Islands")
            {
                txtstatecode.Text = "35";
            }
            else if (cmbstate.SelectedItem == "Andhra Pradesh")
            {
                txtstatecode.Text = "28";
            }
            else if (cmbstate.SelectedItem == "Andhra Pradesh (New)")
            {
                txtstatecode.Text = "37";
            }
            else if (cmbstate.SelectedItem == "Arunachal Pradesh")
            {
                txtstatecode.Text = "12";
            }
            else if (cmbstate.SelectedItem == "Assam")
            {
                txtstatecode.Text = "18";
            }
            else if (cmbstate.SelectedItem == "Bihar")
            {
                txtstatecode.Text = "10";
            }
            else if (cmbstate.SelectedItem == "Chandigarh")
            {
                txtstatecode.Text = "04";
            }
            else if (cmbstate.SelectedItem == "Chhattisgarh")
            {
                txtstatecode.Text = "22";
            }
            else if (cmbstate.SelectedItem == "Dadra and Nagar Haveli")
            {
                txtstatecode.Text = "26";
            }
            else if (cmbstate.SelectedItem == "Daman and Diu")
            {
                txtstatecode.Text = "25";
            }
            else if (cmbstate.SelectedItem == "Delhi")
            {
                txtstatecode.Text = "07";
            }
            else if (cmbstate.SelectedItem == "Goa")
            {
                txtstatecode.Text = "30";
            }
            else if (cmbstate.SelectedItem == "Gujarat")
            {
                txtstatecode.Text = "24";
            }
            else if (cmbstate.SelectedItem == "Haryana")
            {
                txtstatecode.Text = "06";
            }
            else if (cmbstate.SelectedItem == "Himachal Pradesh")
            {
                txtstatecode.Text = "02";
            }
            else if (cmbstate.SelectedItem == "Jammu and Kashmir")
            {
                txtstatecode.Text = "01";
            }
            else if (cmbstate.SelectedItem == "Jharkhand")
            {
                txtstatecode.Text = "20";
            }
            else if (cmbstate.SelectedItem == "Karnataka")
            {
                txtstatecode.Text = "29";
            }
            else if (cmbstate.SelectedItem == "Kerala")
            {
                txtstatecode.Text = "32";
            }
            else if (cmbstate.SelectedItem == "Lakshadweep Islands")
            {
                txtstatecode.Text = "31";
            }
            else if (cmbstate.SelectedItem == "Madhya Pradesh")
            {
                txtstatecode.Text = "23";
            }
            else if (cmbstate.SelectedItem == "Maharashtra")
            {
                txtstatecode.Text = "27";
            }
            else if (cmbstate.SelectedItem == "Manipur")
            {
                txtstatecode.Text = "14";
            }
            else if (cmbstate.SelectedItem == "Meghalaya")
            {
                txtstatecode.Text = "17";
            }
            else if (cmbstate.SelectedItem == "Mizoram")
            {
                txtstatecode.Text = "15";
            }
            else if (cmbstate.SelectedItem == "Nagaland")
            {
                txtstatecode.Text = "13";
            }
            else if (cmbstate.SelectedItem == "Odisha")
            {
                txtstatecode.Text = "21";
            }
            else if (cmbstate.SelectedItem == "Pondicherry")
            {
                txtstatecode.Text = "34";
            }
            else if (cmbstate.SelectedItem == "Punjab")
            {
                txtstatecode.Text = "03";
            }
            else if (cmbstate.SelectedItem == "Rajasthan")
            {
                txtstatecode.Text = "08";
            }
            else if (cmbstate.SelectedItem == "Sikkim")
            {
                txtstatecode.Text = "11";
            }
            else if (cmbstate.SelectedItem == "Tamil Nadu")
            {
                txtstatecode.Text = "33";
            }
            else if (cmbstate.SelectedItem == "Telangana")
            {
                txtstatecode.Text = "36";
            }
            else if (cmbstate.SelectedItem == "Tripura")
            {
                txtstatecode.Text = "16";
            }
            else if (cmbstate.SelectedItem == "Uttar Pradesh")
            {
                txtstatecode.Text = "09";
            }
            else if (cmbstate.SelectedItem == "Uttarakhand")
            {

                txtstatecode.Text = "05";
            }
            else if (cmbstate.SelectedItem == "West Bengal")
            {
                txtstatecode.Text = "19";
            }
        }

        private void cmbstate_SelectedIndexChanged(object sender, EventArgs e)
        {
            autostcode();
        }

        private void cmbcntry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

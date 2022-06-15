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
    public partial class PartySetup : Form
    {
        private DataTable dt;
        SqlCommandBuilder cmdbld;
        SqlCommand cmd;
        SqlDataAdapter da;
        
        public PartySetup()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(log.constr);
            cmd = new SqlCommand("genpartyid", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter paramout = new SqlParameter("@newid", SqlDbType.NVarChar, 50);
            paramout.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(paramout);


            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                PartySetupAdd.partyid = paramout.Value.ToString();



            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }

            PartySetupAdd a = new PartySetupAdd(this);
            a.Size = new Size(372, 550);
            a.ShowDialog();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PartySetup_Load(object sender, EventArgs e)
        {
            load();
        }

        internal void load()
        {
            SqlConnection con = new SqlConnection(log.constr);
            cmd = new SqlCommand("select * from partysetup", con);

            da = new SqlDataAdapter(cmd);
            cmdbld = new SqlCommandBuilder(da);
            dt = new DataTable();
            try
            {
                con.Open();
                da.Fill(dt);
                foreach (DataRow drow in dt.Rows)
                {
                    string[] strdata = { "", drow["party_id"].ToString(), drow["pt_name"].ToString(), drow["pt_type"].ToString(), drow["addrs"].ToString(), drow["cont_no"].ToString(), drow["email"].ToString(), drow["pan_no"].ToString(), drow["gst_no"].ToString(), drow["statecode"].ToString(), drow["payment_mode"].ToString(), drow["details"].ToString(), drow["remark"].ToString() };

                    DataGridView1.Rows.Add(strdata);
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

            txtserchdata();
        }

        private void txtserchdata()
        {
            SqlConnection con = new SqlConnection(log.constr);
            SqlCommand cmdtxt = new SqlCommand("select pt_name from partysetup", con);

            
            con.Open();
            SqlDataAdapter datxt = new SqlDataAdapter(cmdtxt);
            DataTable dttxt = new DataTable();
            datxt.Fill(dttxt);
            datxt.Dispose();
            cmdtxt.Dispose();
            con.Close();
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            foreach (DataRow drow in dttxt.Rows)
            {
                col.Add(drow[0].ToString());
            }
            txtnm.AutoCompleteCustomSource = col;

        }

        private void DataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.DataGridView1.Rows[e.RowIndex].Cells["serialno"].Value = (e.RowIndex + 1).ToString();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {

            updateParty();
        }

        public void updateParty()
        {
            
            if(DataGridView1.SelectedRows[0].Index >-1 && DataGridView1.SelectedRows[0].Index <= dt.Rows.Count-1 && dt.Rows.Count > 0)
            {
                PartySetupAdd psa = new PartySetupAdd(this);
                psa.isAdd = false;
                psa.txtpartyid.Text = DataGridView1.SelectedRows[0].Cells["partyid"].Value.ToString();
                psa.txtpartyid.ReadOnly = true;
                psa.txtpartynm.Text = DataGridView1.SelectedRows[0].Cells["partyname"].Value.ToString();
                psa.cmbtp.SelectedItem = DataGridView1.SelectedRows[0].Cells["type"].Value.ToString();
                psa.txtadd.Text = DataGridView1.SelectedRows[0].Cells["address"].Value.ToString();
                psa.txtcon.Text = DataGridView1.SelectedRows[0].Cells["contact"].Value.ToString();
                psa.txtemail.Text = DataGridView1.SelectedRows[0].Cells["emailid"].Value.ToString();
                psa.txtpan.Text = DataGridView1.SelectedRows[0].Cells["panno"].Value.ToString();
                psa.txtgst.Text = DataGridView1.SelectedRows[0].Cells["gstno"].Value.ToString();
                psa.txtscode.Text = DataGridView1.SelectedRows[0].Cells["statecode"].Value.ToString();
                psa.cmbpay.SelectedItem = DataGridView1.SelectedRows[0].Cells["paymentmode"].Value.ToString();
                psa.txtdtls.Text = DataGridView1.SelectedRows[0].Cells["details"].Value.ToString();
                psa.txtremark.Text = DataGridView1.SelectedRows[0].Cells["remark"].Value.ToString();
                psa.Size = new Size(372, 550);
                psa.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kindly select a valid row", "Data Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView1.ReadOnly = false;
            updateParty();
        }

        private void btndlt_Click(object sender, EventArgs e)
        {
            deleteparty();
            
        }

        private void deleteparty()
        {
            SqlConnection con = new SqlConnection(log.constr);
            if (DataGridView1.SelectedRows[0].Index > -1 && DataGridView1.SelectedRows[0].Index <= dt.Rows.Count - 1)
            {
                
                String psid =  DataGridView1.SelectedRows[0].Cells["partyid"].Value.ToString();
                cmd = new SqlCommand("delete  partysetup where party_id ='"+psid.ToString()+"' ", con);
                try
                {
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Data deleted successfully", "Data Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        partyclear();
                        load();

                    }
                    else
                    {
                        MessageBox.Show("Data not deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    

                }
                catch(SqlException ex) 
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    con.Close();
                    con.Dispose();
                }
                
                
            }
            else
            {
                MessageBox.Show("Kindly select a valid row", "Data Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            partyclear();
        }

        public void partyclear()
        {
            DataGridView1.Rows.Clear();
            DataGridView1.Refresh();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(log.constr);
           
            String ptnm_search = txtnm.Text + "%" ;
            cmd = new SqlCommand("select * from partysetup where pt_name like '"+ptnm_search+"' ", con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();

            try
            {
                con.Open();
                partyclear();
                da.Fill(dt);
                foreach (DataRow drow in dt.Rows)
                {
                    string[] strdata = { "", drow["party_id"].ToString(), drow["pt_name"].ToString(), drow["pt_type"].ToString(), drow["addrs"].ToString(), drow["cont_no"].ToString(), drow["email"].ToString(), drow["pan_no"].ToString(), drow["gst_no"].ToString(), drow["statecode"].ToString(), drow["payment_mode"].ToString(), drow["details"].ToString(), drow["remark"].ToString() };

                    DataGridView1.Rows.Add(strdata);
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
                                                                                      
        }
    }
}

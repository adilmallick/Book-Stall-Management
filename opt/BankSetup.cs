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
    public partial class BankSetup : Form
    {
        public BankSetup()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            BankSetupAdd bsa = new BankSetupAdd(this);
            bsa.ShowDialog();
        }

        private void BankSetup_Load(object sender, EventArgs e)
        {
            load(true);
        }

        internal void load(bool search)
        {
            
            SqlConnection con = new SqlConnection(log.constr);
            SqlCommand cmd = new SqlCommand();
            if (!search)
            {
                String acno_search = txtnm.Text + "%";
                cmd = new SqlCommand("select * from partysetup where pt_name like '" + acno_search + "' ", con);
            }
            else
            {
                cmd = new SqlCommand("select * from banksetup", con);
            }


           SqlDataAdapter da = new SqlDataAdapter(cmd);
        
           DataTable dt = new DataTable();
            try
            {
                con.Open();
                da.Fill(dt);
                foreach (DataRow drow in dt.Rows)
                {
                    string[] strdata = { "", drow["holder_name"].ToString(), drow["bank_name"].ToString(), drow["actype"].ToString(), drow["acno"].ToString(), drow["ifsc"].ToString(), drow["micr"].ToString(), drow["branch"].ToString(), drow["addrs"].ToString(), drow["remark"].ToString() };
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
        }

        private void DataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.DataGridView1.Rows[e.RowIndex].Cells["serialno"].Value = (e.RowIndex + 1).ToString();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            updateDelete(false);
        }

        internal void updateDelete(bool delete)
        {
            SqlConnection con = new SqlConnection(log.constr);
            SqlCommand cmd = new SqlCommand("select * from banksetup", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                da.Fill(dt);
               
                if (DataGridView1.SelectedRows[0].Index > -1 && DataGridView1.SelectedRows[0].Index <= dt.Rows.Count - 1 )
                {
                    if (!delete)
                    {
                        BankSetupAdd bsa = new BankSetupAdd(this);
                        bsa.isAdd = false;
                        bsa.holdername.Text = DataGridView1.SelectedRows[0].Cells["holdername"].Value.ToString();
                        bsa.bankname.Text = DataGridView1.SelectedRows[0].Cells["bankname"].Value.ToString();
                        bsa.acctype.Text = DataGridView1.SelectedRows[0].Cells["acctype"].Value.ToString();
                        bsa.accno.Text = DataGridView1.SelectedRows[0].Cells["accno"].Value.ToString();
                        bsa.ifsc.Text = DataGridView1.SelectedRows[0].Cells["ifsc"].Value.ToString();
                        bsa.micr.Text = DataGridView1.SelectedRows[0].Cells["micr"].Value.ToString();
                        bsa.branch.Text = DataGridView1.SelectedRows[0].Cells["branch"].Value.ToString();
                        bsa.address.Text = DataGridView1.SelectedRows[0].Cells["address"].Value.ToString();
                        bsa.remark.Text = DataGridView1.SelectedRows[0].Cells["remark"].Value.ToString();
                        bsa.ShowDialog();
                    }
                    else
                    {

                        if (MessageBox.Show("Are you sure?", "Data Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            String account = DataGridView1.SelectedRows[0].Cells["accno"].Value.ToString();
                            cmd = new SqlCommand("delete  banksetup where acno ='" + account.ToString() + "' ", con);
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                bankclear();
                                load(true);
                                MessageBox.Show("Data deleted successfully", "Data Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);



                            }
                            else
                            {
                                MessageBox.Show("Data not deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                   
                }
                else
                {
                    MessageBox.Show("Kindly select a valid row", "Data Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
                da.Dispose();
                dt.Dispose();
            }

        }


        public void bankclear()
        {
            DataGridView1.Rows.Clear();
            DataGridView1.Refresh();
        }

        private void btndlt_Click(object sender, EventArgs e)
        {
           

                updateDelete(true);
            


        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            bankclear();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            updateDelete(false);
        }

        private void BankSetup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

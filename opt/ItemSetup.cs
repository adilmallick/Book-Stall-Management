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
    public partial class ItemSetup : Form
    {
        private DataTable dt;
        SqlCommandBuilder cmdbld;
        SqlCommand cmd;
        SqlDataAdapter da;
        public ItemSetup()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            ItemSetupAdd a = new ItemSetupAdd(this);
            a.ShowDialog();
        }



        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ItemSetup_Load(object sender, EventArgs e)
        {
            load();
        }

        internal void load()
        {
            SqlConnection con = new SqlConnection(log.constr);
            cmd = new SqlCommand("select * from itemsetup", con);

            da = new SqlDataAdapter(cmd);
            cmdbld = new SqlCommandBuilder(da);
            dt = new DataTable();
            try
            {
                con.Open();
                da.Fill(dt);
                foreach (DataRow drow in dt.Rows)
                {

                    string[] strdata = { "", drow["book_name"].ToString(), drow["isbn_code"].ToString(), drow["pub_comp"].ToString(), drow["gst"].ToString(), drow["cgst"].ToString(), drow["sgst"].ToString(), drow["remark"].ToString() };

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
            SqlCommand cmdtxt = new SqlCommand("select book_name from itemsetup", con);

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
            UpdateItem();
        }

        public void UpdateItem()
        {

            if (DataGridView1.SelectedRows[0].Index > -1 && DataGridView1.SelectedRows[0].Index <= dt.Rows.Count - 1 && DataGridView1.SelectedRows != null)
            {
                                                          
                ItemSetupAdd psa = new ItemSetupAdd(this);
                psa.isAdd = false;
                psa.txtbooknm.Text = DataGridView1.SelectedRows[0].Cells["bookname"].Value.ToString();
                psa.txtisbncode.Text = DataGridView1.SelectedRows[0].Cells["itemcode"].Value.ToString();
                psa.txtisbncode.ReadOnly = true;
                psa.txtpublishers.Text = DataGridView1.SelectedRows[0].Cells["publishers"].Value.ToString();
                psa.txtgst.Text = DataGridView1.SelectedRows[0].Cells["gst"].Value.ToString();
                psa.txtcgst.Text = DataGridView1.SelectedRows[0].Cells["cgst"].Value.ToString();
                psa.txtsgst.Text = DataGridView1.SelectedRows[0].Cells["sgst"].Value.ToString();
                psa.txtremark.Text = DataGridView1.SelectedRows[0].Cells["remark"].Value.ToString();
              
                psa.Size = new Size(372, 550);
                psa.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kindly select a valid row", "Data Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            itemclear();
        }
        public void itemclear()
        {
            DataGridView1.Rows.Clear();
            DataGridView1.Refresh();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateItem();
        }

        private void btndlt_Click(object sender, EventArgs e)
        {
            deleteitem();
        }

        private void deleteitem()
        {
            if (DataGridView1.SelectedRows[0].Index > -1 && DataGridView1.SelectedRows[0].Index <= dt.Rows.Count - 1)
            {

                String isbn_code = DataGridView1.SelectedRows[0].Cells["itemcode"].Value.ToString();
                SqlConnection con = new SqlConnection(log.constr);
                cmd = new SqlCommand("delete  itemsetup where isbn_code ='" + isbn_code.ToString() + "' ", con);
                try
                {
                    //log.con.Open();
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Data deleted successfully", "Data Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //log.con.Close();
                        itemclear();
                        
                        load();
                    }
                    else
                    {
                        MessageBox.Show("Data not deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                  


                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    //log.con.Close();
                    //log.con.Dispose();
                    con.Close();
                }


            }
            else
            {
                MessageBox.Show("Kindly select a valid row", "Data Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            String constr = "Data Source=LAPTOP-3G9KFH97; Initial Catalog=OPTBS; Integrated Security=true";
            SqlConnection con = new SqlConnection(constr);
            String booknm_search = txtnm.Text + "%";
            cmd = new SqlCommand("select * from itemsetup where book_name like '" + booknm_search + "' ", con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();

            try
            {
                con.Open();
                itemclear();
                da.Fill(dt);
                foreach (DataRow drow in dt.Rows)
                {
                    string[] strdata = { "", drow["book_name"].ToString(), drow["isbn_code"].ToString(), drow["pub_comp"].ToString(), drow["gst"].ToString(), drow["cgst"].ToString(), drow["sgst"].ToString(), drow["remark"].ToString() };

                    DataGridView1.Rows.Add(strdata);
                }
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
        }
    }
}

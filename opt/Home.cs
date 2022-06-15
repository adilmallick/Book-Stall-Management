using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace opt
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            customizeDesing();
        }
           //set the submenu hidden
        private void customizeDesing()
        { 
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panel1.Visible == true)
                panel1.Visible = false;
            if (panel2.Visible == true)
                panel2.Visible = false;
            if (panel3.Visible == true)
                panel3.Visible = false;
            if (panel4.Visible == true)
                panel4.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        

        private void aDMINToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rEPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pARTYSETUPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sALEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
          //  Form1.Visible = false;
            //Task.Factory.StartNew(() => Login());
            
        }

        //private void Login()
        //{
        //    try
        //    {
        //        Login login = new Login();
        //        DialogResult dr = login.ShowDialog();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void button1_Click(object sender, EventArgs e) ////DASHBOARD btn
        {
            //openChildForm(new DashBoard());
            hideSubMenu();
            Dashboard dBord = new Dashboard();
            dBord.Size = new Size(700, 540);
            dBord.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) ////MASTER btn
        {
            showSubMenu(panel1);
            btnaccountsetup.BackColor = Color.FromArgb(11, 7, 17);
            button4.BackColor = Color.FromArgb(11, 7, 17);
            button5.BackColor = Color.FromArgb(11, 7, 17);
            button6.BackColor = Color.FromArgb(11, 7, 17);
            button1.BackColor = Color.FromArgb(11, 7, 17);
        }
        private void button3_Click(object sender, EventArgs e) //Account subbtn
        {
            //openChildForm(new AccountSetup());
            AccountSetup accSetup = new AccountSetup();
            accSetup.Size = new Size(370, 555);
            accSetup.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e) //Bank Setup sunbtn
        {
            //openChildForm(new BankSetup());
            BankSetup bs = new BankSetup();
            bs.Size = new Size(780, 545);
            bs.ShowDialog();
        }
        private void button5_Click(object sender, EventArgs e) //Party Setup subbtn
        {
            //openChildForm(new PartySetup());
            PartySetup ps = new PartySetup();
            ps.Size = new Size(780, 545);
            ps.ShowDialog();
        }
        private void button6_Click(object sender, EventArgs e) //Item setup subbtn
        {
            //openChildForm(new ItemSetup());
            ItemSetup isp = new ItemSetup();
            isp.Size = new Size(780, 545);
            isp.ShowDialog();
        }
        private void button1_Click_1(object sender, EventArgs e) //Terms & Condition subbtn
        {
            //openChildForm(new TermsAndCondition());
            TermsAndCondition ta = new TermsAndCondition();
            ta.Size = new Size(780, 545);
            ta.ShowDialog();
        }

        private void button10_Click_1(object sender, EventArgs e) ////Purchase btn
        {
            hideSubMenu();
            Purchase ps = new Purchase();
            ps.Size = new Size(780, 545);//380, 545
            ps.ShowDialog();
        }
        private void button11_Click(object sender, EventArgs e) ////BILLING btn
        {
            showSubMenu(panel2);
            button9.BackColor = Color.FromArgb(11, 7, 17);
            button8.BackColor = Color.FromArgb(11, 7, 17);
        }
        private void button9_Click(object sender, EventArgs e) //Sale subbtn
        {
            //openChildForm(new Sale());
            // hideSubMenu();
            Sale sl = new Sale();
            sl.Size = new Size(914, 640);
            sl.ShowDialog();
        }
        private void button8_Click(object sender, EventArgs e) //Return subbtn
        {
            //openChildForm(new Return());
            // hideSubMenu();
            Return rtn = new Return();
            rtn.Size = new Size(914, 640);
            rtn.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e) ////TRANSACTION btn
        {
            showSubMenu(panel3);
            button13.BackColor = Color.FromArgb(11, 7, 17);
            button12.BackColor = Color.FromArgb(11, 7, 17);
            button7.BackColor = Color.FromArgb(11, 7, 17);
        }
        private void button13_Click(object sender, EventArgs e) //Customer subbtn
        {
            //openChildForm(new Customer());
            Customer c = new Customer();
            c.Size = new Size(780, 545);
            c.ShowDialog();
        }
        private void button13_Click_1(object sender, EventArgs e) //Customer subbtn
        {
            //openChildForm(new Customer());
            Customer c = new Customer();
            c.Size = new Size(780, 545);
            c.ShowDialog();
        }
        private void button12_Click(object sender, EventArgs e) //Party subbtn //Cus
        {
            //openChildForm(new Party());
            Party p = new Party();
            p.Size = new Size(780, 545);
            p.ShowDialog();
        }
        private void button7_Click(object sender, EventArgs e) //Expense subbtn
        {
            //openChildForm(new Expense());
            Expense ex = new Expense();
            ex.Size = new Size(780, 545);
            ex.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e) ////STOCK btn
        {
            //openChildForm(new Stock());
            hideSubMenu();
            Stock st = new Stock();
            st.Size = new Size(780, 545);
            st.ShowDialog();
        }

        private void button16_Click_1(object sender, EventArgs e) ////SETTING btn
        {
            showSubMenu(panel4);
            button17.BackColor = Color.FromArgb(11, 7, 17);
            button18.BackColor = Color.FromArgb(11, 7, 17);
            button19.BackColor = Color.FromArgb(11, 7, 17);
            button20.BackColor = Color.FromArgb(11, 7, 17);
        }
        private void button17_Click_1(object sender, EventArgs e) //Admin subbtn
        {
            //openChildForm(new Admin());
            AdminAdd am = new AdminAdd();
            //am.Size = new Size(780, 545);
            am.ShowDialog();
        }
        private void button18_Click_1(object sender, EventArgs e) //User subbtn
        {
            //openChildForm(new User());
            User ur = new User();
            ur.Size = new Size(780, 545);
            ur.ShowDialog();
        }
        private void button19_Click_1(object sender, EventArgs e) //Database Backup subbtn
        {
            //openChildForm(new DatabaseBackup());
            DatabaseBackup db = new DatabaseBackup();
            db.ShowDialog();
        }
        private void button20_Click_1(object sender, EventArgs e) //Database User subbtn
        {
            openChildForm(new DatabaseRestoref());
            //DatabaseRestoref dr = DatabaseRestoref();
            //dr.ShowDialog();
        }

        private void button15_Click_1(object sender, EventArgs e) ////REPORT btn
        {
            //openChildForm(new Report());
            hideSubMenu();
            Report rp = new Report();
            rp.Size = new Size(350, 150);
            rp.ShowDialog();
        }

        private void button21_Click_1(object sender, EventArgs e) ////HELP btn
        {
            openChildForm(new Help());
            hideSubMenu();
        }

        private void button22_Click_1(object sender, EventArgs e) ////EXIT btn
        {
            System.Windows.Forms.Application.ExitThread();
            //Application.Exit(); //or
        }

        //May be these parts are repeated;
        /* 
        private void button15_Click(object sender, EventArgs e)
        {
            openChildForm(new Report());
        }

        private void button16_Click(object sender, EventArgs e)
        {
            showSubMenu(panel4);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Admin adm = new Admin();
            adm.Show();
            hideSubMenu();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            User a = new User();
            a.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            openChildForm(new DatabaseBackup());
            hideSubMenu();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            openChildForm(new DatabaseUser());
            hideSubMenu();
        }
        */

        //to show the child form in Body panel
        private Form ActiveForm = null;
        private void openChildForm(Form childForm)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        //Hover & Colour
        private void btndashboard_MouseHover(object sender, EventArgs e)
        {
            btndashboard.BackColor = Color.Magenta;
        }

        private void btndashboard_MouseLeave(object sender, EventArgs e)
        {
            btndashboard.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void btnaccountsetup_MouseHover(object sender, EventArgs e)
        {
            btnaccountsetup.BackColor = Color.FromArgb(212, 24, 29);
        }

        private void btnaccountsetup_MouseLeave(object sender, EventArgs e)
        {
            btnaccountsetup.BackColor = Color.FromArgb(35, 32, 39);
        }

        private void btnmastersetup_MouseHover(object sender, EventArgs e)
        {
            btnmastersetup.BackColor = Color.Magenta;
        }

        private void btnmastersetup_MouseLeave(object sender, EventArgs e)
        {
            btnmastersetup.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(212, 24, 29);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(35, 32, 39);
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(212, 24, 29);
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(35, 32, 39);
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(212, 24, 29);
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(35, 32, 39);
        }

        private void button11_MouseHover(object sender, EventArgs e)
        {
            button11.BackColor = Color.Magenta;
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void button10_MouseHover(object sender, EventArgs e)
        {
            button10.BackColor = Color.FromArgb(212, 24, 29);
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.BackColor = Color.FromArgb(35, 32, 39);
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            button9.BackColor = Color.FromArgb(212, 24, 29);
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackColor = Color.FromArgb(35, 32, 39);
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            button8.BackColor = Color.FromArgb(212, 24, 29);
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.FromArgb(35, 32, 39);
        }

        private void button14_MouseHover(object sender, EventArgs e)
        {
            button14.BackColor = Color.Magenta;
        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {
            button14.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void button13_MouseHover(object sender, EventArgs e)
        {
            button13.BackColor = Color.FromArgb(212, 24, 29);
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            button13.BackColor = Color.FromArgb(35, 32, 39);
        }

        private void button12_MouseHover(object sender, EventArgs e)
        {
            button12.BackColor = Color.FromArgb(212, 24, 29);
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            button12.BackColor = Color.FromArgb(35, 32, 39);
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            button7.BackColor = Color.FromArgb(212, 24, 29);
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.FromArgb(35, 32, 39);
        }

        private void button15_MouseHover(object sender, EventArgs e)
        {
            button15.BackColor = Color.Magenta;
        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            button15.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void button16_MouseHover(object sender, EventArgs e)
        {
            button16.BackColor = Color.Magenta;
        }

        private void button16_MouseLeave(object sender, EventArgs e)
        {
            button16.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void button17_MouseHover(object sender, EventArgs e)
        {
            button17.BackColor = Color.FromArgb(212, 24, 29);
        }

        private void button17_MouseLeave(object sender, EventArgs e)
        {
            button17.BackColor = Color.FromArgb(35, 32, 39);
        }

        private void button18_MouseHover(object sender, EventArgs e)
        {
            button18.BackColor = Color.FromArgb(212, 24, 29);
        }

        private void button18_MouseLeave(object sender, EventArgs e)
        {
            button18.BackColor = Color.FromArgb(35, 32, 39);
        }

        private void button19_MouseHover(object sender, EventArgs e)
        {
            button19.BackColor = Color.FromArgb(212, 24, 29);
        }

        private void button19_MouseLeave(object sender, EventArgs e)
        {
            button19.BackColor = Color.FromArgb(35, 32, 39);
        }

        private void button20_MouseHover(object sender, EventArgs e)
        {
            button20.BackColor = Color.FromArgb(212, 24, 29);
        }

        private void button20_MouseLeave(object sender, EventArgs e)
        {
            button20.BackColor = Color.FromArgb(35, 32, 39);
        }

        private void button21_MouseHover(object sender, EventArgs e)
        {
            button21.BackColor = Color.Magenta;
        }

        private void button21_MouseLeave(object sender, EventArgs e)
        {
            button21.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void button22_MouseHover(object sender, EventArgs e)
        {
            button22.BackColor = Color.Magenta;
        }

        private void button22_MouseLeave(object sender, EventArgs e)
        {
            button22.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void button17_MouseHover_1(object sender, EventArgs e)
        {
            button17.BackColor = Color.FromArgb(212, 24, 29);
        }

        private void button17_MouseLeave_1(object sender, EventArgs e)
        {
            button17.BackColor = Color.FromArgb(35, 32, 39);
        }

        private void button18_MouseHover_1(object sender, EventArgs e)
        {
            button18.BackColor = Color.FromArgb(212, 24, 29);
        }

        private void button18_MouseLeave_1(object sender, EventArgs e)
        {
            button18.BackColor = Color.FromArgb(35, 32, 39);
        }

        private void button19_MouseHover_1(object sender, EventArgs e)
        {
            button19.BackColor = Color.FromArgb(212, 24, 29);
        }

        private void button19_MouseLeave_1(object sender, EventArgs e)
        {
            button19.BackColor = Color.FromArgb(35, 32, 39);
        }

        private void button20_MouseHover_1(object sender, EventArgs e)
        {
            button20.BackColor = Color.FromArgb(212, 24, 29);
        }

        private void button20_MouseLeave_1(object sender, EventArgs e)
        {
            button20.BackColor = Color.FromArgb(35, 32, 39);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(212, 24, 29);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(35, 32, 39);
        }

        private void btnaccountsetup_MouseDown(object sender, MouseEventArgs e)
        {
            btnaccountsetup.BackColor = Color.Gray;
        }

        private void btnaccountsetup_MouseLeave_1(object sender, EventArgs e)
        {
            btnaccountsetup.BackColor = Color.Gray;
        }

        private void btndashboard_MouseDown(object sender, MouseEventArgs e)
        {
            btndashboard.BackColor = Color.WhiteSmoke;
            btndashboard.ForeColor = Color.Black;
            btnmastersetup.BackColor = Color.FromArgb(41, 39, 40);
            btnStock.BackColor = Color.FromArgb(41, 39, 40);
            button10.BackColor = Color.FromArgb(41, 39, 40);
            button11.BackColor = Color.FromArgb(41, 39, 40);
            button15.BackColor = Color.FromArgb(41, 39, 40);
            button21.BackColor = Color.FromArgb(41, 39, 40);
            button16.BackColor = Color.FromArgb(41, 39, 40);
            button14.BackColor = Color.FromArgb(41, 39, 40);
            btnmastersetup.ForeColor = Color.Gainsboro;
            btnStock.ForeColor = Color.Gainsboro;
            button10.ForeColor = Color.Gainsboro;
            button11.ForeColor = Color.Gainsboro;
            button15.ForeColor = Color.Gainsboro;
            button21.ForeColor = Color.Gainsboro;
            button16.ForeColor = Color.Gainsboro;
            button14.ForeColor = Color.Gainsboro;
        }
        private void btnmastersetup_MouseDown(object sender, MouseEventArgs e)
        {
            btnmastersetup.BackColor = Color.WhiteSmoke;
            btnmastersetup.ForeColor = Color.Black;
            btndashboard.BackColor = Color.FromArgb(41, 39, 40);
            btnStock.BackColor = Color.FromArgb(41, 39, 40);
            button10.BackColor = Color.FromArgb(41, 39, 40);
            button11.BackColor = Color.FromArgb(41, 39, 40);
            button15.BackColor = Color.FromArgb(41, 39, 40);
            button21.BackColor = Color.FromArgb(41, 39, 40);
            button16.BackColor = Color.FromArgb(41, 39, 40);
            button14.BackColor = Color.FromArgb(41, 39, 40);
            btndashboard.ForeColor = Color.Gainsboro;
            btnStock.ForeColor = Color.Gainsboro;
            button10.ForeColor = Color.Gainsboro;
            button11.ForeColor = Color.Gainsboro;
            button15.ForeColor = Color.Gainsboro;
            button21.ForeColor = Color.Gainsboro;
            button16.ForeColor = Color.Gainsboro;
            button14.ForeColor = Color.Gainsboro;
            
        }
        private void button10_MouseDown_1(object sender, MouseEventArgs e)
        {
            button10.BackColor = Color.WhiteSmoke;
            button10.ForeColor = Color.Black;
            btnmastersetup.BackColor = Color.FromArgb(41, 39, 40);
            btndashboard.BackColor = Color.FromArgb(41, 39, 40);
            btnStock.BackColor = Color.FromArgb(41, 39, 40);
            button11.BackColor = Color.FromArgb(41, 39, 40);
            button15.BackColor = Color.FromArgb(41, 39, 40);
            button21.BackColor = Color.FromArgb(41, 39, 40);
            button16.BackColor = Color.FromArgb(41, 39, 40);
            button14.BackColor = Color.FromArgb(41, 39, 40);
            btnmastersetup.ForeColor = Color.Gainsboro;
            btndashboard.ForeColor = Color.Gainsboro;
            btnStock.ForeColor = Color.Gainsboro;
            button11.ForeColor = Color.Gainsboro;
            button15.ForeColor = Color.Gainsboro;
            button21.ForeColor = Color.Gainsboro;
            button16.ForeColor = Color.Gainsboro;
            button14.ForeColor = Color.Gainsboro;
        }
        
        private void btnStock_MouseDown(object sender, MouseEventArgs e)
        {
            btndashboard.BackColor = Color.FromArgb(41, 39, 40);
            btnStock.ForeColor = Color.Black;
            btnmastersetup.BackColor = Color.FromArgb(41, 39, 40);
            btnStock.BackColor = Color.WhiteSmoke;
            button10.BackColor = Color.FromArgb(41, 39, 40);
            button11.BackColor = Color.FromArgb(41, 39, 40);
            button15.BackColor = Color.FromArgb(41, 39, 40);
            button21.BackColor = Color.FromArgb(41, 39, 40);
            button16.BackColor = Color.FromArgb(41, 39, 40);
            button14.BackColor = Color.FromArgb(41, 39, 40);
            btndashboard.ForeColor = Color.Gainsboro;
            btnmastersetup.ForeColor = Color.Gainsboro;
            button10.ForeColor = Color.Gainsboro;
            button11.ForeColor = Color.Gainsboro;
            button15.ForeColor = Color.Gainsboro;
            button21.ForeColor = Color.Gainsboro;
            button16.ForeColor = Color.Gainsboro;
            button14.ForeColor = Color.Gainsboro;
        }
        private void button11_MouseDown(object sender, MouseEventArgs e)
        {
            btndashboard.BackColor = Color.FromArgb(41, 39, 40);
            btnStock.ForeColor = Color.Gainsboro;
            btnmastersetup.BackColor = Color.FromArgb(41, 39, 40);
            btnStock.BackColor = Color.FromArgb(41, 39, 40);
            button10.BackColor = Color.FromArgb(41, 39, 40);
            button11.BackColor = Color.WhiteSmoke;
            button15.BackColor = Color.FromArgb(41, 39, 40);
            button21.BackColor = Color.FromArgb(41, 39, 40);
            button16.BackColor = Color.FromArgb(41, 39, 40);
            button14.BackColor = Color.FromArgb(41, 39, 40);
            btndashboard.ForeColor = Color.Gainsboro;
            btnmastersetup.ForeColor = Color.Gainsboro;
            button10.ForeColor = Color.Gainsboro;
            button11.ForeColor = Color.Black;
            button15.ForeColor = Color.Gainsboro;
            button21.ForeColor = Color.Gainsboro;
            button16.ForeColor = Color.Gainsboro;
            button14.ForeColor = Color.Gainsboro;
        }
        private void button14_MouseDown(object sender, MouseEventArgs e)
        {
            btndashboard.BackColor = Color.FromArgb(41, 39, 40);
            btnStock.ForeColor = Color.Gainsboro;
            btnmastersetup.BackColor = Color.FromArgb(41, 39, 40);
            btnStock.BackColor = Color.FromArgb(41, 39, 40);
            button10.BackColor = Color.FromArgb(41, 39, 40);
            button11.BackColor = Color.FromArgb(41, 39, 40);
            button15.BackColor = Color.FromArgb(41, 39, 40);
            button21.BackColor = Color.FromArgb(41, 39, 40);
            button16.BackColor = Color.FromArgb(41, 39, 40);
            button14.BackColor = Color.WhiteSmoke;
            btndashboard.ForeColor = Color.Gainsboro;
            btnmastersetup.ForeColor = Color.Gainsboro;
            button10.ForeColor = Color.Gainsboro;
            button11.ForeColor = Color.Gainsboro;
            button15.ForeColor = Color.Gainsboro;
            button21.ForeColor = Color.Gainsboro;
            button16.ForeColor = Color.Gainsboro;
            button14.ForeColor = Color.Black;
        }
        private void button16_MouseDown(object sender, MouseEventArgs e)
        {
            btndashboard.BackColor = Color.FromArgb(41, 39, 40);
            btnStock.ForeColor = Color.Gainsboro;
            btnmastersetup.BackColor = Color.FromArgb(41, 39, 40);
            btnStock.BackColor = Color.FromArgb(41, 39, 40);
            button10.BackColor = Color.FromArgb(41, 39, 40);
            button11.BackColor = Color.FromArgb(41, 39, 40);
            button15.BackColor = Color.FromArgb(41, 39, 40);
            button21.BackColor = Color.FromArgb(41, 39, 40);
            button16.BackColor = Color.WhiteSmoke;
            button14.BackColor = Color.FromArgb(41, 39, 40);
            btndashboard.ForeColor = Color.Gainsboro;
            btnmastersetup.ForeColor = Color.Gainsboro;
            button10.ForeColor = Color.Gainsboro;
            button11.ForeColor = Color.Gainsboro;
            button15.ForeColor = Color.Gainsboro;
            button21.ForeColor = Color.Gainsboro;
            button16.ForeColor = Color.Black;
            button14.ForeColor = Color.Gainsboro;
        }
        private void button15_MouseDown(object sender, MouseEventArgs e)
        {
            btndashboard.BackColor = Color.FromArgb(41, 39, 40);
            btnStock.ForeColor = Color.Gainsboro;
            btnmastersetup.BackColor = Color.FromArgb(41, 39, 40);
            btnStock.BackColor = Color.FromArgb(41, 39, 40);
            button10.BackColor = Color.FromArgb(41, 39, 40);
            button11.BackColor = Color.FromArgb(41, 39, 40);
            button15.BackColor = Color.WhiteSmoke;
            button21.BackColor = Color.FromArgb(41, 39, 40);
            button16.BackColor = Color.FromArgb(41, 39, 40);
            button14.BackColor = Color.FromArgb(41, 39, 40);
            btndashboard.ForeColor = Color.Gainsboro;
            btnmastersetup.ForeColor = Color.Gainsboro;
            button10.ForeColor = Color.Gainsboro;
            button11.ForeColor = Color.Gainsboro;
            button15.ForeColor = Color.Black;
            button21.ForeColor = Color.Gainsboro;
            button16.ForeColor = Color.Gainsboro;
            button14.ForeColor = Color.Gainsboro;
        }
        private void button21_MouseDown(object sender, MouseEventArgs e)
        {

            btndashboard.BackColor = Color.FromArgb(41, 39, 40);
            btnStock.ForeColor = Color.Gainsboro;
            btnmastersetup.BackColor = Color.FromArgb(41, 39, 40);
            btnStock.BackColor = Color.FromArgb(41, 39, 40);
            button10.BackColor = Color.FromArgb(41, 39, 40);
            button11.BackColor = Color.FromArgb(41, 39, 40);
            button15.BackColor = Color.FromArgb(41, 39, 40);
            button21.BackColor = Color.WhiteSmoke;
            button16.BackColor = Color.FromArgb(41, 39, 40);
            button14.BackColor = Color.FromArgb(41, 39, 40);
            btndashboard.ForeColor = Color.Gainsboro;
            btnmastersetup.ForeColor = Color.Gainsboro;
            button10.ForeColor = Color.Gainsboro;
            button11.ForeColor = Color.Gainsboro;
            button15.ForeColor = Color.Gainsboro;
            button21.ForeColor = Color.Black;
            button16.ForeColor = Color.Gainsboro;
            button14.ForeColor = Color.Gainsboro;
        }

        //Master Setup Submenu MousDown
        private void btnaccountsetup_MouseDown_1(object sender, MouseEventArgs e)
        {
            btnaccountsetup.BackColor = Color.FromArgb(27, 114, 158);
            button4.BackColor = Color.FromArgb(11, 7, 17);
            button5.BackColor = Color.FromArgb(11, 7, 17);
            button6.BackColor = Color.FromArgb(11, 7, 17);
            button1.BackColor = Color.FromArgb(11, 7, 17);
        }
        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            btnaccountsetup.BackColor = Color.FromArgb(11, 7, 17);
            button4.BackColor = Color.FromArgb(27, 114, 158);
            button5.BackColor = Color.FromArgb(11, 7, 17);
            button6.BackColor = Color.FromArgb(11, 7, 17);
            button1.BackColor = Color.FromArgb(11, 7, 17);
        }
        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            btnaccountsetup.BackColor = Color.FromArgb(11, 7, 17);
            button4.BackColor = Color.FromArgb(11, 7, 17);
            button5.BackColor = Color.FromArgb(27, 114, 158);
            button6.BackColor = Color.FromArgb(11, 7, 17);
            button1.BackColor = Color.FromArgb(11, 7, 17);
        }
        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            btnaccountsetup.BackColor = Color.FromArgb(11, 7, 17);
            button4.BackColor = Color.FromArgb(11, 7, 17);
            button5.BackColor = Color.FromArgb(11, 7, 17);
            button6.BackColor = Color.FromArgb(27, 114, 158);
            button1.BackColor = Color.FromArgb(11, 7, 17);
        }
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            btnaccountsetup.BackColor = Color.FromArgb(11, 7, 17);
            button4.BackColor = Color.FromArgb(11, 7, 17);
            button5.BackColor = Color.FromArgb(11, 7, 17);
            button6.BackColor = Color.FromArgb(11, 7, 17);
            button1.BackColor = Color.FromArgb(27, 114, 158);
        }

        // Billing Submenu MousDown
        //private void button10_MouseDown(object sender, MouseEventArgs e)
        //{
        //    //button10.BackColor = Color.FromArgb(27, 114, 158);
        //    button9.BackColor = Color.FromArgb(11, 7, 17);
        //    button8.BackColor = Color.FromArgb(11, 7, 17);
        //}
        private void button9_MouseDown(object sender, MouseEventArgs e)
        {
            //button10.BackColor = Color.FromArgb(11, 7, 17);
            button9.BackColor = Color.FromArgb(27, 114, 158);
            button8.BackColor = Color.FromArgb(11, 7, 17);
        }
        private void button8_MouseDown(object sender, MouseEventArgs e)
        {
            //button10.BackColor = Color.FromArgb(11, 7, 17);
            button9.BackColor = Color.FromArgb(11, 7, 17);
            button8.BackColor = Color.FromArgb(27, 114, 158);
        }

        //Transaction Submenu MousDown
        private void button13_MouseDown(object sender, MouseEventArgs e)
        {
            button13.BackColor = Color.FromArgb(27, 114, 158);
            button12.BackColor = Color.FromArgb(11, 7, 17);
            button7.BackColor = Color.FromArgb(11, 7, 17);
        }
        private void button12_MouseDown(object sender, MouseEventArgs e)
        {
            button13.BackColor = Color.FromArgb(11, 7, 17);
            button12.BackColor = Color.FromArgb(27, 114, 158);
            button7.BackColor = Color.FromArgb(11, 7, 17);
        }
        private void button7_MouseDown(object sender, MouseEventArgs e)
        {
            button13.BackColor = Color.FromArgb(11, 7, 17);
            button12.BackColor = Color.FromArgb(11, 7, 17);
            button7.BackColor = Color.FromArgb(27, 114, 158);
        }

        // Setting Submenu MousDown
        private void button17_MouseDown(object sender, MouseEventArgs e)
        {
            button17.BackColor = Color.FromArgb(27, 114, 158);
            button18.BackColor = Color.FromArgb(11, 7, 17);
            button19.BackColor = Color.FromArgb(11, 7, 17);
            button20.BackColor = Color.FromArgb(11, 7, 17);
        }
        private void button18_MouseDown(object sender, MouseEventArgs e)
        {
            button17.BackColor = Color.FromArgb(11, 7, 17);
            button18.BackColor = Color.FromArgb(27, 114, 158);
            button19.BackColor = Color.FromArgb(11, 7, 17);
            button20.BackColor = Color.FromArgb(11, 7, 17);
        }
        private void button19_MouseDown(object sender, MouseEventArgs e)
        {
            button17.BackColor = Color.FromArgb(11, 7, 17);
            button18.BackColor = Color.FromArgb(11, 7, 17);
            button19.BackColor = Color.FromArgb(27, 114, 158);
            button20.BackColor = Color.FromArgb(11, 7, 17);
        }
        private void button20_MouseDown(object sender, MouseEventArgs e)
        {
            button17.BackColor = Color.FromArgb(11, 7, 17);
            button18.BackColor = Color.FromArgb(11, 7, 17);
            button19.BackColor = Color.FromArgb(11, 7, 17);
            button20.BackColor = Color.FromArgb(27, 114, 158);
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}

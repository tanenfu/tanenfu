using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace test1
{
    public partial class loginForm : Form
    {
        public static string connectionString = "server=.;Initial Catalog=studend;Integrated Security=SSPI";
        public static  string name;
        public static string role="";
        //public static string stuname;
        //public static string manname;
       
        public loginForm()
        {
            

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBoxname.Text.Trim();
            if (name == "")
                MessageBox.Show("请输入用户名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (textBoxpasswd.Text.Trim() == "")
                MessageBox.Show("请输入用户密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (role == "")
                    MessageBox.Show("请选择您的登录身份！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SqlConnection conn = new SqlConnection(loginForm.connectionString);
                conn.Open();
                if (role == "学生")
                {
                    string sql1 = "select * from student where stuxuehao='" + name + "'and stupasswd='" + textBoxpasswd.Text.Trim() + "'";
                    string sql2 = "select * from manager where manname='" + name + "' and manpasswd='" + textBoxpasswd.Text.Trim() + "'";
                    SqlDataAdapter adp = new SqlDataAdapter(sql1, conn);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        SqlCommand cmd = new SqlCommand(sql1, conn);
                        SqlDataReader dr = cmd.ExecuteReader();
                        dr.Read();
                        //this.Close();
                        Program.stuname = dr.GetValue(1).ToString().Trim();
                        conn.Close();
                        Form3 mainframe = new Form3();
                        mainframe.BringToFront();
                        mainframe.Show();
                        this.Hide();

                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand(sql2, conn);
                        SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                        DataSet ds1 = new DataSet();
                        adp1.Fill(ds1);
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            MessageBox.Show("您的登录权限不是学生，请确认后重试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            radioButton1_xs.Checked = false;
                            radioButton2_gly.Checked = false;
                        }
                        else
                            MessageBox.Show("用户名或密码错误,请确认后重输！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (role == "管理员")
                {
                    string sql1 = "select * from manager where manname='" + name + "' and manpasswd='" + textBoxpasswd.Text.Trim() + "'";
                    string sql2 = "select * from student where stuxuehao='" + name + "'and stupasswd='" + textBoxpasswd.Text.Trim() + "'";
                    SqlDataAdapter adp = new SqlDataAdapter(sql1, conn);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        Program.manname = this.textBoxname.Text.Trim();
                        conn.Close();
                        Form1 mainframe = new Form1();
                        mainframe.BringToFront();
                        mainframe.Show();
                        this.Hide();
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand(sql2, conn);
                        SqlDataAdapter adp1 = new SqlDataAdapter(cmd);
                        DataSet ds1 = new DataSet();
                        adp1.Fill(ds1);
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            MessageBox.Show("您的登录权限不是管理员，请确认后重试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            radioButton1_xs.Checked = false;
                            radioButton2_gly.Checked = false;
                        }
                        else
                            MessageBox.Show("用户名或密码错误,请确认后重输！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void loginForm_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            radioButton1_xs.BackColor = Color.Transparent;
            radioButton2_gly.BackColor = Color.Transparent;
            
        }

        private void comboBoxrole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public static  String getStudent()
        {
            String stuxuehao = "";
            stuxuehao = loginForm.name;
            return stuxuehao;
        }

        public static String getRole()
        {
            String role1 = "";
            role1 = role;
            return role1;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_xs_CheckedChanged(object sender, EventArgs e)
        {
            role = "学生";
        }

        private void radioButton2_gly_CheckedChanged(object sender, EventArgs e)
        {
            role = "管理员";
        }

     

       

       


      

       
       


    }
}

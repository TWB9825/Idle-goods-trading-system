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
namespace 闲置物品交易系统
{
    public partial class Form2 : Form
    {
        //string link = "";
        //string flag = "";
        public Form2()
        {
            InitializeComponent();
        }
        public void clearAll()
        {
            registerUserText.Text = "";
            registerSchoolText.Text = "";
            registerPhoneText.Text = "";
            registerEmailText.Text = "";
            registerPwdText.Text = "";
            registerPwdAgainText.Text = "";
        }

        private void registerConfimButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            string userName = "", school= "", phone = "", email= "", pwd= "";
            if(registerUserText.Text == "")  //获得用户名
            {
                MessageBox.Show("对不起，您未输入用户名!");
                return;
            }
            else                        
            {
                userName = registerUserText.Text;
            }
            if (registerSchoolText.Text == "")  //获得学校名
            {
                MessageBox.Show("对不起，您未输入学校!");
                return;
            }
            else
            {
                school = registerSchoolText.Text;
            }
            if (registerPhoneText.Text == "")    //获得电话
            {
                MessageBox.Show("对不起，您未输入电话!");
                return;
            }
            else
            {
                phone = registerPhoneText.Text;
            }
            if (registerPwdText.Text == "")      //获得密码
            {
                MessageBox.Show("对不起，您未输入密码!");
                return;
            }          
            if (registerPwdAgainText.Text == "")
            {
                MessageBox.Show("对不起，请再次输入密码!");
                return;
            }
            if (registerPwdText.Text != registerPwdAgainText.Text)
            {
                MessageBox.Show("对不起，两次输入的密码不一样!");
                return;
            }
            else
            {
                pwd = registerPwdAgainText.Text;
            }
            if(registerEmailText.Text != "")    //获得邮箱
            {
                email = registerEmailText.Text;
            }
            //连接数据库
            string con, sql = ""; 
            con = "Server=.;Database=keshe;user id = sa;password = 316023";
            if (registerEmailText.Text == "")
            {
                sql = string.Format("insert into usr (Uname,Uschool,Uphone,Upwd) values('{0}','{1}','{2}','{3}')",userName,school,phone,pwd);
            }
            else
            {
                sql = string.Format("insert into usr (Uname,Uschool,Uphone,Upwd,Uemail) values('{0}','{1}','{2}','{3}','{4}')", userName, school, phone, pwd,email);
            }
            SqlConnection myCon = new SqlConnection(con);
            myCon.Open();
            SqlCommand myCom = new SqlCommand(sql, myCon);
            myCom.ExecuteNonQuery();
            myCon.Close();
            MessageBox.Show("恭喜，注册成功！");
            form1.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Location = new Point(300, 150);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void registerClearButton_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void registerCancelButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void registerUserText_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                registerSchoolText.Focus();
            }
        }

        private void registerSchoolText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                registerPhoneText.Focus();
            }
        }

        private void registerPhoneText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                registerEmailText.Focus();
            }
        }

        private void registerEmailText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                registerPwdText.Focus();
            }
        }

        private void registerPwdText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                registerPwdAgainText.Focus();
            }
        }

        private void registerPwdAgainText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                registerConfimButton_Click(sender, e);
                e.SuppressKeyPress = false;
            }
        }
    }
}

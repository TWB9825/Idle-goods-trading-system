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
    public partial class Form1 : Form
    {
        public Form2 form2 = new Form2();
        public Form3 form3 = new Form3();
        string username = "";       //读取文本框中的用户名
        string password = "";       //读取文本框中的密码
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(300, 150);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

            form2.Show();
            this.Hide();
        }

        private void SignButton_Click(object sender, EventArgs e)
        {
            int flag = 0;

            string[] uName = new string[100];  //用于读取数据库中符合条件的用户名
            string[] uPwd = new string[100];   //读取相应的密码
            if(signInUserText.Text != "")
            {
                username = signInUserText.Text;
            }
            else
            {
                MessageBox.Show("请输入用户名!");
                return;
            }
            if(signInPwdText.Text != "")
            {
                password = signInPwdText.Text;
            }
            else
            {
                MessageBox.Show("请输入密码！");
            }
            string con, sql1 = "",sql2 = "";
            con = "Server=.;Database=keshe;user id = sa;password = 316023";
            sql1 = string.Format("select Uname,Upwd from usr where Uname = '{0}'", username);
            //sql = "select * from usr_table";
            SqlConnection myCon = new SqlConnection(con);
            myCon.Open();
            SqlCommand myCom = new SqlCommand(sql1, myCon);
            int r = 0;
            SqlDataReader myReader = myCom.ExecuteReader();
            while(myReader.Read())
            {
                r++;
            }
            myCon.Close();
            if(r == 0 )
            {
                MessageBox.Show("对不起，您尚未注册！");
            }
            else
            {
                myCon.Open();
                SqlDataReader myReader1 = myCom.ExecuteReader();
                int i = 0;
                while (myReader1.Read())
                {
                    uName[i] = myReader1.GetString(0);
                    uPwd[i] = myReader1.GetString(1);
                    i++;
                }
                for(int j = 0; j<i;j++)
                {

                    string m = uPwd[j];
                    if(m == password)
                    {
                        flag = 1;
                        myCon.Close();
                        con = "Server=.;Database=keshe;user id = sa;password = 316023";
                        SqlConnection myCon1 = new SqlConnection(con);
                        myCon1.Open();
                        sql2 = string.Format("delete from stayUser;insert into stayUser values('{0}')", uName[j]);
                        SqlCommand myCom2 = new SqlCommand(sql2, myCon1);
                        myCom2.ExecuteNonQuery();
                        myCon1.Close();
                        form3.Show();
                        this.Hide();
                        break;
                    }
                }
                if(flag!=1)
                {
                    MessageBox.Show("对不起，密码输入错误！");
                    signInPwdText.Text = "";
                    signInPwdText.Focus();
                }
            }
        }

        private void signInUserText_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                signInPwdText.Focus();
            }
        }

        private void signInPwdText_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SignButton_Click(sender, e);
                e.SuppressKeyPress = false;
            }
        }

        private void signInPwdText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form5 : Form
    {
        string link = "", flag = "";
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.Location = new Point(300, 150);
            string con = "", sql = "";
            con = "Server=.;Database=keshe;user id = sa;password = 316023";
            SqlConnection myCon = new SqlConnection(con);
            myCon.Open();
            sql = "select * from pitureTable";
            SqlCommand myCom = new SqlCommand(sql, myCon);
            SqlDataReader myreader = myCom.ExecuteReader();
            while (myreader.Read())
            {
                link = myreader.GetString(0);

            }
            myCon.Close();
            flag = link.Substring(link.Length - 1, 1);
            if (flag == "0")
            {
                link = link.Substring(0, link.Length - 1);              
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //打开文件对话窗口
            OpenFileDialog ofd = new OpenFileDialog();
            //对话窗口默认打开路径
            ofd.InitialDirectory = @"C:\Users\hjacker\Desktop";
            //对话窗口名字
            ofd.Title = "请选择文件";
            //打开文件的后缀名
            ofd.Filter = "所有文件|*.jpg";

            ofd.ShowDialog();
            //将打开文件的路径显示在文本框内
            picText.Text = ofd.FileName;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameText.Text = "";
            introText.Text = "";
            priceText.Text = "";
            picText.Text = "";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

            if (flag == "0")
            {
                changeImfor chanInfo = new changeImfor();
                chanInfo.Show();
                this.Hide();
            }
            else
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();

            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string introduce = "", name = "", priceString = "", picLink = "",uname = "";
            string time;
            time = DateTime.Now.ToString("yyyyMMdd");
            float price;
            if(nameText.Text == "")
            {
                MessageBox.Show("对不起，您的宝贝没有名称!");
                return;
            }
            name = nameText.Text;
            if(introText.Text == "")
            {
                MessageBox.Show("对不起，请为您的宝贝介绍一下！");
                return;
            }
            introduce = introText.Text;
            if(priceText.Text == "")
            {
                MessageBox.Show("对不起，请为您的宝贝添加价格!");
                return;
            }
            priceString = priceText.Text;
            if(picText.Text == "")
            {
                MessageBox.Show("对不起，请问您的宝贝添加图片");
                return;
            }
            picLink = picText.Text;
            string con, sql1 = "",sql2 = "";
            price = Convert.ToSingle(priceString);
            con = "Server=.;Database=keshe;user id = sa;password = 316023";
            sql1 = "select * from stayUser";
            SqlConnection myCon = new SqlConnection(con);
            myCon.Open();
            SqlCommand myCom = new SqlCommand(sql1, myCon);
            SqlDataReader myReader = myCom.ExecuteReader();
            while (myReader.Read())
            {
                uname = myReader.GetString(0);
            }
            myCon.Close();

            myCon.Open();
            if(flag == "0")
            {
                sql2 = string.Format("delete from thing where Tpic = '{0}';insert into thing values('{1}','{2}','{3}','{4}','{5}',{6})",link, uname, name, introduce, picLink, time, price);
                MessageBox.Show("修改成功!");
            }
            else
            {
                sql2 = string.Format("insert into thing values('{0}','{1}','{2}','{3}','{4}',{5})", uname, name, introduce, picLink, time, price);
                MessageBox.Show("添加成功!");
            }  
            SqlCommand myCom1 = new SqlCommand(sql2, myCon);
            myCom1.ExecuteNonQuery();
            myCon.Close();
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(flag == "0")
            {
                changeImfor chanInfo = new changeImfor();
                chanInfo.Show();
                this.Hide();
            }
            else
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
                
            }
        }

        private void nameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                introText.Focus();
            }
        }

        private void introText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                priceText.Focus();
            }
        }

        private void priceText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
                e.SuppressKeyPress = false;
            }
        }

        private void picText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                confirmButton_Click(sender, e);
                e.SuppressKeyPress = false;
            }
        }
    }
}

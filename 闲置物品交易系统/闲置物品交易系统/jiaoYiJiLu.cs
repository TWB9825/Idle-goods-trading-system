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
    public partial class jiaoYiJiLu : Form
    {
        string[] thingName = new string[200];
        string[] pictures = new string[200];
        string[] buyTime = new string[200];
        int i = 0;

        int r;//执行sql语句影响的条数
        string name = "";
        public jiaoYiJiLu()
        {
            InitializeComponent();
        }
        //显示图片
        public void showPictureAndName(int m)
        {
            if (i == 0)
            {
                backButton.Enabled = false;
            }
            else
            {
                backButton.Enabled = true;
            }
            if (pictures[m * 4 + 0] != null && (m * 4 + 0) < r)
            {
                pictureBox1.Image = Image.FromFile(pictures[m * 4 + 0]);
                pictureBox1.ImageLocation = pictures[m * 4 + 0];
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                label1.Text = thingName[m * 4 + 0];
                //label1.TextAlign = ContentAlignment.MiddleCenter;
                label5.Text = DateTime.ParseExact(buyTime[m * 4 + 0], "yyyyMMdd", null).ToString("yyyy-MM-dd");
                label5.TextAlign = ContentAlignment.MiddleCenter;
                    nextButton.Enabled = true;
            }
            else
            {
                nextButton.Enabled = false;
                pictureBox1.Image = null;
                label1.Text = "";
                label5.Text = "";
                pictureBox2.Image = null;
                label2.Text = "";
                label6.Text = "";
                pictureBox3.Image = null;
                label3.Text = "";
                pictureBox4.Image = null;
                label4.Text = "";
                label7.Text = "";
                label8.Text = "";

                return;
            }
            if (pictures[m * 4 + 1] != null && (m * 4 + 1) < r)
            {
                pictureBox2.Image = Image.FromFile(pictures[m * 4 + 1]);
                pictureBox2.ImageLocation = pictures[m * 4 + 1];
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                label2.Text = thingName[m * 4 + 1];
                //label2.TextAlign = ContentAlignment.MiddleCenter;
                label6.Text = DateTime.ParseExact(buyTime[m * 4 + 1], "yyyyMMdd", null).ToString("yyyy-MM-dd");
                label6.TextAlign = ContentAlignment.MiddleCenter;
                nextButton.Enabled = true;
            }
            else
            {
                nextButton.Enabled = false;
                pictureBox2.Image = null;
                label2.Text = "";
                label6.Text = "";
                pictureBox3.Image = null;
                label3.Text = "";
                label7.Text = "";
                pictureBox4.Image = null;
                label4.Text = "";
                label8.Text = "";
                return;
            }
            if (pictures[m * 4 + 2] != null && (m * 4 + 2) < r)
            {
                pictureBox3.Image = Image.FromFile(pictures[m * 4 + 2]);
                pictureBox3.ImageLocation = pictures[m * 4 + 2];
                pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                label3.Text = thingName[m * 4 + 2];
                //label3.TextAlign = ContentAlignment.MiddleCenter;
                label7.Text = DateTime.ParseExact(buyTime[m * 4 + 2], "yyyyMMdd", null).ToString("yyyy-MM-dd");
                label7.TextAlign = ContentAlignment.MiddleCenter;
                nextButton.Enabled = true;
            }
            else
            {
                nextButton.Enabled = false;
                pictureBox3.Image = null;
                label3.Text = "";
                label7.Text = "";
                pictureBox4.Image = null;
                label4.Text = "";
                label8.Text = "";
                return;
            }
            if (pictures[m * 4 + 3] != null && (m * 4 + 3) < r)
            {
                pictureBox4.Image = Image.FromFile(pictures[m * 4 + 3]);
                pictureBox4.ImageLocation = pictures[m * 4 + 3];
                pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
                label4.Text = thingName[m * 4 + 3];
                label8.Text = DateTime.ParseExact(buyTime[m * 4 + 3], "yyyyMMdd", null).ToString("yyyy-MM-dd");
                label8.TextAlign = ContentAlignment.MiddleCenter;
                if (r%4==0&&(m + 1) >= (r / 4))
                {
                    nextButton.Enabled = false;
                }
                else
                {
                    nextButton.Enabled = true;
                }

            }
            else
            {
                nextButton.Enabled = false;
                pictureBox4.Image = null;
                label4.Text = "";
                label8.Text = "";
                return;
            }
        }
        //从数据库中获得数据
        public void selectData(string sql1)
        {

            string con = "", sql = sql1;
            if (i == 0)
            {
                backButton.Enabled = false;
            }
            else
            {
                backButton.Enabled = true;
            }
            int h = 0;
            con = "Server=.;Database=keshe;user id = sa;password = 316023";
            SqlConnection myCon = new SqlConnection(con);
            myCon.Open();
            SqlCommand myCom = new SqlCommand(sql, myCon);
            SqlDataReader myReader = myCom.ExecuteReader();
            r = 0;
            while (myReader.Read())
            {
                
                pictures[h] = myReader.GetString(0);
                buyTime[h] = myReader.GetString(1);
                h++;
                r++;
            }
            if(r == 4)
            {
                nextButton.Enabled = false;
            }

            myCon.Close();
            string con1 = "Server=.;Database=keshe;user id = sa;password = 316023";
            SqlConnection myCon1 = new SqlConnection(con1);
            myCon1.Open();
            sql= "select Tname,Tpic from BoughtTable";
            SqlCommand myCom1 = new SqlCommand(sql, myCon1);
            SqlDataReader myReader1 = myCom1.ExecuteReader();
            string[] tempName = new string[200];
            string[] tempLink = new string[200];
            int a = 0;
            while(myReader1.Read())
            {
                tempName[a] = myReader1.GetString(0);
                tempLink[a] = myReader1.GetString(1);
                a++;
            }
            for (int b = 0;pictures[b] != null;b++)
            {
                for(int c = 0;tempLink[c]!= null;c++)
                {
                    if(pictures[b]==tempLink[c])
                    {
                        thingName[b] = tempName[c];
                    }
                }
            }
            showPictureAndName(i);

        }
        private void jiaoYiJiLu_Load(object sender, EventArgs e)
        {
            this.Location = new Point(300, 150);
            string con = "", _sql = "";
            con = "Server=.;Database=keshe;user id = sa;password = 316023";
            SqlConnection myCon = new SqlConnection(con);
            myCon.Open();
            _sql = "select * from stayUser";
            SqlCommand myCom = new SqlCommand(_sql, myCon);
            SqlDataReader myReader = myCom.ExecuteReader();
            while (myReader.Read())
            {
                name = myReader.GetString(0);
            }
            myCon.Close();
            selectData(string.Format("select BuyLink,BuyDate from BuyTable where BuyName = '{0}'", name));
            if (r == 0 && !checkBox2.Checked)
            {
                MessageBox.Show("您未买任何物品");
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            i--;
            showPictureAndName(i);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            i++;
            showPictureAndName(i);
        }

        

        private void jiaoYiJiLu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            string sql = "";

            if (checkBox2.Checked)
            {                                   //string.Format("select BuyLink,BuyDate from BuyTable where BuyName = '{0}'
                sql = string.Format("select BuyLink,BuyDate from BuyTable where Uname = '{0}'", name);
                selectData(sql);
                showPictureAndName(i);
                if (r == 0 && checkBox2.Checked)
                {
                    MessageBox.Show("您未卖出任何物品");
                }
                return;
            }
            else
            {
                sql = string.Format("select BuyLink,BuyDate from BuyTable where BuyName = '{0}'", name);
                selectData(sql);
                showPictureAndName(i);
            }

        }

        //将当前点进去的图片链接插入到pitureTable表里，用于各窗口传值
        public void insertIntoData(string picLink)
        {
            string con = "", sql = "";
            con = "Server=.;Database=keshe;user id = sa;password = 316023";
            SqlConnection myCon = new SqlConnection(con);
            myCon.Open();
            sql = string.Format("delete from pitureTable;insert into pitureTable values('{0}')", picLink);
            SqlCommand myCom = new SqlCommand(sql, myCon);
            myCom.ExecuteNonQuery();
            myCon.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string link = "";
            link = pictureBox1.ImageLocation;
            insertIntoData(link);
            BuyForm buyForm = new BuyForm();
            buyForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string link = "";
            link = pictureBox2.ImageLocation;
            insertIntoData(link);
            BuyForm buyForm = new BuyForm();
            buyForm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string link = "";
            link = pictureBox3.ImageLocation;
            insertIntoData(link);
            BuyForm buyForm = new BuyForm();
            buyForm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string link = "";
            link = pictureBox4.ImageLocation;
            insertIntoData(link);
            BuyForm buyForm = new BuyForm();
            buyForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            string sql = "", text = textBox1.Text;
            if (text.StartsWith("发布者："))
            {
                text = text.Substring(4, text.Length - 4);
                sql = string.Format("select Tpic,Time from BoughtTable where Uname like '%{0}%' and not Uname = '{1}'", text, name);
            }
            else if (text.StartsWith("名称："))
            {
                text = text.Substring(3, text.Length - 3);
                sql = string.Format("select Tpic,Time from BoughtTable where Tname like '%{0}%'  and not Uname = '{1}'", text, name);
            }
            else
            {
                sql = string.Format("select Tpic,Time from BoughtTable where Tname like '%{0}%'  and not Uname = '{1}'", text, name);
            }
            selectData(sql);
            if (r == 0)
            {
                MessageBox.Show("未找到您需要的物品！");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
                e.SuppressKeyPress = false;
            }
        }
    }
}
